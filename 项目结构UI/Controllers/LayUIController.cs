using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using 项目结构Model;
using 项目结构BLL;


namespace 项目结构UI.Controllers
{
    public class LayUIController : Controller
    {
        // GET: LayUI
        public ActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public ActionResult Add()
        {
           
            return PartialView() ;
        }

        [HttpPost]
        public ActionResult Add(Goods Info)
        {
            GoodsManager bll = new GoodsManager();
            var result = bll.Add(Info);

            return Json(result, JsonRequestBehavior.AllowGet);
        }


    }
}