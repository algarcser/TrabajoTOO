using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicaModeloCliente;

namespace CapaPersistenciaCliente
{
    public class PersistenciaCliente
    {
        public static String conex;

        /// <summary>
        /// Dado un cliente llama al metodo de insertar de la BD
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool CREATE(Cliente c)
        {
            if (!BDCliente.EXISTS(conversor.Convertir(c)))
            {
                BDCliente.INSERTCliente(conversor.Convertir(c));
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Dado un cliente llama al metodo de eliminar de la BD
        /// </summary>
        /// <param name="c"></param>
        public static void DELETE(Cliente c)
        {
            BDCliente.DELETECliente(conversor.Convertir(c));
        }

        /// <summary>
        /// Dado un cliente llama al metodo de actualizar de la BD
        /// </summary>
        /// <param name="c"></param>
        public static void UPDATE(Cliente c)
        {
            BDCliente.UPDATECliente(conversor.Convertir(c));
        }

        /// <summary>
        /// Dado un cliente, lo convierte a clienteDato para poder acceder a la BD y llamar al metodo de seleccionar, despues vulve a convertir 
        /// el resultado de vuelta a cliente para devolverlo
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static Cliente READ(Cliente c)
        {
            ClienteDato aux = BDCliente.SELECTCliente(conversor.Convertir(c));
            return c = conversor.Convertir(aux);
        }

        /// <summary>
        /// Dado un cliente llama al metodo existe de la BD
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool EXISTE(Cliente c)
        {
            return BDCliente.EXISTS(conversor.Convertir(c));
        }

        /// <summary>
        /// Dado un cliente llama al metodo de selceccionar todos los clientes de la BD para hacerse una lista nueva y devolverla
        /// </summary>
        /// <returns></returns>
        public static List<Cliente> SELECT_ALL()
        {
            List<Cliente> cliente = new List<Cliente>();
            foreach (ClienteDato clienteDato in BDCliente.SELECT_ALL())
            {
                Cliente auxiliar = conversor.Convertir(clienteDato);
                cliente.Add(auxiliar);
            }
            return cliente;
        }

        /// <summary>
        /// Conversor que convierte un cliente a clienteDato y viceversa, técnicamente estos dos son lo mismo,
        /// pero el segundo se usa para tener acceso a la BD y el otro para usarlo en las capas superiores
        /// </summary>
        public static class conversor
        {
            public static Cliente Convertir(ClienteDato clienteDato)
            {
                return new Cliente(clienteDato.getNombre, clienteDato.getApellidos, clienteDato.getDNI, (CategoriaCliente)clienteDato.getcategoria, clienteDato.getTlfno);
            }

            public static ClienteDato Convertir(Cliente cliente)
            {
                return new ClienteDato(cliente.getNombre, cliente.getApellidos, cliente.getDNI, (CategoriaClienteDato)cliente.getcategoria, cliente.getTlfno);
            }
        }
    }
}
