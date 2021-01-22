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
        public static void actualizarEstado(Presupuesto presupuesto)
        {
            if ((int)presupuesto.EstadoPresupuesto == 0)
            {
                if(DateTime.Today.Subtract(presupuesto.FechaRealizacion).Days > 15)
                {
                    Presupuesto auxiliar = new Presupuesto(presupuesto.FechaRealizacion, EstadoPresupuesto.desestimado, presupuesto.Cliente, presupuesto.ListaVehiculos);
                    DELETE(presupuesto);
                    INSERT(auxiliar);
                }
            }
        }

        public static void venderCoche(Presupuesto presupuesto)
        {
            Presupuesto auxiliar = new Presupuesto(presupuesto.FechaRealizacion, EstadoPresupuesto.aceptado, presupuesto.Cliente, presupuesto.ListaVehiculos);
            DELETE(presupuesto);
            INSERT(auxiliar);
        }

        public static float calcularPresupuesto(Presupuesto presupuesto)
        {
            double descuento;
            if ((int)presupuesto.Cliente.getcategoria() == 0)
            {
                descuento = 1 - 0.05;
            }else if ((int)presupuesto.Cliente.getcategoria() == 1)
            {
                descuento = 1 - 0.1;
            }else
            {
                descuento = 1 - 0.15;
            }

            float precioCoches = 0;
            foreach (vehiculo v in presupuesto.ListaVehiculos)
            {
                precioCoches = precioCoches + v.PVP;
            }
            
            return ((float)(precioCoches * descuento));
        }

        public static bool INSERT(Presupuesto presupuesto)
        {
            return (PersistenciaPresupuesto.INSERT(presupuesto));
        }

        public static void DELETE(Presupuesto presupuesto)
        {
            PersistenciaPresupuesto.DELETE(presupuesto);
        }


        public static void UPDATE(Presupuesto presupuesto)
        {
            PersistenciaPresupuesto.UPDATE(presupuesto);
        }

        public static bool READ(int id, out Presupuesto presupuesto)
        {
            return (PersistenciaPresupuesto.READ(id, out presupuesto));
        }

        public static bool EXIST(int id)
        {
            return (PersistenciaPresupuesto.EXIST(id));
        }
    }
}
