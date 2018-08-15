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
using Flujo_Contable.Otros;

namespace Flujo_Contable
{
    public partial class frm_InicioCaja : Form
    {
        ControldeCaja objcontrol = new ControldeCaja();
        usuarios objUsuarios = new usuarios();

        public frm_InicioCaja()
        {
            InitializeComponent();
        }


        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            txt_Monedas5.Text = string.Empty;
        }

        /*Metodo para vizualizar el monto de inicio de Caja*/
        private void btn_Total_Click(object sender, EventArgs e)
        {
            try
            {

                #region Validacion
                if (txt_Monedas5.Text == string.Empty)
                {
                    MessageBox.Show("Favor Ingresar Monedas de 5", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txt_Monedas10.Text == string.Empty)
                {
                    MessageBox.Show("Favor Ingresar Monedas de 10", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txt_Monedas25.Text == string.Empty)
                {
                    MessageBox.Show("Favor Ingresar Monedas de 25", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txt_Monedas50.Text == string.Empty)
                {
                    MessageBox.Show("Favor Ingresar Monedas de 50", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txt_Monedas100.Text == string.Empty)
                {
                    MessageBox.Show("Favor Ingresar Monedas de 100", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txt_Monedas500.Text == string.Empty)
                {
                    MessageBox.Show("Favor Ingresar Monedas de 500", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txt_Billetes1000.Text == string.Empty)
                {
                    MessageBox.Show("Favor Ingresar Billetes de 1000", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txt_Billetes2000.Text == string.Empty)
                {
                    MessageBox.Show("Favor Ingresar Billetes de 2000", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txt_Billetes5000.Text == string.Empty)
                {
                    MessageBox.Show("Favor Ingresar Billetes de 5000", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txt_Billetes10000.Text == string.Empty)
                {
                    MessageBox.Show("Favor Ingresar Billetes de 10000", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txt_Billetes20000.Text == string.Empty)
                {
                    MessageBox.Show("Favor Ingresar Billetes de 20000", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txt_Billetes50000.Text == string.Empty)
                {
                    MessageBox.Show("Favor Ingresar Billetes de 50000", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                #endregion
                else
                {
                    txt_SaldoFinal.Text = ((Convert.ToDecimal(txt_Monedas5.Text) * 5) + (Convert.ToDecimal(txt_Monedas10.Text) * 10) + (Convert.ToDecimal(txt_Monedas25.Text) * 25) + (Convert.ToDecimal(txt_Monedas50.Text) * 50) + (Convert.ToDecimal(txt_Monedas100.Text) * 100) + (Convert.ToDecimal(txt_Monedas500.Text) * 500) +
                                        (Convert.ToDecimal(txt_Billetes1000.Text) * 1000) + (Convert.ToDecimal(txt_Billetes2000.Text) * 2000) + (Convert.ToDecimal(txt_Billetes5000.Text) * 5000) + (Convert.ToDecimal(txt_Billetes10000.Text) * 10000) + (Convert.ToDecimal(txt_Billetes20000.Text) * 20000) + (Convert.ToDecimal(txt_Billetes50000.Text) * 50000)).ToString();
                    btn_Aceptar.Enabled = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "btn_Total_Click");
            }

        }

        /*Metodo para agregar la informacion a la tabla Control, por medio de la instancia del metodo de la clase
         Contol de Caja*/
        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            try
            {

                objcontrol.M5 = Convert.ToInt32(txt_Monedas5.Text);
                objcontrol.M10 = Convert.ToInt32(txt_Monedas10.Text);
                objcontrol.M25 = Convert.ToInt32(txt_Monedas25.Text);
                objcontrol.M50 = Convert.ToInt32(txt_Monedas50.Text);
                objcontrol.M100 = Convert.ToInt32(txt_Monedas100.Text);
                objcontrol.M500 = Convert.ToInt32(txt_Monedas500.Text);
                objcontrol.B1000 = Convert.ToInt32(txt_Billetes1000.Text);
                objcontrol.B2000 = Convert.ToInt32(txt_Billetes2000.Text);
                objcontrol.B5000 = Convert.ToInt32(txt_Billetes5000.Text);
                objcontrol.B10000 = Convert.ToInt32(txt_Billetes10000.Text);
                objcontrol.B20000 = Convert.ToInt32(txt_Billetes20000.Text);
                objcontrol.B50000 = Convert.ToInt32(txt_Billetes50000.Text);
                objcontrol.InicioCaja = Convert.ToInt32(txt_SaldoFinal.Text);
                objcontrol.Ubicacion = cbo_Ubicacion.Text;
                objcontrol.Usuario = txt_Usuario.Text;
                objcontrol.INSERT_INICIO_CAJA();
                if (objcontrol.Validacion == "Insertado")
                {
                    frm_Mensaje objmensaje = new frm_Mensaje();
                    objmensaje.lbl_Mensaje.Text = "Caja Nueva";
                    objmensaje.pic_Check.Visible = true;
                    objmensaje.Show();
                }
                else
                {
                    MessageBox.Show("Se Encontro un Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "btn_Aceptar_Click");

            }

        }

        private void txt_Monedas5_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {

                if (char.IsNumber(e.KeyChar))
                {

                }
                else
                {
                    e.Handled = e.KeyChar != (char)Keys.Back;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txt_Monedas10_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {

                if (char.IsNumber(e.KeyChar))
                {

                }
                else
                {
                    e.Handled = e.KeyChar != (char)Keys.Back;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txt_Monedas25_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {

                if (char.IsNumber(e.KeyChar))
                {

                }
                else
                {
                    e.Handled = e.KeyChar != (char)Keys.Back;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txt_Monedas50_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {

                if (char.IsNumber(e.KeyChar))
                {

                }
                else
                {
                    e.Handled = e.KeyChar != (char)Keys.Back;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txt_Monedas100_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {

                if (char.IsNumber(e.KeyChar))
                {

                }
                else
                {
                    e.Handled = e.KeyChar != (char)Keys.Back;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txt_Monedas500_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {

                if (char.IsNumber(e.KeyChar))
                {

                }
                else
                {
                    e.Handled = e.KeyChar != (char)Keys.Back;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txt_Billetes1000_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {

                if (char.IsNumber(e.KeyChar))
                {

                }
                else
                {
                    e.Handled = e.KeyChar != (char)Keys.Back;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txt_Billetes2000_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {

                if (char.IsNumber(e.KeyChar))
                {

                }
                else
                {
                    e.Handled = e.KeyChar != (char)Keys.Back;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txt_Billetes5000_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {

                if (char.IsNumber(e.KeyChar))
                {

                }
                else
                {
                    e.Handled = e.KeyChar != (char)Keys.Back;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txt_Billetes10000_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {

                if (char.IsNumber(e.KeyChar))
                {

                }
                else
                {
                    e.Handled = e.KeyChar != (char)Keys.Back;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txt_Billetes20000_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {

                if (char.IsNumber(e.KeyChar))
                {

                }
                else
                {
                    e.Handled = e.KeyChar != (char)Keys.Back;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txt_Billetes50000_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {

                if (char.IsNumber(e.KeyChar))
                {

                }
                else
                {
                    e.Handled = e.KeyChar != (char)Keys.Back;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frm_InicioCaja_Load(object sender, EventArgs e)
        {
            this.CARGA_UBICACION();
            cbo_Ubicacion.Text = lbl_Ubicacion.Text;

            if(cbo_Ubicacion.Text == "Universal")
            {
                cbo_Ubicacion.Enabled = true;
            }
            else
            {
                cbo_Ubicacion.Enabled = false;
            }
        }


        private void CARGA_UBICACION()
        {
            try
            {

                DataSet ds;
                ds = objUsuarios.CARGA_UBICACION();
                cbo_Ubicacion.DataSource = ds.Tables[0];
                cbo_Ubicacion.DisplayMember = ds.Tables[0].Columns["Descripcion"].ColumnName.ToString();
                cbo_Ubicacion.ValueMember = ds.Tables[0].Columns["Id_Ubicacion"].ColumnName.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "CARGA_UBICACION()");
            }
        }

    }
}
