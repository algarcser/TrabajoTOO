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



        public vehiculoNuevo(string nBastidor, string marca, string modelo, float potencia, float precioRecomendado, iva iva) : base(nBastidor,marca,modelo,potencia,precioRecomendado,iva)
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


        public void AddExtra(extra extra)
        {
            this.extras.Add(extra);
        }
    }
}
