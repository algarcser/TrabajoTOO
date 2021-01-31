using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaPersistenciaPresupuesto
{
    /// <summary>
    /// Esta es la clase BD de Presupuesto con su tipo equivalente a Presupuesto, PresupuestoDato.
    /// </summary>
    internal class BDPresupuesto
    {
        private static TablaPresupuesto pres; //Es el almacen de datos ya qcomentado en TablaPresupuesto

        /// <summary>
        /// Este es un constructor vacío.
        /// </summary>
        public BDPresupuesto() { }

        /// <summary>
        /// Propiedad get de BDPresupuesto que devuelve la KeyedCollection<int, PresupeustoDato> ya comentada, si esta es nula
        /// la declara y devuelve una KeyedCollection vacía.
        /// </summary>
        public static TablaPresupuesto Presupuestos
        {
            get
            {
                if (BDPresupuesto.pres == null)
                {
                    BDPresupuesto.pres = new TablaPresupuesto();
                }
                return (BDPresupuesto.pres);
            }
        }

        /// <summary>
        /// Método void que inserta un PresupuestoDato p en TablaPresupuesto pres.
        /// PRE: Requiere de un PresupuestoDato p.
        /// POST: Añade a la p al atributo pres de la clase.
        /// </summary>
        public static void INSERTPresupuesto(PresupuestoDato p)
        {
            BDPresupuesto.Presupuestos.Add(p);
        }

        /// <summary>
        /// Método que comprueba si existe PresupuestoDato referencia por su Identificacion en TablaPresupuesto pres, si existe
        /// obtiene el PresupuestoDato qeu coincida en la BD y lo da a PresupuestoDato presupuestoDato, que se actualizará ya que
        /// es un parámetro de salida.
        /// PRE: Requiere un PresupuestoDato referencia y un PresupuestoDato presupuestoDato de salida.
        /// POST: Actualiza PresupuestoDato presupuestoDato con el de la BD si existe PresupuestoDato referencia en ella y
        /// devuelve bool true; o con null si no existe devolviendo bool false.
        /// </summary>
        public static bool SELECTPresupuesto(PresupuestoDato referencia, out PresupuestoDato presupuestoDato)
        {

            if (BDPresupuesto.EXISTPresupuesto(referencia) == true)
            {
                presupuestoDato = BDPresupuesto.Presupuestos[referencia.Identificacion];
                return (true);
            }
            else
            {
                presupuestoDato = null;
                return (false);
            }
        }

        /// <summary>
        /// Método void que actualiza un PresupuestoDato p en la BD. Lo elimina por referencia con un método, eliminando el viejo, ya
        /// que el nuevo y el viejo tienen la misma. Después lo añade por método.
        /// PRE: Requiere un PresupuestoDato p.
        /// POST: Actualiza p en la BD.
        /// </summary>
        public static void UPDATEPresupuesto(PresupuestoDato p)
        {
            DELETEPresupuesto(p);
            INSERTPresupuesto(p);
        }

        /// <summary>
        /// Método void que elimina el PresupuestoDato p de la BD por medio de su Identificacion.
        /// PRE: Requiere un PresupuestoDato p.
        /// POST: Elimina p de la BD.
        /// </summary>
        public static void DELETEPresupuesto(PresupuestoDato p)
        {
            BDPresupuesto.Presupuestos.Remove(p.Identificacion);
        }

        /// <summary>
        /// Método que comprueba si un PresupuestoDato presupuestoDato no nulo pertenece a la BD.
        /// PRE: Requiere PresupuestoDato presupuestoDato.
        /// POST: Devuelve bool false si presupuestoDato es null o si no encuentra su Identificacion en la BD, y bool true en
        ///       caso contrario.
        /// </summary>
        public static bool EXISTPresupuesto(PresupuestoDato presupuestoDato)
        {          
            if (presupuestoDato != null)
            {
                return (BDPresupuesto.Presupuestos.Contains(presupuestoDato.Identificacion));
            }
            else
            {
                return (false);
            }           
        }

        /// <summary>
        /// Método que devuelve todos los PresupuestoDato contenidos en la BD.
        /// PRE:
        /// POST: Devuleve una List<PresupuestoDato> vacía si la BD es null o con los PresupuestoDato contenidos en la BD.
        /// </summary>
        public static List<PresupuestoDato> SELECTALLPresupuesto()
        {
            List<PresupuestoDato> lista = new List<PresupuestoDato>();
            if(BDPresupuesto.pres != null)
            {
                foreach (PresupuestoDato pd in BDPresupuesto.pres)
                {
                    lista.Add(pd);
                }
            }  

            return (lista);
        }

    }
}
