using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaModeloCliente
{
    public class Cliente
    {
        private string nombre;
        //private string apellidos;
        private string DNI;
        private CategoriaCliente categoria;
        private int tlfno;
        //public Cliente(string nombre, string apellidos, string DNI, CategoriaCliente categoria, int tlfno)
        public Cliente(string nombre, string DNI, CategoriaCliente categoria, int tlfno)
        {
            this.nombre = nombre;
            //this.apellidos = apellidos;
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
        /// It returns the name of the client
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
        /// It returns the surnames of the client
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
        /// It returns the DNI of the client
        /// </summary>
        /// <returns></returns>
        public String getDNI
        {
            get{
                return this.DNI;
            }
        }


        /// <summary>
        /// It returns the cathegory of the client
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
        /// It returns the telephone number of the client
        /// </summary>
        /// <returns></returns>
        public int getTlfno
        {
            get
            {
                return this.tlfno;
            }
            
        }

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
