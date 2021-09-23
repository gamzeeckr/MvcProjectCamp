using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
   public interface IRepository<T> //generic yapı
    {
        // generic yapı ile kod tekrarından kaçınırız
        List<T> List();
        void Insert(T item);
        void Update(T item);
        T Get(Expression<Func<T, bool>> filter);
        void Delete(T item);
        List<T> List(Expression<Func<T, bool>> filter); // şartlı listeleme
       
    }
}
