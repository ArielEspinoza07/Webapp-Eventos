using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test.Models;

namespace Test.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            LeerExcel le = new LeerExcel();
            le.fillMiembro();
            return View();
        }

        public ActionResult Dashboard(){
            return View();
        }

        [HttpPost]
        public void Login(string Usuario, string Password)
        {
            dbASEntities db = new dbASEntities();

            if (Convert.ToString(Usuario).Equals("") && Convert.ToString(Password).Equals(""))
            {
                Response.Redirect("Index");
            }
            else
            {
                Usuario usuario = new Usuario();
                usuario.usuario1 = Convert.ToString(Usuario);
                usuario.contrasena = Crypto.encrypt(Convert.ToString(Password));

                Usuario user = db.Usuario.Where(u => u.usuario1 == usuario.usuario1 && u.contrasena == usuario.contrasena).FirstOrDefault();

                if(user != null){
                    Session["Usuario"] = user;

                    Response.Redirect("Dashboard");
                }
                else
                {
                    
                    Response.Redirect("Index");
                }

                
            }
        }

        public void Logout(){
            Session.RemoveAll();
            Response.Redirect("Index");
        }


    }
}
