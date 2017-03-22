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
    public class HonourController : Controller
    {
        private LFCContext db = new LFCContext();

        // GET: Honour
        public ActionResult Index()
        {
            return View(db.Honours.ToList());
        }

        // GET: Honour/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Honour honour = db.Honours.Find(id);
            if (honour == null)
            {
                return HttpNotFound();
            }
            return View(honour);
        }

        // GET: Honour/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Honour/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "HonourId,Image,Award,Amount,Season,Type")] Honour honour)
        {
            if (ModelState.IsValid)
            {
                db.Honours.Add(honour);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(honour);
        }

        // GET: Honour/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Honour honour = db.Honours.Find(id);
            if (honour == null)
            {
                return HttpNotFound();
            }
            return View(honour);
        }

        // POST: Honour/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "HonourId,Image,Award,Amount,Season,Type")] Honour honour)
        {
            if (ModelState.IsValid)
            {
                db.Entry(honour).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(honour);
        }

        // GET: Honour/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Honour honour = db.Honours.Find(id);
            if (honour == null)
            {
                return HttpNotFound();
            }
            return View(honour);
        }

        // POST: Honour/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Honour honour = db.Honours.Find(id);
            db.Honours.Remove(honour);
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
            return RedirectToAction("../Honour/Index/");
        }

    }
}
