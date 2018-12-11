using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _21_WCF_Assignment1_MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string btnclickVal)
        {
            //Button For HTTP
            if (btnclickVal == "HTTPButton")
            {
                ServiceReference1.Service1Client Objhttp = new ServiceReference1.Service1Client("Task1HttpBinding");
                Objhttp.Open();
                string hellomessage = Objhttp.SayHello("Adam");
                ViewBag.HelloMsg = hellomessage;
                //ViewBag.HelloMsg = "adadv dfsdf dsfds yuiy sdfdsf";
                string todayprogram= Objhttp.TodayProgram("Adam");
                ViewBag.ProgramMsg = todayprogram;
                Objhttp.Close();
            }
            else if(btnclickVal == "TCPButton")
            {
                //Button For TCP
                ServiceReference1.Service1Client Objtcp = new ServiceReference1.Service1Client("Task1TcpBinding");
                Objtcp.Open();
                string hellomessage = Objtcp.SayHello("Sam");
                ViewBag.HelloMsg = hellomessage;
                string todayprogram = Objtcp.TodayProgram("Sam");
                ViewBag.ProgramMsg = todayprogram;
                Objtcp.Close();
            }
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