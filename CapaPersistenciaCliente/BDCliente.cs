using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CapaPersistenciaCliente
{
    class BDCliente
    {
        private static TablaClientes clientes;

        //private static TablaExtras extras;
        private BDCliente() { }
        public static TablaClientes Clientes
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
        public static void INSERTCliente(ClienteDato c)
        {
            BDCliente.clientes.Add(c);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="l"></param>
        public static List<ClienteDato> SELECTCliente()
        {
            List<ClienteDato> lista = new List<ClienteDato>();
            return lista;
        }

        public static bool SELECTCliente(string clave, out ClienteDato c)
        {
            if (BDCliente.EXISTS(clave))
            {
                c = BDCliente.clientes[clave];
                return true;
            }
            else
            {
                c = null;
                return false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="c"></param>
        public static void UPDATECliente(ClienteDato c)
        {
            DELETECliente(c);
            INSERTCliente(c);

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="c"></param>
        public static void DELETECliente(ClienteDato c)
        {
            BDCliente.clientes.Remove(c);
        }

        public static bool EXISTS(string clave)
        {
            return BDCliente.Clientes.Contains(clave);
            //bool existe = false;

            //foreach (ClienteDato cliente in BDCliente.Clientes)
            //{
            //    if (cliente.Equals(c))
            //    {
            //        existe = true;
            //    }
            //}
            //return existe;
        }

    }
}
