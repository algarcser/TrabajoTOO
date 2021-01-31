using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CapaPersistenciaCliente
{
    // Esta es la Base de Datos (BD) del cliente
    internal class BDCliente
    {
        private static TablaClientes clientes;

        /// <summary>
        /// Constructor vacio de la BD
        /// </summary>
        /// 
        private BDCliente() { }

        /// <summary>
        /// Devuelve una keyedCollection sobre los clientes 
        /// </summary>
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
        /// PRE: No introducir un cliente ya existente
        ///  Dado un cliente, lo introduce en la BD
        /// </summary>
        /// <param name="c"></param>
        internal static void INSERTCliente(ClienteDato c)
        {
            BDCliente.Clientes.Add(c);
            Console.WriteLine("La BDCliente ha metido un cliente con el dni " + c.getDNI);
        }

        /// <summary>
        /// Dado un cliente, lo coge de la BD por su clave, en el caso de que exista, y lo devuelve 
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
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
        /// Dado un cliente, lo actualiza en la BD con sus nuevos datos
        /// </summary>
        /// <param name="c"></param>
        internal static void UPDATECliente(ClienteDato c)
        {
            DELETECliente(c);
            INSERTCliente(c);

        }

        /// <summary>
        /// PRE: Introducir un cliente que exista
        /// Elimina un cliente de la BD
        /// </summary>
        /// <param name="c"></param>
        internal static void DELETECliente(ClienteDato c)
        {
            BDCliente.clientes.Remove(c);
        }

        /// <summary>
        /// Comprueba si existe un cliente dado en la BD
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        internal static bool EXISTS(ClienteDato c)
        {
            Console.WriteLine("llega aqui");
            return BDCliente.Clientes.Contains(c.getDNI);  
        }

        /// <summary>
        /// Devuelve una lista con todos los clientes que hay en la BD
        /// </summary>
        /// <returns></returns>
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
