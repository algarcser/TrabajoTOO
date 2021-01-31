using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaPersistenciaVehiculo
{
    internal class BDVehiculo_Extras
    {
        private static Tabla_VehiculoNuevo_Extras tabla_vehiculoNuevo_extras;


        /// <summary>
        /// constructor de bd extras
        /// </summary>
        internal BDVehiculo_Extras() { }


        /// <summary>
        /// funcion para acceder a la tabla de la base de datos
        /// get: devuelve una referencia a la tabla de la base de datos
        /// </summary>
        internal static Tabla_VehiculoNuevo_Extras Tabla_vehiculoNuevo_extras
        {
            get
            {
                if(tabla_vehiculoNuevo_extras == null)
                {
                    tabla_vehiculoNuevo_extras = new Tabla_VehiculoNuevo_Extras();
                }
                return tabla_vehiculoNuevo_extras;
            }
        }


        /// <summary>
        /// funcion que inserta un vehiculo-nuevo-extra-dato en la base de datos
        /// </summary>
        /// <param name="c"> dehiculo nuevo extra dato a ingresar</param>
        internal static void INSERT(vehiculoNuevo_Extra_Dato c)
        {
            BDVehiculo_Extras.Tabla_vehiculoNuevo_extras.Add(c);
        }


        /// <summary>
        /// funcion para seleccionar los vehiculo nuevo extra dato de la base de datos
        /// si hay alguno que sea igual a la referencia pasada, cargara los datos y los guardara en paremetro de salida pasado
        /// </summary>
        /// <param name="referencia"> vehiculo nuevo extra dato de refencia</param>
        /// <param name="vehiculoNuevo_Extra_Dato"> resultado la operacion select</param>
        /// <returns> devuelve true en el caso de que la busqueda haya sido exitosa, y devuelve falso en caso contrario</returns>
        internal static bool SELECT(vehiculoNuevo_Extra_Dato referencia, out vehiculoNuevo_Extra_Dato vehiculoNuevo_Extra_Dato)
        {

            if (BDVehiculo_Extras.Exists(referencia))
            {
                vehiculoNuevo_Extra_Dato = BDVehiculo_Extras.Tabla_vehiculoNuevo_extras[referencia.Key];
                return true;
            }
            else
            {
                vehiculoNuevo_Extra_Dato = null;
                return false;
            }
        }

        /// <summary>
        /// funcion para actuailizar los datos de un registro
        /// </summary>
        /// <param name="c"> representacion del vehiculoNuevoExtra dato</param>
        internal static void UPDATE(vehiculoNuevo_Extra_Dato c)
        {
            DELETE(c);
            INSERT(c);

        }

        /// <summary>
        /// se elimina de la base de datos a aquel elemento igual a la referencia pasado
        /// </summary>
        /// <param name="c"> referencia que se quiere elimninar</param>
        internal static void DELETE(vehiculoNuevo_Extra_Dato c)
        {
            BDVehiculo_Extras.Tabla_vehiculoNuevo_extras.Remove(c);
        }


        /// <summary>
        /// funcion que dice si hay un elemento igual o no en la base de datos de la referencia dada
        /// </summary>
        /// <param name="vehiculoNuevo_Extra_Dato"> referencia vehiculo nuevo extra dato a introducir</param>
        /// <returns> devuelve cierto en el caso de que haya un elemento igual en la base datos, y devuelve falso en caso contrario</returns>
        internal static bool Exists(vehiculoNuevo_Extra_Dato vehiculoNuevo_Extra_Dato)
        {
            return BDVehiculo_Extras.Tabla_vehiculoNuevo_extras.Contains(vehiculoNuevo_Extra_Dato.Key);
        }

        /// <summary>
        /// devuelve la lista completa de vehiculos extra datos
        /// </summary>
        /// <returns> devuelve una lista que contiene todos los elementos de vehiculo nuevo extra datos</returns>
        internal static List<vehiculoNuevo_Extra_Dato> SELECT_ALL()
        {
            List<vehiculoNuevo_Extra_Dato> lista = new List<vehiculoNuevo_Extra_Dato>();
            foreach (vehiculoNuevo_Extra_Dato vehiculo_extra in BDVehiculo_Extras.Tabla_vehiculoNuevo_extras)
            {
                lista.Add(vehiculo_extra);
            }
            return lista;
        }

        /// <summary>
        /// funcion que devueleve una lista de enteros donde dado un vehiculo, se encuentran todos los elementos que estes en la base de datos con el numero de bastidor del vehiculo pasado
        /// </summary>
        /// <param name="vehiculoDato"> referencia del vehiculo que buscamos</param>
        /// <returns> devuelve una lista de enteros asociados al vehiculo que se ha pasado como parametro</returns>
        internal static List<int> Obtain_All_Extras(vehiculoDato vehiculoDato)
        {
            List<int> lista_id = new List<int>();
            foreach(vehiculoNuevo_Extra_Dato auxiliar in BDVehiculo_Extras.Tabla_vehiculoNuevo_extras)
            {
                if(auxiliar.NBastidor == vehiculoDato.NBastidor)
                {
                    lista_id.Add(auxiliar.Id_extra);
                }
            }

            return lista_id;
        }

    }
}
