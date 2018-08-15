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

namespace Flujo_Contable
{
    public partial class frm_Errores : Form
    {
        Errores objerrores = new Errores();
        public frm_Errores()
        {
            InitializeComponent();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /*Carga la informacion dentro del datagridview por medio de una instancia a la clase Errores*/
        private void CARGA_ERRORES()
        {
            try
            {

                dgv_Errores.DataSource = objerrores.CARGA_LISTA_ERRORES().Tables[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "CARGA_ERRORES()");
            }
        }

        private void frm_Errores_Load(object sender, EventArgs e)
        {
            CARGA_ERRORES();
        }

        private void btn_Salir_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }

    }
}
