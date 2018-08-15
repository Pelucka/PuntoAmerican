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
    public partial class frm_Ubicaciones : Form
    {
        Otrosn objotros = new Otrosn();

        
        public frm_Ubicaciones()
        {
            InitializeComponent();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*Metodo para agregar informacion a la tabla Ubicaciones, por medio de instancia al metodo dentro de la 
         clas Otros*/
        private void btn_Agregar_Click(object sender, EventArgs e)
        {

        }

        private void frm_Ubicaciones_Load(object sender, EventArgs e)
        {

            CARGA_LISTA_UBICACIONES();
            CARGA_UBICACION();
            CARGA_DUEÑOS();
        }

        /*Metodo que permite cargar ña informacion al datagridview, por medio de una instancia al metodo de la
         clase Otros*/
        private void CARGA_LISTA_UBICACIONES()
        {
            try
            {
                dgv_Ubicaciones.DataSource = objotros.CARGA_LISTA_UBICACION().Tables[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "CARGA_LISTA_UBICACIONES()");

            }
        }


        private void CARGA_UBICACION()
        {
            try
            {

                DataSet ds;
                ds = objotros.CARGA_PROVINCIA();
                cbo_Provincia.DataSource = ds.Tables[0];
                cbo_Provincia.DisplayMember = ds.Tables[0].Columns["Provincia"].ColumnName.ToString();
                cbo_Provincia.ValueMember = ds.Tables[0].Columns["Codigo"].ColumnName.ToString();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "CARGA_PROVINCIA()");
            }
        }

        private void CARGA_CANTON()
        {
            try
            {

                DataSet ds;
                ds = objotros.CARGA_CANTON();
                cbo_Canton.DataSource = ds.Tables[0];
                cbo_Canton.DisplayMember = ds.Tables[0].Columns["Canton"].ColumnName.ToString();
                cbo_Canton.ValueMember = ds.Tables[0].Columns["Codigo"].ColumnName.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "CARGA_CANTON()");
            }
        }
        private void CARGA_DISTRITO()
        {
            try
            {

                DataSet ds;
                ds = objotros.CARGA_DISTRITO();
                cbo_Distrito.DataSource = ds.Tables[0];
                cbo_Distrito.DisplayMember = ds.Tables[0].Columns["Distrito"].ColumnName.ToString();
                cbo_Distrito.ValueMember = ds.Tables[0].Columns["Codigo"].ColumnName.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "CARGA_DISTRITO()");
            }
        }
        private void CARGA_BARRIO()
        {
            try
            {

                DataSet ds;
                ds = objotros.CARGA_BARRIO();
                cbo_Barrio.DataSource = ds.Tables[0];
                cbo_Barrio.DisplayMember = ds.Tables[0].Columns["Barrio"].ColumnName.ToString();
                cbo_Barrio.ValueMember = ds.Tables[0].Columns["Codigo"].ColumnName.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "CARGA_BARRIO()");
            }
        }

        private void CARGA_DUEÑOS()
        {
            try
            {

                DataSet ds;
                ds = objotros.CARGA_DUEÑOS();
                cbo_dueño.DataSource = ds.Tables[0];
                cbo_dueño.DisplayMember = ds.Tables[0].Columns["Nombre"].ColumnName.ToString();
                cbo_dueño.ValueMember = ds.Tables[0].Columns["Dueno"].ColumnName.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "CARGA_DUEÑOS()");
            }
        }




        private void cbo_Provincia_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
            

            cbo_Canton.Enabled = true;
            objotros.Provincia = Convert.ToInt32(cbo_Provincia.SelectedValue.ToString());
            CARGA_CANTON();

        }

        private void cbo_Canton_SelectionChangeCommitted(object sender, EventArgs e)
        {

            cbo_Distrito.Enabled = true;
            objotros.Provincia = Convert.ToInt32(cbo_Provincia.SelectedValue.ToString());
            objotros.Canton = Convert.ToInt32(cbo_Canton.SelectedValue.ToString());
            CARGA_DISTRITO();
        }

        private void cbo_Distrito_SelectionChangeCommitted(object sender, EventArgs e)
        {
   
            cbo_Barrio.Enabled = true;
            objotros.Provincia = Convert.ToInt32(cbo_Provincia.SelectedValue.ToString());
            objotros.Canton = Convert.ToInt32(cbo_Canton.SelectedValue.ToString());
            objotros.Distrito = Convert.ToInt32(cbo_Distrito.SelectedValue.ToString());
            CARGA_BARRIO();
        }

        private void btn_Consulta_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cbo_Provincia.SelectedValue.ToString() + "," + cbo_Canton.SelectedValue.ToString() + "," + cbo_Distrito.SelectedValue.ToString() + "," + cbo_Barrio.SelectedValue.ToString());
        }

        private void cbo_Barrio_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txt_UbicacionExacta.Enabled = true;
        }

        private void dgv_Ubicaciones_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_Agregar_Click_1(object sender, EventArgs e)
        {
            try
            {

                #region Validaciones
                if (txt_Nombre.Text == string.Empty)
                {
                    MessageBox.Show("Favor Ingresar Nombre de la Sucursal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_Nombre.Focus();
                    return;
                }
                else if (txt_Prefijo.Text == string.Empty)
                {
                    MessageBox.Show("Favor Ingresar un Prefijo para la Sucursal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_Prefijo.Focus();
                    return;
                }
                #endregion
                
                objotros.Descripcion = txt_Nombre.Text;
                objotros.Prefijo = txt_Prefijo.Text;
                objotros.Provincia = Convert.ToInt32(cbo_Provincia.SelectedValue);
                objotros.Canton = Convert.ToInt32(cbo_Canton.SelectedValue);
                objotros.Distrito = Convert.ToInt32(cbo_Distrito.SelectedValue);
                objotros.Barrio = Convert.ToInt32(cbo_Barrio.SelectedValue);
                objotros.Telefono = Convert.ToInt32(msk_Telefono.Text.Replace("-", string.Empty));
                objotros.SELECT_CODIGO_DE_UBICACION();
                objotros.DescripciondeUbicacion = txt_UbicacionExacta.Text;
                objotros.Identificacion = Convert.ToInt32( cbo_dueño.SelectedValue);
                objotros.SELECT_CONSECUTIVO();
                objotros.INSERT_UBICACION();
                if (objotros.Validacion == "Insertado")
                {
                    frm_Mensaje objmensaje = new frm_Mensaje();
                    objmensaje.lbl_Mensaje.Text = "Insertado";
                    objmensaje.pic_Check.Visible = true;
                    objmensaje.Show();
                    CARGA_LISTA_UBICACIONES();
                    txt_Nombre.Text = string.Empty;
                    txt_Prefijo.Text = string.Empty;
                    txt_UbicacionExacta.Text = string.Empty;
                    cbo_Barrio.Enabled = false;
                    cbo_Canton.Enabled = false;
                    cbo_Distrito.Enabled = false;
                    CARGA_LISTA_UBICACIONES();
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

        private void cbo_Provincia_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgv_Ubicaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
