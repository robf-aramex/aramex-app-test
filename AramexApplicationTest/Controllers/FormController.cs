using AramexApplicationTest.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AramexApplicationTest.Controllers
{
    public class FormController : Controller
    {
        /// <summary>
        /// YOU SHOULD NOT NEED TO CHANGE THIS ACTION METHOD TO COMPLETE THIS TEST
        /// CREATE A NEW ACTION METHOD TO PROCESS THE FORM WHEN IT IS POSTED TO THE CONTROLLER
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Index()
        {
            return View(new FormViewModel());
        }
    }
}