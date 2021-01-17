using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac10
{
    class TablaVehiculo
    {
        class TablaVehiculos : KeyedCollection<string, VehiculoDato>
        {
            /// <summary>
            /// This is the only method that absolutely must be overridden,
            /// because without it the KeyedCollection cannot extract the
            /// keys from the items. The input parameter type is the
            /// second generic type argument, in this case ClienteDato, and
            /// the return value type is the first generic type argument,
            /// in this case String
            /// </summary>
            protected override string GetKeyForItem(VehiculoDato item)
            {
                // In this example, the key is the DNI
                return item.getBastidor();
            }


        }
    }
}
