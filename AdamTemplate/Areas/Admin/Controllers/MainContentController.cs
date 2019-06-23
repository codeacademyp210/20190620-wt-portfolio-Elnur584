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
    public class MainContentController : Controller
    {
        private PageContext db = new PageContext();

        // GET: Admin/MainContents
        public ActionResult Index()
        {
            return View(db.MainContents.ToList());
        }

        // GET: Admin/MainContents/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MainContent mainContent = db.MainContents.Find(id);
            if (mainContent == null)
            {
                return HttpNotFound();
            }
            return View(mainContent);
        }

        // GET: Admin/MainContents/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/MainContents/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Title,Content,Date,BigContent")] MainContent mainContent)
        {
            if (ModelState.IsValid)
            {
                db.MainContents.Add(mainContent);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(mainContent);
        }

        // GET: Admin/MainContents/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MainContent mainContent = db.MainContents.Find(id);
            if (mainContent == null)
            {
                return HttpNotFound();
            }
            return View(mainContent);
        }

        // POST: Admin/MainContents/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Title,Content,Date,BigContent")] MainContent mainContent)
        {
            if (ModelState.IsValid)
            {
                db.Entry(mainContent).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mainContent);
        }

        // GET: Admin/MainContents/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MainContent mainContent = db.MainContents.Find(id);
            if (mainContent == null)
            {
                return HttpNotFound();
            }
            return View(mainContent);
        }

        // POST: Admin/MainContents/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MainContent mainContent = db.MainContents.Find(id);
            db.MainContents.Remove(mainContent);
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
