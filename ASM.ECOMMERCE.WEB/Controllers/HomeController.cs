using ASM.Core.Interfaces.IUnitOfWork;
using ASM.Core.Interfaces.Services;
using ASM.Core.Model;
using ASM.Infrastructure.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASM.ECOMMERCE.WEB.Controllers
{
    public class HomeController : Controller
    {
     
        
        private ICustomerServices _customerServices ;
        public HomeController()
        {

        }
        public HomeController(ICustomerServices customerServices)
        {
            this._customerServices = customerServices;
        }
        public ActionResult Index()
       {
            Customer customer = new Customer();
            customer.Firstname = "bilel";
            customer.Lastname = "benkhalifa";
            customer.Email = "benkh.bilel@hotmail.fr";
           
            _customerServices.CreateCustomer(customer);
          var c =  _customerServices.GetCustomers();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}