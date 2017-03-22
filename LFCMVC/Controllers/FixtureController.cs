using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using LFCMVC.Models;

namespace LFCMVC.Controllers
{
    public class FixtureController : Controller
    {
        private LFCContext db = new LFCContext();

        // GET: Fixture
        public ActionResult Index(string SearchString)
        {
            var fixtures = db.Fixtures.Include(f => f.Competition);

            if (!String.IsNullOrEmpty(SearchString))
            {
                fixtures = fixtures.Where(s => s.Competition.Name.StartsWith(SearchString));
            }

            return View(fixtures.ToList());
        }

        // GET: Fixture/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Fixture fixture = db.Fixtures.Find(id);
            if (fixture == null)
            {
                return HttpNotFound();
            }
            return View(fixture);
        }

        // GET: Fixture/Create
        public ActionResult Create()
        {
            ViewBag.CompetitionId = new SelectList(db.Competitions, "CompetitionId", "Name");
            return View();
        }

        // POST: Fixture/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "FixtureId,Date,Stadium,HomeTeam,HomeScore,AwayScore,AwayTeam,CompetitionId")] Fixture fixture)
        {
            if (ModelState.IsValid)
            {
                db.Fixtures.Add(fixture);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CompetitionId = new SelectList(db.Competitions, "CompetitionId", "Name", fixture.CompetitionId);
            return View(fixture);
        }

        // GET: Fixture/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Fixture fixture = db.Fixtures.Find(id);
            if (fixture == null)
            {
                return HttpNotFound();
            }
            ViewBag.CompetitionId = new SelectList(db.Competitions, "CompetitionId", "Name", fixture.CompetitionId);
            return View(fixture);
        }

        // POST: Fixture/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "FixtureId,Date,Stadium,HomeTeam,HomeScore,AwayScore,AwayTeam,CompetitionId")] Fixture fixture)
        {
            if (ModelState.IsValid)
            {
                db.Entry(fixture).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CompetitionId = new SelectList(db.Competitions, "CompetitionId", "Name", fixture.CompetitionId);
            return View(fixture);
        }

        // GET: Fixture/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Fixture fixture = db.Fixtures.Find(id);
            if (fixture == null)
            {
                return HttpNotFound();
            }
            return View(fixture);
        }

        // POST: Fixture/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Fixture fixture = db.Fixtures.Find(id);
            db.Fixtures.Remove(fixture);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public JsonResult AutocompleteSuggestions(string term)
        {
            var suggestions = from s in db.Fixtures
                              select s.Competition.Name;
            var namelist = suggestions.Where(n => n.ToLower().StartsWith(term.ToLower()));
            return Json(namelist, JsonRequestBehavior.AllowGet);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
