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
    public partial class frm_MenuControlCaja : Form
    {
        public frm_MenuControlCaja()
        {
            InitializeComponent();
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_InicioCaja_Click(object sender, EventArgs e)
        {
            try
            {

                frm_InicioCaja ventana = new frm_InicioCaja();
                /*Paso de informacion a controladores de otro formulario*/
                ventana.lbl_Ubicacion.Text =lbl_Ubicacion.Text ;
                ventana.txt_Usuario.Text = lbl_Usuario.Text;
                ventana.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_FinCaja_Click(object sender, EventArgs e)
        {
            try
            {

                frm_FinCaja ventana = new frm_FinCaja();
                /*Paso de informacion a controladores de otro formulario*/
                ventana.txt_Ubicacion.Text = lbl_Ubicacion.Text;
                ventana.txt_Usuario.Text = lbl_Usuario.Text;
                ventana.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_MenuControlCaja_Load(object sender, EventArgs e)
        {
           
        }
    }
}
