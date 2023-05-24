using TE.Core.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE.Data
{
    public class Repository<T> : IRepository<T> where T : class
    {
        readonly TEContext context;
        public Repository(TEContext context)
        {
            this.context = context;
        }
        public void Add(T entity)
        {
            context.Add(entity);
            //context.SaveChanges();
        }

        public void Delete(T entity)
        {
            context.Remove(entity);
            //context.SaveChanges();
        }

        public T? Get(int id)
        {
            return (T?)context.Find(typeof(T), id);
        }

        public T? Get(string id)
        {
            return (T?)context.Find(typeof(T), id);
        }

        public IList<T> GetAll()
        {
            return context.Set<T>().ToList();
        }

        public void Update(T entity)
        {
            context.Update(entity);
            //context.SaveChanges();
        }
    }
}
