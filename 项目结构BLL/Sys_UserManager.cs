using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 项目结构DAL;
using 项目结构Model;

namespace 项目结构BLL
{
    public class Sys_UserManager : BaseBLL<Sys_User>
    {

        Sys_UserService dal = new Sys_UserService();


        public Sys_UserManager() :base( new Sys_UserService())
        {

        }

        public Sys_User Login(string uid, string pwd)
        {
            return dal.Login(uid, pwd);
        }
    }
}
