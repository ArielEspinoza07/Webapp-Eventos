using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test.Models;
using PagedList;
using PagedList.Mvc;

namespace Test.Controllers
{
    public class RegistroController : Controller
    {
        private dbASEntities db = new dbASEntities();
        //
        // GET: /Registro/

        public ActionResult Index(int? page)
        {
            return View(db.Evento.ToList().ToPagedList(page ?? 1, 5));
        }

    }
}
