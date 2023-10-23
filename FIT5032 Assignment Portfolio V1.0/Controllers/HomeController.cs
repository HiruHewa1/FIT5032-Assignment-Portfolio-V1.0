using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Mail;
using System.Threading.Tasks;
using FIT5032_Assignment_Portfolio_V1._0.Models;
using System.Net;
using System.Web.UI.WebControls;

namespace FIT5032_Assignment_Portfolio_V1._0.Controllers
{
    [Authorize]
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