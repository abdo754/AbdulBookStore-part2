using System;
using System.Collections.Generic;
using System.Text;

namespace AbdulBooks.DataAccess.Repository.IRepository
{
    interface IUnitOfWork: IDisposable
    {
        ICategoryRepository category { get; }
        ISP_Call SP_Call { get; }
    }
}
