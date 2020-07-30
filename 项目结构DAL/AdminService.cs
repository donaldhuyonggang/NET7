using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 项目结构Model;

namespace 项目结构DAL
{
    public class AdminService : BaseDAL<Admin>
    {
        public Admin Login(string uid,string pwd)
        {
            NET41 db = new NET41();
            var info = (from item in db.Admin
                       where item.LoginUID == uid && item.LoginPWD == pwd
                       select item).FirstOrDefault();
            return info;
        }
    }
}
