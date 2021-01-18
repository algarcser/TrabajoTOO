using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaPersistenciaPresupuesto
{
    class BDPresupuesto
    {
        private static TablaPresupuesto presupuestos;

        private BDPresupuesto() { }

        public static TablaPresupuesto Presupuestos
        {
            get
            {
                if (presupuestos == null)
                {
                    presupuestos = new TablaPresupuesto();
                }
                return (presupuestos);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p"></param>
        public static void INSERTPresupuesto(PresupuestoDato p)
        {
            BDPresupuesto.presupuestos.Add(p);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name=""></param>
        public static List<PresupuestoDato> SELECTPresupuesto()
        {
            List<PresupuestoDato> lista = new List<PresupuestoDato>();
            return (lista);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p"></param>
        public static PresupuestoDato SELECTPresupuesto(PresupuestoDato p)
        {
            return (p);
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
            BDPresupuesto.presupuestos.Remove(p);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p"></param>
        public static void EXISTSPresupuesto(PresupuestoDato p)
        {

        }
    }
}
