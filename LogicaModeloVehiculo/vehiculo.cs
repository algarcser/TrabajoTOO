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

        public vehiculo(string nBastidor)
        {
            this.nBastidor = nBastidor;
            this.marca = "";
            this.modelo = "";
            this.potencia = 0;
            this.precioRecomendado = 0;
            this.iva = iva.cocheNuevo;
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
                return (float)(this.PrecioRecomendado * (1 + (int)this.Iva) / 100); ;
            }
        }


        public float PrecioRecomendado
        {
            get
            {
                return this.precioRecomendado;
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

        public string Tipo
        {
            get
            {
                if(this is vehiculoNuevo)
                {
                    return "vehiculo nuevo";
                }else if ( this is vehiculo2Mano)
                {
                    return "vehiculo 2 mano";
                }
                return "not found";
            }
        }

        public override string ToString()
        {
            return this.nBastidor.ToString() + "" + this.marca.ToString() + "" + this.modelo.ToString() + "" + this.potencia.ToString() + "" + this.precioRecomendado.ToString() + "" + this.iva.ToString();
        }

        public override bool Equals(object vehiculo)
        {
            if ( vehiculo == null) {
                return false;
            }
            else
            {
                if(vehiculo is vehiculo) {
                    vehiculo auxiliar = (vehiculo)vehiculo;
                    return this.NBastidor.Equals(auxiliar.NBastidor);
                }
            }
            return false;
        }

    }
}
