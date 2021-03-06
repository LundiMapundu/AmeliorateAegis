using AmeliorateAegis.Data;
using AmeliorateAegis.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmeliorateAegis.Controllers
{
    [Area("Liason")]
    public class Meetings : Controller
    {
        private readonly ApplicationDbContext IdentityDbContext;

        public Meetings(ApplicationDbContext context)
        {
            IdentityDbContext = context;
        }

        public Meeting m = new Meeting();

        //Get Method to display View
        public async Task<IActionResult> Index()
        {
            return View(await IdentityDbContext.Meetings.ToListAsync());
        }



        // GET: Meetings/Create
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Meetings/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Date,Time,Reason")] Meeting a)
        {

            if (ModelState.IsValid)
            {
                IdentityDbContext.Add(a);
                await IdentityDbContext.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View();

        }

        // GET method: Meetings/Edit
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
                return NotFound();
            var meeting = await IdentityDbContext.Meetings.FindAsync(id);
            if (meeting == null)
            {
                return NotFound();
            }
            return View(meeting);
        }

        // POST method: Meetings/Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Meeting a)
        {
            //a.Choice = "Active";
            if (id != a.MeetingID)
                return NotFound();

            if (ModelState.IsValid)
            {
                try
                {
                    IdentityDbContext.Update(a);
                    await IdentityDbContext.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MeetingExists(a.MeetingID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Create));
            }
            return View(a);
        }


        //Method : Meetings/Details
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var appointment = await IdentityDbContext.Meetings
                .FirstOrDefaultAsync(m => m.MeetingID == id);
            if (appointment == null)
            {
                return NotFound();
            }

            return View(appointment);
        }

        private bool MeetingExists(int id)
        {
            return IdentityDbContext.Meetings.Any(k => k.MeetingID == id);
        }

        //Disposing Method
        protected override void Dispose(bool disposing)
        {
            if (disposing)
                IdentityDbContext.Dispose();
        }


    }
}
