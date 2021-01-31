using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacionPresupuesto
{
    /// <summary>
    /// Punto de entrada de CapaPresenatcionPresupuesto para pruebas de sus formualrios.
    /// </summary>
    static class Program
    {
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormIntroducirDNIPresupuesto("busqueda", "admin"));
        }
    }
}
