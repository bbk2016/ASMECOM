using ASM.Core.Interfaces.IRepository;
using ASM.Core.Model;
using ASM.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM.Infrastructure.Repository
{
  public  class ASMGenericRepository<T> : IASMRepository<T> where T :class
    {

        #region attributes


        internal ASMCONTEXT context;
        internal IDbSet<T> dbSet;

       


        #endregion

        #region Construcor
        public ASMGenericRepository(ASMCONTEXT context)
        {
            this.context = context;
            this.dbSet = context.Set<T>();
                
        }

        #endregion



        public virtual void Add(T entity)
        {
            dbSet.Add(entity);

        }
        public virtual void Update(T entity)
        {
            context.Entry(entity).State = EntityState.Modified;
        }
        public virtual void Delete(T entity)
        {
            dbSet.Remove(entity);

        }

        public virtual void Delete(Func<T, Boolean> predicate)
        {
            IEnumerable<T> objs = dbSet.Where<T>(predicate).AsEnumerable();
            foreach (T t in objs)
                dbSet.Remove(t);
        }


        public virtual T GetById(int id)
        {
            return dbSet.Find(id);

        }

        public virtual T Get(Func<T, Boolean> where)
        {
            return dbSet.Where(where).FirstOrDefault<T>();

        }
        public virtual IEnumerable<T> GetAll()
        {
            return dbSet.ToList();
        }

        public virtual IEnumerable<T> GetMany(Func<T, bool> where)
        {
            return dbSet.Where(where).ToList();

        }
        public virtual IQueryable<T> Find(Func<T, bool> where)
        {
            return dbSet.Where(where).AsQueryable();

        }

    }
}
