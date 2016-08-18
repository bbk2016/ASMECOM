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
       public   class UnitOfWork:IUnitOfWork
     {

       
       

        #region Attributes

        public IAdressRepository AdressRepository { get; }
        private ICustomerRepository CustmerRepository { get; }
        private ASMCONTEXT _context;

        #endregion


        

        #region Methodes
      

        IAdressRepository IUnitOfWork.AdressRepository
        {
            get
            {
                return new AdressRepository(_context);
            }
        }

        public ICustomerRepository CustomerRepository
        {
            get
            {
                return new CustomerRepository(_context);
            }
        }

        public void Save()
        {
            _context.SaveChanges();


        }


        #endregion



    }
}
