using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _21_WCF_Assignment1_MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ServiceReference1.Service1Client Objhttp = new ServiceReference1.Service1Client("Task1TcpBinding");
            Objhttp.Open();
            Objhttp.SayHello("Adam");
            Objhttp.TodayProgram("Adam");
            Objhttp.Close();

            ServiceReference1.Service1Client Objtcp = new ServiceReference1.Service1Client("Task1HttpBinding");
            Objtcp.Open();
            Objtcp.SayHello("Adam");
            Objtcp.TodayProgram("Adam");
            Objtcp.Close();
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