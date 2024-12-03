using MateoProgreso2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MateoProgreso2.Interfaces
{
    public class IRecarga
    {
        List<Recarga> DevuelveListRecarga();
        Recarga DevuelveRecarg(int Id);
        Boolean CrearRecarga(Recarga recarga);
    }
}
