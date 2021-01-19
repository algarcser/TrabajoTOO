using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaModeloVehiculo
{
    public class listaExtras
    {
        private static List<extra> extras;

        private listaExtras() { }

        public static List<extra> Extras
        {
            get
            {
                if( extras == null)
                {
                    extras = new List<extra>();
                }
                return extras;
            }
        }

        public static void Add(extra extra)
        {
            extras.Add(extra);
        }
    }
}
