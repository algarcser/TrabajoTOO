using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaPersistenciaCliente
{
    /// <summary>
    /// Esta es la clase cliente de bajo nivel
    /// </summary>
    public class ClienteDato
    {
        private string nombre;
        private string DNI;
        private string apellidos;
        private CategoriaClienteDato categoria;
        private int tlfno;

        /// <summary>
        /// Constructor del cliente
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellidos"></param>
        /// <param name="DNI"></param>
        /// <param name="categoria"></param>
        /// <param name="tlfno"></param>
        public ClienteDato(string nombre, string apellidos, string DNI, CategoriaClienteDato categoria, int tlfno)      
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.DNI = DNI;
            this.categoria = categoria;
            this.tlfno = tlfno;
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
            get
            {
                return this.DNI;
            }
            
        }

        /// <summary>
        /// Devuelve la categoria del cliente
        /// </summary>
        /// <returns></returns>
        public CategoriaClienteDato getcategoria
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
        /// Calcula si dos clientes son iguales
        /// </summary>
        /// <param name="clienteDato"></param>
        /// <returns></returns>
        public override bool Equals(object clienteDato)
        {
            if (clienteDato == null)
            {
                return false;
            }
            else
            {
                if (clienteDato is ClienteDato)
                {
                    ClienteDato auxiliar = (ClienteDato) clienteDato;
                    return this.getDNI.Equals(auxiliar.getDNI);
                }
            }
            return false;
        }
    }
}
