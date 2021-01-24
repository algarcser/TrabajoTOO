using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaPersistenciaVehiculo
{
    class BDVehiculo_Extras
    {
        private static Tabla_VehiculoNuevo_Extras tabla_vehiculoNuevo_extras;

        internal BDVehiculo_Extras() { }

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

        internal static void INSERT(vehiculoNuevo_Extra_Dato c)
        {
            BDVehiculo_Extras.Tabla_vehiculoNuevo_extras.Add(c);
        }



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
        /// 
        /// </summary>
        /// <param name="c"></param>
        internal static void UPDATE(vehiculoNuevo_Extra_Dato c)
        {
            DELETE(c);
            INSERT(c);

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="c"></param>
        internal static void DELETE(vehiculoNuevo_Extra_Dato c)
        {
            BDVehiculo_Extras.Tabla_vehiculoNuevo_extras.Remove(c);
        }

        internal static bool Exists(vehiculoNuevo_Extra_Dato vehiculoNuevo_Extra_Dato)
        {
            return BDVehiculo_Extras.Tabla_vehiculoNuevo_extras.Contains(vehiculoNuevo_Extra_Dato.Key);
        }

        internal static List<vehiculoNuevo_Extra_Dato> SELECT_ALL()
        {
            List<vehiculoNuevo_Extra_Dato> lista = new List<vehiculoNuevo_Extra_Dato>();
            foreach (vehiculoNuevo_Extra_Dato vehiculo_extra in BDVehiculo_Extras.Tabla_vehiculoNuevo_extras)
            {
                lista.Add(vehiculo_extra);
            }
            return lista;
        }

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
