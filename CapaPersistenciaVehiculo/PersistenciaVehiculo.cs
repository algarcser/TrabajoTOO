using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicaModeloVehiculo;


namespace CapaPersistenciaVehiculo
{
    public static class PersistenciaVehiculo
    {

        /// <summary>
        /// funcion que anade un vehiculos a la base de datos
        /// </summary>
        /// <param name="vehiculo"> representacion de vehiculo a insertar</param>
        /// <returns> si no existe un vehiculo igual lo anade a la base de datos y devuelve true
        /// en caso contrario no lo anade y devuelve falso</returns>
        public static bool INSERT(vehiculo vehiculo)
        {
            if (!BDvehiculo.Exists(conversor.Convertir(vehiculo)))
            {
                BDvehiculo.INSERTVehiculo(conversor.Convertir(vehiculo));
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// funcion que elimina de la base de dato de vehiculo el vehiculo pasado igual
        /// </summary>
        /// <param name="vehiculo"> representacion del vehiculo </param>
        public static void DELETE(vehiculo vehiculo)
        {
            BDvehiculo.DELETEVehiculo(conversor.Convertir(vehiculo));
        }

        /// <summary>
        /// funcion que actualiza el vehiculo igual que haya en la base de datos
        /// </summary>
        /// <param name="vehiculo"> representacion del vehiculo</param>
        public static void UPDATE(vehiculo vehiculo)
        {
            BDvehiculo.DELETEVehiculo(conversor.Convertir(vehiculo));
            BDvehiculo.INSERTVehiculo(conversor.Convertir(vehiculo));
        }

        /// <summary>
        /// funcion que lee un vehiculo de la base de datos que sea igual a la referencia pasada, los datos de la salida se guardan el parametro de salida
        /// </summary>
        /// <param name="referencia"> vehiculo de referencia, </param>
        /// <param name="vehiculo"> vehiculo de salida donde se guarda el resultado de la busqueda</param>
        /// <returns> devuevel true si la busqueda ha sido correcta y devuelve false en caso contrario</returns>
        public static bool READ(vehiculo referencia, out vehiculo vehiculo)
        {
            vehiculoDato auxiliar;
            bool resultado = BDvehiculo.SELECTVehiculo(conversor.Convertir(referencia), out auxiliar);
            if (resultado)
            {
                vehiculo = conversor.Convertir(auxiliar);
            }
            else
            {
                vehiculo = null;
            }
            return resultado;
        }

        /// <summary>
        /// funcion que comprueba si existe un vehiculo igual a la referencia en la base de datos
        /// </summary>
        /// <param name="referencia"> vehiculo de referencia</param>
        /// <returns> devuelve true en el caso de que haya un vehiculo igual a la referencia en la base de datos, y devuelve falso en caso contrario</returns>
        public static bool EXISTS(vehiculo referencia)
        {
            return BDvehiculo.Exists(conversor.Convertir(referencia));
        }

        /// <summary>
        /// funcion que devuelve toda la lista de vehiculos que haya en la base de datos
        /// </summary>
        /// <returns>devuele una lista que contiene todos los vehiculos de la base de datos</returns>
        public static List<vehiculo> SELECT_ALL()
        {
            List<vehiculo> vehiculos = new List<vehiculo>();
            foreach(vehiculoDato vehiculoDato in BDvehiculo.SELECT_ALL())
            {
                vehiculo auxiliar = conversor.Convertir(vehiculoDato);
                vehiculos.Add(auxiliar);
            }
            return vehiculos;
        }

    }

    public static class conversor
    {

        /// <summary>
        /// convierte un vehivulo dato en un vehiculo, que tenga los mismo parametros
        /// </summary>
        /// <param name="vehiculoDato"> vehiculo dato a convertir</param>
        /// <returns> devuelve un vehiculo dato que tenga la misma informacion</returns>
        public static vehiculo Convertir(vehiculoDato vehiculoDato)
        {

            iva auxiliarIva;
            if(vehiculoDato.Iva == 0)
            {
                auxiliarIva = iva.cocheNuevo;
            }
            else
            {
                auxiliarIva = iva.cocheSegundaMano;
            }


            if ( vehiculoDato is vehiculo2ManoDato)
            {
                vehiculo2ManoDato auxiliarVehiculo = vehiculoDato as vehiculo2ManoDato;
                return new vehiculo2Mano(auxiliarVehiculo.NBastidor, auxiliarVehiculo.Modelo, auxiliarVehiculo.Marca, auxiliarVehiculo.Potencia, auxiliarVehiculo.PrecioRecomendado, auxiliarIva, auxiliarVehiculo.Matricula, auxiliarVehiculo.FechaMatriculacion);
            }
            else if(vehiculoDato is vehiculoNuevoDato)
            {
                vehiculoNuevoDato auxiliarVehiculo = vehiculoDato as vehiculoNuevoDato;
                vehiculoNuevo auxiliarVehiculoNuevo = new vehiculoNuevo(auxiliarVehiculo.NBastidor, auxiliarVehiculo.Modelo, auxiliarVehiculo.Marca, auxiliarVehiculo.Potencia, auxiliarVehiculo.PrecioRecomendado, auxiliarIva);
               foreach(extraDato extraDato in auxiliarVehiculo.Extras)
                {
                    auxiliarVehiculoNuevo.AddExtra(conversor.Convertir(extraDato));
                }
                
                return auxiliarVehiculoNuevo;
            }

            return null;
            
        }

        /// <summary>
        /// funcion que converte un vehiculo en un vehiculo dato que tenga los mismos datos
        /// </summary>
        /// <param name="vehiculo">representacion del vehiculo</param>
        /// <returns> vehiculo dato que tiene la misma informacion que el vehiculo pasado</returns>
        public static vehiculoDato Convertir(vehiculo vehiculo)
        {
            ivaDato auxiliar_iva_dato;
            if (vehiculo.Iva == 0)
            {
                auxiliar_iva_dato = ivaDato.cocheNuevo;
            }
            else
            {
                auxiliar_iva_dato = ivaDato.cocheSegundaMano;
            }
            

            if (vehiculo is vehiculo2Mano)
            {
                vehiculo2Mano auxiliarVehiculo = vehiculo as vehiculo2Mano;
                return new vehiculo2ManoDato(auxiliarVehiculo.NBastidor, auxiliarVehiculo.Modelo, auxiliarVehiculo.Marca, auxiliarVehiculo.Potencia, auxiliarVehiculo.PrecioRecomendado, auxiliar_iva_dato, auxiliarVehiculo.Matricula, auxiliarVehiculo.FechaMatriculacion);
            }
            else if (vehiculo is vehiculoNuevo)
            {
                vehiculoNuevo auxiliarVehiculo = vehiculo as vehiculoNuevo;
                vehiculoNuevoDato auxiliarVehiculoNuevo = new vehiculoNuevoDato(auxiliarVehiculo.NBastidor, auxiliarVehiculo.Modelo, auxiliarVehiculo.Marca, auxiliarVehiculo.Potencia, auxiliarVehiculo.PrecioRecomendado, auxiliar_iva_dato);
                foreach (extra extra in auxiliarVehiculo.Extras)
                {
                    auxiliarVehiculoNuevo.AddExtra(conversor.Convertir(extra));
                }

                return auxiliarVehiculoNuevo;
            }

            return null;

        }

        /// <summary>
        /// funcion que convierte un extradato en un dato con la misma informacion
        /// </summary>
        /// <param name="extraDato">extrado a convertir</param>
        /// <returns> dato convertido</returns>
        public static extra Convertir(extraDato extraDato)
        {
            return new extra(extraDato.Id, extraDato.Descripcion, extraDato.Precio);
        }

        /// <summary>
        /// funcion para convertir un extra en un extradato con la misma informacion
        /// </summary>
        /// <param name="extra"> referencia al extra a convertir</param>
        /// <returns> extradao convertido</returns>
        public static extraDato Convertir(extra extra)
        {
            return new extraDato(extra.Id, extra.Descripcion, extra.Precio);
        }
    }
}
