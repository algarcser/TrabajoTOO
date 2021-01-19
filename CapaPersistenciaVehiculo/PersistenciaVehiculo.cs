﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicaModeloVehiculo;

namespace CapaPersistenciaVehiculo
{
    class PersistenciaVehiculo
    {


        private bool INSERT(vehiculo vehiculo)
        {
            if (!BDvehiculo.Exists(vehiculo.NBastidor))
            {
                BDvehiculo.INSERTVehiculo(conversor.Convertir(vehiculo));
                return true;
            }
            else
            {
                return false;
            }
        }

        private void DELETE(vehiculo vehiculo)
        {
            BDvehiculo.DELETEVehiculo(conversor.Convertir(vehiculo));
        }


        private void UPDATE(vehiculo vehiculo)
        {
            BDvehiculo.DELETEVehiculo(conversor.Convertir(vehiculo));
            BDvehiculo.INSERTVehiculo(conversor.Convertir(vehiculo));
        }

        private bool READ(string clave, out vehiculo vehiculo)
        {
            vehiculoDato auxiliar;
            bool resultado = BDvehiculo.SELECTVehiculo(clave, out auxiliar);
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
            return new vehiculoDato(vehiculo.NBastidor, vehiculo.Marca, vehiculo.Modelo, vehiculo.Potencia, vehiculo.PrecioRecomendado, auxiliar);
        }
    }
}
