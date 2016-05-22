using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM.Core.Interfaces.IRepository
{
   public  interface IASMRepository<T> where T :class
    {

        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Delete(Func<T, bool> predicate);

        T GetById(int Id);
        T Get(Func<T, bool> where);
        IEnumerable<T> GetAll();
        IEnumerable<T> GetMany(Func<T, bool> where);
        IQueryable<T> Find(Func<T, bool> where);


    }
}
