using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaPersistenciaPresupuesto
{
    /// <summary>
    /// Con esta clase creo el almacen de la BD de presupuesto a partir de una KeyedCollection<int, PresupuestoDato>
    /// </summary>

    public class TablaPresupuesto : KeyedCollection<int, PresupuestoDato>
    {
        /// <summary>
        /// Se produce un override en este método, haciendo que la clave de de un Presupuesto en la KeyedCollection
        /// sea la propiedad Identificacion de PresupuestoDato.
        /// PRE: Requiere un PresupuestoDato item.
        /// POST: Devuelve un int que es la propiedad Identificacion de item
        /// </summary>
        protected override int GetKeyForItem(PresupuestoDato item)
        {
            return (item.Identificacion);
        }

    }
}
