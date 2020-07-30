using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using 项目结构Model;

namespace 项目结构DAL
{
    /// <summary>
    /// 数据访问层的父类。
    /// </summary>
   public  class BaseDAL<T> where T :class
    {
        public virtual List<T> GetAll()
        {
            //NET41 db = new NET41();
            //return db.Set<T>().ToList();

            NET41 db = new NET41();

            var list = (from item in db.Set<T>()
                        select item).ToList();

            return list;
        }


        public virtual T GetByPK(object pk)
        {
            NET41 db = new NET41();
            return db.Set<T>().Find(pk);
        }

        public virtual List<T> Where(Expression<Func<T, bool>> predicate)
        {
            NET41 db = new NET41();
            return db.Set<T>().Where(predicate).ToList();

           
        }


        public virtual bool Add(T info)
        {
            NET41 db = new NET41();
            db.Set<T>().Add(info);
            return db.SaveChanges() > 0;
        }


        public bool Update(T info)
        {
            NET41 db = new NET41();
            db.Entry<T>(info).State = EntityState.Modified;
            return db.SaveChanges() > 0;
        } 

        public virtual bool Delete(object pk)
        {
            NET41 db = new NET41();
            var info = db.Set<T>().Find(pk);
            if(info == null)
            {
                return false;
            }
            {
                db.Set<T>().Remove(info);
                return db.SaveChanges() > 0;
            }
        }



    }
}
