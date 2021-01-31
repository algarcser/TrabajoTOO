using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaModeloPresupuesto
{
    /// <summary>
    /// Enumeración de Presupuesto que indica el estado de un Presupuesto. Añadí creado ya que era necesario un estado 
    /// intermedio debido a las especificaciones de cada tipo de Estado. Esta clase se comunica con el exterior.
    /// </summary>
    public enum EstadoPresupuesto
    {
        creado, aceptado, desestimado, pendiente
    }
}
