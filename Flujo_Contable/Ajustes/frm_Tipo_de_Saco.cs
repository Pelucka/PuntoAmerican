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
    public partial class frm_Tipo_de_Saco : Form
    {
        Otrosn objotros = new Otrosn();
        
        public frm_Tipo_de_Saco()
        {
            InitializeComponent();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /*Metodo para agregar informacion en la tabla Tipo Saco, por medio de la instancia al metodo en la clase
         Otros*/
        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            try
            {

                #region Validaciones
                if (txt_TipoSaco.Text == string.Empty)
                {
                    MessageBox.Show("Favor Ingresar el Tipo de Saco", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_TipoSaco.Focus();
                    return;
                }
                #endregion
                objotros.Descripcion = txt_TipoSaco.Text;
                objotros.INSERT_TIPO_SACO();
                if (objotros.Validacion == "Insertado")
                {
                    MessageBox.Show("Nuevo Tipo de Saco Insertado Correctamente", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CARGA_LISTA_SACO();
                    txt_TipoSaco.Text = string.Empty;
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

        private void frm_Tipo_de_Saco_Load(object sender, EventArgs e)
        {
            CARGA_LISTA_SACO();
        }

        /*Metodo para cargar dentro del datagridview la informacion solicitada por medio de la instancia,
         al metodo de la clase Otros*/
        private void CARGA_LISTA_SACO()
        {
            try
            {
                dgv_TipoSacos.DataSource = objotros.CARGA_LISTA_TIPO_SACO().Tables[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "CARGAR_LISTA_SACO()");


            }
        }

        private void btn_Agregar_Click_1(object sender, EventArgs e)
        {
            try
            {

                #region Validaciones
                if (txt_TipoSaco.Text == string.Empty)
                {
                    MessageBox.Show("Favor Ingresar el Tipo de Saco", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_TipoSaco.Focus();
                    return;
                }
                #endregion
                objotros.Descripcion = txt_TipoSaco.Text;
                objotros.INSERT_TIPO_SACO();
                if (objotros.Validacion == "Insertado")
                {
                    frm_Mensaje objmensaje = new frm_Mensaje();
                    objmensaje.lbl_Mensaje.Text = "Insertado";
                    objmensaje.pic_Check.Visible = true;
                    objmensaje.Show();
                    CARGA_LISTA_SACO();
                    txt_TipoSaco.Text = string.Empty;
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
    }
}
