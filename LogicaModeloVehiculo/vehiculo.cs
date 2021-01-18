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
        private float iva;


        public vehiculo(string nBastidor, string marca, string modelo, float potencia, float precioRecomendado, float iva)
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
        public virtual float PrecioRecomendado
        {
            get
            {
                return this.precioRecomendado;
            }
        }

        /// <summary>
        /// get: devuelve el iva
        /// </summary>
        public float Iva
        {
            get
            {
                return this.iva;
            }
        }

    }
}
