using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaPersistenciaCliente
{
   
    public class TablaClientes : KeyedCollection<string, ClienteDato>
    {
        /// <summary>
        /// This is the only method that absolutely must be overridden,
        /// because without it the KeyedCollection cannot extract the
        /// keys from the items. The input parameter type is the
        /// second generic type argument, in this case ClienteDato, and
        /// the return value type is the first generic type argument,
        /// in this case String
        /// </summary>
        protected override string GetKeyForItem(ClienteDato item)
        {
            // En este ejemplo, la clave es el dni
            return item.getDNI;
        }

        
    }
}
