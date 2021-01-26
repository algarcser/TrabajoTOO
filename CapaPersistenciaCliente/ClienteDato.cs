using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaPersistenciaCliente
{
    public class ClienteDato
    {
        private string nombre;
        private string DNI;
        //private string apellidos;
        private CategoriaClienteDato categoria;
        private int tlfno;
        //public ClienteDato(string nombre, string apellidos, string DNI, CategoriaClienteDato categoria, int tlfno)
        public ClienteDato(string nombre, string DNI, CategoriaClienteDato categoria, int tlfno)
        {
            this.nombre = nombre;
            //this.apellidos = apellidos;
            this.DNI = DNI;
            this.categoria = categoria;
            this.tlfno = tlfno;
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
        //public String getApellidos
        //{
        //    get
        //    {
        //        return this.apellidos;
        //    }
        //}

        /// <summary>
        /// It returns the DNI of the client
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
        /// It returns the cathegory of the client
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
