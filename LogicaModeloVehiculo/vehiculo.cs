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

        /// <summary>
        /// constructor de un vehiculo
        /// </summary>
        /// <param name="nBastidor">representa el numero de bastidor de un coche</param>
        /// <param name="marca">representa la marca de un coche</param>
        /// <param name="modelo"> representa el modelo de un coche</param>
        /// <param name="potencia"> representa la potencia de ese coche</param>
        /// <param name="precioRecomendado"> representa el precio que se recomienda de partida para ese coche</param>
        /// <param name="iva">representa el iva de un coche</param>
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
        /// construcor de un coche con solo el num de bastidor
        /// </summary>
        /// <param name="nBastidor"> representa el numero de bastidor de un coche</param>
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
                return (float) ( (this.PrecioRecomendado) + (float)(this.PrecioRecomendado * (int)this.Iva)/100 ) ;
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

        /// <summary>
        /// get: devuelve una cadena, si el coche es creado como cocheNuevo, devuelve una cade vehiculo nuevo, en caso contrario, si es de tipo vehiculo2Mano, devuelve vehiculo 2 mano como cadena
        /// </summary>
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


        /// <summary>
        /// funcion que redefine el comportamiento de to string para vehiculos
        /// </summary>
        /// <returns>devuelve una cadena que consiste en el numero de bastidor  mas la marca el modelo la potencia y su precio recomendado </returns>
        public override string ToString()
        {
            return this.nBastidor.ToString() + "" + this.marca.ToString() + "" + this.modelo.ToString() + "" + this.potencia.ToString() + "" + this.precioRecomendado.ToString() + "" + this.iva.ToString();
        }


        /// <summary>
        /// refininicion del metodo equals
        /// </summary>
        /// <param name="vehiculo"> vehiculos con el que estamos comparando</param>
        /// <returns> devuelve true si los numero de bastidores de los vehiculos coinciden, devuelve falso en caso contrario</returns>
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
