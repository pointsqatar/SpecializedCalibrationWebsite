using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SpecializedCalibration.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.IsHomeActive = "active";
            ViewBag.IsAboutusActive = string.Empty;
            ViewBag.IsServicesActive = string.Empty;
            ViewBag.IsTradingActive = string.Empty;
            ViewBag.IsGalleryActive = string.Empty;
            ViewBag.IsContactActive = string.Empty;
            return View();
        }

        public ActionResult contact()
        {
            ViewBag.IsHomeActive = string.Empty;
            ViewBag.IsAboutusActive = string.Empty;
            ViewBag.IsServicesActive = string.Empty;
            ViewBag.IsTradingActive = string.Empty;
            ViewBag.IsGalleryActive = string.Empty;
            ViewBag.IsContactActive = "active";
            return View();
        }

        public ActionResult about()
        {
            ViewBag.IsHomeActive = string.Empty;
            ViewBag.IsAboutusActive = "active";
            ViewBag.IsServicesActive = string.Empty;
            ViewBag.IsTradingActive = string.Empty;
            ViewBag.IsGalleryActive = string.Empty;
            ViewBag.IsContactActive = string.Empty;
            return View();
        }

        public ActionResult trading()
        {
            ViewBag.IsHomeActive = string.Empty;
            ViewBag.IsAboutusActive = string.Empty;
            ViewBag.IsServicesActive = string.Empty;
            ViewBag.IsTradingActive = "active";
            ViewBag.IsGalleryActive = string.Empty;
            ViewBag.IsContactActive = string.Empty;
            return View();
        }

        public ActionResult services()
        {
            ViewBag.IsHomeActive = string.Empty;
            ViewBag.IsAboutusActive = string.Empty;
            ViewBag.IsServicesActive = "active";
            ViewBag.IsTradingActive = string.Empty;
            ViewBag.IsGalleryActive = string.Empty;
            ViewBag.IsContactActive = string.Empty;
            return View();
        }

        public ActionResult gallery()
        {
            ViewBag.IsHomeActive = string.Empty;
            ViewBag.IsAboutusActive = string.Empty;
            ViewBag.IsServicesActive = string.Empty;
            ViewBag.IsTradingActive = string.Empty;
            ViewBag.IsGalleryActive = "active";
            ViewBag.IsContactActive = string.Empty;
            return View();
        }
    }
}