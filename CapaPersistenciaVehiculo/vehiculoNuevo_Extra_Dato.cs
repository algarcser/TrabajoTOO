using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaPersistenciaVehiculo
{
    internal class vehiculoNuevo_Extra_Dato
    {
        private string nBastidor;
        private int id_extra;

        /// <summary>
        /// constructor de vehiculo nuevo extra dato
        /// </summary>
        /// <param name="nBastidor"> numero de bastidor del vehiculo asociado</param>
        /// <param name="id_extra"> id del extra asociado</param>
        internal vehiculoNuevo_Extra_Dato(string nBastidor, int id_extra)
        {
            this.nBastidor = nBastidor;
            this.id_extra = id_extra;
        }

        /// <summary>
        /// get: devuelve el numero de bastidor
        /// </summary>
        internal string NBastidor
        {
            get
            {
                return this.nBastidor;
            }
        }

        /// <summary>
        /// get: devuelve la id
        /// </summary>
        internal int Id_extra
        {
            get
            {
                return this.id_extra;
            }
        }

        /// <summary>
        /// get: devuelv eun string que combina el numero de bastidor y la id de un extra
        /// </summary>
        internal string Key
        {
            get
            {
                return this.nBastidor + "|" + this.id_extra.ToString();
            }
        }
    }
}
