using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaPersistenciaPresupuesto;
using LogicaModeloPresupuesto;

namespace LogicaNegocioPresupuesto
{
    class LNPresupuesto
    {
        public void actualizarEstado(Presupuesto presupuesto, EstadoPresupuesto estado)
        {
            if (((int)estado != 0) && ((int)estado != 2))
            {
                //presupuesto.FechaRealizacion
            }
        }
    }
}
