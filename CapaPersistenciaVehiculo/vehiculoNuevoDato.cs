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
        private List<string> Extras
        {
            get
            {
                List<string> auxliar = new List<string>();
                foreach (extraDato extra in this.extras)
                {
                    auxliar.Add(extra.Descripcion);
                }
                return auxliar;
            }
        }




        public void AddExtra(extraDato extra)
        {
            this.extras.Add(extra);
        }
    }
}
