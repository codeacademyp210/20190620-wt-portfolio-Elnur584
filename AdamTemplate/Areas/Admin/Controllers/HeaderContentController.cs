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
    public class HeaderContentController : Controller
    {
        private PageContext db = new PageContext();

        // GET: Admin/HeaderContent
        public ActionResult Index()
        {
            return View(db.HeaderContents.ToList());
        }

        // GET: Admin/HeaderContent/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HeaderContent headerContent = db.HeaderContents.Find(id);
            if (headerContent == null)
            {
                return HttpNotFound();
            }
            return View(headerContent);
        }

        // GET: Admin/HeaderContent/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/HeaderContent/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Photo,NavItem")] HeaderContent headerContent)
        {
            if (ModelState.IsValid)
            {
                db.HeaderContents.Add(headerContent);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(headerContent);
        }

        // GET: Admin/HeaderContent/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HeaderContent headerContent = db.HeaderContents.Find(id);
            if (headerContent == null)
            {
                return HttpNotFound();
            }
            return View(headerContent);
        }

        // POST: Admin/HeaderContent/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Photo,NavItem")] HeaderContent headerContent)
        {
            if (ModelState.IsValid)
            {
                db.Entry(headerContent).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(headerContent);
        }

        // GET: Admin/HeaderContent/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HeaderContent headerContent = db.HeaderContents.Find(id);
            if (headerContent == null)
            {
                return HttpNotFound();
            }
            return View(headerContent);
        }

        // POST: Admin/HeaderContent/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            HeaderContent headerContent = db.HeaderContents.Find(id);
            db.HeaderContents.Remove(headerContent);
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
