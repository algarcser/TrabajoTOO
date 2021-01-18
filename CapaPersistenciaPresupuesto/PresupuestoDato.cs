using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaPersistenciaVehiculo;
//using CapaPersistenciaCliente;

namespace CapaPersistenciaPresupuesto
{
    class PresupuestoDato
    {
        private DateTime fechaRealizacion;
        private EstadoPresupuesto estado;
        //private ClienteDato cliente;
        private vehiculoDato vehiculo;

        /// <summary>
        /// It returns the hour/date the budget was established.
        /// </summary>
        /// <returns></returns>
        public DateTime getFechaRealizacion()
        {
            return (this.fechaRealizacion);
        }

        /// <summary>
        /// It returns the state of the budget.
        /// </summary>
        /// <returns></returns>
        public EstadoPresupuesto getEstadoPresupuesto()
        {
            return (this.estado);
        }
    }
}
