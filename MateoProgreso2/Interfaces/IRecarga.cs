using MateoProgreso2.Models;
using System.Collections.Generic;

namespace MateoProgreso2.Interfaces
{
   
    public interface IRecarga
    {

        List<Recarga> DevuelveListRecarga();
        Recarga DevuelveRecarg(int Id);
        bool CrearRecarga(Recarga recarga);
    }
}
