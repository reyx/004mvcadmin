using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Reyx.Web.Admin.Controllers
{
    public class AdminController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Custom(string entity, int? id, string option)
        {
            if (string.IsNullOrEmpty(entity))
            {
                return View("Dashboard");
            }
            if (id.HasValue)
            {
                if (string.IsNullOrEmpty(option))
                {
                    return View("Detail");
                }

                return View(option);
            }
            else
            {
                return View("List");
            }
        }
    }
}