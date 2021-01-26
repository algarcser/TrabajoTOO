using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CapaPersistenciaCliente
{
    internal class BDCliente
    {
        private static TablaClientes clientes;

        //private static TablaExtras extras;
        private BDCliente() { }
        private static TablaClientes Clientes
        {
            get
            {
                if (clientes == null)
                    clientes = new TablaClientes();
                return clientes;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="c"></param>
        internal static void INSERTCliente(ClienteDato c)
        {
            BDCliente.Clientes.Add(c);
            Console.WriteLine("La BDCliente ha metido un cliente con el dni " + c.getDNI);
        }

        internal static ClienteDato SELECTCliente(ClienteDato c)
        {
            if (BDCliente.EXISTS(c))
            {
                return c = BDCliente.Clientes[c.getDNI];
            }
            else
            {
                return c = null;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="c"></param>
        internal static void UPDATECliente(ClienteDato c)
        {
            DELETECliente(c);
            INSERTCliente(c);

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="c"></param>
        internal static void DELETECliente(ClienteDato c)
        {
            BDCliente.clientes.Remove(c);
        }

        internal static bool EXISTS(ClienteDato c)
        {
            Console.WriteLine("llega aqui");
            return BDCliente.Clientes.Contains(c.getDNI);  
        }

        internal static List<ClienteDato> SELECT_ALL()
        {
            List<ClienteDato> lista = new List<ClienteDato>();
            foreach (ClienteDato cliente in BDCliente.Clientes)
            {
                lista.Add(cliente);
            }
            return lista;
        }

    }
}
