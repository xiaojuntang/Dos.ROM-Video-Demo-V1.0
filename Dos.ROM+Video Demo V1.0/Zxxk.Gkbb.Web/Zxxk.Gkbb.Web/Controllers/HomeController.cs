using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Zxxk.Gkbb.BusinessLayer;

namespace Zxxk.Gkbb.Web.Controllers
{
    public class HomeController : Controller
    {
        public ICollegeEntranceLayer CollegeEntrance { get; private set; }

        public HomeController(ICollegeEntranceLayer college)
        {
            this.CollegeEntrance = college;
        }

        public ActionResult Index()
        {          
            return View();
        }
    }
}
