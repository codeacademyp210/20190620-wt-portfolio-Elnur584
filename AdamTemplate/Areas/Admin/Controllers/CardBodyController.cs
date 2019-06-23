﻿using System;
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
    public class CardBodyController : Controller
    {
        private PageContext db = new PageContext();

        // GET: Admin/CardBodiy
        public ActionResult Index()
        {
            return View(db.CardBodies.ToList());
        }

        // GET: Admin/CardBodiy/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CardBody cardBody = db.CardBodies.Find(id);
            if (cardBody == null)
            {
                return HttpNotFound();
            }
            return View(cardBody);
        }

        // GET: Admin/CardBodiy/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/CardBodiy/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,MainTitle,Title,Content,Icon")] CardBody cardBody)
        {
            if (ModelState.IsValid)
            {
                db.CardBodies.Add(cardBody);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cardBody);
        }

        // GET: Admin/CardBodiy/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CardBody cardBody = db.CardBodies.Find(id);
            if (cardBody == null)
            {
                return HttpNotFound();
            }
            return View(cardBody);
        }

        // POST: Admin/CardBodiy/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,MainTitle,Title,Content,Icon")] CardBody cardBody)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cardBody).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cardBody);
        }

        // GET: Admin/CardBodiy/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CardBody cardBody = db.CardBodies.Find(id);
            if (cardBody == null)
            {
                return HttpNotFound();
            }
            return View(cardBody);
        }

        // POST: Admin/CardBodiy/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CardBody cardBody = db.CardBodies.Find(id);
            db.CardBodies.Remove(cardBody);
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
