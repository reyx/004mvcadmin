using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web;

namespace Reyx.Lib.Admin
{
    class AreaAdminRegistration : AreaRegistration
    {
        public override string AreaName 
        {
            get
            {
                return "Admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Admin_default",
                "Admin/{controller}/{action}/{id}",
                new { area = "Admin", controller = "Site", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}