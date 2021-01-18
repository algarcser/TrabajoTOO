using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace CapaPersistenciaVehiculo
{
    public class TablaVehiculo : KeyedCollection<string, vehiculoDato>
    {

        protected override string GetKeyForItem(vehiculoDato vehiculoDato)
        {

            return vehiculoDato.NBastidor;
        }
    }
}
