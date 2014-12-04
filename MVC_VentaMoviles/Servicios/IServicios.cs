using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Servicios
{
   public interface IServicios<TModelo>
   {
       Task Add(TModelo modelo);
       Task Update(int id, TModelo modelo);
       Task Delete(int id);
       List<TModelo> Get();
       List<TModelo> Get(String metodo, String param);
       TModelo Get(int id);
   }
}
