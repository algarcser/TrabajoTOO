using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaPersistenciaVehiculo
{
    internal class BDExtras
    {
        private static TablaExtras tablaExtras;

        private BDExtras() { }

        private static TablaExtras TablaExtras
        {
            get
            {
                if(tablaExtras == null)
                {
                    tablaExtras = new TablaExtras();
                }
                return tablaExtras;
            }
        }



        internal static void INSERT(extraDato c)
        {
            BDExtras.TablaExtras.Add(c);
        }



        internal static bool SELECT(extraDato referencia, out extraDato extraDato)
        {

            if (BDExtras.Exists(referencia))
            {
                extraDato = BDExtras.TablaExtras[referencia.Id];
                return true;
            }
            else
            {
                extraDato = null;
                return false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="c"></param>
        internal static void UPDATE(extraDato c)
        {
            DELETE(c);
            INSERT(c);

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="c"></param>
        internal static void DELETE(extraDato c)
        {
            BDExtras.TablaExtras.Remove(c);
        }

        internal static bool Exists(extraDato extraDato)
        {
            return BDExtras.TablaExtras.Contains(extraDato.Id);
        }

        internal static List<extraDato> SELECT_ALL()
        {
            List<extraDato> lista = new List<extraDato>();
            foreach (extraDato extraDato in BDExtras.TablaExtras)
            {
                lista.Add(extraDato);
            }
            return lista;
        }

        internal static List<extraDato> Obtain_All_Extras(List<int> ids)
        {
            List<extraDato> extras = new List<extraDato>();
            foreach (int id in ids)
            {
                extraDato auxiliar;
                if(BDExtras.Exists(new extraDato(id)))
                {
                    BDExtras.SELECT(new extraDato(id), out auxiliar);
                    extras.Add(auxiliar);
                }
            }
            return extras;
        }

        internal static int COUNT()
        {
            return BDExtras.TablaExtras.Count();
        }
    }
}
