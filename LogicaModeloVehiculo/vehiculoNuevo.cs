using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaModeloVehiculo
{
    public class vehiculoNuevo : vehiculo
    {
        private List<extra> extras;


        /// <summary>
        /// construtor de un vehiculoNuevo
        /// </summary>
        /// <param name="nBastidor"> representa el numero de bastidor de un vehiculo</param>
        /// <param name="marca"> representa la marca de coche</param>
        /// <param name="modelo"> representa el modelo del coche</param>
        /// <param name="potencia"> representa la potencia del coche</param>
        /// <param name="precioRecomendado"> representa el precio recomendado de un coche</param>
        /// <param name="iva"> representa el iva de un coche</param>
        public vehiculoNuevo(string nBastidor, string marca, string modelo, float potencia, float precioRecomendado, iva iva) : base(nBastidor,marca,modelo,potencia,precioRecomendado,iva)
        {
            this.extras = new List<extra>();
        }

        /// <summary>
        /// construcor de un vehiculo nuevo, solo con numero de bastidor
        /// </summary>
        /// <param name="nBastidor"> represente el numero de bastidor de un coche</param>
        public vehiculoNuevo(string nBastidor) : base(nBastidor)
        {
            this.extras = new List<extra>();
        }

        /// <summary>
        /// get: devuelve la lista de extras, hay que cambiarlo para que solo devuelvas las descripciones
        /// </summary>
        public List<extra> Extras
        {
            get
            {
                return this.extras;
            }
        }


        /// <summary>
        /// get: redefine precio de un vehiculo, sumandole el precio de los extras asociados
        /// </summary>
        public override float PVP
        {
            get
            {
                float precio = base.PVP;
                foreach (extra extra in this.extras)
                {
                    precio = precio + extra.Precio;
                }
                return precio;
            }
        }


        /// <summary>
        /// funcion que anade un vehiculo, un extra nuevo a su lista de extras
        /// </summary>
        /// <param name="extra"> representa el extra nuevoa a anadir a la lista</param>
        public void AddExtra(extra extra)
        {
            this.extras.Add(extra);
        }
    }
}
