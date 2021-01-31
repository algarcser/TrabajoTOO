using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaPersistenciaVehiculo;
using LogicaModeloVehiculo;

namespace LogicaNegocioVehiculo
{
    public class LNExtras
    {
        /// <summary>
        /// funcion que introduce en la base de datos un extra, en el caso de que no haya un extra ya en la base de datos con la misma ID
        /// </summary>
        /// <param name="extra"> representa un extra</param>
        /// <returns> devuelve true en el caso de no existiese un extra que sea igual a alguno de la base de datos, devuelve False en el caso de que ya hubiese un extra en la base de datos</returns>
        public static bool INSERT(extra extra)
        {
            return PersistenciaExtras.INSERT(extra);
        }

        /// <summary>
        /// funcion que elimina de la base de datos un extra sea Equals, es decir igual que el extra que se ha proporcionado. En el caso de que no hay un extra no habra ningun cambio en la base de datos. 
        /// </summary>
        /// <param name="extra"> representa un extra</param>
        public static void DELETE(extra extra)
        {
            PersistenciaExtras.DELETE(extra);
        }


        /// <summary>
        /// funcion que actualiza los campos descripcion y precio de un extra en la base de datos. Se elimina el extra que sea Equals que el extra proporcionado y se incluye de nuevo en la base de datos de extras
        /// </summary>
        /// <param name="extra"> representa un extra</param>
        public static void UPDATE(extra extra)
        {
            PersistenciaExtras.DELETE(extra);
            PersistenciaExtras.INSERT(extra);
        }

        /// <summary>
        /// funcion que lee los datos de un extra que este dentro de la base de datos.Y lo devuelve. Se busca aquel extra que sea igual el extra proporcionado. Los datos de ese extra se guardaran en referencia. Una variable de salida
        /// </summary>
        /// <param name="referencia"> representa un extra</param>
        /// <param name="extra"> representa un extra, resultado de la busqueda </param>
        /// <returns> devuelve true en el caso de que la lectura fuese correcta y guarda los datos del extra igual al contenido en la base de datos. En caso contrario devuelve false </returns>
        public static bool READ(extra referencia, out extra extra)
        {
            return PersistenciaExtras.READ(referencia, out extra);
        }


        /// <summary>
        /// funcion que dice si en la base de datos existe un extra con la misma id que la id de referencia. 
        /// </summary>
        /// <param name="referencia"> representa un extra para buscar</param>
        /// <returns> devuelve true en el caso de que en la base de datos haya un extra igual al de la referencia. Y devuelve false en caso contrario</returns>
        public static bool EXISTS(extra referencia)
        {
            return PersistenciaExtras.EXISTS(referencia);
        }


        /// <summary>
        /// devuelve una lista con todos los extras que haya en la base de datos. 
        /// </summary>
        /// <returns> devuelve una lista que contiene todos los extras en la base de datos</returns>
        public static List<extra> SELECT_ALL()
        {
            return PersistenciaExtras.SELECT_ALL();
        }


        /// <summary>
        /// devuelve un entero que cuenta cuantos elementos tiene la base de datos
        /// </summary>
        /// <returns>devuelve un entero que representa cuantos elementos tiene la base de datos</returns>
        public static int COUNT()
        {
            return PersistenciaExtras.COUNT();
        }
    }
}
