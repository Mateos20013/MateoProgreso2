using MateoProgreso2.Models;
using System.Collections.Generic;

namespace MateoProgreso2.Interfaces
{
    // Definición de la interfaz IRecarga
    public interface IRecarga
    {
        // Métodos sin cuerpo (sólo las firmas de los métodos)
        List<Recarga> DevuelveListRecarga();
        Recarga DevuelveRecarg(int Id);
        bool CrearRecarga(Recarga recarga);
    }
}
