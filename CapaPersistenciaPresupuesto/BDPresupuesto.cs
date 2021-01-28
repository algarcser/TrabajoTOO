using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaPersistenciaPresupuesto
{
    internal class BDPresupuesto
    {
        private static TablaPresupuesto pres;

        public BDPresupuesto() { }

        public static TablaPresupuesto Presupuestos
        {
            get
            {
                if (BDPresupuesto.pres == null)
                {
                    BDPresupuesto.pres = new TablaPresupuesto();
                }
                return (BDPresupuesto.pres);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p"></param>
        public static void INSERTPresupuesto(PresupuestoDato p)
        {
            BDPresupuesto.Presupuestos.Add(p);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        public static bool SELECTPresupuesto(PresupuestoDato referencia, out PresupuestoDato presupuestoDato)
        {

            if (BDPresupuesto.EXISTPresupuesto(referencia) == true)
            {
                presupuestoDato = BDPresupuesto.Presupuestos[referencia.Identificacion];
                return (true);
            }
            else
            {
                presupuestoDato = null;
                return (false);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p"></param>
        public static void UPDATEPresupuesto(PresupuestoDato p)
        {
            DELETEPresupuesto(p);
            INSERTPresupuesto(p);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p"></param>
        public static void DELETEPresupuesto(PresupuestoDato p)
        {
            BDPresupuesto.Presupuestos.Remove(p.Identificacion);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p"></param>
        public static bool EXISTPresupuesto(PresupuestoDato presupuestoDato)
        {          
            if (presupuestoDato != null)
            {
                return (BDPresupuesto.Presupuestos.Contains(presupuestoDato.Identificacion));
            }
            else
            {
                return (false);
            }           
        }

        public static List<PresupuestoDato> SELECTALLPresupuesto()
        {
            List<PresupuestoDato> lista = new List<PresupuestoDato>();
            if(BDPresupuesto.pres != null)
            {
                foreach (PresupuestoDato pd in BDPresupuesto.pres)
                {
                    lista.Add(pd);
                }
            }  

            return (lista);
        }

    }
}
