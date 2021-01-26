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
        public static bool CREATE(Cliente c)
        {
            if (!BDCliente.EXISTS(conversor.Convertir(c)))
            {
                BDCliente.INSERTCliente(conversor.Convertir(c));
                Console.WriteLine("La PersistenciaCliente ha metido un cliente con el dni " + c.getDNI);
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void DELETE(Cliente c)
        {
            BDCliente.DELETECliente(conversor.Convertir(c));
        }

        public static void UPDATE(Cliente c)
        {
            BDCliente.DELETECliente(conversor.Convertir(c));
            BDCliente.INSERTCliente(conversor.Convertir(c));
        }
        public static Cliente READ(Cliente c)
        {
            ClienteDato aux = BDCliente.SELECTCliente(conversor.Convertir(c));
            return c = conversor.Convertir(aux);
        }

        public static bool EXISTE(Cliente c)
        {
            return BDCliente.EXISTS(conversor.Convertir(c));
        }

        public static List<Cliente> SELECT_ALL()
        {
            List<Cliente> vehiculos = new List<Cliente>();
            foreach (ClienteDato clienteDato in BDCliente.SELECT_ALL())
            {
                Cliente auxiliar = conversor.Convertir(clienteDato);
                vehiculos.Add(auxiliar);
            }
            return vehiculos;
        }

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
