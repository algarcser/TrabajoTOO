﻿using System;
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
        private CategoriaClienteDato categoria;
        private int tlfno;

        public ClienteDato(string nombre, string DNI, CategoriaClienteDato categoria, int tlfno)
        {
            this.nombre = nombre;
            this.DNI = DNI;
            this.categoria = categoria;
            this.tlfno = tlfno;
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
        public CategoriaClienteDato getcategoria()
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
