using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaPersistenciaVehiculo;
using LogicaModeloVehiculo;

namespace LogicaNegocioVehiculo
{
    public class LNExtras
    {
        public static bool INSERT(extra extra)
        {
            return PersistenciaExtras.INSERT(extra);
        }

        public static void DELETE(extra extra)
        {
            PersistenciaExtras.DELETE(extra);
        }


        public static void UPDATE(extra extra)
        {
            PersistenciaExtras.DELETE(extra);
            PersistenciaExtras.INSERT(extra);
        }

        public static bool READ(extra referencia, out extra extra)
        {
            return PersistenciaExtras.READ(referencia, out extra);
        }

        public static bool EXISTS(extra referencia)
        {
            return PersistenciaExtras.EXISTS(referencia);
        }

        public static List<extra> SELECT_ALL()
        {
            return PersistenciaExtras.SELECT_ALL();
        }
    }
}
