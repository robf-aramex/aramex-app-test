using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AramexApplicationTest.Controllers
{
    public class FizzBuzzController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
    }
}