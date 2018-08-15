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

namespace Flujo_Contable.Otros
{
    public partial class frm_Gastos : Form
    {
        Gastos_e_Ingresos objgastos = new Gastos_e_Ingresos();
        public frm_Gastos()
        {
            InitializeComponent();
        }

        private void txt_Gastos_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_Gasto_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*Metodo para agregar informacion de gastos, utlizando por instancia metodo de la clase Gastos e Ingresos*/
        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            try
            {

                #region Validaciones
                if (txt_Gasto.Text == string.Empty)
                {
                    MessageBox.Show("Favor Ingresar el Monto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_Gasto.Focus();
                    return;
                }
                else if (txt_Descripcion.Text == string.Empty)
                {
                    MessageBox.Show("Favor Ingresar una Descripción", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_Descripcion.Focus();
                    return;
                }
                else if (cb_TipoGasto.Text == string.Empty)
                {
                    MessageBox.Show("Favor Escoger Tipo de Gasto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cb_TipoGasto.Focus();
                    return;

                }
                #endregion

                objgastos.Gastos = txt_Gasto.Text;
                objgastos.Descripcion = txt_Descripcion.Text;
                objgastos.Ubicacion = lbl_Ubicacion.Text;
                objgastos.TipoGasto = cb_TipoGasto.Text;
                objgastos.INSERT_GASTOS();
                if (objgastos.Validacion == "Insertado")
                {
                    MessageBox.Show("Gasto Nuevo Insertado", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_Descripcion.Text = string.Empty;
                    txt_Gasto.Text = string.Empty;
                    cb_TipoGasto.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "btn_Agregar_Click");

            }
        }

        private void frm_Gastos_Load(object sender, EventArgs e)
        {

        }

        private void btn_Agregar_Click_1(object sender, EventArgs e)
        {
            try
            {

                #region Validaciones
                if (txt_Gasto.Text == string.Empty)
                {
                    MessageBox.Show("Favor Ingresar el Monto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_Gasto.Focus();
                    return;
                }
                else if (txt_Descripcion.Text == string.Empty)
                {
                    MessageBox.Show("Favor Ingresar una Descripción", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_Descripcion.Focus();
                    return;
                }
                else if (cb_TipoGasto.Text == string.Empty)
                {
                    MessageBox.Show("Favor Escoger Tipo de Gasto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cb_TipoGasto.Focus();
                    return;

                }
                #endregion

                objgastos.Gastos = txt_Gasto.Text;
                objgastos.Descripcion = txt_Descripcion.Text;
                objgastos.Ubicacion = lbl_Ubicacion.Text;
                objgastos.TipoGasto = cb_TipoGasto.Text;
                objgastos.INSERT_GASTOS();
                if (objgastos.Validacion == "Insertado")
                {
                    frm_Mensaje objmensaje = new frm_Mensaje();
                    objmensaje.lbl_Mensaje.Text = "Insertado";
                    objmensaje.pic_Check.Visible = true;
                    objmensaje.Show();
                    txt_Descripcion.Text = string.Empty;
                    txt_Gasto.Text = string.Empty;
                    cb_TipoGasto.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "btn_Agregar_Click");

            }
        }

    }
}
