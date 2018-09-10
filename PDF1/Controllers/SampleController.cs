using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Rotativa;
using PDF1.Models;
using System.Collections;
using Rotativa.Options;

namespace PDF1.Controllers
{
    public class SampleController : Controller
    {
        // GET: Sample
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult GetSamples()
        {
            Sample obj = new Sample();
            List<Sample> sampleList = new List<Sample>();
            sampleList = obj.GetSampleDetails();
            return View("Sample", sampleList);
        }
        public ActionResult GeneratePDF()
        {
            Sample obj = new Sample();
            List<Sample> sampleList = new List<Sample>();
            sampleList = obj.GetSampleDetails();
            string footer =
                "--footer-right \"Date: [date] [time]\" " + "--footer-center \"Page: [page] of " +
                "[toPage]\" --footer-line --footer-font-size \"9\" --footer-spacing 5 --footer-font-name \"calibri light\"";
            return new Rotativa.ViewAsPdf("Report", sampleList)
            {
                FileName = "firstpdf.pdf",
                CustomSwitches = footer
            };
        }

      
    }
}