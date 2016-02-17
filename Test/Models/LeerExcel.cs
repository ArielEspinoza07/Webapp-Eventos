﻿using LinqToExcel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Core;
using System.Data.OleDb;
using System.Linq;
using System.Web;

namespace Test.Models
{
    public class LeerExcel
    {
        public  List<Miembro> readExcel()
        {
            List<Miembro> listmiembro = new List<Miembro>();
            string pathexcel = HttpContext.Current.Server.MapPath("\\App_Data\\PadronAsociados.xlsx");
            string sheetName = "Hoja1";

            var excelFile = new ExcelQueryFactory(pathexcel);


            var members = from a in excelFile.Worksheet(sheetName) select a;

            foreach (var a in members)
            {
                int n = a["Id"].Value.ToString().Length;
                if( n < 1){
                    break;
                }

                Miembro m = new Miembro();
                m.idMiembro = a["Id"];
                m.nombre = a["Nombre"];
                m.numeroCedula = a["Número Cédula"];
                m.correo = a["Correo"];
                m.telefono = a["Telefono"];

                if(a["Estatus 1"] == "Activo"){
                    m.Estado = 1;
                }
                else
                {
                    m.Estado = 0;
                }

                if (a["Estado 2"] == "Confirmado")
                {
                    m.Confirmo = 1;
                }
                else
                {
                    m.Confirmo = 0;
                }

                listmiembro.Add(m);
            }

            return listmiembro;
        }


        public  void fillMiembro()
        {
            dbASEntities db = new dbASEntities();

            try
            {
                if(db.Miembro.ToList().Count < 0){

                foreach (Miembro m in readExcel())
                {
                    db.Miembro.Add(m);
                    db.SaveChanges();
                }

            }
            }catch(EntityException err){
                Console.WriteLine(err.ToString());
            }


            
        }
        


    }
}