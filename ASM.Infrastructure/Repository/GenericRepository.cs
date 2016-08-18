using ASM.Core.Interfaces.IRepository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM.Infrastructure.Repository
{
    public abstract class GenericRepository<C, T> : IASMRepository<T> where T : class where C : DbContext, new()
    {
        #region attributes
        private C _entities = new C();

        #endregion


        #region ctor

        public GenericRepository(C c)
        {
            c = _entities;
        }
        public C Context
        {

            get { return _entities; }
            set { _entities = value; }
        }

        #endregion


        #region Methodes

        public virtual void Add(T entity)
        {
            _entities.Set<T>().Add(entity);
        }

        public virtual void Delete(Func<T, bool> predicate)
        {
            IEnumerable<T> objs = _entities.Set<T>().Where<T>(predicate).AsEnumerable();
            foreach (T t in objs)
                _entities.Set<T>().Remove(t);

        }

        public virtual void Delete(T entity)
        {
            _entities.Set<T>().Remove(entity);
        }

        public virtual IQueryable<T> Find(Func<T, bool> where)
        {
            return _entities.Set<T>().Where(where).AsQueryable();
        }

        public virtual T Get(Func<T, bool> where)
        {
            return _entities.Set<T>().Where(where).FirstOrDefault<T>();
        }

        public virtual IEnumerable<T> GetAll()
        {
            return _entities.Set<T>().ToList();
        }

        public virtual T GetById(int Id)
        {
            return _entities.Set<T>().Find(Id);
        }

        public virtual IEnumerable<T> GetMany(Func<T, bool> where)
        {
            return _entities.Set<T>().Where(where).ToList();
        }

        public void Save()
        {
            _entities.SaveChanges();
        }

        public virtual void Update(T entity)
        {
            Context.Entry(entity).State = EntityState.Modified;
        }
        #endregion

    }
}
