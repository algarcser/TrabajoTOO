﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaPersistenciaVehiculo
{
    internal class vehiculoNuevoDato : vehiculoDato
    {
        private List<extraDato> extras;



        internal vehiculoNuevoDato(string nBastidor, string marca, string modelo, float potencia, float precioRecomendado, ivaDato iva) : base(nBastidor, marca, modelo, potencia, precioRecomendado, iva)
        {
            this.extras = new List<extraDato>();
        }

        /// <summary>
        /// get: devuelve la lista de extras, hay que cambiarlo para que solo devuelvas las descripciones
        /// </summary>
        internal List<extraDato> Extras
        {
            get
            {
                return this.extras;
            }
        }




        internal void AddExtra(extraDato extra)
        {
            this.extras.Add(extra);
        }
    }
}
