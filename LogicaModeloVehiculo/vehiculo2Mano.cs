using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaModeloVehiculo
{
    public class vehiculo2Mano : vehiculo
    {

        private string matricula;
        private DateTime fechaMatriculacion;

        /// <summary>
        /// constructor vehiculos nde segunda mano
        /// </summary>
        /// <param name="nBastidor"> representa el numero de bastidor de de un vehiculo</param>
        /// <param name="marca"> representa la marca del coche</param>
        /// <param name="modelo"> representa el modelo de un coche</param>
        /// <param name="potencia"> representa la potencia del coche</param>
        /// <param name="precioRecomendado"> representa el precio recomendado para un coche</param>
        /// <param name="iva"> representa el iva que tiene asignado el coche</param>
        /// <param name="matricula"> representa la matricula de coche</param>
        /// <param name="fechaMatriculacion"> representa la fecha de matriculacion del coche</param>
        public vehiculo2Mano(string nBastidor, string marca, string modelo, float potencia, float precioRecomendado, iva iva, string matricula, DateTime fechaMatriculacion) : base(nBastidor, marca, modelo, potencia, precioRecomendado, iva)
        {
            this.matricula = matricula;
            this.fechaMatriculacion = fechaMatriculacion;
        }


        /// <summary>
        /// get: devuelva la matricula
        /// </summary>
        public string Matricula
        {
            get
            {
                return this.matricula;
            }
        }

        /// <summary>
        /// get: devuelve la fecha de matriculacion
        /// </summary>
        public DateTime FechaMatriculacion
        {
            get
            {
                return this.fechaMatriculacion;
            }
        }

    }
}
