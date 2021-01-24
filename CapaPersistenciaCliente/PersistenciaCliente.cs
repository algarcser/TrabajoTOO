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
        public static void CREATE(Cliente c)
        {
            if (!BDCliente.EXISTS(conversor.Convertir(c)))
            {
                BDCliente.INSERTCliente(conversor.Convertir(c));
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

        public static class conversor
        {
            public static Cliente Convertir(ClienteDato clienteDato)
            {
                return new Cliente(clienteDato.getNombre(), clienteDato.getDNI(), (CategoriaCliente)clienteDato.getcategoria(), clienteDato.getTlfno());
            }

            public static ClienteDato Convertir(Cliente cliente)
            {
                return new ClienteDato(cliente.getNombre(), cliente.getDNI(), (CategoriaClienteDato)cliente.getcategoria(), cliente.getTlfno());
            }
        }
    }
}
