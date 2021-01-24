using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace CapaPersistenciaVehiculo
{
    class Tabla_VehiculoNuevo_Extras : KeyedCollection<string, vehiculoNuevo_Extra_Dato>
    {
        protected override string GetKeyForItem(vehiculoNuevo_Extra_Dato vehiculoNuevo_Extra_Dato)
        {

            return vehiculoNuevo_Extra_Dato.Key;
        }
    }
}
