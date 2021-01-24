using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaPersistenciaVehiculo
{
    internal class vehiculoNuevoDato : vehiculoDato
    {



        internal vehiculoNuevoDato(string nBastidor, string marca, string modelo, float potencia, float precioRecomendado, ivaDato iva) : base(nBastidor, marca, modelo, potencia, precioRecomendado, iva)
        {
           
        }

        /// <summary>
        /// get: devuelve la lista de extras, hay que cambiarlo para que solo devuelvas las descripciones
        /// </summary>
        internal List<extraDato> Extras
        {
            get
            {
                return BDExtras.Obtain_All_Extras( BDVehiculo_Extras.Obtain_All_Extras(this));
            }
        }




        internal void AddExtra(extraDato extra)
        {
            if (! BDExtras.Exists(extra))
            {
                BDExtras.INSERT(extra);
            }
            vehiculoNuevo_Extra_Dato vehiculo_dato = new vehiculoNuevo_Extra_Dato(this.NBastidor, extra.Id);
            if(!BDVehiculo_Extras.Exists(vehiculo_dato))
            {
                BDVehiculo_Extras.INSERT(vehiculo_dato);
            }
        }
    }
}
