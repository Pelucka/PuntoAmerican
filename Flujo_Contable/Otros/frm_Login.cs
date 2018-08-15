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
    public partial class frm_InicioSesion : Form
    {
        Login objlogin = new Login();
        Bitacora objBitacora = new Bitacora();


        string Validacion = string.Empty;
        string Ubicacion = string.Empty;
        string Rol = string.Empty;
        string Validacion_Rol = string.Empty;

        public frm_InicioSesion()
        {
            InitializeComponent();
        }


        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            txt_Contraseña.Text = string.Empty;
            txt_Login.Text = string.Empty;
        }



        private void frm_InicioSesion_Load(object sender, EventArgs e)
        {

        }



        /*Metodo para el inicio de session, por medio de instancia a la clase Login*/
        private void btn_Aceptar_Click_1(object sender, EventArgs e)
        {
            try
            {

                frm_Menu_Principal objmenuprincipal = new frm_Menu_Principal();

                if (txt_Login.Text == string.Empty)
                {
                    MessageBox.Show("Favor Ingresar su Login", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txt_Login.Focus();
                }
                else if (txt_Contraseña.Text == string.Empty)
                {
                    MessageBox.Show("Favor Ingresar su Contraseña", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txt_Contraseña.Focus();
                }
                else
                {
                    objlogin.LoginU = txt_Login.Text;
                    objlogin.Contra = txt_Contraseña.Text;
                    objlogin.LOGIN();
                    if (objlogin.LoginSalida == txt_Login.Text)
                    {
                        frm_Mensaje objmensaje = new frm_Mensaje();
                        objBitacora.Usuario = txt_Login.Text;
                        objBitacora.Accion = "Ingreso";
                        objBitacora.Formulario = "Login";
                        objBitacora.Descripcion = "Nuevo Ingreso al Sistema";
                        objBitacora.INSERT_BITACORA();
                        objmensaje.pic_Lock.Visible = true;
                        objmensaje.lbl_Mensaje.Text = "Bienvenido: " + txt_Login.Text;
                        objmensaje.Show();
                        objmenuprincipal.tsl_Usuario.Text = objlogin.LoginSalida;
                        objmenuprincipal.tsl_Ubicacion.Text = objlogin.Ubicacion;
                        objmenuprincipal.tsl_Rol.Text = objlogin.Rol;
                        objmenuprincipal.Show();
                        this.Hide();
                    }
                    else
                    {
                        txt_Login.Focus();

                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "btn_Aceptar_Click_1");

            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
