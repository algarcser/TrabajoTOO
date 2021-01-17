using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac10
{
    class LNCliente
    {
        //private Comercial comercial;
        public bool altaCliente(ClienteDato c)
        {
            PersistenciaCliente.CREATE_CLIENTE(c);
            return false;
        }

        public bool existeCliente(ClienteDato c)
        {
            return false;
        }



    }
}
