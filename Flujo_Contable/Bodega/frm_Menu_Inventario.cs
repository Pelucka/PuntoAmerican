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
    public partial class frm_Menu_Inventario : Form
    {
        public frm_Menu_Inventario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                frm_Bodega ventana = new frm_Bodega();
                /*Paso de informacion a controladores en otro formulario*/
                ventana.txt_Ubicacion.Text = lbl_Ubicacion.Text;
                ventana.txt_Usuario.Text = lbl_Usuario.Text;
                ventana.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                frm_ListaBodega ventana = new frm_ListaBodega();
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
