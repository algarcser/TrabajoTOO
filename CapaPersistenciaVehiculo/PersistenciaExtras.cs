using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicaModeloVehiculo;

namespace CapaPersistenciaVehiculo
{
    public static class PersistenciaExtras
    {
        public static bool INSERT(extra extra)
        {
            if (!BDExtras.Exists(conversor.Convertir(extra)))
            {
                BDExtras.INSERT(conversor.Convertir(extra));
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void DELETE(extra extra)
        {
            BDExtras.DELETE(conversor.Convertir(extra));
        }


        public static void UPDATE(extra extra)
        {
            BDExtras.DELETE(conversor.Convertir(extra));
            BDExtras.INSERT(conversor.Convertir(extra));
        }

        public static bool READ(extra referencia, out extra extra)
        {
            extraDato extraDato;
            bool resultado = BDExtras.SELECT(conversor.Convertir(referencia), out extraDato);
            if (resultado)
            {
                extra = conversor.Convertir(extraDato);
            }
            else
            {
                extra = null;
            }
            return resultado;
        }


        public static bool EXISTS(extra extra)
        {
            return BDExtras.Exists(conversor.Convertir(extra));
        }

        public static List<extra> SELECT_ALL()
        {
            List<extra> extras = new List<extra>();
            foreach (extraDato extraDato in BDExtras.SELECT_ALL())
            {
                extra auxiliar = conversor.Convertir(extraDato);
                extras.Add(auxiliar);
            }
            return extras;
        }
    }
}
