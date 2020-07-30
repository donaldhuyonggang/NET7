using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace 项目结构UI.Controllers
{
    public class CommonController : Controller
    {
        // GET: Common
        public ActionResult NoRight()
        {
            return View();
        }
    }
}