using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
/**
 * Authors:  Ritesh Patel
 * Srudent ID : 200307232
 * Date : Aug 18 2016
 * Name: Home Controller
 * Description: This controller call different views.
 */
namespace COMP2006_S2016_FinalExamV2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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
    }
}