using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Phd.Models;

namespace Phd.Controllers
{
    public class PhdStudentsController : Controller
    {
        private readonly PhdContext _context;

        public PhdStudentsController(PhdContext context)
        {
            _context = context;
        }

        // GET: PhdStudents
        public async Task<IActionResult> Index(string majorCode, string searchString)
        {
            IQueryable<string> codeQuery = from m in _context.PhdStudent
                                           orderby m.MajorCode
                                           select m.MajorCode;

            var phdStudents = from m in _context.PhdStudent
                         select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                phdStudents = phdStudents.Where(s => s.Lname.Contains(searchString));
            }

            if (!string.IsNullOrEmpty(majorCode))
            {
                phdStudents = phdStudents.Where(x => x.MajorCode == majorCode);
            }

            var majorCodeVM = new MajorCodeViewModel
            {
                Codes = new SelectList(await codeQuery.Distinct().ToListAsync()),
                PhdStudents = await phdStudents.ToListAsync()
            };

            return View(majorCodeVM);
        }

        [HttpPost]
        public string Index(string searchString, bool notUsed)
        {
            return "From [HttpPost]Index: filter on " + searchString;
        }


        // GET: PhdStudents/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var phdStudent = await _context.PhdStudent
                .FirstOrDefaultAsync(m => m.Id == id);
            if (phdStudent == null)
            {
                return NotFound();
            }

            return View(phdStudent);
        }

        // GET: PhdStudents/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PhdStudents/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Fname,Lname,Mname,MajName,DisNameKaz,DisNameRus,DisNameEng,ReleaseDate,MajorCode")] PhdStudent phdStudent)
        {
            if (ModelState.IsValid)
            {
                _context.Add(phdStudent);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(phdStudent);
        }











    //////////////////////////////////////////////////////////
    


        public IActionResult CreateVote(int id)
        {
            ViewBag.Id = id;
            return View();
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateVote([Bind("Voice")] Vote vote)
        {
            if (ModelState.IsValid)
            {
                _context.Add(vote);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(vote);
        }










        //////////////////////////////////////////////////////////////////////



































        // GET: PhdStudents/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var phdStudent = await _context.PhdStudent.FindAsync(id);
            if (phdStudent == null)
            {
                return NotFound();
            }
            return View(phdStudent);
        }


        // POST: PhdStudents/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Fname,Lname,Mname,MajName,DisNameKaz,DisNameRus,DisNameEng,ReleaseDate,MajorCode")] PhdStudent phdStudent)
        {
            if (id != phdStudent.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(phdStudent);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PhdStudentExists(phdStudent.Id))
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
            return View(phdStudent);
        }

        // GET: PhdStudents/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var phdStudent = await _context.PhdStudent
                .FirstOrDefaultAsync(m => m.Id == id);
            if (phdStudent == null)
            {
                return NotFound();
            }

            return View(phdStudent);
        }

        // POST: PhdStudents/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var phdStudent = await _context.PhdStudent.FindAsync(id);
            _context.PhdStudent.Remove(phdStudent);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PhdStudentExists(int id)
        {
            return _context.PhdStudent.Any(e => e.Id == id);
        }
    }
}
