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

namespace Flujo_Contable
{
    public partial class frm_Bitacora : Form
    {
        Bitacora objbitacora = new Bitacora();

        public frm_Bitacora()
        {
            InitializeComponent();
        }

        private void frm_Bitacora_Load(object sender, EventArgs e)
        {
            this.CARGA_BITACORA();
            this.CARGA_UBICACION();
        }


        public void CARGA_BITACORA()
        {
            try
            {
                dgv_Bitacora.DataSource = objbitacora.CARGA_BITACORA().Tables[0];
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CARGA_UBICACION()
        {
            try
            {
                DataSet ds;
                ds = objbitacora.CARGA_UBICACION();
                cbo_Ubicacion.DataSource = ds.Tables[0];
                cbo_Ubicacion.DisplayMember = ds.Tables[0].Columns["Descripcion"].ColumnName.ToString();
                cbo_Ubicacion.ValueMember = ds.Tables[0].Columns["Id_Ubicacion"].ColumnName.ToString();
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*Controladores eventos*/
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            try
            {

                if (rb_Fecha.Checked)
                {
                    dtp_fechafin.Enabled = true;
                    dtp_Fechaini.Enabled = true;
                    txt_Busqueda.Enabled = false;
                    txt_Busqueda.Text = "0";
                    cbo_Ubicacion.Enabled = false;
                    txt_Busqueda.Enabled = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        /*Controladores eventos*/
        private void rb_Nombre_CheckedChanged(object sender, EventArgs e)
        {
            try
            {

                if (rb_Nombre.Checked)
                {
                    dtp_fechafin.Enabled = false;
                    dtp_Fechaini.Enabled = false;
                    txt_Busqueda.Enabled = true;
                    txt_Busqueda.Text = string.Empty;
                    cbo_Ubicacion.Enabled = false;
                    cbo_Ubicacion.SendToBack();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        /*Controladores eventos*/
        private void rb_Codigo_CheckedChanged(object sender, EventArgs e)
        {
            try
            {

                if (rb_Ubicacion.Checked)
                {
                    dtp_fechafin.Enabled = false;
                    dtp_Fechaini.Enabled = false;
                    txt_Busqueda.Enabled = false;
                    cbo_Ubicacion.Enabled = true;
                    txt_Busqueda.Text = string.Empty;
                    txt_Busqueda.Text = "0";
                    txt_Busqueda.SendToBack();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        /*Metodo que permite buscar informacion segun el metodo instanciado*/
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            try
            {

                if (txt_Busqueda.Text == string.Empty)
                {
                    MessageBox.Show("Favor Ingresar un Dato para buscar", "Error Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    if(rb_Ubicacion.Checked == true)
                    {
                        objbitacora.Ubicacion = Convert.ToInt32( cbo_Ubicacion.SelectedValue);
                        dgv_Bitacora.DataSource = objbitacora.BUSQUEDA_UBICACION().Tables[0];
                    }
                    else if (rb_Nombre.Checked == true)
                    {
                        objbitacora.Usuario = txt_Busqueda.Text;
                        dgv_Bitacora.DataSource = objbitacora.BUSQUEDA_USUARIO().Tables[0];

                    }
                    else if (rb_Fecha.Checked == true)
                    {
                        objbitacora.fechaini = dtp_Fechaini.Value;
                        objbitacora.fechafin = dtp_fechafin.Value;
                        dgv_Bitacora.DataSource = objbitacora.BUSQUEDA_FECHA().Tables[0];

                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "btn_buscar_Click");

            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            this.CARGA_BITACORA();
            this.CARGA_UBICACION();
            dtp_fechafin.Enabled = false;
            dtp_Fechaini.Enabled = false;
            txt_Busqueda.Enabled = false;
            cbo_Ubicacion.Enabled = false;
            txt_Busqueda.Text = string.Empty;
            txt_Busqueda.Text = "0";
            txt_Busqueda.SendToBack();
            rb_Fecha.Checked = false;
            rb_Nombre.Checked = false;
            rb_Ubicacion.Checked = false;
        }
    }
}
