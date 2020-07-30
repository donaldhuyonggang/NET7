using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 项目结构BLL;
using 项目结构DAL;

namespace 项目结构UI
{
    class Program
    {
        static void Main(string[] args)
        {

            Goods_TypeManager bll = new Goods_TypeManager();

            var list = bll.GetAll();
            



        }
    }
}
