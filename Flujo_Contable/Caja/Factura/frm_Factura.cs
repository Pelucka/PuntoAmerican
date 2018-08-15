using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Factura;

namespace Flujo_Contable.Caja.Factura
{
    public partial class frm_Factura : Form
    {
        public List<factura> datos = new List<factura>();
        public frm_Factura()
        {
            InitializeComponent();
        }

        private void frm_Factura_Load(object sender, EventArgs e)
        {
            LlenarDatos();
            this.rpv_Factura.RefreshReport();
        }
        
        public void LlenarDatos()
        {
            rpv_Factura.LocalReport.DataSources.Clear();
            rpv_Factura.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DatosFactura", datos));
            this.rpv_Factura.RefreshReport();
        }

       
    }
}
