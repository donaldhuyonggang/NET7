using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using 项目结构BLL;

namespace 项目结构UI.Controllers
{
    public class LayUITableController : Controller
    {
        // GET: LayUITable
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetData()
        {
            GoodsManager bll = new GoodsManager(); 
            var list = bll.GetAll();

            var list1 = list.Select(x => new {
                x.GoodsId,
                x.GoodsName,
                x.Num,
                x.Price,
                x.Goods_Type.TypeName
            });

            var json = new
            {
                code = 0,
                data = list1
            };
           
            return Json(json, JsonRequestBehavior.AllowGet);

        }


        public ActionResult GetDataWhere(int id , string name )
        {
            GoodsManager bll = new GoodsManager();
            var list = bll.GetAll();

            var list1 = list.Select(x => new {
                x.GoodsId,
                x.GoodsName,
                x.Num,
                x.Price,
                x.Goods_Type.TypeName
            });

            var json = new
            {
                code = 0,
                data = list1
            };

            return Json(json, JsonRequestBehavior.AllowGet);

        }

    }
}