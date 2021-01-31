using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaPersistenciaVehiculo
{
    internal abstract class vehiculoDato
    {
        private string nBastidor;
        private string marca;
        private string modelo;
        private float potencia;
        private float precioRecomendado;
        private ivaDato iva;


        /// <summary>
        /// constructor para un vehculo
        /// </summary>
        /// <param name="nBastidor"> numero de bastidor de un vehiculo</param>
        /// <param name="marca">marca de un coche</param>
        /// <param name="modelo"> modelo para un coche</param>
        /// <param name="potencia"> potencia del coche</param>
        /// <param name="precioRecomendado"> precio recomendado del coche</param>
        /// <param name="iva"> iva de un coche</param>
        internal vehiculoDato(string nBastidor, string marca, string modelo, float potencia, float precioRecomendado, ivaDato iva)
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
        internal string NBastidor
        {
            get
            {
                return this.nBastidor;
            }
        }

        /// <summary>
        /// refefinicion de hashcode de un vehiculo
        /// </summary>
        /// <returns>devuelve 0</returns>
        public override int GetHashCode()
        {
            return 0;
        }

        /// <summary>
        /// get: devuelve la marca
        /// </summary>
        internal string Marca
        {
            get
            {
                return this.marca;
            }
        }

        /// <summary>
        /// get: delvuelve el modelo
        /// </summary>
        internal string Modelo
        {
            get
            {
                return this.modelo;
            }
        }


        /// <summary>
        /// get: devuelve la potencia
        /// </summary>
        internal float Potencia
        {
            get
            {
                return this.potencia;
            }
        }


        /// <summary>
        /// get: devuelve el precio recomendado
        /// </summary>
        internal virtual float PrecioRecomendado
        {
            get
            {
                return this.precioRecomendado;
            }
        }

        /// <summary>
        /// get: devuelve el iva
        /// </summary>
        internal ivaDato Iva
        {
            get
            {
                return this.iva;
            }
        }

        /// <summary>
        /// redefinicino del equals de un vehiculo dato, dos vehiculos son iguales sin sus numero de bastidor coinciden
        /// </summary>
        /// <param name="vehiculoDato"> referencia del vehiculo a comparar con</param>
        /// <returns> devuelve true si sus numero de bastidor so iguales, y falso en caso contrario</returns>
        public override bool Equals(object vehiculoDato)
        {
            if (vehiculoDato == null)
            {
                return false;
            }
            else
            {
                if (vehiculoDato is vehiculoDato)
                {
                    vehiculoDato auxiliar = (vehiculoDato)vehiculoDato;
                    return this.NBastidor.Equals(auxiliar.NBastidor);
                }
            }
            return false;
        }
    }
}
