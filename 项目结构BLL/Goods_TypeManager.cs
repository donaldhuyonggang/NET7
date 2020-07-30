using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 项目结构DAL;
using 项目结构Model;

namespace 项目结构BLL
{
    public class Goods_TypeManager:BaseBLL<Goods_Type>
    {
        public Goods_TypeManager() :base( new Goods_TypeService())
        {

        }


        public override bool Add(Goods_Type info)
        {
            if (info.TypeName.Length == 0)
            {
                return false;
            }
            return base.Add(info);  
        }


    }
}
