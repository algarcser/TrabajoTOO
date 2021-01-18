using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac10
{
   
    class TablaClientes : KeyedCollection<string, ClienteDato>
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
            // In this example, the key is the DNI
            return item.getDNI();
        }

        
    }
}
