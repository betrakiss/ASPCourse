﻿using DataAccess.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        public GenericRepository(ComputerStoreContext context)
        {
            this.context = context;
        }

        public IQueryable<T> All()
        {
            return context.Set<T>().AsQueryable();
        }

        public void Add(T entity)
        {
            context.Set<T>().Add(entity);
        }

        public void Delete(int id)
        {
            T entity = FindById(id);
            context.Set<T>().Remove(entity);
        }

        public T FindById(int id)
        {
            return context.Set<T>().Find(id);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void Update(T entity)
        {
            context.Entry(entity).State = EntityState.Modified;
        }

        public IQueryable<T> Where(Expression<Func<T, bool>> filter)
        {
            return context.Set<T>().Where(filter);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private bool disposed = false;
        private ComputerStoreContext context;
    }
}
