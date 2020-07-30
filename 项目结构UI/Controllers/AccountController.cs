using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using 项目结构BLL;
using 项目结构Model;
using 项目结构UI.Models;

namespace 项目结构UI.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        [HttpGet]
        public ActionResult Login()
        {
            AdminViewModel vmInfo = new AdminViewModel() { LoginUID = "Admin", LoginPWD = "123456" };
            return View(vmInfo);
        }


        [HttpPost]
        public ActionResult Login(AdminViewModel vmInfo)
        {
            if(ModelState.IsValid) //验证通过
            {
                Sys_UserManager bll = new Sys_UserManager(); 
                var info = bll.Login(vmInfo.LoginUID,vmInfo.LoginPWD); 
                if (info == null)
                {
                    //登录失败
                    ModelState.AddModelError("error", "登录失败");
                }
                else
                {
                    this.Session["MYUSER"] = info;
                    return Redirect("/LayUI/Index");
                }

            }
            return View();
        }
    }
}