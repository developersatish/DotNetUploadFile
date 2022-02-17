using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UploadFiles.Models;

namespace UploadFiles.Controllers
{
    public class ReportFileController : Controller
    {
        // GET: ReportFile
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Upload(DataModel data)
        {
            //foreach (var item in data.File)
            //{
            //    data.Files.Add(item.FileName);
            //}
            TempData["data"] = data;
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public ActionResult Submit(DataModel data)
        {
            TempData["data"] = data;
            return RedirectToAction("Twofile", "Home");
        }
    }
}