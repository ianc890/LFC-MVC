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
    public class PlayerController : Controller
    {
        private LFCContext db = new LFCContext();

        // GET: Player
        public ActionResult Index(string SearchString)
        {
            var players = db.Players.Include(p => p.PlayerPosition).Include(p => p.Team);
            if (!String.IsNullOrEmpty(SearchString))
            {
                players = players.Where(s => s.LastName.StartsWith(SearchString));
            }

            return View(players.OrderBy(p => p.PlayerPosition.PlayerPositionId).ToList());
        }

        // GET: Player/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Player player = db.Players.Find(id);
            if (player == null)
            {
                return HttpNotFound();
            }
            return View(player);
        }

        // GET: Player/Create
        public ActionResult Create()
        {
            ViewBag.PlayerPositionId = new SelectList(db.PlayerPositions, "PlayerPositionId", "Position");
            ViewBag.TeamId = new SelectList(db.Teams, "TeamId", "Name");
            return View();
        }

        // POST: Player/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PlayerId,Image,FirstName,LastName,Age,Nationality,SquadNumber,PlayerPositionId,TeamId")] Player player)
        {
            if (ModelState.IsValid)
            {
                db.Players.Add(player);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.PlayerPositionId = new SelectList(db.PlayerPositions, "PlayerPositionId", "Position", player.PlayerPositionId);
            ViewBag.TeamId = new SelectList(db.Teams, "TeamId", "Name", player.TeamId);
            return View(player);
        }

        // GET: Player/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Player player = db.Players.Find(id);
            if (player == null)
            {
                return HttpNotFound();
            }
            ViewBag.PlayerPositionId = new SelectList(db.PlayerPositions, "PlayerPositionId", "Position", player.PlayerPositionId);
            ViewBag.TeamId = new SelectList(db.Teams, "TeamId", "Name", player.TeamId);
            return View(player);
        }

        // POST: Player/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PlayerId,Image,FirstName,LastName,Age,Nationality,SquadNumber,PlayerPositionId,TeamId")] Player player)
        {
            if (ModelState.IsValid)
            {
                db.Entry(player).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.PlayerPositionId = new SelectList(db.PlayerPositions, "PlayerPositionId", "Position", player.PlayerPositionId);
            ViewBag.TeamId = new SelectList(db.Teams, "TeamId", "Name", player.TeamId);
            return View(player);
        }

        // GET: Player/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Player player = db.Players.Find(id);
            if (player == null)
            {
                return HttpNotFound();
            }
            return View(player);
        }

        // POST: Player/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Player player = db.Players.Find(id);
            db.Players.Remove(player);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        public JsonResult AutocompleteSuggestions(string term)
        {
            var suggestions = from s in db.Players
                              select s.LastName ;
            var namelist = suggestions.Where(n => n.ToLower().StartsWith(term.ToLower()));
            return Json(namelist, JsonRequestBehavior.AllowGet);
        }

        public ActionResult FileUpload(HttpPostedFileBase file)
        {

            if (file != null)
            {
                LFCContext db = new LFCContext();
                string ImageName = System.IO.Path.GetFileName(file.FileName);
                string physicalPath = Server.MapPath("~/Images/" + ImageName);

                // save image in folder
                file.SaveAs(physicalPath);

            }
            //Display records
            return RedirectToAction("../Player/Index/");
        }

    }
}
