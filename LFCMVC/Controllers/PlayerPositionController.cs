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
    public class PlayerPositionController : Controller
    {
        private LFCContext db = new LFCContext();

        // GET: PlayerPosition
        public ActionResult Index()
        {
            return View(db.PlayerPositions.ToList());
        }

        // GET: PlayerPosition/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PlayerPosition playerPosition = db.PlayerPositions.Find(id);
            if (playerPosition == null)
            {
                return HttpNotFound();
            }
            return View(playerPosition);
        }

        // GET: PlayerPosition/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PlayerPosition/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PlayerPositionId,Position,Description")] PlayerPosition playerPosition)
        {
            if (ModelState.IsValid)
            {
                db.PlayerPositions.Add(playerPosition);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(playerPosition);
        }

        // GET: PlayerPosition/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PlayerPosition playerPosition = db.PlayerPositions.Find(id);
            if (playerPosition == null)
            {
                return HttpNotFound();
            }
            return View(playerPosition);
        }

        // POST: PlayerPosition/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PlayerPositionId,Position,Description")] PlayerPosition playerPosition)
        {
            if (ModelState.IsValid)
            {
                db.Entry(playerPosition).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(playerPosition);
        }

        // GET: PlayerPosition/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PlayerPosition playerPosition = db.PlayerPositions.Find(id);
            if (playerPosition == null)
            {
                return HttpNotFound();
            }
            return View(playerPosition);
        }

        // POST: PlayerPosition/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PlayerPosition playerPosition = db.PlayerPositions.Find(id);
            db.PlayerPositions.Remove(playerPosition);
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
    }
}
