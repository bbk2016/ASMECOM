using ASM.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ASM.Core.Model;
using ASM.Core.Interfaces.IUnitOfWork;

namespace ASM.Infrastructure.Services
{
    public class CustomerServices : ICustomerServices
    {
        private readonly IUnitOfWork _unitOfWork;

       
        public CustomerServices(IUnitOfWork unitofwork)
        {
            this._unitOfWork = unitofwork;
        }
        public void CreateCustomer(Customer Customer)
        {
            _unitOfWork.CustomerRepository.Add(Customer);
            _unitOfWork.Save();
        }

        public void DeleteCustomer(int id)
        {
        Customer customer=    _unitOfWork.CustomerRepository.GetById(id);
            if (customer != null)
                _unitOfWork.CustomerRepository.Delete(customer);
        }

        public Customer Find(int id)
        {
            throw new NotImplementedException();
        }

        public Customer GetCusomerByID(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Customer> GetCustomers()
        {
            return _unitOfWork.CustomerRepository.GetAll();
        }

        public void SaveCustomer()
        {
            throw new NotImplementedException();
        }

        public void UpdateCustomer(Customer Customer)
        {
            throw new NotImplementedException();
        }
    }
}
