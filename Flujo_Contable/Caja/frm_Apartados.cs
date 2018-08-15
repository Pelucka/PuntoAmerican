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
    public partial class frm_Apartados : Form
    {
        Gastos_e_Ingresos gi = new Gastos_e_Ingresos();
        Apartados ap = new Apartados();
        Otrosn otr = new Otrosn();
        BLL.Caja cj = new BLL.Caja();
        Bitacora objBitacora = new Bitacora();
        public frm_Apartados()
        {
            InitializeComponent();
        }

      
        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            try
            {

                if (rb_Juguete.Checked == true)
                {
                    grb_TipoApartado.Enabled = true;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void rb_Ropa_CheckedChanged(object sender, EventArgs e)
        {
            try
            {

                if (rb_Ropa.Checked == true)
                {
                    grb_TipoApartado.Enabled = true;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        /*Metodo para agregar informacion dentro de la tabla Apartados, por medio de la instancia al metodo de la
         clase Apartados*/
  

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        /*Metodo para limpiar controladores dentro del formulario*/
        public void Limpiar()
        {
            try
            {

                mtxt_Cedula.Text = string.Empty;
                txt_Nombre.Text = string.Empty;
                mtxt_Telefono.Text = string.Empty;
                txt_CantidadPagado.Text = string.Empty;
                rb_Juguete.Checked = false;
                rb_Ropa.Checked = false;
                rb_15Dias.Checked = false;
                rb_Mes.Checked = false;
                rb_Efectivo.Checked = false;
                rb_Tarjeta.Checked = false;
                txt_PrecioProducto.Text = string.Empty;
                txt_Decripcion.Text = string.Empty;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Problemas en LIMPIAR_DATOS()");

            }
        }

        private void btn_Agregar_Click_1(object sender, EventArgs e)
        {
            try
            {

                #region Validaciones
                if (txt_Nombre.Text == string.Empty)
                {
                    MessageBox.Show("Favor Ingresar Nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_Nombre.Focus();
                    return;
                }
                else if (mtxt_Cedula.Text == string.Empty)
                {
                    MessageBox.Show("Favor Ingresar Cedula", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    mtxt_Cedula.Focus();
                    return;
                }
                else if (mtxt_Telefono.Text == string.Empty)
                {
                    MessageBox.Show("Favor Ingresar Numero de Telefono", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    mtxt_Telefono.Focus();
                    return;
                }
                else if (txt_CantidadPagado.Text == string.Empty)
                {
                    MessageBox.Show("Favor Ingresar la cantidad pagada por el Cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_CantidadPagado.Focus();
                    return;
                }

                else if (txt_Decripcion.Text == string.Empty)
                {
                    MessageBox.Show("Favor Ingresar una Descripcion del Apartado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_Decripcion.Focus();
                    return;
                }
                else if (txt_PrecioProducto.Text == string.Empty)
                {
                    MessageBox.Show("Favor Ingresar el Precio del Producto Apartado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_PrecioProducto.Focus();
                    return;
                }
                else if (rb_Juguete.Checked == false && rb_Ropa.Checked == false)
                {
                    MessageBox.Show("Favor Seleccionar tipo de apartado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }
                else if (rb_15Dias.Checked == false && rb_Mes.Checked == false)
                {
                    MessageBox.Show("Favor Seleccionar tiempo para cancelación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }
                else if (rb_Efectivo.Checked == false && rb_Tarjeta.Checked == false)
                {
                    MessageBox.Show("Favor Seleccionar tipo de pago", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }
                #endregion

                if (rb_Mes.Checked)
                {
                    if (rb_Juguete.Checked)
                    {
                        ap.Cedula = mtxt_Cedula.Text;
                        ap.Nombre = txt_Nombre.Text;
                        ap.Telefono = mtxt_Telefono.Text;
                        ap.TipoApartado = rb_Juguete.Text;
                        ap.CantidadPagado = txt_CantidadPagado.Text;
                        ap.PrecioProducto = txt_PrecioProducto.Text;
                        ap.Descripcion = txt_Decripcion.Text;
                        ap.TiempoApartado = 30;
                        ap.Usuario = lbl_Usuario.Text;

                    }
                    else if (rb_Ropa.Checked)
                    {
                        ap.Cedula = mtxt_Cedula.Text;
                        ap.Nombre = txt_Nombre.Text;
                        ap.Telefono = mtxt_Telefono.Text;
                        ap.TipoApartado = rb_Ropa.Text;
                        ap.CantidadPagado = txt_CantidadPagado.Text;
                        ap.PrecioProducto = txt_PrecioProducto.Text;
                        ap.Descripcion = txt_Decripcion.Text;
                        ap.TiempoApartado = 30;
                        ap.Usuario = lbl_Usuario.Text;

                    }
                }
                else if (rb_15Dias.Checked)
                {
                    if (rb_Juguete.Checked)
                    {
                        ap.Cedula = mtxt_Cedula.Text;
                        ap.Nombre = txt_Nombre.Text;
                        ap.Telefono = mtxt_Telefono.Text;
                        ap.TipoApartado = rb_Juguete.Text;
                        ap.CantidadPagado = txt_CantidadPagado.Text;
                        ap.PrecioProducto = txt_PrecioProducto.Text;
                        ap.Descripcion = txt_Decripcion.Text;
                        ap.TiempoApartado = 15;
                        ap.Usuario = lbl_Usuario.Text;


                    }
                    else if (rb_Ropa.Checked)
                    {
                        ap.Cedula = mtxt_Cedula.Text;
                        ap.Nombre = txt_Nombre.Text;
                        ap.Telefono = mtxt_Telefono.Text;
                        ap.TipoApartado = rb_Ropa.Text;
                        ap.CantidadPagado = txt_CantidadPagado.Text;
                        ap.PrecioProducto = txt_PrecioProducto.Text;
                        ap.Descripcion = txt_Decripcion.Text;
                        ap.TiempoApartado = 15;
                        ap.Usuario = lbl_Usuario.Text;

                    }

                }

                ap.INSERT_APARTADO();

                if (ap.Validacion == "Insertado")
                {
                    //gi.Ingresos = txt_CantidadPagado.Text;
                    //gi.Ubicacion = lbl_Ubicacion.Text;
                    //gi.Descripcion = txt_Decripcion.Text;
                    //gi.INSERT_INGRESO();

                    if (rb_Efectivo.Checked)
                    {
                        cj.TipoPago = rb_Efectivo.Text;
                        cj.DineroTotal = txt_CantidadPagado.Text;
                        cj.Ubicacion = lbl_Ubicacion.Text;
                        cj.CodigoFactura = "Apartado";
                        cj.Login = lbl_Usuario.Text;
                        cj.Descripcion = txt_Decripcion.Text;

                    }
                    else if (rb_Tarjeta.Checked)
                    {
                        cj.TipoPago = rb_Tarjeta.Text;
                        cj.DineroTotal = txt_CantidadPagado.Text;
                        cj.Ubicacion = lbl_Ubicacion.Text;
                        cj.CodigoFactura = "Apartado";
                        cj.Login = lbl_Usuario.Text;
                        cj.Descripcion = txt_Decripcion.Text;
                    }
                    cj.INSERT_VENTASTOTALES();
                    objBitacora.Usuario = lbl_Usuario.Text;
                    objBitacora.Accion = "Inserción";
                    objBitacora.Formulario = "Apartado";
                    objBitacora.Descripcion = "Nuevo Apartado de: " + mtxt_Cedula;
                    objBitacora.INSERT_BITACORA();
                    frm_Mensaje objmensaje = new frm_Mensaje();
                    objmensaje.lbl_Mensaje.Text = "Nuevo Apartado";
                    objmensaje.pic_Check.Visible = true;
                    objmensaje.Show();
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("Ocurrio un Error", "Validacion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Problemas en btn_Agregar_Click");

            }

        }

        private void mtxt_Cedula_KeyPress(object sender, KeyPressEventArgs e)
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

        private void mtxt_Telefono_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_PrecioProducto_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_CantidadPagado_KeyPress(object sender, KeyPressEventArgs e)
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
