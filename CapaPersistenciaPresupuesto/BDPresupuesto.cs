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
            BDPresupuesto.Presupuestos.Remove(p);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p"></param>
        public static bool EXISTPresupuesto(PresupuestoDato presupuestoDato)
        {
            return (BDPresupuesto.Presupuestos.Contains(presupuestoDato.Identificacion));
        }

        public static List<PresupuestoDato> SELECTALLPresupuesto()
        {
            /*
            List<ICloneable> oldList = new List<ICloneable>();
            List<ICloneable> newList = new List<ICloneable>(oldList.Count);

            oldList.ForEach((item) =>
            {
                newList.Add((ICloneable)item.Clone());
            });
            */

            List<PresupuestoDato> lista = new List<PresupuestoDato>();
            List<PresupuestoDato> nuevalista = new List<PresupuestoDato>(lista.Count);
            lista = BDPresupuesto.pres.ToList();

            return (lista);
        }

    }
}
