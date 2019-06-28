using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
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

        [Authorize(Roles = "moderator, user")]
        // GET: PhdStudents
        public async Task<IActionResult> Index(string majorCode, string searchString)
        {
            IQueryable<string> codeQuery = from m in _context.PhdStudent
                                           orderby m.MajorCode
                                           select m.MajorCode;

            // запрос на поиск по строке
                var phdStudents = from m in _context.PhdStudent
                         select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                phdStudents = phdStudents.Where(s => s.LastName.Contains(searchString));
            }

            ///////////////////

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

        [Authorize(Roles = "moderator, user")]
        [HttpPost]
        public string Index(string searchString, bool notUsed)
        {
            return "From [HttpPost]Index: filter on " + searchString;
        }

        [Authorize(Roles = "moderator, user")]
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

       // [Authorize(Roles = "moderator")]
        // GET: PhdStudents/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PhdStudents/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.

        [Authorize(Roles = "moderator")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,LastName,FirstName,MiddleName,MajorCode,MajorName,ThesisNameRus,ThesisComDate,ComMemberNumberTotal,ComMemberNumberSpecific")] PhdStudent phdStudent)
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






        [Authorize(Roles = "moderator, user")]
        public IActionResult CreateVote(int id)
        {
            ViewBag.Id = id;
            return View();
        }


        [Authorize(Roles = "moderator, user")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateVote([Bind("PhdStudentId,Voice")] Vote vote)
        {
            if (ModelState.IsValid)
            {
                _context.Add(vote);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View();
        }












        /*

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
        */
        /*
        public IActionResult VoteResult(int id, string lastName, string firstName, string middleName, string majorName, string majorCode, string projectName, int voicesCount, int voicesCountPositive, int voicesCountNegative, int voicesCountAbstain)
        {
            ViewBag.Id = id;
            ViewBag.Lname = lastName;
            ViewBag.Fname = firstName;
            ViewBag.Mname = middleName;
            ViewBag.MajName = majorName;
            ViewBag.MajorCode = majorCode;
            ViewBag.DisNameRus = projectName;


            var result  = from m in _context.PhdStudent
                   where m.Id == id
                   select m;



            return View();
        }

    */
        /*
            public IActionResult VoteResult(int? id)
            {
                ViewBag.Id = id;
                return View();
            }

        *//*
            public IActionResult VoteResult(int id)
            {
                var result = from m in _context.PhdStudent
                             select m;

                    result = result.Where(s => s.Id == id);

                return View(result.ToList());
            }
            */



        /*

    public Task<IAsyncResult> VoteResult(int id)
    {

        // var vote = await _context.Vote
        //         .FirstOrDefaultAsync(m => m.Id == id);


        /*
        var vote = "SELECT COUNT(Voice) FROM Vote where PhdStudentId = '" + id + "'";
        ViewBag.Vote = vote;

        return vote;
        */
        /*
        var result = from r in _context.Vote
                     where r.PhdStudentId = id
                     orderby t

*/
        /*

                var voteResult = await  _context.Vote.
                    FirstOrDefaultAsync(Where(p => p.PhdStudentId == id));

                /*
                var phdStudent = await _context.PhdStudent
                    .FirstOrDefaultAsync(m => m.Id == id);

        */
        //     return View();
        //     }


        //    */





        [Authorize(Roles = "moderator")]
        public IActionResult VoteResult(int? id)
        {
            var resultAll = _context.Vote.Count(p => p.PhdStudentId == id);
            ViewBag.Vote = resultAll;
            return View(resultAll);
        }

        /*
        [HttpGet]
        public async Task<IActionResult> GetReportsAsync(int id)
        {
            var student = await _context.PhdStudent.Include(x => x.Vote).FirstOrDefaultAsync(x => x.Id == id);

            return Ok(new StudentReportViewModel
            {
                FName = student.Fname,
                LName = student.Lname,
                PositiveVoteQuantity = student.Vote.Where(xx => xx.Voice == "1").Count(),
                NegativeVoteQuantity = student.Vote.Where(xx => xx.Voice == "0").Count()
            });
        }
        */



        [Authorize(Roles = "moderator")]
        [HttpGet]
        public async Task<IActionResult> GetReportsAsync(int id)
        {
            var student = await _context.PhdStudent.Include(x => x.Vote).FirstOrDefaultAsync(x => x.Id == id);

            return View(new StudentReportViewModel
            {
                FName = student.FirstName,
                LName = student.LastName,
                MName = student.MiddleName,
                PositiveVoteQuantity = student.Vote.Where(xx => xx.Voice == "1").Count(),
                NegativeVoteQuantity = student.Vote.Where(xx => xx.Voice == "0").Count(),
                OverallVoteQuantity = student.Vote.Where(xx => xx.PhdStudentId == id).Count(),
                MajName = student.MajorCode,
                MajCode = student.MajorCode,
                DisNameRus = student.ThesisNameRus,
                ReleaseDate = student.ThesisComDate,
                MemberNumberTotal = student.ComMemberNumberTotal,
                MemberNumberSpecific = student.ComMemberNumberSpecific

            }) ;
        }



        //////////////////////////////////////////////////////////////////////


































        [Authorize(Roles = "moderator")]
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

        [Authorize(Roles = "moderator")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,LastName,FirstName,MiddleName,MajorCode,MajorName,ThesisNameRus,ThesisComDate,ComMemberNumberTotal,ComMemberNumberSpecific")] PhdStudent phdStudent)
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

        [Authorize(Roles = "moderator")]
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
        [Authorize(Roles = "moderator")]
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
