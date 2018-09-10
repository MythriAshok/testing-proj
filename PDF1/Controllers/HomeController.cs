using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PDF1.Models;

namespace PDF1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetData()
        {
            Sample obj = new Sample();
            List<Sample> sampleList = new List<Sample>();
            sampleList = obj.GetSampleDetails();
            int complianced = sampleList.Count(x => x.Status == "Complianced");
            int non_complianced = sampleList.Where(x => x.Status == "Non-Complianced").Count();
            int partially_complianced = sampleList.Where(x => x.Status == "Partially-Complianced").Count();
            Ratio objratio = new Ratio();
            objratio.Complianced = complianced;
            objratio.Non_Complianced = non_complianced;
            objratio.Partially_Complianced = partially_complianced;

            return Json(objratio, JsonRequestBehavior.AllowGet);
        }
        public class Ratio
        {
            public int Complianced { get; set; }
            public int Non_Complianced { get; set; }
            public int Partially_Complianced { get; set; }
        }
    }
}