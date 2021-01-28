using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicaModeloCliente;
using LogicaModeloVehiculo;

namespace LogicaModeloPresupuesto
{
    public class Presupuesto
    {
        private int ID = 0;
        private DateTime fechaRealizacion;
        private EstadoPresupuesto estado;
        private Cliente cliente;
        private List<vehiculo> vehiculos;

        /// <summary>
        /// It is the constructor of the class.
        /// </summary>
        /// <returns></returns>
        public Presupuesto(DateTime fch, EstadoPresupuesto e, Cliente c, List<vehiculo> v)
        {
            this.fechaRealizacion = fch;
            this.estado = EstadoPresupuesto.creado;
            this.cliente = c;
            this.vehiculos = v;
        }
        public Presupuesto(int n)
        {
            this.ID = n;
        }

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
        public EstadoPresupuesto EstadoPresupuesto
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
        public Cliente Cliente
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
        public List<vehiculo> ListaVehiculos
        {
            get
            {
                return (this.vehiculos);
            }
        }
    }
}
