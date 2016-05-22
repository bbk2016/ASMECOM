using ASM.Core.Interfaces.IUnitOfWork;
using ASM.Core.Model;
using ASM.Infrastructure.Data;
using ASM.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ASM.Core.Interfaces.IRepository;

namespace ASM.Infrastructure.UnitOfWorks
{
       public   class UnitOfWork:IDisposable,IUnitOfWork
    {
         #region Attributes
        private ASMCONTEXT context = new ASMCONTEXT();

        public UnitOfWork(ASMCONTEXT context)
        {
            this.context = context;
        }
     
        private ASMGenericRepository<Customer> customerRepository;


        public ASMGenericRepository<Customer> CustomerRepository
        {
            get
            {

                if (this.customerRepository == null)
                {
                    this.customerRepository = new ASMGenericRepository<Customer>(context);
                }
                return customerRepository;
            }
        }

    




        ICustomerRepository IUnitOfWork.CustomerRepository
        {
             get { return new CustomerRepository(context); }
        }
        #endregion

   


        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

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




    }
}
