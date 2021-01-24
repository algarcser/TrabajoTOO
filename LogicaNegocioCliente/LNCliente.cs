using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaPersistenciaCliente;
using LogicaModeloCliente;

namespace LogicaNegocioCliente
{
    public class LNCliente
    {
        //private Comercial comercial;

        public static bool altaCliente(Cliente c)
        {
            PersistenciaCliente.CREATE(c);
            return true;
        }

        public static bool bajaCliente(Cliente c)
        {
            PersistenciaCliente.DELETE(c);
            return true;
        }

        public static Cliente readCliente(Cliente c)
        {
            return PersistenciaCliente.READ(c);
        }

        public static bool existeCliente(Cliente c)
        {
            return PersistenciaCliente.EXISTE(c);
        }

    }
}
