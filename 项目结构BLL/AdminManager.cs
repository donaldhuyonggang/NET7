using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 项目结构DAL;
using 项目结构Model;

namespace 项目结构BLL
{
    public class AdminManager : BaseBLL<Admin>
    {
        AdminService dal = new AdminService();

        public AdminManager():base(new AdminService())
        {
        }

        public Admin Login(string uid, string pwd)
        {
            return dal.Login(uid, pwd);
        }

    }
}
