using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flujo_Contable.Otros
{
    public partial class frm_Mensaje : Form
    {
        Boolean Flag;
        public frm_Mensaje()
        {
            InitializeComponent();
    
        }

        private void frm_Mensaje_Load(object sender, EventArgs e)
        {
            Flag = true;
            this.Opacity = 0.1;
            tmr_Tiempo.Start();

        }

        private void tmr_Tiempo_Tick(object sender, EventArgs e)
        {
            if (Flag)
            {

                if (this.Opacity == 1.0)
                {
                    tmr_Tiempo.Stop();
                    Flag = false;
                    tmr_Tiempo2.Start();
                }
                else if (this.Opacity <= 1.0)
                {
                    this.Opacity += 0.025;

                }
            }
            else
            {
                if (this.Opacity == 0.0)
                {
                    tmr_Tiempo.Stop();
                    tmr_Tiempo2.Stop();
                    lbl_Mensaje.Text = string.Empty;
                    this.Close();
                }
                else if (this.Opacity >= 0.0)
                {
                    this.Opacity -= 0.025;
                    
                }
            }
        }

        private void tmr_Tiempo2_Tick(object sender, EventArgs e)
        {
            tmr_Tiempo.Start();
        }
    }
}
