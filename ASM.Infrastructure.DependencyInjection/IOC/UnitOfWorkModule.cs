using ASM.Core.Interfaces.IUnitOfWork;
using ASM.Infrastructure.UnitOfWorks;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM.Infrastructure.DependencyInjection.IOC
{
   public  class UnitOfWorkModule: NinjectModule
    {
      
           public override void Load()
        {
            //TO do binding here
            Bind<IUnitOfWork>().To<UnitOfWork>();
          
        }
   
    }
}
