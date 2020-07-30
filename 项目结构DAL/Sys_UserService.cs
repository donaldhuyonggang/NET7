using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 项目结构Model;

namespace 项目结构DAL
{
    public class Sys_UserService : BaseDAL<Sys_User>
    {
        public Sys_User Login(string uid, string pwd)
        {
            NET41 db = new NET41();
            var info = (from item in db.Sys_User
                        where item.LoginId == uid && item.LoginPwd == pwd
                        select item).FirstOrDefault();
            return info;
        }
    }
}
