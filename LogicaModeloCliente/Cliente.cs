using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaModeloCliente
{
    /// <summary>
    /// Esta es la clase cliente de mas alto nivel
    /// </summary>
    public class Cliente
    {
        private string nombre;
        private string apellidos;
        private string DNI;
        private CategoriaCliente categoria;
        private int tlfno;
        private List<float> importes = new List<float>();

        /// <summary>
        /// Constructor del cliente
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellidos"></param>
        /// <param name="DNI"></param>
        /// <param name="categoria"></param>
        /// <param name="tlfno"></param>
        public Cliente(string nombre, string apellidos, string DNI, CategoriaCliente categoria, int tlfno)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.DNI = DNI;
            this.categoria = categoria;
            this.tlfno = tlfno;
        }
        public Cliente(string DNI)
        {
            this.nombre = "";
            this.DNI = DNI;
            this.categoria = CategoriaCliente.A;
            this.tlfno = 0;
        }

        /// <summary>
        /// Devuelve el nombre del cliente
        /// </summary>
        /// <returns></returns>
        public String getNombre
        {
            get
            {
                return this.nombre;
            }
            
        }

        /// <summary>
        /// Devuelve los apellidos del cliente
        /// </summary>
        /// <returns></returns>
        public String getApellidos
        {
            get
            {
                return this.apellidos;
            }
        }

        /// <summary>
        /// Devuelve el DNI del cliente
        /// </summary>
        /// <returns></returns>
        public String getDNI
        {
            get{
                return this.DNI;
            }
        }


        /// <summary>
        /// Devuelve la categoria del cliente
        /// </summary>
        /// <returns></returns>
        public CategoriaCliente getcategoria
        {
            get
            {
                return this.categoria;
            }
            
        }

        /// <summary>
        /// Devuelve el numero de telefono del cliente
        /// </summary>
        /// <returns></returns>
        public int getTlfno
        {
            get
            {
                return this.tlfno;
            }
            
        }

        /// <summary>
        /// el get devuelve una lista de importes del cliente
        /// el set asigna una lista de importes a la actual
        /// </summary>
        public List<float> Importes
        {
            get
            {
                return this.importes;
            }

            set
            {
                this.importes = value;
            }
        }

        /// <summary>
        /// devuelve la suma de todos los importes de la lista de importes del cliente
        /// </summary>
        public string importeTotal
        {
            get
            {
                float result = 0;
                foreach(float elem in Importes)
                {
                    result += elem;
                }
                return result + " €";
            }
        }

        /// <summary>
        /// Calcula si dos clientes son iguales
        /// </summary>
        /// <param name="clienteDato"></param>
        /// <returns></returns>
        public override bool Equals(object cliente)
        {
            if (cliente == null)
            {
                return false;
            }
            else
            {
                if (cliente is Cliente)
                {
                    Cliente auxiliar = (Cliente) cliente;
                    return this.getDNI.Equals(auxiliar.getDNI);
                }
            }
            return false;
        }

    }
}
