using l.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;

namespace l.Controllers 
{
    public class HomeController : Controller
    {

        public ActionResult form3()
        {
            ViewBag.Message = "Your contacpage.";

            return View();
        }


        public ActionResult Form2()
        {
            a fas = new a();
             

            fas.correo1 =Request.Form["correo1"];

            return View(fas);
        }


        public ActionResult Index()
        {
            ViewBag.Message = "Your contacpage.";

            return View();
        }


        

        public ActionResult form()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult resultado  (datos data, HttpPostedFileBase foto)
        {


            datos obj = new datos();
             

            string nombreFoto = Path.GetFileName(foto.FileName);
            string rutaFoto = Path.Combine(Server.MapPath("/Imagenes"), nombreFoto);

             ViewBag.picture = nombreFoto;

            foto.SaveAs(rutaFoto);
             return View(data);



        }

        public ActionResult ProcesaFoto(string foto)
        {
            string ruta = ControllerContext.HttpContext.Server.MapPath("/Imagenes");
            return File(Path.Combine(ruta, foto), "image");
        }


    }
}


//public ActionResult resultado(datos data, HttpPostedFileBase foto)
//string nombreFoto = Path.GetFileName(foto.FileName);
//string rutaFoto = Path.Combine(Server.MapPath("/Imagenes"), nombreFoto);

//ViewBag.picture = nombreFoto;

//foto.SaveAs(rutaFoto);
//return View(data);