using ASM.Core.Interfaces.IRepository;
using ASM.Core.Interfaces.IUnitOfWork;
using ASM.Core.Interfaces.Services;
using ASM.Infrastructure.Repository;
using ASM.Infrastructure.Services;
using ASM.Infrastructure.UnitOfWorks;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM.Infrastructure.DependencyInjection.IOC
{
    public class RepositoryModule : NinjectModule
    {
        public override void Load()
        {
            //TO do binding here
            
            Bind<ICustomerRepository>().To<CustomerRepository>();
            Bind<IAdressRepository>().To<AdressRepository>();
        }

    }
}
