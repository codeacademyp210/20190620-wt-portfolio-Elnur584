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
    public class AmazingFeatureController : Controller
    {
        private PageContext db = new PageContext();

        // GET: Admin/AmazingFeature
        public ActionResult Index()
        {
            return View(db.AmazingFeatures.ToList());
        }

        // GET: Admin/AmazingFeature/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AmazingFeatures amazingFeatures = db.AmazingFeatures.Find(id);
            if (amazingFeatures == null)
            {
                return HttpNotFound();
            }
            return View(amazingFeatures);
        }

        // GET: Admin/AmazingFeature/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/AmazingFeature/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Icon,Name")] AmazingFeatures amazingFeatures)
        {
            if (ModelState.IsValid)
            {
                db.AmazingFeatures.Add(amazingFeatures);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(amazingFeatures);
        }

        // GET: Admin/AmazingFeature/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AmazingFeatures amazingFeatures = db.AmazingFeatures.Find(id);
            if (amazingFeatures == null)
            {
                return HttpNotFound();
            }
            return View(amazingFeatures);
        }

        // POST: Admin/AmazingFeature/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Icon,Name")] AmazingFeatures amazingFeatures)
        {
            if (ModelState.IsValid)
            {
                db.Entry(amazingFeatures).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(amazingFeatures);
        }

        // GET: Admin/AmazingFeature/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AmazingFeatures amazingFeatures = db.AmazingFeatures.Find(id);
            if (amazingFeatures == null)
            {
                return HttpNotFound();
            }
            return View(amazingFeatures);
        }

        // POST: Admin/AmazingFeature/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AmazingFeatures amazingFeatures = db.AmazingFeatures.Find(id);
            db.AmazingFeatures.Remove(amazingFeatures);
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
