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

namespace Flujo_Contable.Usuarios
{
    public partial class frm_CambioContraseña : Form
    {
        usuarios objUsuarios = new usuarios();
        public frm_CambioContraseña()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        /*Metodo para el cambio de contraseña, se logra por medio de la instancia a un metodo de la clase
         Usuarios*/
        private void btn_Cambiar_Click(object sender, EventArgs e)
        {
            try
            {

                #region Validaciones
                if (txt_ContraActual.Text == string.Empty)
                {
                    MessageBox.Show("Favor Ingresar la contraseña actual", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_ContraActual.Focus();
                    return;
                }
                else if (txt_ContraNueva.Text == string.Empty)
                {
                    MessageBox.Show("Favor Ingresar la nueva contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_ContraNueva.Focus();
                    return;
                }
                #endregion

                objUsuarios.Login = lbl_Usuario.Text;
                objUsuarios.SELECT_CONTRASEÑA_USUARIO();
                if (objUsuarios.Constrasena != txt_ContraActual.Text)
                {
                    MessageBox.Show("Contraseña actual invalida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_ContraActual.Focus();
                    txt_ContraActual.Text = string.Empty;
                }
                else
                {
                    objUsuarios.Constrasena = txt_ContraNueva.Text;
                    objUsuarios.Login = lbl_Usuario.Text;
                    objUsuarios.UPDATE_USUARIOS_CONPASSWORD();
                    if (objUsuarios.Validacion == "Actualizado")
                    {
                        MessageBox.Show("Cambio de Contraseña Correcto", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Hubo un Error al Cambiar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
