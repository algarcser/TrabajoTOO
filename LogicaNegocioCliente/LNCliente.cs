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

        public static bool readCliente(Cliente c)
        {
            PersistenciaCliente.READ(c.getDNI(), out c) ;
            return true;
        }

        public static bool existeCliente(string dni)
        {
            return PersistenciaCliente.EXISTE(dni);
        }
    
    }
}
