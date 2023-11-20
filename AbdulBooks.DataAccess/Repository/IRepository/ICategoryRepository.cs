using AbdulBooks.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbdulBooks.DataAccess.Repository.IRepository
{
    public interface ICategoryRepository :IRepository<Category>
    {
        void update(Category category);
    }
}
