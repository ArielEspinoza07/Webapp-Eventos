using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Test.Models;
using PagedList;
using PagedList.Mvc;

namespace Test.Controllers
{
    public class MiembroController : Controller
    {
        private dbASEntities db = new dbASEntities();

        
        //
        // GET: /Miembro/

        public ActionResult Index(int? page)
        {
            return View(db.Miembro.ToList().ToPagedList(page ?? 1,5));
        }

        //
        // GET: /Miembro/Details/5

        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Miembro miembro = db.Miembro.Find(id);
            if (miembro == null)
            {
                return HttpNotFound();
            }
            return View(miembro);
        }

        //
        // GET: /Miembro/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Miembro/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idMiembro,nombre,numeroCedula,correo,telefono,Estado,Confirmo")] Miembro miembro)
        {
            if (ModelState.IsValid)
            {
                db.Miembro.Add(miembro);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(miembro);
        }

        //
        // GET: /Miembro/Edit/5

        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Miembro miembro = db.Miembro.Find(id);
            if (miembro == null)
            {
                return HttpNotFound();
            }
            return View(miembro);
        }

        //
        // POST: /Miembro/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idMiembro,nombre,numeroCedula,correo,telefono,Estado,Confirmo")] Miembro miembro)
        {
            if (ModelState.IsValid)
            {
                db.Entry(miembro).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(miembro);
        }

        //
        // GET: /Miembro/Delete/5

        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Miembro miembro = db.Miembro.Find(id);
            if (miembro == null)
            {
                return HttpNotFound();
            }
            return View(miembro);
        }

        //
        // POST: /Miembro/Delete/5


        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Miembro miembro = db.Miembro.Find(id);
            db.Miembro.Remove(miembro);
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
