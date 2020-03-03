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
    public class AdminController : Controller
    {
        private readonly RFCContext _context;

        public AdminController(RFCContext context)
        {
            _context = context;
        }

        // GET: Admin
        [Route("admin")]
        public async Task<IActionResult> Index([Bind("ID,Role,Name,DomainUser")] User user, string sortOrder, string searchString, string columnSelect, int? pageNumber, DateTime? DateTo)
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
            ViewBag.RoleSortParm = sortOrder == "RoleAsc" ? "RoleDesc" : "RoleAsc";

            //// The 'submissions' is the variable with the data from the table
            var submissions = from s in _context.User
                              select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                submissions = submissions.Where(s => s.Name.Contains(searchString));
            }

            ViewData["Users"] = submissions;

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
                    case "Role":
                        submissions = submissions.Where(s => s.Role.ToString().Contains(searchString));
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
                case "RoleAsc":
                    submissions = submissions.OrderBy(submission => submission.Name);
                    break;
                default:
                    submissions = submissions.OrderBy(submission => submission.ID);
                    break;
            }
            int pageSize = 5;
            return View(await PaginatedList<User>.CreateAsync(submissions.AsNoTracking(), pageNumber ?? 1, pageSize));
        }

        // GET: Admin/Details/5
        public async Task<IActionResult> Details([Bind("ID,Name,Role,DomainUser")] User CurrentUser, int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.User
                .FirstOrDefaultAsync(m => m.ID == id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // GET: Admin/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Name,Role,DomainUser")] User user)
        {
            if (ModelState.IsValid)
            {
                _context.Add(user);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(user);
        }

        // GET: Admin/Edit/5
        public async Task<IActionResult> Edit([Bind("ID,Name,Role,DomainUser")] User CurrentUser, int? id)
        {

            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.User.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }

        // POST: Admin/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Name,Role,DomainUser")] User user)
        {
            if (id != user.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(user);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserExists(user.ID))
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
            return View(user);
        }

        // GET: Admin/Delete/5
        public async Task<IActionResult> Delete([Bind("ID,Name,Role,DomainUser")] User CurrentUser, int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.User
                .FirstOrDefaultAsync(m => m.ID == id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // POST: Admin/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var user = await _context.User.FindAsync(id);
            _context.User.Remove(user);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserExists(int id)
        {
            return _context.User.Any(e => e.ID == id);
        }
    }
}
