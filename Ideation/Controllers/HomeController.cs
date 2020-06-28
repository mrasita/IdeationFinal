using Ideation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ideation.Controllers
{
    public class HomeController : Controller
    {
        private DataContext db = new DataContext();

        [Authorize]
        public ActionResult Index()
        {
            return View(db.Meetings.ToList());
        }

        public ActionResult About()
        {

                        return View();

        
        }


    }
}