using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using 项目结构BLL;
using 项目结构Model;

namespace 项目结构UI.Controllers
{
    public class WebAPITestController : ApiController
    {
        [HttpGet]
        public IHttpActionResult Get()
        {
            GoodsManager bll = new GoodsManager();
            var list = bll.GetAll();
            var list1 = list.Select(x => new {
                x.GoodsId,
                x.GoodsName,
                x.Goods_Type.TypeName
            }); 
            return Json(list1);
        }
        [HttpGet]
        public IHttpActionResult GetByPK(int id)
        {
            GoodsManager bll = new GoodsManager();
            var info = bll.GetByPK(id);
            var info1 = new
            {
                info.GoodsId,
                info.GoodsName,
                info.Num,
                info.Price,
                info.TypeId,
                info.Goods_Type.TypeName
            };
            return Json(info1);
        }
        [HttpGet]
        public IHttpActionResult Get(int page , int limit)
        {
            GoodsManager bll = new GoodsManager();
            var list = bll.GetAll();
            var list1 = list.Skip((page - 1) * limit).Take(limit).Select(x => new {
                x.GoodsId,
                x.GoodsName,
                x.Goods_Type.TypeName
            });
            var info = new
            {
                count = list.Count,
                code = 0,
                data = list1
            };
            return Json(info);
        }


        [HttpPost]
        public IHttpActionResult Add(Goods Info)
        {
            GoodsManager bll = new GoodsManager();
            var result = bll.Add(Info);

            return Json(result);
        }
        [HttpPut]
        public IHttpActionResult Put(Goods info)
        {
            GoodsManager bll = new GoodsManager();
            var result = bll.Update(info);

            return Json(result);
        }
        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            GoodsManager bll = new GoodsManager();
            var result = bll.Delete(id);

            return Json(result);
        }



    }
}
