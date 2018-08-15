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
    public partial class frm_InicioPagina : Form
    {

        public static int count = 10;
        public frm_InicioPagina()
        {
            InitializeComponent();
        }

        private void frm_InicioPagina_Load(object sender, EventArgs e)
        {
            tmr_Timer.Start();

        }

        /*Envento que permite realizar progreso de barra*/
        private void tmr_Timer_Tick(object sender, EventArgs e)
        {
            try
            {

                frm_InicioSesion ventana = new frm_InicioSesion();
                //this.prb_barra.Increment(16);
                this.bn_BarraProgress.Value += 10;
                count -= 1;
                lbl_Count.Text = count.ToString();
                if (count == 0)
                {
                    tmr_Timer.Stop();
                    ventana.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
    }
}
