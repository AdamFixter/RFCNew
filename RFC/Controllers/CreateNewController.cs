using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RFC.Models;
using RFC.ViewModel;

namespace RFC.Controllers
{
    public class CreateNewController : Controller
    {
        private readonly RFCContext _context;
        private TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
        public CreateNewController(RFCContext context)
        {
            _context = context;
        }

        // GET: CreateNew
        [Route("submissions")]
        public async Task<IActionResult> Index([Bind("ID,Name,Role,DomainUser")] User CurrentUser, string sortOrder, string searchString, string columnSelect, int? pageNumber, DateTime? DateTo)
        {
            ViewData["CurrentSort"] = sortOrder;
            var submissions = from s in _context.CreateNew
                              select s;

            ViewData["CurrentSort"] = sortOrder;

            if (searchString != null)
            {
                pageNumber = 1;
            }
            else
            {
                searchString = "";
            }


            List<SelectListItem> items = new List<SelectListItem>   //// Creates list of possible columns to select in drop-down menu
            {
                new SelectListItem { Value = "ID", Text = "ID" },
                new SelectListItem { Value = "RFCType", Text = "Priority" },
                new SelectListItem { Value = "ProductName", Text = "Product Name" },
                new SelectListItem { Value = "CustomerName", Text = "Customer Name" },
                new SelectListItem { Value = "RequestedDueDate", Text = "Requested Due Date" },
                new SelectListItem { Value = "Approved", Text = "Approved" }
            };
            ViewBag.columnSelect = items;

            ViewBag.IDSortParm = String.IsNullOrEmpty(sortOrder) ? "IDDesc" : "";
            ViewBag.RFCTypeSortParm = sortOrder == "RFCTypeAsc" ? "RFCTypeDesc" : "RFCTypeAsc";
            ViewBag.ProductNameSortParm = sortOrder == "ProductNameAsc" ? "ProductNameDesc" : "ProductNameAsc";
            ViewBag.CustomerNameSortParm = sortOrder == "CustomerNameAsc" ? "CustomerNameDesc" : "CustomerNameAsc";
            ViewBag.RequestedDueDateSortParm = sortOrder == "RequestedDueDateAsc" ? "RequestedDueDateDesc" : "RequestedDueDateAsc";
            ViewBag.Approved = sortOrder == "ApprovedAsc" ? "ApprovedDesc" : "ApprovedAsc";

            if (!String.IsNullOrEmpty(searchString))    //// Filters the 'submissions' data out depending on the search performed and column selected from the dropdown list
            {
                searchString = searchString.ToLower();
                switch (columnSelect)
                {
                    case "ID":
                        submissions = submissions.Where(s => s.ID.ToString().Contains(searchString));
                        break;
                    case "RequestedDueDate":
                        submissions = submissions.Where(s => s.DueDate >= Convert.ToDateTime(searchString) && s.DueDate <= DateTo);
                        break;
                    case "RFCType":
                        if (Enum.GetNames(typeof(Priority)).ToList().IndexOf(searchString) != -1) //Check if the string includes a valid enum.
                        {
                            Priority foundPriority = (Priority)Enum.Parse(typeof(Priority), searchString); //Parse the search string to the Priority.
                            submissions = submissions.Where(s => s.Priority == foundPriority);
                        }
                        
                        break;
                    case "ProductName":
                        if (Enum.GetNames(typeof(Product)).ToList().IndexOf(searchString) != -1)
                        {
                            Product foundProduct = (Product)Enum.Parse(typeof(Product), searchString);
                            submissions = submissions.Where(s => s.Product == foundProduct);
                        }
                        
                        break;
                    case "CustomerName":
                        submissions = submissions.Where(s => s.customers.Contains(searchString));
                        break;
                }
            }

            switch (sortOrder)  //// Sorts the columns when you click on them  by Asc or Desc
            {
                case "IDDesc":
                    submissions = submissions.OrderByDescending(submission => submission.ID);
                    break;
                case "RFCTypeAsc":
                    submissions = submissions.OrderBy(submission => submission.Priority);
                    break;
                case "RFCTypeDesc":
                    submissions = submissions.OrderByDescending(submission => submission.Priority);
                    break;
                case "ProductNameAsc":
                    submissions = submissions.OrderBy(submission => submission.Product);
                    break;
                case "ProductNameDesc":
                    submissions = submissions.OrderByDescending(submission => submission.Product);
                    break;
                case "CustomerNameAsc":
                    submissions = submissions.OrderBy(submission => submission.customers);
                    break;
                case "CustomerNameDesc":
                    submissions = submissions.OrderByDescending(submission => submission.customers);
                    break;
                case "RequestedDueDateAsc":
                    submissions = submissions.OrderBy(submission => submission.DueDate);
                    break;
                case "RequestedDueDateDesc":
                    submissions = submissions.OrderByDescending(submission => submission.DueDate);
                    break;
                case "ApprovedAsc":
                    submissions = submissions.OrderBy(submission => submission.Approved);
                    break;
                case "ApprovedDesc":
                    submissions = submissions.OrderByDescending(submission => submission.Approved);
                    break;
                default:
                    submissions = submissions.OrderBy(submission => submission.ID);
                    break;
            }
            int pageSize = 5;
            return View(await PaginatedList<CreateNew>.CreateAsync(submissions.AsNoTracking(), pageNumber ?? 1, pageSize));



        }


        // GET: CreateNew/Details/5
        public async Task<IActionResult> Details([Bind("ID,Name,Role,DomainUser")] User CurrentUser, long? id)
        {

            if (id == null)
            {
                return NotFound();
            }

            var createNew = await _context.CreateNew
                .FirstOrDefaultAsync(m => m.ID == id);
            if (createNew == null)
            {
                return NotFound();
            }

            return View(createNew);
        }

        // GET: CreateNew/Create
        [Route("create")]
        public IActionResult Create()
        {
            CreateRequestViewModel model = new CreateRequestViewModel();
            List<SelectListItem> items = new List<SelectListItem>();
            var customers = from s in _context.Customer select s;
            customers.ToList().ForEach(customer => items.Add(new SelectListItem { Text = customer.Name, Value = customer.Name }));
            model.CustomerList = items;
            return View(model);
        }

        // POST: CreateNew/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("create")]
        public async Task<IActionResult> Create([Bind("Request, CustomerList")] CreateRequestViewModel createRequest)
        {
            var createNew = createRequest.Request;
            if (ModelState.IsValid)
            {
                _context.Add(createNew);
                await _context.SaveChangesAsync();
                TempData["submittedID"] = createNew.ID.ToString();
                return RedirectToAction("Index", "Home", new { area = "" });
            }

            //
            CreateRequestViewModel model = new CreateRequestViewModel();
            List<SelectListItem> items = new List<SelectListItem>();
            var customers = from s in _context.Customer select s;
            customers.ToList().ForEach(customer => items.Add(new SelectListItem { Text = customer.Name, Value = customer.Name }));
            model.CustomerList = items;
            return View(model);
        }

        // GET: Movies/Edit/5
        public async Task<IActionResult> Approve(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var createNew = await _context.CreateNew.FindAsync(id);
            if (createNew == null)
            {
                return NotFound();
            }
            TempData["lastRowID"] = id.ToString();
            if (ModelState.IsValid)
            {
                if (createNew.Approved == RequestStatus.Accept)
                    createNew.Approved = RequestStatus.Reject;
                else if (createNew.Approved == RequestStatus.Reject || createNew.Approved == RequestStatus.Pending)
                    createNew.Approved = RequestStatus.Accept;
                _context.Update(createNew);
                await _context.SaveChangesAsync();
                if (createNew.Approved == RequestStatus.Accept)
                    TempData["stateMessage"] = true;
                else if (createNew.Approved == RequestStatus.Reject)
                    TempData["stateMessage"] = false;
                TempData["stateStatus"] = true;
                return RedirectToAction(nameof(Index));
            }

            if (createNew.Approved == RequestStatus.Accept)
                TempData["stateMessage"] = true;
            else if (createNew.Approved == RequestStatus.Reject)
                TempData["stateMessage"] = false;
            TempData["stateStatus"] = false;
            return RedirectToAction(nameof(Index));
        }

        // GET: CreateNew/Delete/5
        public async Task<IActionResult> Delete([Bind("ID,Name,Role,DomainUser")] User CurrentUser, long? id)
        {
            //if (CurrentUser.Role == UserRole.Standard) return RedirectToAction("Index", "Home", new { area = "" });   //// The CurrentUser.Role isn't valid for this to work

            if (id == null)
            {
                return NotFound();
            }

            var createNew = await _context.CreateNew
                .FirstOrDefaultAsync(m => m.ID == id);
            if (createNew == null)
            {
                return NotFound();
            }

            return View(createNew);
        }

        // POST: CreateNew/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed([Bind("ID,Name,Role,DomainUser")] User CurrentUser,long id)
        {
            //if (CurrentUser.Role == UserRole.Standard) return RedirectToAction("Index", "Home", new { area = "" });   //// The CurrentUser.Role isn't valid for this to work
            var createNew = await _context.CreateNew.FindAsync(id);
            _context.CreateNew.Remove(createNew);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CreateNewExists(long id)
        {
            return _context.CreateNew.Any(e => e.ID == id);
        }
    }
}
