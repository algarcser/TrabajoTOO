using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace CapaPersistenciaVehiculo
{
    internal class TablaVehiculo : KeyedCollection<string, vehiculoDato>
    {
        /// <summary>
        /// redefinicion de la clave para un vehiculo dato
        /// </summary>
        /// <param name="vehiculoDato"> vehiculo dato para calcular la clave</param>
        /// <returns> devuelve la clave para un vehiculo dato</returns>
        protected override string GetKeyForItem(vehiculoDato vehiculoDato)
        {

            return vehiculoDato.NBastidor;
        }
    }
}
