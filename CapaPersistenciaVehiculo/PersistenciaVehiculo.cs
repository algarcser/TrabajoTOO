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

        public static void DELETE(vehiculo vehiculo)
        {
            BDvehiculo.DELETEVehiculo(conversor.Convertir(vehiculo));
        }


        public static void UPDATE(vehiculo vehiculo)
        {
            BDvehiculo.DELETEVehiculo(conversor.Convertir(vehiculo));
            BDvehiculo.INSERTVehiculo(conversor.Convertir(vehiculo));
        }

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


        public static bool EXISTS(vehiculo referencia)
        {
            return BDvehiculo.Exists(conversor.Convertir(referencia));
        }



    }

    public static class conversor
    {
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

        public static extra Convertir(extraDato extraDato)
        {
            return new extra(extraDato.Descripcion, extraDato.Precio);
        }

        public static extraDato Convertir(extra extra)
        {
            return new extraDato(extra.Descripcion, extra.Precio);
        }
    }
}
