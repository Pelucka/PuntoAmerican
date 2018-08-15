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
    public partial class frm_Ingresos_Mes : Form
    {
        Gastos_e_Ingresos objingresos = new Gastos_e_Ingresos();
        Usuarios objusuarios = new Usuarios();

        public frm_Ingresos_Mes()
        {
            InitializeComponent();
        }

        private void frm_Ingresos_Mes_Load(object sender, EventArgs e)
        {
            lbl_AnoHoy.Text = DateTime.Now.Year.ToString();
            CARGA_INGRESOS_CHART();
            CARGA_GASTOS_CHART();
            CARGA_UBICACION();
            GANANCIA_UBICACIONES();
            pib_Top.SendToBack();

        }
        private void CARGA_INGRESOS_CHART()
        {
            cha_Ingresos.DataSource = objingresos.CARGA_LISTA_INGRESOS();
            cha_Ingresos.Series["Ingresos"].YValueMembers = "Ingreso";
            cha_Ingresos.Series["Ingresos"].XValueMember = "Ubicacion";
            cha_Ingresos.Series["Ingresos"].IsValueShownAsLabel = true;
            cha_Ingresos.DataBind();


            
        }

        private void GANANCIA_UBICACIONES()
        {
                for (int j = Convert.ToInt32(cbo_Ubicacion.Items.Count)-1; j >= 0; j--)
                {
                    var Ubicacion = cbo_Ubicacion.GetItemText(cbo_Ubicacion.Items[j]);
                    objingresos.Ubicacion = Ubicacion;
                    objingresos.CARGA_INGRESO_UBICACION();
                    objingresos.CARGA_GASTOS_UBICACION();
                    cha_Ganancia.Series["Ganancias"].Points.AddXY(Ubicacion, objingresos.Ganancia);
                    objingresos.GastoNuevo = "0";
                    objingresos.IngresoNuevo = "0";
                    objingresos.Ganancia = 0;
                }
                
            


        }


        private void CARGA_UBICACION()
        {
            DataSet ds;
            ds = objusuarios.CARGA_UBICACION();
            cbo_Ubicacion.DataSource = ds.Tables[0];
            cbo_Ubicacion.DisplayMember = ds.Tables[0].Columns["Descripcion"].ColumnName.ToString();
            cbo_Ubicacion.ValueMember = ds.Tables[0].Columns["Id_Ubicacion"].ColumnName.ToString();
        }

        private void CARGA_GASTOS_CHART()
        {
            cha_Gastos.DataSource = objingresos.CARGA_LISTA_GASTOS();
            cha_Gastos.Series["Gastos"].YValueMembers = "Gastos";
            cha_Gastos.Series["Gastos"].XValueMember = "Ubicacion";
            cha_Gastos.Series["Gastos"].IsValueShownAsLabel = true;
            cha_Gastos.DataBind();
        }



        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(rb_Mes.Checked ==true)
            {
                cbo_Mes.Visible = true;
                txt_Año.Visible = false;
                lbl_Mes.Visible = true;
            }     
            else
            {
                txt_Año.Visible = false;
                cbo_Mes.Visible = false;
                lbl_Mes.Visible = false;
                lbl_Ano.Visible = false;
            }
        }

        private void cbo_Ubicacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            rb_Ano.Visible = true;
            rb_Mes.Visible = true;
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(""+cbo_Ubicacion.SelectedValue.ToString());
            
        }

        private void rb_Ano_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_Ano.Checked == true)
            {
                txt_Año.Visible = true;
                cbo_Mes.Visible = false;
                lbl_Ano.Visible = true;
            }
            else
            {
                txt_Año.Visible = false;
                cbo_Mes.Visible = false;
                lbl_Mes.Visible = false;
                lbl_Ano.Visible = false;
            }
        }

        private void pib_Top_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
