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
        private string DNI;
        private CategoriaCliente categoria;
        private int tlfno;
        public Cliente(string nombre, string DNI, CategoriaCliente categoria, int tlfno)
        {
            this.nombre = nombre;
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
        public String getNombre()
        {
            return this.nombre;
        }

        /// <summary>
        /// It returns the DNI of the client
        /// </summary>
        /// <returns></returns>
        public String getDNI()
        {
            return this.DNI;
        }

        /// <summary>
        /// It returns the cathegory of the client
        /// </summary>
        /// <returns></returns>
        public CategoriaCliente getcategoria()
        {
            return this.categoria;
        }

        /// <summary>
        /// It returns the telephone number of the client
        /// </summary>
        /// <returns></returns>
        public int getTlfno()
        {
            return this.tlfno;
        }
    }
}
