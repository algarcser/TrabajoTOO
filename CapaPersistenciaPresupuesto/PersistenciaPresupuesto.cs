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
    /// <summary>
    /// Esta clase es igual a la BDPresupuesto pero empleando la conversión de Presupuesto a PresupuestoDato y viceversa,
    /// para comunicarse entre la BD y el exterior, y el exterior con la BD.
    /// </summary>
    public static class PersistenciaPresupuesto
    {
        /// <summary>
        /// Método que inserta un PresupuestoDato en la BD a través de la conversión de Presupuesto presupuesto a
        /// PresupuestoDato, si este no existe en la BD
        /// PRE: Requiere de un Presupuesto presupuesto.
        /// POST: Añade la información de presupuesto a la BD por medio de un PresupuestoDato, si es que no existe la información
        ///       de este en la BD devolviendo bool true, en caso contrario devuelve bool false.
        /// </summary>
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

        /// <summary>
        /// Método que elimina el PresupuestoDato p de la BD por conversión de Presupuesto presupuesto, si este último existe
        /// en la BD.
        /// PRE: Requiere un Presupuesto presupuesto.
        /// POST: Elimina el PresupuestoDato en la BD correspondiente a Presupuetso presupuesto, si existe, devolviendo bool true,
        ///       bool false en caso contrario.
        /// </summary>
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

        /// <summary>
        /// Método que actualiza un PresupuestoDato p en la BD a través de una conversión de Presupuesto presupuesto. 
        /// Mismo comportamiento que UPDATEPresupuesto en BDPresupuesto, soloq eu antes de actualizar comprueba si existe por
        /// método.
        /// PRE: Requiere un Presupuesto presupuesto.
        /// POST: Actualiza Preuspuesto presupuesto en la BD or medio de una conversión si existe, devolviendo bool true; bool
        ///       false en caso contrario.
        /// </summary>
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

        /// <summary>
        /// Método que llama al SELECTPresupuesto de por medio de la conversión de Presupuesto referencia y Presupuesto presupuesto
        /// a PresupuestoDato. Mismo comportamiento que el de la BDPresupuesto añadiendo las conversiones.
        /// es un parámetro de salida.
        /// PRE: Requiere un Presupuesto referencia y un Presupuesto presupuestoDato de salida.
        /// POST: Actualiza Presupuesto presupuestoDato con el de la BD con una conversión si existe Presupuesto referencia en 
        ///       ella y devuelve bool true; o con null si no existe devolviendo bool false.
        /// </summary>
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

        /// <summary>
        /// Método con el mismo comportamiento que EXISTPresupuesto de BDPresupuesto, haciendo una conversión a PresupuestoDato
        /// de Presupuesto referencia.
        /// PRE: Requiere Presupuesto referencia.
        /// POST: Mismo comportamiento de devolución que el método mencionado.
        /// </summary>
        public static bool EXIST(Presupuesto referencia)
        {
            return (BDPresupuesto.EXISTPresupuesto(conversor.Convertir(referencia)));
        }

        /// <summary>
        /// Método con el mismo comportamiento que SELECTALLPresupuesto de BDPresupuesto, devolviendo una List<Presupuesto>
        /// mediante la conversión de cada elemento de List<PresupuestoDato>.
        /// PRE:
        /// POST: Mismo comportamiento de devolución qu el método emncionado pero con List<Presupuesto>.
        /// </summary>
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

        /// <summary>
        /// Esta es la clase conversor que convierte un Presupuesto en PresupuestoDato y viceversa.
        /// **Por la forma en la que esta programado la única forma de eliminar, actualizar y seleccionar un presupuesto de la base de datos, es que este haya salido
        ///   de la base de datos habiendo sido introducido.
        /// </summary>
        public static class conversor
        {

            /// <summary>
            /// Metodo que convierte un PresupuestoDato presupuestoDato en un Presupuesto, pasándole la Identificación de 
            /// PresupuestoDato**.
            /// PRE: Requiere PresupuestoDato presupuestoDato.
            /// POST:
            /// </summary>
            public static Presupuesto Convertir(PresupuestoDato presupuestoDato)
            {
                List<vehiculo> vehiculos = new List<vehiculo>();

                if (presupuestoDato != null)
                {
                    foreach (vehiculoDato v in presupuestoDato.ListaVehiculos)
                    {
                        vehiculos.Add(CapaPersistenciaVehiculo.conversor.Convertir(v));
                    }

                    Presupuesto presupuesto = new Presupuesto(presupuestoDato.FechaRealizacion, (EstadoPresupuesto)(int)presupuestoDato.EstadoPresupuesto, CapaPersistenciaCliente.PersistenciaCliente.conversor.Convertir(presupuestoDato.Cliente), vehiculos);
                    presupuesto.Identificacion = presupuestoDato.Identificacion;
                    presupuesto.Comercial = presupuestoDato.Comercial;

                    return (presupuesto);
                }
                else
                {
                    return (null);
                }
            }

            /// <summary>
            /// Metodo que convierte un Presupuesto presupuesto en un PresupuestoDato, pasándole la Identificacion de Presupuesto
            /// si esta no es 0**.
            /// PRE: Requiere Presupuesto presupuesto.
            /// POST: Devuelve el PresupuestoDato convertido.
            /// </summary>
            public static PresupuestoDato Convertir(Presupuesto presupuesto)
            {
                List<vehiculoDato> vehiculos = new List<vehiculoDato>();
                
                if (presupuesto != null)
                {
                    foreach (vehiculo v in presupuesto.ListaVehiculos)
                    {
                        vehiculos.Add(CapaPersistenciaVehiculo.conversor.Convertir(v));
                    }

                    PresupuestoDato presupuestoDato = new PresupuestoDato(presupuesto.FechaRealizacion, (EstadoPresupuestoDato)(int)presupuesto.EstadoPresupuesto, CapaPersistenciaCliente.PersistenciaCliente.conversor.Convertir(presupuesto.Cliente), vehiculos);
                    presupuestoDato.Comercial = presupuesto.Comercial;

                    if (presupuesto.Identificacion != 0)
                    {
                        presupuestoDato.Identificacion = presupuesto.Identificacion;
                    }

                    return (presupuestoDato);
                }
                else
                {
                    return (null);
                } 
            }
        }
    }
}
