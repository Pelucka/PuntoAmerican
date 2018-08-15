using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flujo_Contable
{
    public partial class frm_Caja : Form
    {
        public frm_Caja()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*Cambio de formulario y paso de Informacion*/
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                frm_IngresoCaja ventana = new frm_IngresoCaja();
                ventana.lbl_Usuario.Text = lbl_Usuario.Text;
                ventana.lbl_Ubicacion.Text = lbl_Ubicacion.Text;
                ventana.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /*Cambio de formulario y paso de Informacion*/
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                frm_ListaApartado ventana = new frm_ListaApartado();
                ventana.lbl_Ubicacion.Text = lbl_Ubicacion.Text;
                ventana.lbl_Usuario.Text = lbl_Usuario.Text;
                ventana.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    
    }
}
