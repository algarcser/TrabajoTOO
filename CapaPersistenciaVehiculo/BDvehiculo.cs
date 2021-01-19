using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaPersistenciaVehiculo
{
    internal class BDvehiculo
    {

        private static TablaVehiculo vehiculos;

        //private static TablaExtras extras;
        private BDvehiculo() { }
        private static TablaVehiculo Vehiculos
        {
            get
            {
                if (vehiculos == null)
                    vehiculos = new TablaVehiculo();
                return vehiculos;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="c"></param>
        internal static void INSERTVehiculo(vehiculoDato c)
        {
            BDvehiculo.Vehiculos.Add(c);
        }



        internal static bool SELECTVehiculo(string clave, out vehiculoDato vehiculoDato)
        {

            if (BDvehiculo.Exists(clave))
            {
                vehiculoDato = BDvehiculo.Vehiculos[clave];
                return true;
            }
            else
            {
                vehiculoDato = null;
                return false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="c"></param>
        internal static void UPDATEVehiculo(vehiculoDato c)
        {
            DELETEVehiculo(c);
            INSERTVehiculo(c);

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="c"></param>
        internal static void DELETEVehiculo(vehiculoDato c)
        {
            BDvehiculo.Vehiculos.Remove(c);
        }

        internal static bool Exists(string clave)
        {
            return BDvehiculo.Vehiculos.Contains(clave);
        }

    }
}
