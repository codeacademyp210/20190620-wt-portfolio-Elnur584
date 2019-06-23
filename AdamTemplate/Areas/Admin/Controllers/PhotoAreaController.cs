using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AdamTemplate.DAL;
using AdamTemplate.Models;

namespace AdamTemplate.Areas.Admin.Controllers
{
    public class PhotoAreaController : Controller
    {
        private PageContext db = new PageContext();

        // GET: Admin/PhotoAreas
        public ActionResult Index()
        {
            return View(db.PhotoAreas.ToList());
        }

        // GET: Admin/PhotoAreas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PhotoArea photoArea = db.PhotoAreas.Find(id);
            if (photoArea == null)
            {
                return HttpNotFound();
            }
            return View(photoArea);
        }

        // GET: Admin/PhotoAreas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/PhotoAreas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Photo,Title")] PhotoArea photoArea)
        {
            if (ModelState.IsValid)
            {
                db.PhotoAreas.Add(photoArea);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(photoArea);
        }

        // GET: Admin/PhotoAreas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PhotoArea photoArea = db.PhotoAreas.Find(id);
            if (photoArea == null)
            {
                return HttpNotFound();
            }
            return View(photoArea);
        }

        // POST: Admin/PhotoAreas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Photo,Title")] PhotoArea photoArea)
        {
            if (ModelState.IsValid)
            {
                db.Entry(photoArea).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(photoArea);
        }

        // GET: Admin/PhotoAreas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PhotoArea photoArea = db.PhotoAreas.Find(id);
            if (photoArea == null)
            {
                return HttpNotFound();
            }
            return View(photoArea);
        }

        // POST: Admin/PhotoAreas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PhotoArea photoArea = db.PhotoAreas.Find(id);
            db.PhotoAreas.Remove(photoArea);
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
