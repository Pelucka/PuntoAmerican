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
    public partial class frm_Bodega : Form
    {
        Inventario objinvetario = new Inventario();
        Bitacora objBitacora = new Bitacora();
        public frm_Bodega()
        {
            InitializeComponent();
        }


        private void frm_Bodega_Load(object sender, EventArgs e)
        {

            CARGA_TIPO_SACOS();
        }

        /*Metodo que permite cargar dentro del combobox informacion solicitada, por medio de la instancia al metodo
         de la clase Inventario*/
        private void CARGA_TIPO_SACOS()
        {
            try
            {

                DataSet ds;
                ds = objinvetario.CARGA_TIPO_SACOS();
                cbo_TipoSaco.DataSource = ds.Tables[0];
                cbo_TipoSaco.DisplayMember = ds.Tables[0].Columns["Descripcion"].ColumnName.ToString();
                cbo_TipoSaco.ValueMember = ds.Tables[0].Columns["Id_TipoSaco"].ColumnName.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "CARGA_TIPO_SACO()");


            }
        }




        private void btn_Borrar_Click(object sender, EventArgs e)
        {

        }

        /*Metodo que permite Agregar informacion a la tabla Sacos, por medio de una instancia al metodo de la 
         clase Inventario*/
        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            try
            {

                #region Validacion
                if (cbo_TipoSaco.Text == string.Empty)
                {
                    MessageBox.Show("Favor Seleccionar un Tipo de Saco", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cbo_TipoSaco.Focus();
                    return;
                }
                else
                {
                    objinvetario.TipoSaco = Convert.ToInt32(cbo_TipoSaco.SelectedValue);
                    objinvetario.Ubicacion = txt_Ubicacion.Text;
                    objinvetario.Usuario = txt_Usuario.Text;
                    objinvetario.INSERT_SACOS();
                    if (objinvetario.Validacion == "Insertado")
                    {
                        objBitacora.Usuario = txt_Usuario.Text;
                        objBitacora.Accion = "Inserción";
                        objBitacora.Formulario = "Inventario";
                        objBitacora.Descripcion = "Nuevo Saco: " + cbo_TipoSaco.Text+" en: "+txt_Ubicacion.Text;
                        objBitacora.INSERT_BITACORA();
                        frm_Mensaje objmensaje = new frm_Mensaje();
                        objmensaje.lbl_Mensaje.Text = "Insertado";
                        objmensaje.pic_Check.Visible = true;
                        objmensaje.Show();
                    }
                    else
                    {
                        MessageBox.Show("Error al Insertar el Saco", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                #endregion

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "btn_Agregar_Click");


            }

        }

    
        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
