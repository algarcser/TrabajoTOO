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
            iva auxiliar;
            if(vehiculoDato.Iva == 0)
            {
                auxiliar = iva.cocheNuevo;
            }
            else
            {
                auxiliar = iva.cocheSegundaMano;
            }

            return new vehiculo(vehiculoDato.NBastidor, vehiculoDato.Marca, vehiculoDato.Modelo, vehiculoDato.Potencia, vehiculoDato.PrecioRecomendado, auxiliar);
        }

        public static vehiculoDato Convertir(vehiculo vehiculo)
        {
            ivaDato auxiliar;
            if (vehiculo.Iva == 0)
            {
                auxiliar = ivaDato.cocheNuevo;
            }
            else
            {
                auxiliar = ivaDato.cocheSegundaMano;
            }
            return new vehiculoDato(vehiculo.NBastidor, vehiculo.Marca, vehiculo.Modelo, vehiculo.Potencia, vehiculo.PVP, auxiliar);
        }
    }
}
