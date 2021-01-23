using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaPersistenciaVehiculo
{
    class vehiculoNuevoDato : vehiculoDato
    {
        private List<extraDato> extras;



        private vehiculoNuevoDato(string nBastidor, string marca, string modelo, float potencia, float precioRecomendado, ivaDato iva) : base(nBastidor, marca, modelo, potencia, precioRecomendado, iva)
        {
            this.extras = new List<extraDato>();
        }

        /// <summary>
        /// get: devuelve la lista de extras, hay que cambiarlo para que solo devuelvas las descripciones
        /// </summary>
        public List<extraDato> Extras
        {
            get
            {
                return this.extras;
            }
        }




        public void AddExtra(extraDato extra)
        {
            this.extras.Add(extra);
        }
    }
}
