using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicaModeloCliente;
using LogicaModeloVehiculo;

namespace LogicaModeloPresupuesto
{
    /// <summary>
    /// Clase que trabaja con el exterior.
    /// </summary>
    public class Presupuesto
    {
        private int ID = 0; //Identificación del presupuesto, es 0 si no viene de la BD, por lo atnto no válido, ya que en la BD todas las Identificaciones son > 1.
        private DateTime fechaRealizacion; //Fecha de realización junto con hora de la creación del presupuesto.
        private EstadoPresupuesto estado; //Esatdo del presupuesto.
        private Cliente cliente; //Cliente asociado al presupuesto.
        private List<vehiculo> vehiculos; //Lista de vhículos asociada al presupuesto.
        private string comercial; //comercial asociado al presupuesto, solo puede habe run comercial por aplicación abierta.

        /// <summary>
        /// Constructor de Presupuesto.
        /// PRE: Requiere DateTime fch, EstadoPresupuesto e, Cliente c y List<vehiculo> v.
        /// POST:
        /// </summary>
        public Presupuesto(DateTime fch, EstadoPresupuesto e, Cliente c, List<vehiculo> v)
        {
            this.fechaRealizacion = fch;
            this.estado = e;
            this.cliente = c;
            this.vehiculos = v;
        }

        /// <summary>
        /// Constructor de Presupuesto por medio de ID.
        /// PRE: Requiere int n;
        /// POST:
        /// </summary>
        public Presupuesto(int n)
        {
            this.ID = n;
        }

        /// <summary>
        /// Propiedad get/set de la clase del atributo int ID.
        /// </summary>
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
        /// Propiedad get/set de la clase del atributo string comercial.
        /// </summary>
        public string Comercial
        {
            get
            {
                return (this.comercial);
            }
            set
            {
                this.comercial = value;
            }
        }

        /// <summary>
        /// Propiedad get de la clase del atributo DateTime fechaRealizacion.
        /// </summary>
        public DateTime FechaRealizacion
        {
            get
            {
                return (this.fechaRealizacion);
            }
        }

        /// <summary>
        /// Propiedad get de la clase del atributo EstadoPresupuestoDato estado.
        /// </summary>
        public EstadoPresupuesto EstadoPresupuesto
        {
            get
            {
                return (this.estado);
            }
        }

        /// <summary>
        /// Propiedad get de la clase del atributo Cliente cliente.
        /// </summary>
        public Cliente Cliente
        {
            get
            {
                return (this.cliente);
            }
        }

        /// <summary>
        /// Propiedad get de la clase del atributo List<vehiculos> vehiculos.
        /// </summary>
        public List<vehiculo> ListaVehiculos
        {
            get
            {
                return (this.vehiculos);
            }
        }

        /// <summary>
        /// Propiedad get de la clase que devuleve el número de vehículos asociados a un Presupuesto.
        /// </summary>
        public int NumeroVehiculosPresupuesto
        {
            get
            {
                return (this.ListaVehiculos.Count);
            }
        }

        /// <summary>
        /// Propiedad get de la clase que devuleve el DNI del cliente asociado a un Presupuesto.
        /// </summary>
        public string DNIClientePresupuesto
        {
            get
            {
                return (this.Cliente.getDNI);
            }
        }
    }
}
