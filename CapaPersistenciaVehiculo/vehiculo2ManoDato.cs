using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaPersistenciaVehiculo
{
    internal class vehiculo2ManoDato : vehiculoDato
    {

        private string matricula;
        private DateTime fechaMatriculacion;

        /// <summary>
        /// constructor para vehiculo de segunda mano
        /// </summary>
        /// <param name="nBastidor"> numero de bastidor para un coche nuevo</param>
        /// <param name="marca"> marca de un vehiculo 2 mano</param>
        /// <param name="modelo"> modelo de un coche</param>
        /// <param name="potencia"> potencia de un coche</param>
        /// <param name="precioRecomendado"> precio recomendao para un vehiculo</param>
        /// <param name="iva"> iva para un coche</param>
        /// <param name="matricula"> matricula de un coche de segunda mano</param>
        /// <param name="fechaMatriculacion"> fecha de matriculacion para un coche</param>
        internal vehiculo2ManoDato(string nBastidor, string marca, string modelo, float potencia, float precioRecomendado, ivaDato iva, string matricula, DateTime fechaMatriculacion) : base(nBastidor, marca, modelo, potencia, precioRecomendado, iva)
        {
            this.matricula = matricula;
            this.fechaMatriculacion = fechaMatriculacion;
        }


        /// <summary>
        /// get: devuelva la matricula
        /// </summary>
        internal string Matricula
        {
            get
            {
                return this.matricula;
            }
        }

        /// <summary>
        /// get: devuelve la fecha de matriculacion
        /// </summary>
        internal DateTime FechaMatriculacion
        {
            get
            {
                return this.fechaMatriculacion;
            }
        }

    }
}

