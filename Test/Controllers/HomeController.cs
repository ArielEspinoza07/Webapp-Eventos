using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
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
            Session.RemoveAll();
            if (Convert.ToString(Usuario).Equals("") && Convert.ToString(Password).Equals(""))
            {
                Session["Error"] = "Debe llenar los campos Usuario y Password";
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
                    Session["Succes"] = "Bienvenido " + user.nombre;
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
