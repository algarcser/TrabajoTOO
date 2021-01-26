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
    public static class PersistenciaPresupuesto
    {
        public static bool INSERT(Presupuesto presupuesto)
        {
            if (BDPresupuesto.EXISTPresupuesto(conversor.Convertir(presupuesto)) != true)
            {
                BDPresupuesto.INSERTPresupuesto(conversor.Convertir(presupuesto));
                return (true);
            }
            else
            {
                return (false);
            }
        }

        public static void DELETE(Presupuesto presupuesto)
        {
            BDPresupuesto.DELETEPresupuesto(conversor.Convertir(presupuesto));
        }


        public static void UPDATE(Presupuesto presupuesto)
        {
            BDPresupuesto.DELETEPresupuesto(conversor.Convertir(presupuesto));
            BDPresupuesto.INSERTPresupuesto(conversor.Convertir(presupuesto));
        }

        public static bool READ(Presupuesto referencia, out Presupuesto presupuesto)
        {
            PresupuestoDato auxiliar;
            bool resultado = BDPresupuesto.SELECTPresupuesto(conversor.Convertir(referencia), out auxiliar);
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

        public static bool EXIST(Presupuesto referencia)
        {
            return (BDPresupuesto.EXISTPresupuesto(conversor.Convertir(referencia)));
        }
        
        public static List<Presupuesto> SELECTALL()
        {
            List<PresupuestoDato> listaPD = BDPresupuesto.SELECTALLPresupuesto();
            List<Presupuesto> listaP = new List<Presupuesto>();
            if (listaPD != null)
            {
                foreach (PresupuestoDato p in listaPD)
                {
                    listaP.Add(conversor.Convertir(p));
                }
            }
            
            return (listaP);
        }

        public static class conversor
        {
            public static Presupuesto Convertir(PresupuestoDato presupuestoDato)
            {
                List<vehiculo> vehiculos = new List<vehiculo>();
                if (presupuestoDato != null)
                {
                    foreach (vehiculoDato v in presupuestoDato.ListaVehiculos)
                    {
                        vehiculos.Add(CapaPersistenciaVehiculo.conversor.Convertir(v));
                    }
                    return (new Presupuesto(presupuestoDato.FechaRealizacion, (EstadoPresupuesto)(int)presupuestoDato.EstadoPresupuesto, CapaPersistenciaCliente.PersistenciaCliente.conversor.Convertir(presupuestoDato.Cliente), vehiculos));
                }else
                {
                    return (null);
                }

                
            }

            public static PresupuestoDato Convertir(Presupuesto presupuesto)
            {
                List<vehiculoDato> vehiculos = new List<vehiculoDato>();
                if (presupuesto != null)
                {
                    foreach (vehiculo v in presupuesto.ListaVehiculos)
                    {
                        vehiculos.Add(CapaPersistenciaVehiculo.conversor.Convertir(v));
                    }
                    return (new PresupuestoDato(presupuesto.FechaRealizacion, (EstadoPresupuestoDato)(int)presupuesto.EstadoPresupuesto, CapaPersistenciaCliente.PersistenciaCliente.conversor.Convertir(presupuesto.Cliente), vehiculos));
                }
                else
                {
                    return (null);
                }

                
            }
        }
    }
}
