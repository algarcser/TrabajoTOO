using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaPersistenciaPresupuesto;
using LogicaModeloCliente;
using LogicaModeloPresupuesto;
using LogicaModeloVehiculo;

namespace LogicaNegocioPresupuesto
{
    /// <summary>
    /// Clase donde se encuantran los métodos para realizar operaciones con un Presupuesto.
    /// </summary>
    public class LNPresupuesto
    {
        /// <summary>
        /// Método que actualiza un Presupuesto cambiando su esatdo de creado a desestimado si han pasado más de 15 días desde su
        /// fecha de realización.
        /// PRE: Requiere Presupuesto presupuesto.
        /// POST: Devuelve true si el pressupuesto ha sido actualizado en la BD o bool false en caso contrario.
        /// </summary>
        public static bool actualizarEstado(Presupuesto presupuesto) //usar un int para saber cuantos se actualizan
        {
            if ((int)presupuesto.EstadoPresupuesto == 0)
            {
                if(DateTime.Today.Subtract(presupuesto.FechaRealizacion).Days > 15)
                {
                    Presupuesto auxiliar = new Presupuesto(presupuesto.FechaRealizacion, EstadoPresupuesto.desestimado, presupuesto.Cliente, presupuesto.ListaVehiculos);
                    auxiliar.Identificacion = presupuesto.Identificacion;
                    UPDATE(auxiliar);
                    return (true);
                }
            }
            return (false);
        }

        /// <summary>
        /// Método que cambia el estado de un presupuesto para luego actualizar este en la BD con el nuevo esatdo.
        /// PRE: Requiere Presupuesto presupuesto y EstadoPresupuesto estado.
        /// POST: Devuelve bool true, si ha actualizado presupuesto en la BD con el estado nuevo, y bool false en caso contrario.
        /// </summary>
        public static bool cambiarEstado(Presupuesto presupuesto, EstadoPresupuesto estado) //usar un presupuesto que ya exista y haya sido sacado de la BD
        {
            Presupuesto auxiliar = new Presupuesto(presupuesto.FechaRealizacion, estado, presupuesto.Cliente, presupuesto.ListaVehiculos);
            auxiliar.Identificacion = presupuesto.Identificacion;
            return (UPDATE(auxiliar));
        }

        /// <summary>
        /// Método que cambia la lista de vehículos de un presupuesto para luego actualiziar este en la BD con la nueva lista.
        /// PRE: Requiere Presupuesto presupuesto y List<vehiculo> listaVehiculos.
        /// POST: Devuelve bool true, si ha actualizado presupuesto en la BD con la listaVehiculos nueva, y bool false en caso contrario.
        /// </summary>
        public static bool cambiarListaVehiculos(Presupuesto presupuesto, List<vehiculo> listaVehiculos) //usar un presupuesto que ya exista y haya sido sacado de la BD
        {
            Presupuesto auxiliar = new Presupuesto(presupuesto.FechaRealizacion, presupuesto.EstadoPresupuesto, presupuesto.Cliente, listaVehiculos);
            auxiliar.Identificacion = presupuesto.Identificacion;
            return (UPDATE(auxiliar));
        }

        /// <summary>
        /// Método que calcula el precio (float) de un presupuesto por medio de sus descuentos y PVP de vehículos asociados.
        /// PRE: Requiere Presupuesto presupuesto.
        /// POST: Devuelve float, sinedo este el Importe total del presupuesto.
        /// </summary>
        public static float calcularPresupuesto(Presupuesto presupuesto)
        {
            double descuento = 1;
            if ((int)presupuesto.Cliente.getcategoria == 0)
            {
                descuento = 1 - 0.05;
            }else if ((int)presupuesto.Cliente.getcategoria == 1)
            {
                descuento = 1 - 0.1;
            }else if ((int)presupuesto.Cliente.getcategoria == 2)
            {
                descuento = 1 - 0.15;
            }

            float precioCoches = 0;
            foreach (vehiculo v in presupuesto.ListaVehiculos)
            {
                precioCoches = precioCoches + v.PVP;
            }
            float des = (float)descuento;
            float precioFinal = precioCoches * des;

            return (precioFinal);
        }

        /// <summary>
        /// Mismo comportamiento que el método INSERT de Persistencia Presupuesto, ya que lo llama.
        /// PRE: Requiere Presupuesto presupuesto.
        /// POST: Mismo comportamiento que el método INSERT de Persistencia Presupuesto, ya que lo llama.
        /// </summary>
        public static bool INSERT(Presupuesto presupuesto)
        {
            return (PersistenciaPresupuesto.INSERT(presupuesto));
        }

        /// <summary>
        /// Mismo comportamiento que el método DELETE de Persistencia Presupuesto, ya que lo llama.
        /// PRE: Requiere Presupuesto presupuesto.
        /// POST: Mismo comportamiento que el método DELETE de Persistencia Presupuesto, ya que lo llama.
        /// </summary>
        public static bool DELETE(Presupuesto presupuesto)
        {
            return (PersistenciaPresupuesto.DELETE(presupuesto));
        }

        /// <summary>
        /// Mismo comportamiento que el método UPDATE de Persistencia Presupuesto, ya que lo llama.
        /// PRE: Requiere Presupuesto presupuesto.
        /// POST: Mismo comportamiento que el método UPDATE de Persistencia Presupuesto, ya que lo llama.
        /// </summary>
        public static bool UPDATE(Presupuesto presupuesto)
        {
            return (PersistenciaPresupuesto.UPDATE(presupuesto));
        }

        /// <summary>
        /// Mismo comportamiento que el método SELECT de Persistencia Presupuesto, ya que lo llama.
        /// PRE: Requiere Presupuesto referencia y Presupuesto presupuesto de salida.
        /// POST: Mismo comportamiento que el método SELECT de Persistencia Presupuesto, ya que lo llama.
        /// </summary>
        public static bool SELECT(Presupuesto referencia, out Presupuesto presupuesto)
        {
            return (PersistenciaPresupuesto.SELECT(referencia, out presupuesto));
        }

        /// <summary>
        /// Mismo comportamiento que el método EXIST de Persistencia Presupuesto, ya que lo llama.
        /// PRE: Requiere Presupuesto referencia.
        /// POST: Mismo comportamiento que el método EXIST de Persistencia Presupuesto, ya que lo llama.
        /// </summary>
        public static bool EXIST(Presupuesto referencia)
        {
            return (PersistenciaPresupuesto.EXIST(referencia));
        }

        /// <summary>
        /// Mismo comportamiento que el método SELECTALL de Persistencia Presupuesto, ya que lo llama.
        /// PRE:
        /// POST: Mismo comportamiento que el método SELECTALL de Persistencia Presupuesto, ya que lo llama.
        /// </summary>
        public static List<Presupuesto> SELECTALL()
        {
            return (PersistenciaPresupuesto.SELECTALL());
        }
    }
}
