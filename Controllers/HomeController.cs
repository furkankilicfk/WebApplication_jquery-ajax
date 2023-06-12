using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using WebApplication_jquery.Models;

namespace WebApplication_jquery.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult IndexJson()
        {
            Urun urn = new Urun();
            urn.ID = 5;
            urn.Name = "Domates";
            urn.Description = "Bu bir deneme ürünüdür";
            urn.Title = "Sebze";
            return Json(urn, JsonRequestBehavior.AllowGet);
        }
    }
}