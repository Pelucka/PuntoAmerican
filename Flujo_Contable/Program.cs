using Flujo_Contable.Ajustes;
using Flujo_Contable.Bodega;
using Flujo_Contable.Caja.Factura;
using Flujo_Contable.Clientes;
using Flujo_Contable.Ingresos;
using Flujo_Contable.Otros;
using System;
using System.Windows.Forms;

namespace Flujo_Contable
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new frm_InicioPagina());


        }
    }
}
