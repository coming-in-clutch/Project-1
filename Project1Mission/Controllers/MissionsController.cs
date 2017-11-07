using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project1Mission.Controllers
{
    public class MissionsController : Controller
    {
        // GET: Missions
        public ActionResult Missions()
        {
            return View();
        }
    }
}