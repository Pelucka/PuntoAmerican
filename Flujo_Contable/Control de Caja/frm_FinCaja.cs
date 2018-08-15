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
    public partial class frm_FinCaja : Form
    {
        ControldeCaja objcontrol = new ControldeCaja();

        public frm_FinCaja()
        {
            InitializeComponent();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_FinCaja_Load(object sender, EventArgs e)
        {
            try
            {

                txt_Gastos.Text = "0";
                txt_IngresoCajaInicial.Text = "0";
                txt_TotalDia.Text = "0";
                INGRESO_DE_CAJA_INICIAL();
                if (objcontrol.Validacion == "Error")
                {
                    this.Close();
                }
                else
                {
                    INGRESO_DE_VENTAS_TOTALES();
                    GASTOS_TOTALES_DEL_DIA();
                    TOTAL_DEL_DIA();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        /*Metodo para el ingreso de datos de Fin de Caja, por medio de la instancia a el metodo de la clase
         Control de Caja*/
        private void INGRESO_DE_CAJA_INICIAL()
        {
            try
            {

                objcontrol.Ubicacion = txt_Ubicacion.Text;
                objcontrol.SELECT_INICIO_CAJA();
                txt_IngresoCajaInicial.Text = objcontrol.InicioCajaparaFinCaja;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "INGRESO_DE_CAJA_INICIAL()");

            }
        }

        /*Metodo para obtener las ganancias del dia, por medio de la instancia al metodo de la clase
          Control de Caja*/
        private void INGRESO_DE_VENTAS_TOTALES()
        {
            try
            {

                objcontrol.Ubicacion = txt_Ubicacion.Text;
                objcontrol.SELECT_VENTAS_DEL_DIA();
                txt_TotalDia.Text = objcontrol.DineroTotalDia;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "INGRESO_DE_VENTAS_TOTALES()");
            }
        }

        /*Metodo para obtener los gastos realizados durante el dia, por medio de la instancia al metodo de la 
         clase Control de Caja*/
        private void GASTOS_TOTALES_DEL_DIA()
        {
            try
            {

                objcontrol.Ubicacion = txt_Ubicacion.Text;
                objcontrol.SELECT_GASTOS_DEL_DIA();
                txt_Gastos.Text = objcontrol.Gastos;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "GASTOS_TOTALES_DEL_DIA()");
            }
        }

        /*Metodo para obtener el Total del dia, por medio de la instancia al metodo de la clase Control de Caja*/
        private void TOTAL_DEL_DIA()
        {
            try
            {

                objcontrol.TOTAL_DEL_DIA();
                txt_Total.Text = objcontrol.TotaldelDia;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "TOTAL_DEL_DIA()");
            }
        }


        /*Metodo para vizualizar el total del día*/
        private void btn_Total_Click(object sender, EventArgs e)
        {
            try
            {

                txt_TotalenCaja.Text = ((Convert.ToInt32(txt_Monedas5.Text) * 5) + (Convert.ToInt32(txt_Monedas10.Text) * 10) +
                                        (Convert.ToInt32(txt_Monedas25.Text) * 25) + (Convert.ToInt32(txt_Monedas50.Text) * 50) +
                                        (Convert.ToInt32(txt_Monedas100.Text) * 100) + (Convert.ToInt32(txt_Monedas500.Text) * 500) +
                                        (Convert.ToInt32(txt_Billetes1000.Text) * 1000) + (Convert.ToInt32(txt_Billetes2000.Text) * 2000) +
                                        (Convert.ToInt32(txt_Billetes5000.Text) * 5000) + (Convert.ToInt32(txt_Billetes10000.Text) * 10000) +
                                        (Convert.ToInt32(txt_Billetes20000.Text) * 20000) + (Convert.ToInt32(txt_Billetes50000.Text) * 50000)).ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "btn_Total_Click");

            }
        }

        /*Metodo para actualizar el fin de caja dentro de la tabla control, por medio de la instancia del metodo
         de la clase Control de Caja*/
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
                objcontrol.Ubicacion = txt_Ubicacion.Text;
                objcontrol.Usuario = txt_Usuario.Text;
                objcontrol.FinCaja = txt_TotalenCaja.Text;
                objcontrol.Total = (Convert.ToDecimal(txt_TotalenCaja.Text) - Convert.ToDecimal(txt_Total.Text)).ToString();
                objcontrol.UPDATE_FIN_CAJA();
                if (objcontrol.Validacion == "Actualizado")
                {
                    frm_Mensaje objmensaje = new frm_Mensaje();
                    objmensaje.lbl_Mensaje.Text = "Caja Finalizada";
                    objmensaje.pic_Check.Visible = true;
                    objmensaje.Show();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "btn_Aceptar_Click");

            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

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
    }
}
