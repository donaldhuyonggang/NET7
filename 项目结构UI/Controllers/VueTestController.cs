using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace 项目结构UI.Controllers
{
    public class VueTestController : Controller
    {
        // GET: VueTest
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Update(int id)
        {
            return View(id);
        }

    }
}