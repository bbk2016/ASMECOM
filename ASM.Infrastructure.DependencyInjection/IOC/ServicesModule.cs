using ASM.Core.Interfaces.Services;
using ASM.Infrastructure.Services;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM.Infrastructure.DependencyInjection.IOC
{
    public class ServicesModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ICustomerServices>().To<CustomerServices>();
        }
    }
}
