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
   public  class AdressRepository : GenericRepository<ASMCONTEXT,Adress>, IAdressRepository
    {
       
    }
}
