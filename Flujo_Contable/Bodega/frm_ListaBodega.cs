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
    public partial class frm_ListaBodega : Form
    {
        Inventario objinventario = new Inventario();
        Otrosn objotros = new Otrosn();
        Bitacora objBitacora = new Bitacora();

        public frm_ListaBodega()
        {
            InitializeComponent();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_NombreBuscar_TextChanged(object sender, EventArgs e)
        {

        }


        private void rb_Saco_CheckedChanged(object sender, EventArgs e)
        {
            try
            {

                if (rb_Saco.Checked == true)
                {

                    cbo_Ubicacionbusqueda.Visible = false;
                    cbo_tiposacobusqueda.Visible = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void rb_Ubicacion_CheckedChanged(object sender, EventArgs e)
        {
            try
            {

                if (rb_Ubicacion.Checked == true)
                {

                    cbo_Ubicacionbusqueda.Visible = true;
                    cbo_tiposacobusqueda.Visible = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_Cancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_ListaBodega_Load(object sender, EventArgs e)
        {

            CARGA_SACOS();
            CARGA_TIPO_SACOS();
            CARGA_UBICACIONES();
            CARGA_TIPO_SACOS_BUSQUEDA();
            CARGA_UBICACIONES_BUSQUEDA();

        }

        /*Metodo que permite cargar la informacion obtenida de la instancia al metodo dentro de la clase
         Inventario dentro del datagridview*/
        private void CARGA_SACOS()
        {
            try
            {
                objinventario.Ubicacion = lbl_Ubica.Text;
                objinventario.Rol = lbl_Rol.Text;
                dgv_Inventario.DataSource = objinventario.CARGA_SACOS().Tables[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "CARGA_SACOS()");


            }
        }

        /*Metodo que permite cargar la informacion obtenida de la instancia al metodo dentro de la clase
         Inventario dentro del comobobox*/
        private void CARGA_TIPO_SACOS()
        {
            try
            {

                DataSet ds;
                ds = objinventario.CARGA_TIPO_SACOS();
                cbo_TipoSaco.DataSource = ds.Tables[0];
                cbo_TipoSaco.DisplayMember = ds.Tables[0].Columns["Descripcion"].ColumnName.ToString();
                cbo_TipoSaco.ValueMember = ds.Tables[0].Columns["Id_TipoSaco"].ColumnName.ToString();
                cbo_tiposacobusqueda.DataSource = ds.Tables[0];
                cbo_tiposacobusqueda.DisplayMember = ds.Tables[0].Columns["Descripcion"].ColumnName.ToString();
                cbo_tiposacobusqueda.ValueMember = ds.Tables[0].Columns["Id_TipoSaco"].ColumnName.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "CARGA_TIPO_SACOS()");

            }


        }

        /*Metodo que permite cargar la informacion obtenida de la instancia al metodo dentro de la clase
         Inventario dentro del combobox en la parte de busqueda*/
        private void CARGA_TIPO_SACOS_BUSQUEDA()
        {
            try
            {

                DataSet ds;
                ds = objinventario.CARGA_TIPO_SACOS();
                cbo_tiposacobusqueda.DataSource = ds.Tables[0];
                cbo_tiposacobusqueda.DisplayMember = ds.Tables[0].Columns["Descripcion"].ColumnName.ToString();
                cbo_tiposacobusqueda.ValueMember = ds.Tables[0].Columns["Id_TipoSaco"].ColumnName.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "CARGA_TIPO_SACO_BUSQUEDA()");

            }

        }

        /*Metodo que permite cargar la informacion obtenida de la instancia al metodo dentro de la clase
         Inventario dentro del combobox*/
        private void CARGA_UBICACIONES()
        {
            try
            {

                DataSet ds;
                ds = objotros.CARGA_LISTA_UBICACION_ALL();
                cbo_Ubicacion.DataSource = ds.Tables[0];
                cbo_Ubicacion.DisplayMember = ds.Tables[0].Columns["Descripcion"].ColumnName.ToString();
                cbo_Ubicacion.ValueMember = ds.Tables[0].Columns["Id_Ubicacion"].ColumnName.ToString();
                cbo_Ubicacionbusqueda.DataSource = ds.Tables[0];
                cbo_Ubicacionbusqueda.DisplayMember = ds.Tables[0].Columns["Descripcion"].ColumnName.ToString();
                cbo_Ubicacionbusqueda.ValueMember = ds.Tables[0].Columns["Id_Ubicacion"].ColumnName.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "CARGA_UBICACIONES()");

            }
        }

        /*Metodo que permite cargar la informacion obtenida de la instancia al metodo dentro de la clase
         Inventario dentro del combobox parte de busqueda*/
        private void CARGA_UBICACIONES_BUSQUEDA()
        {
            try
            {

                DataSet ds;
                ds = objotros.CARGA_LISTA_UBICACION_ALL();
                cbo_Ubicacionbusqueda.DataSource = ds.Tables[0];
                cbo_Ubicacionbusqueda.DisplayMember = ds.Tables[0].Columns["Descripcion"].ColumnName.ToString();
                cbo_Ubicacionbusqueda.ValueMember = ds.Tables[0].Columns["Id_Ubicacion"].ColumnName.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "CARGA_UBICACIONES_BUSQUEDA()");


            }
        }



        private void btn_resetear_Click(object sender, EventArgs e)
        {
            LIMPIAR_DATOS();
            CARGA_SACOS();
            CARGA_TIPO_SACOS();
            CARGA_UBICACIONES();
        }

        /*Metodo para realizar la actualizacion de informacion dentron de la tabla Sacos, por medio de una 
         instancia al metodo de la clase Inventario*/
        private void txt_aceptar_Click(object sender, EventArgs e)
        {
            try
            {

                if (cbo_Ubicacion.Text == string.Empty)
                {
                    MessageBox.Show("Favor Seleccionar la Ubicacion", "Validacion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cbo_Ubicacion.Focus();
                    return;
                }
                else if (cbo_TipoSaco.Text == string.Empty)
                {
                    MessageBox.Show("Favor Seleccionar el Tipo de Saco", "Validacion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cbo_TipoSaco.Focus();
                    return;
                }
                
                else if (lbl_Codigo.Text == string.Empty)
                {
                    MessageBox.Show("Favor Seleccionar el Saco a Modificar", "Validacion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    objinventario.Codigo = Convert.ToInt32(lbl_Codigo.Text);
                    objinventario.UbicacionUpdate = Convert.ToInt32(cbo_Ubicacion.SelectedValue);
                    objinventario.TipoSaco = Convert.ToInt32(cbo_TipoSaco.SelectedValue);
                    objinventario.UPDATE_SACOS();
                    if (objinventario.Validacion == "Actualizado")
                    {
                        objBitacora.Usuario = lbl_Usuario.Text;
                        objBitacora.Accion = "Actualización";
                        objBitacora.Formulario = "Inventario";
                        objBitacora.Descripcion = "Saco Actualizado "+lbl_Codigo.Text+" por "+lbl_Usuario.Text;
                        objBitacora.INSERT_BITACORA();
                        frm_Mensaje objmensaje = new frm_Mensaje();
                        objmensaje.lbl_Mensaje.Text = "Actualizado";
                        objmensaje.pic_Check.Visible = true;
                        objmensaje.Show();
                        LIMPIAR_DATOS();
                        CARGA_SACOS();
                        CARGA_TIPO_SACOS();
                        CARGA_UBICACIONES();
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Aceptar_Click");

            }
        }

        /*Metodo para eliminar informacion de la tabla Sacos, por medio de la instancia al metodo dentro de la 
         clase Inventario*/
        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {

                if (lbl_Codigo.Text == string.Empty)
                {
                    MessageBox.Show("Favor Seleccionar el Dato a Eliminar", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                else
                {


                    DialogResult dr = MessageBox.Show("Desea Eliminar el Saco: " + cbo_TipoSaco.Text + " ?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                    switch (dr)
                    {
                        case DialogResult.Yes:
                            objinventario.Codigo = Convert.ToInt32(lbl_Codigo.Text);
                            objinventario.DELETE_SACOS();
                            if (objinventario.Validacion == "Eliminado")
                            {
                                objBitacora.Usuario = lbl_Usuario.Text;
                                objBitacora.Accion = "Elimnado";
                                objBitacora.Formulario = "Inventario";
                                objBitacora.Descripcion = "Saco Eliminado " + lbl_Codigo.Text + " por " + lbl_Usuario.Text;
                                objBitacora.INSERT_BITACORA();
                                frm_Mensaje objmensaje = new frm_Mensaje();
                                objmensaje.lbl_Mensaje.Text = "Insertado";
                                objmensaje.pic_Check.Visible = true;
                                objmensaje.Show();
                                LIMPIAR_DATOS();
                                CARGA_SACOS();
                                CARGA_TIPO_SACOS();
                                CARGA_UBICACIONES();
                            }

                            break;
                        case DialogResult.No:
                            break;

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "btn_Eliminar_Click");

            }
        }

        /*Metodo para limpiar controladores dentro del formulario*/
        private void LIMPIAR_DATOS()
        {
            try
            {

                lbl_Codigo.Text = string.Empty;
                cbo_TipoSaco.Text = string.Empty;
                cbo_Ubicacion.Text = string.Empty;
       

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "LIMPIAR_DATOS()");


            }
        }


        /*Metodo que permite realizar la busuqeda de informacion, segun la instancia establecida a los metodos
         dentro de la clase Inventario*/
        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            try
            {

                if (rb_Saco.Checked == true)
                {
                    objinventario.TipoSaco = Convert.ToInt32(cbo_tiposacobusqueda.SelectedValue);
                    dgv_Inventario.DataSource = objinventario.BUSQUEDA_TIPODESACO().Tables[0];
                    dgv_CantidadUbicacion.DataSource = objinventario.BUSQUEDA_CANTIDAD_UBICACION().Tables[0];
                    dgv_CantidadUbicacion.Visible = true;
                    dgv_Sacos.Visible = false;
                    grb_Opciones.Text = "Cantidad de Saco " + cbo_tiposacobusqueda.SelectedText +" por Ubicaciones";

                }
                else if (rb_Ubicacion.Checked == true)
                {
                    objinventario.UbicacionUpdate = Convert.ToInt32(cbo_Ubicacionbusqueda.SelectedValue);
                    dgv_Inventario.DataSource = objinventario.BUSQUEDA_UBICACION().Tables[0];
                    dgv_Sacos.DataSource = objinventario.BUSQUEDA_CANTIDAD_TIPO_SACO().Tables[0];
                    dgv_CantidadUbicacion.Visible = false;
                    dgv_Sacos.Visible = true;
                    grb_Opciones.Text = "Cantidad de Sacos por "+cbo_Ubicacionbusqueda.SelectedText;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "btn_Buscar_Click");

            }

        }


        /*Metodo que permite pasar la informacion del datagridview a los controladores del formulario*/
        private void dgv_Inventario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dgv_Inventario.Rows[e.RowIndex];
                    cbo_Ubicacion.Text = row.Cells["Ubicacion"].Value.ToString();
                    cbo_TipoSaco.Text = row.Cells["TipodeSaco"].Value.ToString();
                    lbl_Codigo.Text = row.Cells["Id_Saco"].Value.ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "dgv_Inventario_CellContentClick");

            }
        }
    }
}
