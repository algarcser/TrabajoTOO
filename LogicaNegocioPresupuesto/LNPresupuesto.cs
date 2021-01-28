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
    public class LNPresupuesto
    {
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

        public static bool cambiarEstado(Presupuesto presupuesto, EstadoPresupuesto estado) //usar un presupuesto que ya exista y haya sido sacado de la BD
        {
            Presupuesto auxiliar = new Presupuesto(presupuesto.FechaRealizacion, estado, presupuesto.Cliente, presupuesto.ListaVehiculos);
            auxiliar.Identificacion = presupuesto.Identificacion;
            return (UPDATE(auxiliar));
        }

        public static bool cambiarListaVehiculos(Presupuesto presupuesto, List<vehiculo> listaVehiculos) //usar un presupuesto que ya exista y haya sido sacado de la BD
        {
            Presupuesto auxiliar = new Presupuesto(presupuesto.FechaRealizacion, presupuesto.EstadoPresupuesto, presupuesto.Cliente, listaVehiculos);
            auxiliar.Identificacion = presupuesto.Identificacion;
            return (UPDATE(auxiliar));
        }

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

        public static bool INSERT(Presupuesto presupuesto)
        {
            return (PersistenciaPresupuesto.INSERT(presupuesto));
        }

        public static bool DELETE(Presupuesto presupuesto)
        {
            return (PersistenciaPresupuesto.DELETE(presupuesto));
        }


        public static bool UPDATE(Presupuesto presupuesto)
        {
            return (PersistenciaPresupuesto.UPDATE(presupuesto));
        }

        public static bool SELECT(Presupuesto referencia, out Presupuesto presupuesto)
        {
            return (PersistenciaPresupuesto.SELECT(referencia, out presupuesto));
        }

        public static bool EXIST(Presupuesto referencia)
        {
            return (PersistenciaPresupuesto.EXIST(referencia));
        }
        public static List<Presupuesto> SELECTALL()
        {
            return (PersistenciaPresupuesto.SELECTALL());
        }
    }
}
