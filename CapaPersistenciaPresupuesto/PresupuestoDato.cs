using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaPersistenciaVehiculo;
using CapaPersistenciaCliente;

namespace CapaPersistenciaPresupuesto
{
    public class PresupuestoDato
    {
        private int ID;
        private DateTime fechaRealizacion;
        private EstadoPresupuestoDato estado;
        private ClienteDato cliente;
        private List<vehiculoDato> vehiculos;


        /// <summary>
        /// It is the constructor of the class.
        /// </summary>
        /// <returns></returns>
        public PresupuestoDato(DateTime fch, EstadoPresupuestoDato e, ClienteDato c, List<vehiculoDato> v)
        {
            this.ID = BDPresupuesto.SELECTALLPresupuesto().Count + 1;
            this.fechaRealizacion = fch;
            this.estado = e;
            this.cliente = c;
            this.vehiculos = v;
        }

        /// <summary>
        /// It returns the ID.
        /// </summary>
        /// <returns></returns>
        public int Identificacion
        {
            get
            {
                return (this.ID);
            }
            set
            {
                this.ID = value;
            }
        }

        /// <summary>
        /// It returns the hour/date the budget was established.
        /// </summary>
        /// <returns></returns>
        public DateTime FechaRealizacion
        {
            get
            {
                return (this.fechaRealizacion);
            }       
        }

        /// <summary>
        /// It returns the state of the budget.
        /// </summary>
        /// <returns></returns>
        public EstadoPresupuestoDato EstadoPresupuesto
        {
            get
            {
                return (this.estado);
            }
        }

        /// <summary>
        /// It returns the client associated with the budget.
        /// </summary>
        /// <returns></returns>
        public ClienteDato Cliente
        {
            get
            {
                return (this.cliente);
            }
        }

        /// <summary>
        /// It returns the list of vehicles associated with the budget.
        /// </summary>
        /// <returns></returns>
        public List<vehiculoDato> ListaVehiculos
        {
            get
            {
                return (this.vehiculos);
            }
        }
    }
}
