using AbdulBooks.DataAccess.Repository.IRepository;
using AbdulBookStore.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbdulBooks.DataAccess.Repository
{
    public class UnitOfWork
    {
        private readonly ApplicationDbContext _db; 

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Category = new CategoryRepository(_db);
            SP_Call = new SP_Call(_db);
        }

        public ICategoryRepository Category { get; private set; }
        public ISP_Call SP_Call { get; private set; }

        public void Dispose()
        {
            _db.Dispose();
        }
         public void save()
        {
            _db.SaveChanges();
        }
    }
}
