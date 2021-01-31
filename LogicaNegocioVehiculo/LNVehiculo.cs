using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaPersistenciaVehiculo;
using LogicaModeloVehiculo;


namespace LogicaNegocioVehiculo
{
    public class LNVehiculo
    {

        /// <summary>
        /// funcion que inserta un vehiculo en la base de datos de vehiculos en el caso de que no haya un vehiculo igual ya existente en la base de datos
        /// </summary>
        /// <param name="vehiculo">representacion del vehiculo a introducir</param>
        /// <returns>Devuelve cierte en el caso de que no haya ya un vehiculo igual se haya introducido en la base de datos el vehiculo pasado. Devuelve false en caso contrario</returns>
        public static bool INSERT(vehiculo vehiculo)
        {
            return PersistenciaVehiculo.INSERT(vehiculo);
        }


        /// <summary>
        /// funcion que elimina de la base de datos al vehiculo que sea igual al pasado por parametro
        /// </summary>
        /// <param name="vehiculo">representacion del vehiculo a eliminar</param>
        public static void DELETE(vehiculo vehiculo)
        {
            PersistenciaVehiculo.DELETE(vehiculo);
        }


        /// <summary>
        /// funcion que actualiza de la base de datos los datos del vehiculo que sea igual al vehiculo pasado como parametro. 
        /// </summary>
        /// <param name="vehiculo"> representacion del vehiculo a actualizar</param>
        public static void UPDATE(vehiculo vehiculo)
        {
            PersistenciaVehiculo.DELETE(vehiculo);
            PersistenciaVehiculo.INSERT(vehiculo);
        }


        /// <summary>
        /// funcion que lee los datos del vehiculo sea igual al vehiculo pasado como referencia. Los datos del vehiculo leido de la base de datos se guardan en en parametro out vehiculo. En caso de que no exista no se hara nada
        /// </summary>
        /// <param name="referencia"> representacion del vehiculo cuyo numero de bastidor buscamos en la base de datos</param>
        /// <param name="vehiculo"> representacion del vehiculo almacena en la base de datos y los datos guardados, Sera una variable de salida</param>
        /// <returns> devuelve cierto en el caso de la lectura se haya hecho con exito, y devuelve falso en caso contrario</returns>
        public static bool READ(vehiculo referencia, out vehiculo vehiculo)
        {
            return PersistenciaVehiculo.READ(referencia, out vehiculo);
        }


        /// <summary>
        /// funcion que busca en la base de datos un vehiculo que sea igual al vehiculo referencia.
        /// </summary>
        /// <param name="referencia">representacion del vehiculo a buscar en la base de datos</param>
        /// <returns> devuelve cierto en el caso de que haya un vehiculo en la base de datos igual vehiculo. Devuelve falso en caso contrario</returns>
        public static bool EXISTS(vehiculo referencia)
        {
            return PersistenciaVehiculo.EXISTS(referencia);
        }

        /// <summary>
        /// devuelve una lista con todos los vehiculos contenidos en la base de datos
        /// </summary>
        /// <returns>devuelve una lista que contiene a todos los vehiculos en la base de datos</returns>
        public static List<vehiculo> SELECT_ALL()
        {
            return PersistenciaVehiculo.SELECT_ALL();
        }
    }
}
