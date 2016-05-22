using ASM.Core.Interfaces.IUnitOfWork;
using ASM.Core.Interfaces.Services;
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