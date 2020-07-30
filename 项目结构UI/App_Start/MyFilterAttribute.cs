using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using 项目结构Model;

namespace 项目结构UI.App_Start
{
    /// <summary>
    /// 自定义过滤器
    /// </summary>
    public class MyFilterAttribute: ActionFilterAttribute
    { 
        /// <summary>
        /// 登录,权限控制过滤器。
        /// </summary>
        /// <param name="filterContext"></param>
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var info = filterContext.HttpContext.Session["MYUSER"] as Sys_User;
            if (info == null)
            {
                filterContext.HttpContext.Response.Redirect("/Account/Login");
            }
            else //已经登录
            {
                //是否是超级管理员
                if (info.IsAdmin)
                {
                    return;
                }
                else
                {
                    //进行权限验证

                    string controller = filterContext.RouteData.Values["controller"].ToString();
                    string action = filterContext.RouteData.Values["action"].ToString();

                    string path = "/" + controller + "/" + action;


                    var roleInfo = info.Sys_Role;//当前用户的角色
                    var rightList = roleInfo.Sys_Resource;

                    foreach (var item in rightList)
                    {
                        if(item.ResourcePath == path) {
                            return;
                        }
                    }


                    filterContext.HttpContext.Response.Redirect("/Common/NoRight");
                }
            }
        }




    }
}