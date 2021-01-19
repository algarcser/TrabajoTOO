using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaPersistenciaCliente;
using CapaPersistenciaVehiculo;
using LogicaModeloPresupuesto;
using LogicaModeloVehiculo;
using LogicaModeloCliente;

namespace CapaPersistenciaPresupuesto
{
    class PersistenciaPresupuesto
    {
        public bool INSERT(Presupuesto presupuesto)
        {
            if (BDPresupuesto.EXISTPresupuesto(presupuesto.Identificacion) != true)
            {
                BDPresupuesto.INSERTPresupuesto(conversor.Convertir(presupuesto));
                return (true);
            }
            else
            {
                return (false);
            }
        }

        private void DELETE(Presupuesto presupuesto)
        {
            BDPresupuesto.DELETEPresupuesto(conversor.Convertir(presupuesto));
        }


        private void UPDATE(Presupuesto presupuesto)
        {
            BDPresupuesto.DELETEPresupuesto(conversor.Convertir(presupuesto));
            BDPresupuesto.INSERTPresupuesto(conversor.Convertir(presupuesto));
        }

        private bool READ(int id, out Presupuesto presupuesto)
        {
            PresupuestoDato auxiliar;
            bool resultado = BDPresupuesto.SELECTPresupuesto(id, out auxiliar);
            if (resultado)
            {
                presupuesto = conversor.Convertir(auxiliar);
            }
            else
            {
                presupuesto = null;
            }
            return (resultado);
        }

        public static class conversor
        {
            public static Presupuesto Convertir(PresupuestoDato presupuestoDato)
            {
                List<vehiculo> vehiculos = null;
                foreach (vehiculoDato v in presupuestoDato.ListaVehiculos)
                {
                    vehiculos.Add(CapaPersistenciaVehiculo.conversor.Convertir(v));
                }

                return (new Presupuesto(presupuestoDato.FechaRealizacion, (EstadoPresupuesto)(int)presupuestoDato.EstadoPresupuesto, CapaPersistenciaCliente.PersistenciaCliente.conversor.Convertir(presupuestoDato.Cliente), vehiculos));
            }

            public static PresupuestoDato Convertir(Presupuesto presupuesto)
            {
                List<vehiculoDato> vehiculos = null;
                foreach (vehiculo v in presupuesto.ListaVehiculos)
                {
                    vehiculos.Add(CapaPersistenciaVehiculo.conversor.Convertir(v));
                }

                return (new PresupuestoDato(presupuesto.FechaRealizacion, (EstadoPresupuestoDato)(int)presupuesto.EstadoPresupuesto, CapaPersistenciaCliente.PersistenciaCliente.conversor.Convertir(presupuesto.Cliente), vehiculos));
            }
        }
    }
}
