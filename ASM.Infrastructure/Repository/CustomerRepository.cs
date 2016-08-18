using ASM.Core.Interfaces.IRepository;
using ASM.Core.Model;
using ASM.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM.Infrastructure.Repository
{
    public class CustomerRepository : GenericRepository<ASMCONTEXT, Customer>, ICustomerRepository
    {
        #region Attributes

       
        #endregion


        #region Ctor
        public CustomerRepository(ASMCONTEXT context)
          : base(context)
        {

        }
        #endregion


        #region Methodes
        public Customer GetSingle(int CustumerID)
        {
            return GetById(CustumerID);
        }

        #endregion


    }
}
