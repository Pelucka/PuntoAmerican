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
    public partial class frm_ListaGastos : Form
    {
        Gastos_e_Ingresos objgastos = new Gastos_e_Ingresos();
        public frm_ListaGastos()
        {
            InitializeComponent();
        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /*Controladores eventos*/
        private void DESHABILITADOS()
        {
            cbo_Ubicacion.Enabled = false;
            cbo_TipoGasto.Enabled = false;
            dtp_Fecha.Enabled = false;
            dtp_Fecha2.Enabled = false;
        }

        /*Controladores eventos*/
        private void rb_Ubicacion_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rb_Ubicacion.Checked == true)
                {
                    cbo_Ubicacion.Enabled = true;
                }
                else
                {

                    DESHABILITADOS();

                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /*Controladores eventos*/
        private void rb_Fecha_CheckedChanged(object sender, EventArgs e)
        {
            try
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
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        /*Controladores eventos*/
        private void rb_TipoGasto_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rb_TipoGasto.Checked == true)
                {
                    cbo_TipoGasto.Enabled = true;
                }
                else
                {

                    DESHABILITADOS();

                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /*Metodo que permite cargar la informacion dentro del data gridview, por medio de instancia*/
        private void CARGA_GASTOS()
        {
            try
            {
                dgv_Gastos.DataSource = objgastos.CARGA_LISTA_GASTOS_TODO().Tables[0];
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        /*Controladores eventos*/
        private void frm_ListaGastos_Load(object sender, EventArgs e)
        {
            CARGA_GASTOS();
            CARGA_UBICACION();
        }

        /*Metodo que permite cargar la informacion dentro del combobox, por medio de instancia*/
        private void CARGA_UBICACION()
        {
            try
            {
                DataSet ds;
                ds = objgastos.CARGA_UBICACION();
                cbo_Ubicacion.DataSource = ds.Tables[0];
                cbo_Ubicacion.DisplayMember = ds.Tables[0].Columns["Descripcion"].ColumnName.ToString();
                cbo_Ubicacion.ValueMember = ds.Tables[0].Columns["Id_Ubicacion"].ColumnName.ToString();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /*Controladores eventos*/
        private void btn_Refrescar_Click(object sender, EventArgs e)
        {
            try
            {
                CARGA_GASTOS();
                DESHABILITADOS();
                rb_Fecha.Checked = false;
                rb_TipoGasto.Checked = false;
                rb_Ubicacion.Checked = false;
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        /*Evento que permite la busqueda segun el metodo instanciado de la clase Gastos e Ingresos*/
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
                        objgastos.Fechaini = dtp_Fecha.Value;
                        objgastos.Fechafin = dtp_Fecha2.Value;
                        dgv_Gastos.DataSource = objgastos.BUSQUEDA_GASTOS_FECHA().Tables[0];
                    }

                }
                else if (rb_TipoGasto.Checked == true)
                {
                    if (cbo_TipoGasto.Text == String.Empty)
                    {
                        MessageBox.Show("Favor Seleccionar el Tipo de Gasto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        objgastos.TipoGasto = cbo_TipoGasto.Text;
                        dgv_Gastos.DataSource = objgastos.BUSQUEDA_GASTOS_TIPOGASTO().Tables[0];
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
                        objgastos.Ubicacion2 = Convert.ToInt32(cbo_Ubicacion.SelectedValue);
                        dgv_Gastos.DataSource = objgastos.BUSQUEDA_GASTOS_UBICACION().Tables[0];
                    }
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
