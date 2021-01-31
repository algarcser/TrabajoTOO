using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicaModeloVehiculo;

namespace CapaPersistenciaVehiculo
{
    public static class PersistenciaExtras
    {

        /// <summary>
        /// funcion que anade un extra a la base de datos en el caso de que no este, si esta entonces no se anade, si ya hay alguno giual
        /// </summary>
        /// <param name="extra">extra que se quiere anadir</param>
        /// <returns>devuelve cierto si se ha podido anadir correctamente
        /// y devuelve falso en caso contrario</returns>
        public static bool INSERT(extra extra)
        {
            if (!BDExtras.Exists(conversor.Convertir(extra)))
            {
                BDExtras.INSERT(conversor.Convertir(extra));
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// funcion que elimina un extra de la base de datos, en el caso de que haya alguno igual
        /// </summary>
        /// <param name="extra">referencia del extra a eliminar/param>
        public static void DELETE(extra extra)
        {
            BDExtras.DELETE(conversor.Convertir(extra));
        }


        /// <summary>
        /// funcion que actualiza un extra de la base de datos
        /// </summary>
        /// <param name="extra">representacion del extra a actualizar</param>
        public static void UPDATE(extra extra)
        {
            BDExtras.DELETE(conversor.Convertir(extra));
            BDExtras.INSERT(conversor.Convertir(extra));
        }

        /// <summary>
        /// funcion para leer datos de la base de extras, si hay un extra igual a la referencia pasada entonces lo guarda en el parametro de salida out
        /// </summary>
        /// <param name="referencia"> extra de referencia</param>
        /// <param name="extra"> extra donde se guarda el resultado</param>
        /// <returns> devuelve true en caso de que la lectura haya sido correcta, y devuelve falso en caso contrario</returns>
        public static bool READ(extra referencia, out extra extra)
        {
            extraDato extraDato;
            bool resultado = BDExtras.SELECT(conversor.Convertir(referencia), out extraDato);
            if (resultado)
            {
                extra = conversor.Convertir(extraDato);
            }
            else
            {
                extra = null;
            }
            return resultado;
        }

        /// <summary>
        /// funcion que mira si hay un extra igual al pasado como parametro
        /// </summary>
        /// <param name="extra"> extra de referencia</param>
        /// <returns> devuelve true en el caso de que haya un extra igual en la base de datos
        /// y devuelve falso en caso contrario</returns>
        public static bool EXISTS(extra extra)
        {
            return BDExtras.Exists(conversor.Convertir(extra));
        }

        /// <summary>
        /// funcino que devuelve toda la lista de extras de la base de datos
        /// </summary>
        /// <returns>devuelve una lista que contenga todos los extras en la base de datos</returns>
        public static List<extra> SELECT_ALL()
        {
            List<extra> extras = new List<extra>();
            foreach (extraDato extraDato in BDExtras.SELECT_ALL())
            {
                extra auxiliar = conversor.Convertir(extraDato);
                extras.Add(auxiliar);
            }
            return extras;
        }

        /// <summary>
        /// funcion que cuenta cuentos extras hay almacenados en la base de datos
        /// </summary>
        /// <returns> devuelve un entero que dice cuantos extras hay en la base de datos</returns>
        public static int COUNT()
        {
            return BDExtras.COUNT();
        }
    }
}
