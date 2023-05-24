﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE.Core.Services
{
    public interface IService<T> where T:class
    {
        T? Get(int id);
        T? Get(string id);
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
        IList<T> GetAll();
    }
}
