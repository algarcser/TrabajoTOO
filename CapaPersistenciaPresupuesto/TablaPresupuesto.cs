using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaPersistenciaPresupuesto
{
    public class TablaPresupuesto : KeyedCollection<int, PresupuestoDato>
    {
        /// <summary>
        /// This is the only method that absolutely must be overridden,
        /// because without it the KeyedCollection cannot extract the
        /// keys from the items. The input parameter type is the
        /// second generic type argument, in this case PresupuestoDato, and
        /// the return value type is the first generic type argument,
        /// in this case int.
        /// </summary>
        protected override int GetKeyForItem(PresupuestoDato item)
        {
            // In this example, the key is the ID.
            return (item.Identificacion);
        }

    }
}
