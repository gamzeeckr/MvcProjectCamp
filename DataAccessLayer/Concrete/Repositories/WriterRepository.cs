using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repositories
{
    public class WriterRepository : IWriterDAL
    {
        // database ile bağlantı kurma
        Context db = new Context();
        DbSet<Writer> _db;
        public void Delete(Category item)
        {
            throw new NotImplementedException();
        }

        public void Insert(Category item)
        {
            throw new NotImplementedException();
        }

        public List<Category> List()
        {
            throw new NotImplementedException();
        }

        public List<Category> List(Expression<Func<Category, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Update(Category item)
        {
            throw new NotImplementedException();
        }
    }
}
