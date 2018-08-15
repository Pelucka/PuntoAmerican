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
    public partial class frm_ListaApartado : Form
    {
        Gastos_e_Ingresos gi = new Gastos_e_Ingresos();
        Apartados ap = new Apartados();
        BLL.Caja cj = new BLL.Caja();
        Bitacora objBitacora = new Bitacora();
        public frm_ListaApartado()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {

                if (rb_Cedula.Checked == true)
                {
                    txt_NombreBuscar.Enabled = false;
                    msk_CedulaBusqueda.Enabled = true;

                    txt_NombreBuscar.Visible = false;
                    msk_CedulaBusqueda.Visible = true;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void rb_Nombre_CheckedChanged(object sender, EventArgs e)
        {
            try
            {

                if (rb_Nombre.Checked == true)
                {
                    txt_NombreBuscar.Enabled = true;
                    msk_CedulaBusqueda.Enabled = false;

                    txt_NombreBuscar.Visible = true;
                    msk_CedulaBusqueda.Visible = false;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void rb_Telefono_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            try
            {

                msk_CedulaBusqueda.Text = string.Empty;

                txt_NombreBuscar.Text = string.Empty;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void frm_ListaApartado_Load(object sender, EventArgs e)
        {
            LISTA_APARTADOS();
        }

        /*Cargar dentro de datagridview los datos de la tabla apartados, por medio de la intancia al metodo de la
         clase Apartados*/
        private void LISTA_APARTADOS()
        {
            try
            {

                dgv_Apartados.DataSource = ap.CARGA_LISTA_APARTADOS().Tables[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "LISTA_APARTADOS()");

            }
        }

        /*Metodo que permite pasar los datos del datagridview a los controladores del formulario*/
        private void dgv_Apartados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (e.RowIndex >= 0)
                {
                    DateTime fechaInicial;
                    DateTime fechaFinal;
                    DataGridViewRow row = this.dgv_Apartados.Rows[e.RowIndex];
                    txt_IdApartado.Text = row.Cells["Id_Apartados"].Value.ToString();
                    mtxt_Cedula.Text = row.Cells["Cedula"].Value.ToString();
                    txt_Nombre.Text = row.Cells["Nombre"].Value.ToString();
                    mtxt_Telefono.Text = row.Cells["Telefono"].Value.ToString();
                    if (row.Cells["TipoApartado"].Value.ToString() == "Jueguete")
                    {
                        rb_Jueguete.Checked = true;
                        rb_Ropa.Checked = false;
                    }
                    else if (row.Cells["TipoApartado"].Value.ToString() == "Ropa")
                    {
                        rb_Ropa.Checked = true;
                        rb_Jueguete.Checked = false;
                    }
                    txt_PrecioProducto.Text = row.Cells["PrecioProducto"].Value.ToString();
                    txt_CantidadPagado.Text = row.Cells["CantidadPagado"].Value.ToString();
                    lb_Descripcion.Text = row.Cells["Descripcion"].Value.ToString();



                    fechaInicial = Convert.ToDateTime(row.Cells["FechaFinal"].Value.ToString());
                    ap.CARGA_FECHA_BASEDEDATOS();
                    fechaFinal = Convert.ToDateTime(ap.Fecha);
                    lbl_FaltadePagar.Text = (Convert.ToInt32(txt_PrecioProducto.Text) - Convert.ToInt32(txt_CantidadPagado.Text)).ToString();
                    if ((fechaInicial - fechaFinal).TotalDays > 5)
                    {
                      
                    }
                    else if (((fechaInicial - fechaFinal).TotalDays <= 0))
                    {
                        MessageBox.Show("El Apartado ha Caducado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DialogResult dr = MessageBox.Show("Desea Finalizar el Apartado", "Validacion", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (dr == DialogResult.Yes)
                        {
                            gi.Ingresos = txt_CantidadPagado.Text;
                            gi.Ubicacion = lbl_Ubicacion.Text;
                            gi.Descripcion = "Apartado Caducado por Fecha";
                            gi.Usuario = lbl_Usuario.Text;
                            
                            if(rb_Efectivo.Checked == true)
                            {
                                gi.TipodePago = rb_Efectivo.Text;
                            }
                            else if(rb_Tarjeta.Checked == true)
                            {
                                gi.TipodePago = rb_Tarjeta.Text;
                            }
                            ap.Codigo = Convert.ToInt32(txt_IdApartado.Text);
                            ap.DELETE_APARTADO();
                            if (ap.Validacion == "Eliminado")
                            {
                                MessageBox.Show("Apartado Eliminado con Exito", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LISTA_APARTADOS();
                            }
                        }
                        else if (dr == DialogResult.No)
                        {

                        }
                    }
                    else if ((fechaInicial - fechaFinal).TotalDays <= 5 & (fechaInicial - fechaFinal).TotalDays >= 1)
                    {
                        MessageBox.Show("Su Apartado esta a punto de vencer le quedan:  " + Convert.ToInt32((fechaInicial - fechaFinal).TotalDays).ToString() + " Dias.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        /*Metodo que permite realizar la actualizacion en la tabla apartados, para los abonos de dinero,
         por medio de una instancia al metodo dentro de la clase Apartados*/
      


        /*Metodo para buscar los apartados segun el tipo de dato, por medio de los metodos instanciados de la clase
         Apartados*/
        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            try
            {

                if (rb_Cedula.Checked == true)
                {
                    ap.Cedula = msk_CedulaBusqueda.Text;
                    dgv_Apartados.DataSource = ap.BUSQUEDA_CEDULA().Tables[0];
                }
                else if (rb_Nombre.Checked == true)
                {
                    ap.Nombre = txt_NombreBuscar.Text;
                    dgv_Apartados.DataSource = ap.BUSQUEDA_NOMBRE().Tables[0];
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "btn_Buscar_Click");

            }
        }

        /*Metodo para Limpiar los controladores del formulario*/
        public void Limpiar()
        {
            try
            {

                txt_IdApartado.Text = string.Empty;
                mtxt_Cedula.Text = string.Empty;
                txt_Nombre.Text = string.Empty;
                mtxt_Telefono.Text = string.Empty;
                txt_PrecioProducto.Text = string.Empty;
                txt_CantidadPagado.Text = string.Empty;
                txt_DineroPagadoFinal.Text = string.Empty;
                lbl_FaltadePagar.Text = "0";
                rb_Jueguete.Checked = false;
                rb_Ropa.Checked = false;
                rb_Efectivo.Checked = false;
                rb_Tarjeta.Checked = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Limpiar()");

            }

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btn_Pagar_Click_1(object sender, EventArgs e)
        {
            try
            {

                #region Validaciones
                if (txt_DineroPagadoFinal.Text == string.Empty)
                {
                    MessageBox.Show("Favor Ingresar Monto a Cancelar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_DineroPagadoFinal.Focus();
                    return;
                }
                else if (rb_Efectivo.Checked == false && rb_Tarjeta.Checked == false)
                {
                    MessageBox.Show("Favor Ingresar Tipo de pago", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }
                #endregion

                double montoInicial = Convert.ToDouble(txt_CantidadPagado.Text);
                double precio = Convert.ToDouble(txt_PrecioProducto.Text);
                double montoFinal = Convert.ToDouble(txt_DineroPagadoFinal.Text);
                double montoSave = montoInicial + montoFinal;

                if (precio < montoSave)
                {
                    MessageBox.Show("El monto ingresado supera la deuda", "Validacion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (precio > montoSave)
                {

                    ap.CantidadPagado = Convert.ToString(montoSave);
                    ap.Codigo = Convert.ToInt32(txt_IdApartado.Text);
                    ap.UPDATE_APARTADO();

                    if (ap.Validacion == "Actualizado")
                    {
                        frm_Mensaje objmensaje = new frm_Mensaje();
                        objmensaje.lbl_Mensaje.Text = "Apartado Actualizado";
                        objmensaje.pic_Check.Visible = true;
                        objmensaje.Show();

                    }
                    //gi.Ingresos = txt_DineroPagadoFinal.Text;
                    //gi.Ubicacion = lbl_Ubicacion.Text;
                    //gi.Descripcion = lb_Descripcion.Text;
                    //gi.INSERT_INGRESO();

                    if (rb_Efectivo.Checked)
                    {
                        cj.TipoPago = rb_Efectivo.Text;
                        cj.DineroTotal = txt_DineroPagadoFinal.Text;
                        cj.Ubicacion = lbl_Ubicacion.Text;
                        cj.CodigoFactura = "Apartado";
                        cj.Login = lbl_Usuario.Text;
                        cj.Descripcion = lb_Descripcion.Text;

                    }
                    else if (rb_Tarjeta.Checked)
                    {
                        cj.TipoPago = rb_Tarjeta.Text;
                        cj.DineroTotal = txt_DineroPagadoFinal.Text;
                        cj.Ubicacion = lbl_Ubicacion.Text;
                        cj.CodigoFactura = "Apartado";
                        cj.Login = lbl_Usuario.Text;
                        cj.Descripcion = lb_Descripcion.Text;
                    }

                    cj.INSERT_VENTASTOTALES();
                    objBitacora.Usuario = lbl_Usuario.Text;
                    objBitacora.Accion = "Actualización";
                    objBitacora.Formulario = "Apartados";
                    objBitacora.Descripcion = "Monto Actualizado del Apartado: " + txt_IdApartado.Text;
                    objBitacora.INSERT_BITACORA();
                    Limpiar();
                    LISTA_APARTADOS();

                }
                else if (precio == montoSave)
                {
                    MessageBox.Show("Monto de Apartado Cancelado, Apartado Eliminado", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //gi.Ingresos = txt_DineroPagadoFinal.Text;
                    //gi.Ubicacion = lbl_Ubicacion.Text;
                    //gi.Descripcion = lb_Descripcion.Text;
                    //gi.INSERT_INGRESO();

                    if (rb_Efectivo.Checked)
                    {
                        cj.TipoPago = rb_Efectivo.Text;
                        cj.DineroTotal = txt_DineroPagadoFinal.Text;
                        cj.Ubicacion = lbl_Ubicacion.Text;
                        cj.CodigoFactura = "Apartado";
                        cj.Login = lbl_Usuario.Text;
                        cj.Descripcion = lb_Descripcion.Text;

                    }
                    else if (rb_Tarjeta.Checked)
                    {
                        cj.TipoPago = rb_Tarjeta.Text;
                        cj.DineroTotal = txt_DineroPagadoFinal.Text;
                        cj.Ubicacion = lbl_Ubicacion.Text;
                        cj.CodigoFactura = "Apartado";
                        cj.Login = lbl_Usuario.Text;
                        cj.Descripcion = lb_Descripcion.Text;
                    }

                    cj.INSERT_VENTASTOTALES();
                    objBitacora.Usuario = lbl_Usuario.Text;
                    objBitacora.Accion = "Actualización";
                    objBitacora.Formulario = "Apartados";
                    objBitacora.Descripcion = "Finalizado el Apartado: " + txt_IdApartado.Text;
                    objBitacora.INSERT_BITACORA();
                    ap.Codigo = Convert.ToInt32(txt_IdApartado.Text);
                    ap.DELETE_APARTADO();

                    Limpiar();
                    LISTA_APARTADOS();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "btn_Pagar_Click");

            }


        }

        private void msk_CedulaBusqueda_KeyPress(object sender, KeyPressEventArgs e)
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
