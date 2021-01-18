using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaPersistenciaVehiculo;
using CapaPersistenciaPresupuesto;
using LogicaModeloVehiculo;


namespace PersistenciaConversor
{
    public class conversor
    {
        public static vehiculo Convertir(vehiculoDato vehiculoDato)
        {
            return new vehiculo(vehiculoDato.NBastidor, vehiculoDato.Marca, vehiculoDato.Modelo, vehiculoDato.Potencia, vehiculoDato.PrecioRecomendado, vehiculoDato.Iva);
        }

        public static vehiculoDato Convertir(vehiculo vehiculo)
        {
            return new vehiculoDato(vehiculo.NBastidor, vehiculo.Marca, vehiculo.Modelo, vehiculo.Potencia, vehiculo.PrecioRecomendado, vehiculo.Iva);
        }


    }
}
