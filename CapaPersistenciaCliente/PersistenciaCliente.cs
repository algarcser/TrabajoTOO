using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaPersistenciaCliente
{
    class PersistenciaCliente
    {
        public static String conex;
        public static void CREATE_CLIENTE (ClienteDato c)
        {
            BDCliente.INSERTCliente(c);
        }

        public static bool EXISTE (ClienteDato c)
        {
            bool existe = false;

            foreach(ClienteDato cliente in BDCliente.Clientes)
            {
                if (cliente.Equals(c))
                {
                    existe = true;
                }
            }
            return existe;
        }
    }
}
