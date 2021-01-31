using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaPresentacionGeneral;
using System.Windows.Forms;
using CapaPresentacionVehiculo;

namespace Principal
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login() );
        }
    }
}
