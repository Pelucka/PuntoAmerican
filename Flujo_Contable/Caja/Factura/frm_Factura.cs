using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flujo_Contable.Caja.Factura
{
    public partial class frm_Factura : Form
    {
        public string cod;
        public frm_Factura(string valor)
        {
            InitializeComponent();
            cod = valor;
        }

        private void frm_Factura_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataFactura.DataTable1' Puede moverla o quitarla según sea necesario.
            this.DataFactura.EnforceConstraints = false;
            this.DataTable1TableAdapter.Fill(this.DataFactura.DataTable1, cod);
            
            this.reportViewer1.RefreshReport();
        }
    }
}
