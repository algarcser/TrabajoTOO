using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace CapaPersistenciaVehiculo
{
    internal class TablaExtras : KeyedCollection<int, extraDato>
    {

        /// <summary>
        /// redefinicion de la clave para un extradato en la keyect collection list
        /// </summary>
        /// <param name="extraDato"> referencia al extradato que se quiere saber la clave</param>
        /// <returns> devuelve un entero que es la clave para extradato</returns>
        protected override int GetKeyForItem(extraDato extraDato)
        {

            return extraDato.Id;
        }
    }
}
