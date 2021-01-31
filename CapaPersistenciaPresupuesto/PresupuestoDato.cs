using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaPersistenciaVehiculo;
using CapaPersistenciaCliente;

namespace CapaPersistenciaPresupuesto
{
    /// <summary>
    /// Clase que trabaja directamente con la BDPresupuesto, es el tipo de dato que se almacena en la BD.
    /// </summary>
    public class PresupuestoDato
    {
        private int ID; //Identificacion del presupuesto.
        private DateTime fechaRealizacion; //Fecha de realización junto con hora de la creación del presupuesto.
        private EstadoPresupuestoDato estado; //Esatdo del presupuesto.
        private ClienteDato cliente; //Cliente asociado al presupuesto.
        private List<vehiculoDato> vehiculos; //Lista de vhículos asociada al presupuesto.
        private string comercial; //comercial asociado al presupuesto, solo puede habe run comercial por aplicación abierta.


        /// <summary>
        /// Constructor de PresupuestoDato.
        /// PRE: Requiere DateTime fch, EstadoPresupuestoDato e, ClienteDato c y List<vehiculoDato> v.
        /// POST:
        /// </summary>
        public PresupuestoDato(DateTime fch, EstadoPresupuestoDato e, ClienteDato c, List<vehiculoDato> v)
        {
            this.ID = BDPresupuesto.SELECTALLPresupuesto().Count + 1;
            this.fechaRealizacion = fch;
            this.estado = e;
            this.cliente = c;
            this.vehiculos = v;
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
        public EstadoPresupuestoDato EstadoPresupuesto
        {
            get
            {
                return (this.estado);
            }
        }

        /// <summary>
        /// Propiedad get de la clase del atributo Cliente cliente.
        /// </summary>
        public ClienteDato Cliente
        {
            get
            {
                return (this.cliente);
            }
        }

        /// <summary>
        /// Propiedad get de la clase del atributo List<vehiculos> vehiculos.
        /// </summary>
        public List<vehiculoDato> ListaVehiculos
        {
            get
            {
                return (this.vehiculos);
            }
        }
    }
}
