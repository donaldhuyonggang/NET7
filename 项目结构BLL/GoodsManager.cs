using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 项目结构DAL;
using 项目结构Model;

namespace 项目结构BLL
{
    public class GoodsManager : BaseBLL<Goods>
    {
        public GoodsManager() :base( new GoodsService())
        {

        }
    }
}
