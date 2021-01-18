using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaPersistenciaVehiculo
{
    class BDvehiculo
    {

        private static TablaVehiculo vehiculos;

        //private static TablaExtras extras;
        private BDvehiculo() { }
        public static TablaVehiculo Clientes
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
        public static void INSERTCliente(vehiculoDato c)
        {
            BDvehiculo.vehiculos.Add(c);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="l"></param>
        public static List<vehiculoDato> SELECTCliente()
        {
            List<vehiculoDato> lista = new List<vehiculoDato>();
            return lista;
        }

        public static vehiculoDato SELECTVehiculo(vehiculoDato c)
        {
            return c;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="c"></param>
        public static void UPDATEVehiculo(vehiculoDato c)
        {
            DELETECliente(c);
            INSERTCliente(c);

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="c"></param>
        public static void DELETECliente(vehiculoDato c)
        {
            BDvehiculo.vehiculos.Remove(c);
        }

    }
}
