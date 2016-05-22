using ASM.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM.Core.Interfaces.Services
{
    public interface ICustomerServices
    {
        IEnumerable<Customer> GetCustomers();

        Customer GetCusomerByID(int id);

        void CreateCustomer(Customer Customer);


        void UpdateCustomer(Customer Customer);

        Customer Find(int id);
     
        void DeleteAuteur(int id);
        
        void SaveCustomer();

    }
}
