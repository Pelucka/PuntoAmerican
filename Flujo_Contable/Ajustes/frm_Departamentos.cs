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
    public partial class frm_Departamentos : Form
    {
        Otrosn Objotros = new Otrosn();

        public frm_Departamentos()
        {
            InitializeComponent();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_Departamentos_Load(object sender, EventArgs e)
        {
            CARGA_DEPARTAMENTOS();
        }

        /*Metodo para obtener el listado de todos los departamentos*/
        private void CARGA_DEPARTAMENTOS()
        {
            try
            {
                dgv_Departamentos.DataSource = Objotros.CARGA_LISTA_DEPARTAMENTOS().Tables[0];
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + "CARGA_DEPARTAMENTOS()");

            }

        }


        /*Se realiza la inserccion de los datos a la tabla Departamentos, pasando por parametro los datos,
         que se utilizaran dentro de los metodos establecidos en las clases*/
        private void btn_Agregar_Click_1(object sender, EventArgs e)
        {
            try
            {
                #region Validaciones
                if (txt_Departamento.Text == string.Empty)
                {
                    MessageBox.Show("Favor Ingresar el nombre del Departamento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_Departamento.Focus();
                    return;
                }
                #endregion
                Objotros.Descripcion = txt_Departamento.Text;
                Objotros.INSERT_DEPARTAMENTOS();
                if (Objotros.Validacion == "Insertado")
                {
                    frm_Mensaje objmensaje = new frm_Mensaje();
                    objmensaje.lbl_Mensaje.Text = "Insertado";
                    objmensaje.pic_Check.Visible = true;
                    objmensaje.Show();
                    CARGA_DEPARTAMENTOS();
                    txt_Departamento.Text = string.Empty;

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
