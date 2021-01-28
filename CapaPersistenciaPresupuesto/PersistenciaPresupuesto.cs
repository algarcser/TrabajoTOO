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
            if (BDPresupuesto.EXISTPresupuesto(conversor.Convertir(presupuesto)) == false)
            {
                BDPresupuesto.INSERTPresupuesto(conversor.Convertir(presupuesto));
                return (true);
            }
            else
            {
                return (false);
            }
        }

        //La única forma de eliminar, actualizar y seleccionar un presupuesto de la base de datos, es que este haya salido
        //de la base de datos habiendo sido introducido

        public static bool DELETE(Presupuesto presupuesto)
        {
            if (BDPresupuesto.EXISTPresupuesto(conversor.Convertir(presupuesto)) == true)
            {
                BDPresupuesto.DELETEPresupuesto(conversor.Convertir(presupuesto));
                return (true);
            }
            else
            {
                return (false);
            }
        }


        public static bool UPDATE(Presupuesto presupuesto)
        {
            if (BDPresupuesto.EXISTPresupuesto(conversor.Convertir(presupuesto)) == true)
            {
                BDPresupuesto.UPDATEPresupuesto(conversor.Convertir(presupuesto));
                return (true);
            }
            else 
            {
                return (false);
            }
        }

        public static bool SELECT(Presupuesto referencia, out Presupuesto presupuesto)
        {
            PresupuestoDato auxiliar;
            if (BDPresupuesto.SELECTPresupuesto(conversor.Convertir(referencia), out auxiliar) == true)
            {
                presupuesto = conversor.Convertir(auxiliar);
                return (true);
            }
            else
            {
                presupuesto = null;
                return (false);
            }        
        }

        public static bool EXIST(Presupuesto referencia)
        {
            return (BDPresupuesto.EXISTPresupuesto(conversor.Convertir(referencia)));
        }
        
        public static List<Presupuesto> SELECTALL()
        {
            List<PresupuestoDato> listaPD = BDPresupuesto.SELECTALLPresupuesto();
            List<Presupuesto> listaP = new List<Presupuesto>();
            if (listaPD.Count != 0)
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
               
                foreach (vehiculoDato v in presupuestoDato.ListaVehiculos)
                {
                    vehiculos.Add(CapaPersistenciaVehiculo.conversor.Convertir(v));
                }

                Presupuesto presupuesto = new Presupuesto(presupuestoDato.FechaRealizacion, (EstadoPresupuesto)(int)presupuestoDato.EstadoPresupuesto, CapaPersistenciaCliente.PersistenciaCliente.conversor.Convertir(presupuestoDato.Cliente), vehiculos);
                presupuesto.Identificacion = presupuestoDato.Identificacion;

                return (presupuesto);   
            }

            public static PresupuestoDato Convertir(Presupuesto presupuesto)
            {
                List<vehiculoDato> vehiculos = new List<vehiculoDato>();
                
                foreach (vehiculo v in presupuesto.ListaVehiculos)
                {
                    vehiculos.Add(CapaPersistenciaVehiculo.conversor.Convertir(v));
                }

                PresupuestoDato presupuestoDato = new PresupuestoDato(presupuesto.FechaRealizacion, (EstadoPresupuestoDato)(int)presupuesto.EstadoPresupuesto, CapaPersistenciaCliente.PersistenciaCliente.conversor.Convertir(presupuesto.Cliente), vehiculos);

                if (presupuesto.Identificacion != 0)
                {
                    presupuestoDato.Identificacion = presupuesto.Identificacion;
                }

                return (presupuestoDato);  
            }
        }
    }
}
