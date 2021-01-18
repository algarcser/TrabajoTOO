using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaPersistenciaVehiculo;


namespace prac10
{
    class BDCliente
    {
        private static TablaClientes clientes;
        private static TablaVehiculo vehiculos;

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

        public static ClienteDato SELECTCliente(ClienteDato c)
        {
            return c;
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












    //    public static TablaClientes Vehiculo
    //    {
    //        get
    //        {
    //            if (clientes == null)
    //                clientes = new TablaClientes();
    //            return clientes;
    //        }
    //    }

    //    /// <summary>
    //    /// 
    //    /// </summary>
    //    /// <param name="c"></param>
    //    public static void INSERTVehiculo(ClienteDato c)
    //    {
    //        BDCliente.clientes.Add(c);
    //    }

    //    /// <summary>
    //    /// 
    //    /// </summary>
    //    /// <param name="l"></param>
    //    public static SELECTVehiculoe()
    //    {
    //        //List<ClienteDato> lista = new List<ClienteDato>();
    //        return l;
    //    }

    //    public static ClienteDato SELECTVehiculo(ClienteDato c)
    //    {
    //        return c;
    //    }

    //    /// <summary>
    //    /// 
    //    /// </summary>
    //    /// <param name="c"></param>
    //    public static void UPDATEVehiculo(ClienteDato c)
    //    {
    //        DELETECliente(c);
    //        INSERTCliente(c);

    //    }

    //    /// <summary>
    //    /// 
    //    /// </summary>
    //    /// <param name="c"></param>
    //    public static void DELETEVehiculo(ClienteDato c)
    //    {
    //        BDCliente.clientes.Remove(c);
    //    }
    }
}
