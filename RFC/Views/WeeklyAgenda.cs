﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RFC.Models;

namespace RFC.Views
{
    public class WeeklyAgenda : Controller
    {
        private readonly RFCContext _context;

        public WeeklyAgenda(RFCContext context)
        {
            _context = context;
        }

        // GET: WeeklyAgenda
        public async Task<IActionResult> Index()
        {
            return View(await _context.CreateNew.ToListAsync());
        }

        // GET: WeeklyAgenda/Details/5
        public async Task<IActionResult> Details(long? id)
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

        // GET: WeeklyAgenda/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: WeeklyAgenda/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Priority,ChangeDescription,ReasonForChange,Product,SystemAffected,customers,CustomersAffected,ServiceImpact,RiskOfChange,RiskNoChange,VerifyAfter,RollBackPlan,DueDate,WhyDueDate,WhoPerforming,Approved")] CreateNew createNew)
        {
            if (ModelState.IsValid)
            {
                _context.Add(createNew);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(createNew);
        }

        // GET: WeeklyAgenda/Edit/5
        public async Task<IActionResult> Edit(long? id)
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
            return View(createNew);
        }

        // POST: WeeklyAgenda/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("ID,Priority,ChangeDescription,ReasonForChange,Product,SystemAffected,customers,CustomersAffected,ServiceImpact,RiskOfChange,RiskNoChange,VerifyAfter,RollBackPlan,DueDate,WhyDueDate,WhoPerforming,Approved")] CreateNew createNew)
        {
            if (id != createNew.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(createNew);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CreateNewExists(createNew.ID))
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
            return View(createNew);
        }

        // GET: WeeklyAgenda/Delete/5
        public async Task<IActionResult> Delete(long? id)
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

        // POST: WeeklyAgenda/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
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
