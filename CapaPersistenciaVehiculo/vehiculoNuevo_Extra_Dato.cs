using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaPersistenciaVehiculo
{
    class vehiculoNuevo_Extra_Dato
    {
        private string nBastidor;
        private int id_extra;


        internal vehiculoNuevo_Extra_Dato(string nBastidor, int id_extra)
        {
            this.nBastidor = nBastidor;
            this.id_extra = id_extra;
        }

        internal string NBastidor
        {
            get
            {
                return this.nBastidor;
            }
        }

        internal int Id_extra
        {
            get
            {
                return this.id_extra;
            }
        }

        internal string Key
        {
            get
            {
                return this.nBastidor + "|" + this.id_extra.ToString();
            }
        }
    }
}
