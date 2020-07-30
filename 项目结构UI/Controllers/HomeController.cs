using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using 项目结构BLL;
using 项目结构Model;
using 项目结构UI.App_Start;

namespace 项目结构UI.Controllers
{
    [MyFilter]
    public class HomeController : Controller
    {
        // GET: Home
        
        public ActionResult Index()
        { 
            GoodsManager bll = new GoodsManager();

            var list = bll.GetAll();

           // return Redirect("/Admin/Account/Index");
            return View(list);
        }

        public ActionResult Test()
        {
            GoodsManager bll = new GoodsManager();

            var list = bll.GetAll();

            return View(list);
        }

        public ActionResult Test1()
        { 
            return View();
        }

        /// <summary>
        /// 此方法被ajax调用，必须返回json
        /// 返回json，必须返回匿名类，匿名类集合
        /// </summary>
        /// <returns></returns>
        public ActionResult GetGoods(int page,int limit)
        {
            GoodsManager bll = new GoodsManager(); 
            var list = bll.GetAll();
            var list1 = list.Skip((page - 1) * limit).Take(limit).Select(x=> new {
                x.GoodsId,x.GoodsName,x.Goods_Type.TypeName
            });
            var info = new {
                count=list.Count,
                code=0,
                data=list1
            };                
            return Json(info, JsonRequestBehavior.AllowGet);
        }



        public ActionResult Add()
        {
            return PartialView();
        }

        [HttpGet]
        public ActionResult Update(int id)
        {
            GoodsManager bll = new GoodsManager();
            var info = bll.GetByPK(id);


            Goods_TypeManager bll_Type = new Goods_TypeManager();
            var list = bll_Type.GetAll();
            ViewBag.GoodsTypes = new SelectList(list, "TypeId", "TypeName", info.TypeId);
            ViewBag.TypeId = new SelectList(list, "TypeId", "TypeName", info.TypeId);

            return PartialView(info);
        }

        [HttpPost]
        public ActionResult Update( Goods info)
        {
            return Json("",JsonRequestBehavior.AllowGet);
        }

    }
}