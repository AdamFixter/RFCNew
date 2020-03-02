using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RFC.Models;

namespace RFC.Controllers
{
    public class CustomersController : Controller
    {
        private readonly RFCContext _context;

        public CustomersController(RFCContext context)
        {
            _context = context;
        }

        // GET: Customers
        /*TODO: Filters don't work for this page. Still needs to be done. - AdamF*/
        public async Task<IActionResult> Index([Bind("ID,Name")] Customer customer, string sortOrder, string searchString, string columnSelect, int? pageNumber, DateTime? DateTo)
        {
            ViewData["CurrentSort"] = sortOrder;
            if (searchString != null)
            {
                pageNumber = 1;
            }
            else
            {
                searchString = "";
            }

            ///// ViewBag.[something]Parm is used for sorting order by clicking column
            ViewBag.IDSortParm = String.IsNullOrEmpty(sortOrder) ? "IDDesc" : "";
            ViewBag.NameSortParm = sortOrder == "NameAsc" ? "NameDesc" : "NameAsc";

            //// The 'submissions' is the variable with the data from the table
            var submissions = from s in _context.Customer
                              select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                submissions = submissions.Where(s => s.Name.Contains(searchString));
            }

            ViewData["Customers"] = submissions;

            if (!String.IsNullOrEmpty(searchString))    //// Filters the 'submissions' data out depending on the search performed and column selected from the dropdown list
            {
                searchString = searchString.ToLower();
                switch (columnSelect)
                {
                    case "ID":
                        submissions = submissions.Where(s => s.ID.ToString().Contains(searchString));
                        break;
                    case "Name":
                        submissions = submissions.Where(s => s.Name.Contains(searchString));
                        break;
                }
            }

            ViewBag.sortOrder = sortOrder;
            switch (sortOrder)  //// Sorts the columns when you click on them  by Asc or Desc
            {
                case "IDDesc":
                    submissions = submissions.OrderByDescending(submission => submission.ID);
                    break;
                case "NameAsc":
                    submissions = submissions.OrderBy(submission => submission.Name);
                    break;
                default:
                    submissions = submissions.OrderBy(submission => submission.ID);
                    break;
            }
            int pageSize = 5;
            return View(await PaginatedList<Customer>.CreateAsync(submissions.AsNoTracking(), pageNumber ?? 1, pageSize));
        }

        // GET: Customers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _context.Customer
                .FirstOrDefaultAsync(m => m.ID == id);
            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

        // GET: Customers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Customers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Name")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                _context.Add(customer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(customer);
        }

        // GET: Customers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _context.Customer.FindAsync(id);
            if (customer == null)
            {
                return NotFound();
            }
            return View(customer);
        }

        // POST: Customers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Name")] Customer customer)
        {
            if (id != customer.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(customer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CustomerExists(customer.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(customer);
        }

        // GET: Customers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _context.Customer
                .FirstOrDefaultAsync(m => m.ID == id);
            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

        // POST: Customers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var customer = await _context.Customer.FindAsync(id);
            _context.Customer.Remove(customer);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CustomerExists(int id)
        {
            return _context.Customer.Any(e => e.ID == id);
        }
    }
}
