using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaPersistenciaVehiculo;
using LogicaModeloVehiculo;


namespace LogicaNegocioVehiculo
{
    public class LNVehiculo
    {
        public static bool INSERT(vehiculo vehiculo)
        {
            return PersistenciaVehiculo.INSERT(vehiculo);
        }

        public static void DELETE(vehiculo vehiculo)
        {
            PersistenciaVehiculo.DELETE(vehiculo);
        }


        public static void UPDATE(vehiculo vehiculo)
        {
            PersistenciaVehiculo.DELETE(vehiculo);
            PersistenciaVehiculo.INSERT(vehiculo);
        }

        public static bool READ(vehiculo referencia, out vehiculo vehiculo)
        {
            return PersistenciaVehiculo.READ(referencia, out vehiculo);
        }

        public static bool EXISTS(vehiculo referencia)
        {
            return PersistenciaVehiculo.EXISTS(referencia);
        }
    }
}
