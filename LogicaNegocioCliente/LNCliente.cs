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
        /// <summary>
        /// Llama al metodo de insertar cliente de la capa de persistencia
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool altaCliente(Cliente c)
        {
            return PersistenciaCliente.CREATE(c);
        }

        /// <summary>
        /// Llama al metodo de eliminarr cliente de la capa de persistencia
        /// </summary>
        /// <param name="c"></param>
        public static void bajaCliente(Cliente c)
        {
            PersistenciaCliente.DELETE(c);
        }

        /// <summary>
        /// Llama al metodo de actualizar cliente de la capa de persistencia
        /// </summary>
        /// <param name="c"></param>
        public static void updateCliente(Cliente c)
        {
            PersistenciaCliente.UPDATE(c);
        }

        /// <summary>
        /// Llama al metodo de leer cliente de la capa de persistencia
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static Cliente readCliente(Cliente c)
        {
            return PersistenciaCliente.READ(c);
        }

        /// <summary>
        /// Llama al metodo de existe cliente de la capa de persistencia
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool existeCliente(Cliente c)
        {
            return PersistenciaCliente.EXISTE(c);
        }

        /// <summary>
        /// Llama al metodo de seleccionar todos de la capa de persistencia
        /// </summary>
        /// <returns></returns>
        public static List<Cliente> SELECT_ALL()
        {
            return PersistenciaCliente.SELECT_ALL();
        }

        /// <summary>
        /// suma todos los importes que tiene un cliente, está relacionado con los presupuestos
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static float sumaImportes(Cliente c)
        {
            float importeTotal = 0;

            foreach (float elem in c.Importes)
            {
                importeTotal += elem;
            }
            return importeTotal;
        }

    }
}
