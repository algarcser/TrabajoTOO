using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaPersistenciaPresupuesto
{
    /// <summary>
    /// Enumeración de PresupuestoDato que indica el estado de un PresupuestoDato. Añadí creado ya que era necesario un estado 
    /// intermedio debido a las especificaciones de cada tipo de Estado. Esta clase se comunica con la BD.
    /// </summary>
    public enum EstadoPresupuestoDato
    {
        creado, aceptado, desestimado, pendiente
    }
}
