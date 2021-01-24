using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace CapaPersistenciaVehiculo
{
    class TablaExtras : KeyedCollection<int, extraDato>
    {
        protected override int GetKeyForItem(extraDato extraDato)
        {

            return extraDato.Id;
        }
    }
}
