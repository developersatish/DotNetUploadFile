using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UploadFiles.Models;

namespace UploadFiles.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            DataModel data = new DataModel();
            if (TempData["data"] != null)
            {
                data = TempData["data"] as DataModel;
            }
            return View(data);
        }

        public ActionResult Twofile()
        {
            DataModel data = new DataModel();
            if (TempData["data"] != null)
            {
                data = TempData["data"] as DataModel;
            }
            return View(data);
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        [HttpDelete]
        public ActionResult Delete(int id)
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}