using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using 项目结构DAL;

namespace 项目结构BLL
{
    public class BaseBLL <T> where T:class
    {

        BaseDAL<T> _dal = null;

        public BaseBLL( BaseDAL<T> dal)
        {
            _dal = dal;
        }

        public virtual List<T> GetAll()
        {
            return _dal.GetAll();
        }


        public virtual T GetByPK( object pk)
        {
            return _dal.GetByPK(pk);
        }

        public List<T> Where(Expression<Func<T, bool>> predicate)
        {
            return _dal.Where(predicate);

        }


        public virtual bool Add(T info)
        {
            return _dal.Add(info);
        }
        public virtual bool Update(T info)
        {
            return _dal.Update(info);
        }

        public virtual bool Delete(object pk)
        {
            return _dal.Delete(pk);
        }

    }
}
