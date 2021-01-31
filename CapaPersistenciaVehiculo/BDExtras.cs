using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaPersistenciaVehiculo
{
    internal class BDExtras
    {
        private static TablaExtras tablaExtras;

        /// <summary>
        /// constructor
        /// </summary>
        private BDExtras() { }

        /// <summary>
        /// metodo de acceso a la tabla de extras. Si no esta creada la crea
        /// </summary>
        private static TablaExtras TablaExtras
        {
            get
            {
                if(tablaExtras == null)
                {
                    tablaExtras = new TablaExtras();
                }
                return tablaExtras;
            }
        }


        /// <summary>
        /// funcion que anade a extra dato a la tabla de datos, en el caso de no haya alguna que sea igual
        /// </summary>
        /// <param name="c"> representa el extrada a anadir</param>
        internal static void INSERT(extraDato c)
        {
            BDExtras.TablaExtras.Add(c);
        }


        /// <summary>
        /// funcion que carga los datos del extrado dato de referencia que se pasa en el extradato de salida
        /// </summary>
        /// <param name="referencia">extradato de referencia</param>
        /// <param name="extraDato">exttradato de salida en el que se guarda el resultado de la busqueda</param>
        /// <returns>devuelve cierta si existe el extradato que se busca, devuelve falso en caso contrario</returns>
        internal static bool SELECT(extraDato referencia, out extraDato extraDato)
        {

            if (BDExtras.Exists(referencia))
            {
                extraDato = BDExtras.TablaExtras[referencia.Id];
                return true;
            }
            else
            {
                extraDato = null;
                return false;
            }
        }

        /// <summary>
        /// funcion que actualiza un extradato de la base de datos
        /// </summary>
        /// <param name="c"> extradato que se quiere actualizar</param>
        internal static void UPDATE(extraDato c)
        {
            DELETE(c);
            INSERT(c);

        }

        /// <summary>
        /// funcion que elimina el extradato igual que haya en la base de datos con el extradato pasado
        /// </summary>
        /// <param name="c"> extradato que se quiere eliminar</param>
        internal static void DELETE(extraDato c)
        {
            BDExtras.TablaExtras.Remove(c);
        }

        /// <summary>
        /// funcion que comprueba si existe en la base de datos un extradato igual al pasado como parametro
        /// </summary>
        /// <param name="extraDato">extradato que si quiere saber si esta</param>
        /// <returns>devuelve cierto si hay un extradato igual en la base de datos, y devulve falso en caso contrario</returns>
        internal static bool Exists(extraDato extraDato)
        {
            return BDExtras.TablaExtras.Contains(extraDato.Id);
        }

        /// <summary>
        /// devuelve una lista con todos los extradatos que haya en la base de datos
        /// </summary>
        /// <returns> devuelve una lista con todos los extrados que haya en la base de datos</returns>
        internal static List<extraDato> SELECT_ALL()
        {
            List<extraDato> lista = new List<extraDato>();
            foreach (extraDato extraDato in BDExtras.TablaExtras)
            {
                lista.Add(extraDato);
            }
            return lista;
        }

        /// <summary>
        /// datos un lista de enteros, devuelve una lista de extras cuyas id, esten dentro la lista de enteros proporcionada
        /// </summary>
        /// <param name="ids"> la lista de id que queremos buscar</param>
        /// <returns>devuelve una lista de extras cuyas id, esten dentro la lista de enteros proporcionada</returns>
        internal static List<extraDato> Obtain_All_Extras(List<int> ids)
        {
            List<extraDato> extras = new List<extraDato>();
            foreach (int id in ids)
            {
                extraDato auxiliar;
                if(BDExtras.Exists(new extraDato(id)))
                {
                    BDExtras.SELECT(new extraDato(id), out auxiliar);
                    extras.Add(auxiliar);
                }
            }
            return extras;
        }

        /// <summary>
        /// funcion que cuenta cuantos elementos hay en la tabla
        /// </summary>
        /// <returns> devuelve un entero de cuantos elementos hay en la tabla contenido</returns>
        internal static int COUNT()
        {
            return BDExtras.TablaExtras.Count();
        }
    }
}
