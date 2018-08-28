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
    public partial class frm_Usuarios : Form
    {
        usuarios objusuarios = new usuarios();
        public frm_Usuarios()
        {
            InitializeComponent();
        }
        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            try
            {
                LIMPIAR();
                lbl_CodigoUsuario.Text = string.Empty;
                lbl_Dato.Text = "0";           
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LIMPIAR()
        {
            try
            {

                txt_Login.Text = string.Empty;
                txt_Nombre.Text = string.Empty;
                txt_Apellidos.Text = string.Empty;
                txt_Correo.Text = string.Empty;
                msk_Telefono.Text = string.Empty;
                lbl_Dato.Text = "0";
                lbl_CodigoUsuario.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            txt_Busqueda.Text = string.Empty;
        }
        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frm_Usuarios_Load(object sender, EventArgs e)
        {
            this.CARGA_UBICACION();
            this.CARGA_ROL();
        }
        /*Se carga informacion por medio de instancia a metodo de la clase Usuarios*/
        private void CARGA_UBICACION()
        {
            try
            {
                DataSet ds;
                ds = objusuarios.CARGA_UBICACION();
                cbo_Ubicacion.DataSource = ds.Tables[0];
                cbo_Ubicacion.DisplayMember = ds.Tables[0].Columns["Descripcion"].ColumnName.ToString();
                cbo_Ubicacion.ValueMember = ds.Tables[0].Columns["Id_Ubicacion"].ColumnName.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "CARGA_UBICACION()");
            }
        }
        /*Se carga informacion por medio de instancia a metodo de la clase Usuarios*/
        private void CARGA_ROL()
        {
            try
            {
                DataSet ds;
                ds = objusuarios.CARGA_ROL();
                cbo_Rol.DataSource = ds.Tables[0];
                cbo_Rol.DisplayMember = ds.Tables[0].Columns["Descripcion"].ColumnName.ToString();
                cbo_Rol.ValueMember = ds.Tables[0].Columns["Id_Rol"].ColumnName.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "CARGA_ROL()");
            }
        }
        /*Se agrega informacion en tabla Usuarios por medio de instancia a metodo de la clase Usuarios*/
        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                #region Validaciones
                if (txt_Login.Text == string.Empty)
                {
                    MessageBox.Show("Favor Ingresar un Login", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_Login.Focus();
                    return;
                }
                else if (txt_Apellidos.Text == string.Empty)
                {
                    MessageBox.Show("Favor Ingresar los Apellidos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_Apellidos.Focus();
                    return;
                }
                else if (txt_Correo.Text == string.Empty)
                {
                    MessageBox.Show("Favor Ingresar un Correo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_Correo.Focus();
                    return;
                }
                else if (txt_Nombre.Text == string.Empty)
                {
                    MessageBox.Show("Favor Ingresar un Nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_Nombre.Focus();
                    return;
                }
                else if (msk_Telefono.Text == string.Empty)
                {
                    MessageBox.Show("Favor Ingresar un Telefono", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    msk_Telefono.Focus();
                    return;
                }
                else if (cbo_Ubicacion.Text == string.Empty)
                {
                    MessageBox.Show("Favor Ingresar una Ubicacion Correcta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cbo_Ubicacion.Focus();
                    return;
                }
                #endregion
                //Actualizacion del Usuario
                if (lbl_Dato.Text == "1")
                {
                    objusuarios.Nombre = txt_Nombre.Text;
                    objusuarios.Apellidos = txt_Apellidos.Text;
                    objusuarios.Codigo = Convert.ToInt32(lbl_CodigoUsuario.Text);
                    objusuarios.Telefono = msk_Telefono.Text;
                    objusuarios.Correo = txt_Correo.Text;
                    objusuarios.Login = txt_Login.Text;
                    objusuarios.Ubicacion = Convert.ToInt32(cbo_Ubicacion.SelectedValue);
                    objusuarios.Rol = Convert.ToInt32(cbo_Rol.SelectedValue);
                    objusuarios.UPDATE_USUARIOS_NOPASSWORD();
                    if (objusuarios.Validacion == "Actualizado")
                    {
                        frm_Mensaje objmensaje = new frm_Mensaje();
                        objmensaje.lbl_Mensaje.Text = "Usuario Actualizado";
                        objmensaje.pic_Check.Visible = true;
                        objmensaje.Show();
                        LIMPIAR();
                        this.CARGA_UBICACION();
                        this.CARGA_ROL();
                    }
                }
                //Insertar el Usuario
                else
                {
                    objusuarios.Correo = txt_Correo.Text;
                    objusuarios.RANDOM_CONTRASEÑA();
                    objusuarios.ENVIO_DE_CONTRASEÑA();
                    objusuarios.Nombre = txt_Nombre.Text;
                    objusuarios.Apellidos = txt_Apellidos.Text;
                    objusuarios.Telefono = msk_Telefono.Text;
                    objusuarios.Login = txt_Login.Text;
                    objusuarios.Ubicacion = Convert.ToInt32(cbo_Ubicacion.SelectedValue);
                    objusuarios.Rol = Convert.ToInt32(cbo_Rol.SelectedValue);
                    objusuarios.INSERT_USUARIOS();
                    if (objusuarios.Validacion == "Insertado")
                    {
                        frm_Mensaje objmensaje = new frm_Mensaje();
                        objmensaje.lbl_Mensaje.Text = "Usuario Insertado";
                        objmensaje.pic_Check.Visible = true;
                        objmensaje.Show();
                        LIMPIAR();
                        this.CARGA_UBICACION();
                        this.CARGA_ROL();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "btn_Aceptar_Click");
            }
        }
        /*Se eliminar informacion de la tabla Usuarios por medio de instancia a metodo de la clase Usuarios*/
        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (lbl_CodigoUsuario.Text != string.Empty)
                {
                    objusuarios.Codigo = Convert.ToInt32(lbl_CodigoUsuario.Text);
                    DialogResult dr = MessageBox.Show("Desea Eliminar el Usuario " + txt_Login.Text + " ?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    switch (dr)
                    {
                        case DialogResult.Yes:
                            objusuarios.Codigo = Convert.ToInt32(lbl_CodigoUsuario.Text);
                            objusuarios.DELETE_USUARIOS();
                            if (objusuarios.Validacion == "Eliminado")
                            {
                                this.LIMPIAR();
                                this.CARGA_ROL();
                                this.CARGA_UBICACION();
                                frm_Mensaje objmensaje = new frm_Mensaje();
                                objmensaje.lbl_Mensaje.Text = "Usuario Eliminado";
                                objmensaje.pic_Check.Visible = true;
                                objmensaje.Show();
                            }
                            break;
                        case DialogResult.No:
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("No se ha seleccionado el Usuario a Eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "btn_Eliminar_Click");
            }    
        }
        /*Se busca informacion por medio de instancia a metodo de la clase Usuarios*/
        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_Busqueda.Text == string.Empty)
                {
                    MessageBox.Show("Favor Ingresar información", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_Busqueda.Focus();
                    return;
                }
                else
                {
                    if (rb_Login.Checked == true)
                    {
                        objusuarios.Login = txt_Busqueda.Text;
                        dgv_Usuarios.DataSource = objusuarios.BUSQUEDA_LOGIN().Tables[0];

                    }
                    else if (rb_Nombre.Checked == true)
                    {
                        objusuarios.Nombre = txt_Busqueda.Text;
                        dgv_Usuarios.DataSource = objusuarios.BUSQUEDA_USUARIOS().Tables[0];

                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "btn_Bucar_Click");
            }
        }
        /*Se pasa informacion del datagridview a los controladores del formulario*/
        private void dgv_Usuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dgv_Usuarios.Rows[e.RowIndex];
                    txt_Nombre.Text = row.Cells["Nombre"].Value.ToString();
                    txt_Apellidos.Text = row.Cells["Apellidos"].Value.ToString();
                    msk_Telefono.Text = row.Cells["Telefono"].Value.ToString();
                    txt_Login.Text = row.Cells["Login"].Value.ToString();
                    txt_Correo.Text = row.Cells["Correo"].Value.ToString();
                    cbo_Rol.Text = row.Cells["Rol"].Value.ToString();
                    cbo_Ubicacion.Text = row.Cells["Ubicacion"].Value.ToString();
                    lbl_CodigoUsuario.Text = row.Cells["Id_Usuario"].Value.ToString();
                    lbl_Dato.Text = "1";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /*Controladores enventos*/
        private void btn_Refrescar_Click(object sender, EventArgs e)
        {
            this.CARGA_ROL();
            this.CARGA_UBICACION();
            this.LIMPIAR();
        }
        private void msk_Telefono_KeyPress(object sender, KeyPressEventArgs e)
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
