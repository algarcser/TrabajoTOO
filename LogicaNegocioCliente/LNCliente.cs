using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaPersistenciaCliente;
using LogicaModeloCliente;

namespace LogicaNegocioCliente
{
    public class LNCliente
    {
        //private Comercial comercial;

        public static bool altaCliente(Cliente c)
        {
            Console.WriteLine("La LNCliente ha metido un cliente con el dni " + c.getDNI);
            return PersistenciaCliente.CREATE(c);
        }

        public static void bajaCliente(Cliente c)
        {
            PersistenciaCliente.DELETE(c);
        }

        public static void updateCliente(Cliente c)
        {
            PersistenciaCliente.DELETE(c);
            PersistenciaCliente.CREATE(c);
        }

        public static Cliente readCliente(Cliente c)
        {
            return PersistenciaCliente.READ(c);
        }

        public static bool existeCliente(Cliente c)
        {
            return PersistenciaCliente.EXISTE(c);
        }

        public static List<Cliente> SELECT_ALL()
        {
            return PersistenciaCliente.SELECT_ALL();
        }

    }
}
