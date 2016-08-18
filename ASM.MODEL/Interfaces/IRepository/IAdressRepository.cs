using ASM.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM.Core.Interfaces.IRepository
{
  public  interface IAdressRepository:IASMRepository<Adress>
    {
        void Save();
    }
}
