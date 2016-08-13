using ASM.Core.Interfaces.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM.Core.Interfaces.IUnitOfWork
{
  public   interface IUnitOfWork
    {
        ICustomerRepository CustomerRepository { get; }
        IAdressRepository AdressRepository { get; }

        void Save();
    }
}
