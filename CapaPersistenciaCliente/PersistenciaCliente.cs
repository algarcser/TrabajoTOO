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
        private bool READ(string clave, out Cliente c)
        {
            ClienteDato auxiliar;
            bool resultado = BDCliente.SELECTCliente(clave, out auxiliar);
            if (resultado)
            {
                c = conversor.Convertir(auxiliar);
            }
            else
            {
                c = null;
            }
            return resultado;
        }


        public static class conversor
        {
            public static Cliente Convertir(ClienteDato clienteDato)
            {
                CategoriaCliente categoria;
                if (clienteDato.getcategoria() == 0) { categoria = CategoriaCliente.A; }
                else if (clienteDato.getcategoria().Equals(1)) { categoria = CategoriaCliente.B; }
                else { categoria = CategoriaCliente.C; }

                return new Cliente(clienteDato.getNombre(), clienteDato.getDNI(), categoria, clienteDato.getTlfno());
   
            }

            public static ClienteDato Convertir(Cliente cliente)
            {
                CategoriaClienteDato categoria;
                if (cliente.getcategoria() == 0) { categoria = CategoriaClienteDato.A; }
                else if (cliente.getcategoria().Equals(1)) { categoria = CategoriaClienteDato.B; }
                else { categoria = CategoriaClienteDato.C; }

                return new ClienteDato(cliente.getNombre(), cliente.getDNI(), categoria, cliente.getTlfno());
            
            }
        }
    }
}
