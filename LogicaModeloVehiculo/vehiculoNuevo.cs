using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaModeloVehiculo
{
    class vehiculoNuevo : vehiculo
    {
        private List<extra> extras;


        /// <summary>
        /// get: devuelve la lista de extras, hay que cambiarlo para que solo devuelvas las descripciones
        /// </summary>
        private List<string> Extras
        {
            get
            {
                List<string> auxliar = new List<string>();
                foreach (extra extra in this.extras)
                {
                    auxliar.Add(extra.Descripcion);
                }
                return auxliar;
            }
        }
    }
}
