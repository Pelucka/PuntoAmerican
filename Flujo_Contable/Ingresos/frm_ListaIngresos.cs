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

namespace Flujo_Contable.Ingresos
{
    public partial class frm_ListaIngresos : Form
    {
        Gastos_e_Ingresos objIngresos = new Gastos_e_Ingresos();
        public frm_ListaIngresos()
        {
            InitializeComponent();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*Controladores eventos*/
        private void DESHABILITADOS()
        {
            cbo_Ubicacion.Enabled = false;
            cbo_TipoPago.Enabled = false;
            dtp_Fecha.Enabled = false;
            dtp_Fecha2.Enabled = false;
        }

        /*Controladores eventos*/
        private void rb_Ubicacion_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_Ubicacion.Checked == true)
            {
                cbo_Ubicacion.Enabled = true;
            }
            else
            {
                DESHABILITADOS();
            }
        }

        /*Controladores eventos*/
        private void rb_Fecha_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_Fecha.Checked == true)
            {
                dtp_Fecha.Enabled = true;
                dtp_Fecha2.Enabled = true;
            }
            else
            {
                DESHABILITADOS();
            }
        }

        /*Controladores eventos*/
        private void rb_TipoPago_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_TipoPago.Checked == true)
            {
                cbo_TipoPago.Enabled = true;
            }
            else
            {
                DESHABILITADOS();
            }
        }

        /*Metodo que permite cargar la informacion dentro del datagridview obtenida por instancia a metodo*/
        private void CARGA_INGRESOS()
        {
            try
            {
                dgv_Ingresos.DataSource = objIngresos.CARGA_LISTA_INGRESOS_TODO().Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void frm_ListaIngresos_Load(object sender, EventArgs e)
        {
            CARGA_INGRESOS();
            CARGA_UBICACION();
        }

        /*Carga de infomacion en combobox por medio de instancia*/
        private void CARGA_UBICACION()
        {
            try
            {
                DataSet ds;
                ds = objIngresos.CARGA_UBICACION();
                cbo_Ubicacion.DataSource = ds.Tables[0];
                cbo_Ubicacion.DisplayMember = ds.Tables[0].Columns["Descripcion"].ColumnName.ToString();
                cbo_Ubicacion.ValueMember = ds.Tables[0].Columns["Id_Ubicacion"].ColumnName.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /*Controladores eventos*/
        private void btn_Refrescar_Click(object sender, EventArgs e)
        {
            DESHABILITADOS();
            rb_Fecha.Checked = false;
            rb_TipoPago.Checked = false;
            rb_Ubicacion.Checked = false;
            CARGA_INGRESOS();
        }

        /*Metodo que permite realizar busqueda segun la instancia establecida y metodo llamado*/
        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (rb_Fecha.Checked == true)
                {
                    if (dtp_Fecha.Text == string.Empty)
                    {
                        MessageBox.Show("Favor Seleccionar la Fecha", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        objIngresos.Fechaini = dtp_Fecha.Value;
                        objIngresos.Fechafin = dtp_Fecha2.Value;
                        dgv_Ingresos.DataSource = objIngresos.BUSQUEDA_INGRESOS_FECHA().Tables[0];
                    }

                }
                else if (rb_TipoPago.Checked == true)
                {
                    if (cbo_TipoPago.Text == String.Empty)
                    {
                        MessageBox.Show("Favor Seleccionar el Tipo de Pago", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        objIngresos.TipoGasto = cbo_TipoPago.Text;
                        dgv_Ingresos.DataSource = objIngresos.BUSQUEDA_INGRESOS_TIPOPAGO().Tables[0];
                    }
                }
                else if (rb_Ubicacion.Checked == true)
                {
                    if (cbo_Ubicacion.Text == string.Empty)
                    {
                        MessageBox.Show("Favor Seleccionar la Ubicación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        objIngresos.Ubicacion2 = Convert.ToInt32(cbo_Ubicacion.SelectedValue);
                        dgv_Ingresos.DataSource = objIngresos.BUSQUEDA_INGRESOS_UBICACION().Tables[0];
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
