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
            if (!BDCliente.EXISTS(c.getDNI()))
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
        public static Cliente READ(string DNI)
        {
            ClienteDato auxiliar;
            bool resultado = BDCliente.SELECTCliente(DNI, out auxiliar);
            Cliente c;
            if (resultado)
            {
                
                c = conversor.Convertir(auxiliar);
            }
            else
            {
                c = null;
            }
            return c;
        }

        public static bool EXISTE (string dni)
        {
            return BDCliente.EXISTS(dni);
        }

        public static class conversor
        {
            public static Cliente Convertir(ClienteDato clienteDato)
            {
                return new Cliente(clienteDato.getNombre(), clienteDato.getDNI(), (CategoriaCliente) clienteDato.getcategoria(), clienteDato.getTlfno());
            }

            public static ClienteDato Convertir(Cliente cliente)
            {
                return new ClienteDato(cliente.getNombre(), cliente.getDNI(), (CategoriaClienteDato) cliente.getcategoria(), cliente.getTlfno());           
            }
        }
    }
}
