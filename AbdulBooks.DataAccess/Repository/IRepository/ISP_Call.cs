﻿using System;
using Dapper;
using System.Collections.Generic;
using System.Text;

namespace AbdulBooks.DataAccess.Repository.IRepository
{
   public interface ISP_Call :  IDisposable
    {
        T Single<T>(string procedurname, DynamicParameters param = null);
        void Execute(string procedurname, DynamicParameters param = null);

        T OneRecord<T>(string procedurname, DynamicParameters param = null);
        IEnumerable<T> List<T>(string procedurname, DynamicParameters param = null);
        Tuple<IEnumerable<T1>, IEnumerable<T2>> List<T1, T2>(string procedurname, DynamicParameters param = null);
    }
}
