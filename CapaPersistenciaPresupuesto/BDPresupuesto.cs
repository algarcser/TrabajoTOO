﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaPersistenciaPresupuesto
{
    public class BDPresupuesto
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
        public static bool SELECTPresupuesto(int id, out PresupuestoDato presupuestoDato)
        {

            if (BDPresupuesto.EXISTPresupuesto(id) == true)
            {
                presupuestoDato = BDPresupuesto.Presupuestos[id];
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
        public static bool EXISTPresupuesto(int id)
        {
            return (BDPresupuesto.Presupuestos.Contains(id));
        }
    }
}
