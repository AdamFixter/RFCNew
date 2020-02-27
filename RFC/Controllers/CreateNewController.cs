using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        public async Task<IActionResult> Index([Bind("ID,Name,Role,DomainUser")] User CurrentUser, string sortOrder, string searchID, Priority searchPriority, Product searchProduct, string searchCustomer, string searchStatus, DateTime? searchDateStart, DateTime? searchDateEnd, string columnSelect, int? pageNumber)
        {
            Debug.WriteLine($"\n\n{sortOrder}\n{searchID}\n{searchPriority.ToString()}\n{searchProduct.ToString()}\n{searchCustomer}\n{searchStatus}");
            ViewData["CurrentSort"] = sortOrder;

            var submissions = from s in _context.CreateNew
                              select s;


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
            return View();
        }

        // POST: CreateNew/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("create")]
        public async Task<IActionResult> Create([Bind("ID,Priority,ChangeDescription,ReasonForChange,Product,SystemAffected,CustomersAffected,customers,ServiceImpact,RiskOfChange,RiskNoChange,VerifyAfter,RollBackPlan,DueDate,WhyDueDate,WhoPerforming")] CreateNew createNew)
        {
            if (ModelState.IsValid)
            {
                _context.Add(createNew);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(createNew);
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
            if (ModelState.IsValid)
            {
                createNew.Approved = !createNew.Approved;
                _context.Update(createNew);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return RedirectToAction(nameof(Index));
        }

        // GET: CreateNew/Delete/5
        public async Task<IActionResult> Delete([Bind("ID,Name,Role,DomainUser")] User CurrentUser, long? id)
        {
            if (CurrentUser.Role != UserRole.Power) return RedirectToAction("Index", "Home", new { area = "" });

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
            if (CurrentUser.Role != UserRole.Power) return RedirectToAction("Index", "Home", new { area = "" });

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
