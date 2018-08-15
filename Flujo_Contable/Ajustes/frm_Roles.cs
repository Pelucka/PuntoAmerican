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

namespace Flujo_Contable.Ajustes
{
    public partial class frm_Roles : Form
    {
        Otrosn Objotros = new Otrosn();
        public frm_Roles()
        {
            InitializeComponent();
        }

        private void frm_Roles_Load(object sender, EventArgs e)
        {
            CARGA_LISTA_ROLES();
        }

        /*Metodo para cargar informacion en el datagridview, por medio de una instancia al metodo de la clase Otros*/
        private void CARGA_LISTA_ROLES()
        {
            try
            {
                dgv_Roles.DataSource = Objotros.CARGA_LISTA_ROLES().Tables[0];
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + "CARGA_LISTA_ROLES()");

            }
        }

        private void dgv_Consecutivos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dgv_Roles.Rows[e.RowIndex];
                    txt_Rol.Text = row.Cells["Descripcion"].Value.ToString();
                    chk_Admin.Checked = Convert.ToBoolean(row.Cells["Administracion"].Value);
                    chk_Ajustes.Checked = Convert.ToBoolean(row.Cells["Ajustes"].Value);
                    chk_Caja.Checked = Convert.ToBoolean(row.Cells["Caja"].Value);
                    chk_Control.Checked = Convert.ToBoolean(row.Cells["Control"].Value);
                    chk_IngresosyGastos.Checked = Convert.ToBoolean(row.Cells["IngresosyGastos"].Value);
                    chk_Inventario.Checked = Convert.ToBoolean(row.Cells["Inventario"].Value);
                    chk_Traslados.Checked = Convert.ToBoolean(row.Cells["Traslados"].Value);
                    chk_Usuarios.Checked = Convert.ToBoolean(row.Cells["Usuarios"].Value);
                    btn_Agregar.Enabled = false;

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

        /*Metodo para agregar la informacion en la tabla Roles, por medio de una instancia al metodo de la clase
         Otros*/
        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            try
            {

                #region Validaciones
                if (txt_Rol.Text == string.Empty)
                {
                    MessageBox.Show("Favor Ingresar el Rol", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_Rol.Focus();
                    return;
                }
                else if (chk_Admin.Checked == false && chk_Ajustes.Checked == false && chk_Caja.Checked == false && chk_Control.Checked == false
                     && chk_IngresosyGastos.Checked == false && chk_Inventario.Checked == false && chk_Usuarios.Checked == false)
                {
                    MessageBox.Show("Favor Seleccionar los Permisos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    chk_Admin.Focus();
                    return;
                }
                #endregion

                #region Checkbox
                if (chk_Admin.Checked == true)
                {
                    Objotros.Admin = true;
                }
                else
                {
                    Objotros.Admin = false;
                }

                if (chk_Ajustes.Checked == true)
                {
                    Objotros.Ajustes = true;
                }
                else
                {
                    Objotros.Ajustes = false;
                }


                if (chk_Caja.Checked == true)
                {
                    Objotros.Caja = true;
                }
                else
                {
                    Objotros.Caja = false;
                }

                if (chk_Control.Checked == true)
                {
                    Objotros.Control = true;
                }
                else
                {
                    Objotros.Control = false;
                }

                if (chk_IngresosyGastos.Checked == true)
                {
                    Objotros.IngresosyGastos = true;
                }
                else
                {
                    Objotros.IngresosyGastos = false;
                }

                if (chk_Inventario.Checked == true)
                {
                    Objotros.Inventario = true;
                }
                else
                {
                    Objotros.Inventario = false;
                }

                if (chk_Usuarios.Checked == true)
                {
                    Objotros.Usuarios = true;
                }
                else
                {
                    Objotros.Usuarios = false;
                }

                #endregion
                Objotros.Descripcion = txt_Rol.Text;
                Objotros.INSERT_ROLES();
                if (Objotros.Validacion == "Insertado")
                {
                    MessageBox.Show("Rol Insertado Correctamente", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CARGA_LISTA_ROLES();
                    txt_Rol.Text = string.Empty;
                    chk_Admin.Checked = true;
                    chk_Ajustes.Checked = true;
                    chk_Caja.Checked = true;
                    chk_Control.Checked = true;
                    chk_IngresosyGastos.Checked = true;
                    chk_Inventario.Checked = true;
                    chk_Usuarios.Checked = true;

                }
                else
                {
                    MessageBox.Show("Ocurrio un Error", "Validacion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "btn_Agregar_Click");


            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_Agregar_Click_1(object sender, EventArgs e)
        {
            try
            {

                #region Validaciones
                if (txt_Rol.Text == string.Empty)
                {
                    MessageBox.Show("Favor Ingresar el Rol", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_Rol.Focus();
                    return;
                }
                else if (chk_Admin.Checked == false && chk_Ajustes.Checked == false && chk_Caja.Checked == false && chk_Control.Checked == false
                     && chk_IngresosyGastos.Checked == false && chk_Inventario.Checked == false && chk_Usuarios.Checked == false)
                {
                    MessageBox.Show("Favor Seleccionar los Permisos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    chk_Admin.Focus();
                    return;
                }
                #endregion

                #region Checkbox
                if (chk_Admin.Checked == true)
                {
                    Objotros.Admin = true;
                }
                else
                {
                    Objotros.Admin = false;
                }

                if (chk_Ajustes.Checked == true)
                {
                    Objotros.Ajustes = true;
                }
                else
                {
                    Objotros.Ajustes = false;
                }


                if (chk_Caja.Checked == true)
                {
                    Objotros.Caja = true;
                }
                else
                {
                    Objotros.Caja = false;
                }

                if (chk_Control.Checked == true)
                {
                    Objotros.Control = true;
                }
                else
                {
                    Objotros.Control = false;
                }

                if (chk_IngresosyGastos.Checked == true)
                {
                    Objotros.IngresosyGastos = true;
                }
                else
                {
                    Objotros.IngresosyGastos = false;
                }

                if (chk_Inventario.Checked == true)
                {
                    Objotros.Inventario = true;
                }
                else
                {
                    Objotros.Inventario = false;
                }

                if (chk_Usuarios.Checked == true)
                {
                    Objotros.Usuarios = true;
                }
                else
                {
                    Objotros.Usuarios = false;
                }

                if(chk_Traslados.Checked == true)
                {
                    Objotros.Traslados = true;
                }
                else
                {
                    Objotros.Traslados = false;
                }

                #endregion
                Objotros.Descripcion = txt_Rol.Text;
                Objotros.INSERT_ROLES();
                if (Objotros.Validacion == "Insertado")
                {
                    frm_Mensaje objmensaje = new frm_Mensaje();
                    objmensaje.lbl_Mensaje.Text = "Insertado";
                    objmensaje.pic_Check.Visible = true;
                    objmensaje.Show();
                    CARGA_LISTA_ROLES();
                    txt_Rol.Text = string.Empty;
                    chk_Admin.Checked = true;
                    chk_Ajustes.Checked = true;
                    chk_Caja.Checked = true;
                    chk_Control.Checked = true;
                    chk_IngresosyGastos.Checked = true;
                    chk_Inventario.Checked = true;
                    chk_Usuarios.Checked = true;
                    chk_Traslados.Checked = true;

                }
                else
                {
                    MessageBox.Show("Ocurrio un Error", "Validacion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "btn_Agregar_Click");


            }
        }

        private void btn_Refrescar_Click(object sender, EventArgs e)
        {
            CARGA_LISTA_ROLES();
            txt_Rol.Text = string.Empty;
            chk_Admin.Checked = true;
            chk_Ajustes.Checked = true;
            chk_Caja.Checked = true;
            chk_Control.Checked = true;
            chk_IngresosyGastos.Checked = true;
            chk_Inventario.Checked = true;
            chk_Usuarios.Checked = true;
            chk_Traslados.Checked = true;
            btn_Agregar.Enabled = true;

        }
    }
}
