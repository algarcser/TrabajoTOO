using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace CapaPersistenciaVehiculo
{
    internal class Tabla_VehiculoNuevo_Extras : KeyedCollection<string, vehiculoNuevo_Extra_Dato>
    {

        /// <summary>
        /// redefinicion de la clave para un vehiculo nuevo extra dato
        /// </summary>
        /// <param name="vehiculoNuevo_Extra_Dato"></param>
        /// <returns> devuelve un string que es la clave un un vehiculo extra dato</returns>
        protected override string GetKeyForItem(vehiculoNuevo_Extra_Dato vehiculoNuevo_Extra_Dato)
        {

            return vehiculoNuevo_Extra_Dato.Key;
        }
    }
}
