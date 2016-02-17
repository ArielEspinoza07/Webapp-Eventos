using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test.Models;

namespace Test.Controllers
{
    public class EventoMiembroController : Controller
    {
        private dbASEntities db = new dbASEntities();
        //
        // GET: /EventoMiembro/

        public ActionResult Index()
        {
            return View(db.EventoMiembro.ToList());
        }

        //
        // GET: /EventoMiembro/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /EventoMiembro/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /EventoMiembro/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /EventoMiembro/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /EventoMiembro/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /EventoMiembro/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /EventoMiembro/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
