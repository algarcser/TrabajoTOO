using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaModeloVehiculo
{
    public class vehiculo
    {

        private string nBastidor;
        private string marca;
        private string modelo;
        private float potencia;
        private float precioRecomendado;
        private iva iva;


        public vehiculo(string nBastidor, string marca, string modelo, float potencia, float precioRecomendado, iva iva)
        {
            this.nBastidor = nBastidor;
            this.marca = marca;
            this.modelo = modelo;
            this.potencia = potencia;
            this.precioRecomendado = precioRecomendado;
            this.iva = iva;
        }


        /// <summary>
        /// get, devuelve el numero de bastidor
        /// </summary>
        public string NBastidor
        {
            get
            {
                return this.nBastidor;
            }
        }

        /// <summary>
        /// get: devuelve la marca
        /// </summary>
        public string Marca
        {
            get
            {
                return this.marca;
            }
        }

        /// <summary>
        /// get: delvuelve el modelo
        /// </summary>
        public string Modelo
        {
            get
            {
                return this.modelo;
            }
        }


        /// <summary>
        /// get: devuelve la potencia
        /// </summary>
        public float Potencia
        {
            get
            {
                return this.potencia;
            }
        }


        /// <summary>
        /// get: devuelve el precio recomendado
        /// </summary>
        public virtual float PVP
        {
            get
            {
                float precioFinal = this.precioRecomendado;
                if ( this.Iva == iva.cocheNuevo)
                {
                    precioFinal = (float) (precioFinal*1.1);
                }
                else
                {
                    precioFinal = (float) (precioFinal*1.21);
                }
                return precioFinal;
            }
        }

        /// <summary>
        /// get: devuelve el iva
        /// </summary>
        public iva Iva
        {
            get
            {
                return this.iva;
            }
        }

        public override string ToString()
        {
            return this.nBastidor.ToString() + "" + this.marca.ToString() + "" + this.modelo.ToString() + "" + this.potencia.ToString() + "" + this.precioRecomendado.ToString() + "" + this.iva.ToString();
        }

    }
}
