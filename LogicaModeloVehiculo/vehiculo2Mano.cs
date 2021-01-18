using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaModeloVehiculo
{
    class vehiculo2Mano : vehiculo
    {

        private string matricula;
        private DateTime fechaMatriculacion;
        public vehiculo2Mano(string nBastidor, string marca, string modelo, float potencia, float precioRecomendado, float iva, string matricula, DateTime fechaMatriculacion) : base(nBastidor, marca, modelo, potencia, precioRecomendado, iva)
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
