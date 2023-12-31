﻿using DAL.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Concrete.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        Context c = new Context();
        DbSet<T> obj;
        public GenericRepository()
        {
            obj = c.Set<T>();
        }

        public void Delete(T item)
        {
            var delEnt = c.Entry(item);
            delEnt.State = EntityState.Deleted;
            //obj.Remove(item);
            c.SaveChanges();
        }

        public List<T> List()
        {
            return obj.ToList();
        }

        public List<T> List(Expression<Func<T, bool>> filter)
        {
            return obj.Where(filter).ToList();
        }

        public void Insert(T item)
        {
            var addEnt = c.Entry(item);
            addEnt.State = EntityState.Added;
            //obj.Add(item);
            c.SaveChanges();
        }

        public void Update(T item)
        {
            var updEnt = c.Entry(item);
            updEnt.State = EntityState.Modified; 
            c.SaveChanges();
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            return obj.SingleOrDefault(filter);
        }
    }
}