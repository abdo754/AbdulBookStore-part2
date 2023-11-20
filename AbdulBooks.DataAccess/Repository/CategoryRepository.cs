using AbdulBooks.DataAccess.Repository.IRepository;
using AbdulBooks.Models;
using AbdulBookStore.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbdulBooks.DataAccess.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db): base(db)
        {
            _db = db;
        }
    }
}
