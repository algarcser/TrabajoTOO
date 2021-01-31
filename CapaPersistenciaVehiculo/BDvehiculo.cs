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

        /// <summary>
        /// constructor
        /// </summary>
        private BDvehiculo() { }

        /// <summary>
        /// funcion que devuelve la tabla de vehiculos
        /// si no esta creada la crea y devuele una referencia a esta
        /// </summary>
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
        /// funcion que incluue un nuevo vehiculo en la tabla de vehiculos
        /// </summary>
        /// <param name="c">vehiculo que se quiere introducir</param>
        internal static void INSERTVehiculo(vehiculoDato c)
        {
            BDvehiculo.Vehiculos.Add(c);
        }


        /// <summary>
        /// funcion para leer la informacion de un vehiculo. 
        /// este vehiculo corresponde a aquel se sea igual al vehiculo de referencia pasado
        /// </summary>
        /// <param name="referencia"> vehiculos de referencia</param>
        /// <param name="vehiculoDato"> vehiculos el cual se quiere guardar el resultado de la busqueda</param>
        /// <returns>devuelve true si la busqueda ha tenido exito, devuelve falso en caso contrario</returns>
        internal static bool SELECTVehiculo(vehiculoDato referencia, out vehiculoDato vehiculoDato)
        {

            if (BDvehiculo.Exists(referencia))
            {
                vehiculoDato = BDvehiculo.Vehiculos[referencia.NBastidor];
                return true;
            }
            else
            {
                vehiculoDato = null;
                return false;
            }
        }

        /// <summary>
        /// funcion para actualizar los datos de un vehiculo
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

        internal static bool Exists(vehiculoDato vehiculoDato)
        {
            return BDvehiculo.Vehiculos.Contains(vehiculoDato.NBastidor);
        }

        internal static List<vehiculoDato> SELECT_ALL()
        {
            List<vehiculoDato> lista = new List<vehiculoDato>();
            foreach ( vehiculoDato vehiculo in BDvehiculo.Vehiculos)
            {
                lista.Add(vehiculo);
            }
            return lista;
        }

    }
}
