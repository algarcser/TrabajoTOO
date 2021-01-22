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
        
        public bool altaCliente(Cliente c)
        {
            PersistenciaCliente.CREATE(c);
            return true;
        }

        public bool bajaCliente(Cliente c)
        {
            PersistenciaCliente.DELETE(c);
            return true;
        }

        public bool readCliente(Cliente c)
        {
            PersistenciaCliente.READ(c.getDNI(), out c) ;
            return true;
        }

        public bool existeCliente(Cliente c)
        {
            return PersistenciaCliente.EXISTE(c);
        }
    
    }
}
