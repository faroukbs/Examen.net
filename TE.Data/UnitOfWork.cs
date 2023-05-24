using TE.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        readonly TEContext context;

        public UnitOfWork(TEContext context)
        {
            this.context = context;
        }

        public void Dispose()
        {
            context.Dispose();
        }

        public IRepository<T> GetRepository<T>() where T : class
        {
            return new Repository<T>(context);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}
