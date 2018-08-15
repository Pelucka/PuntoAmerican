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
using Flujo_Contable.Ingresos;

namespace Flujo_Contable
{
    public partial class frm_Ingresos_Mes : Form
    {
        Gastos_e_Ingresos objingresos = new Gastos_e_Ingresos();
        usuarios objusuarios = new usuarios();
        int dir = 1;

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



        }

        /*Metodo para cagar la informacion obtenida del metodo de la clase, dentro del grafico, se muestra,
         Ingresos y gastos en general*/
        private void CARGA_INGRESOS_CHART()
        {
            try
            {

                cha_Ingresos.DataSource = objingresos.CARGA_LISTA_INGRESOS();
                cha_Ingresos.Series["Ingresos"].YValueMembers = "Ingreso";
                cha_Ingresos.Series["Ingresos"].XValueMember = "Ubicacion";
                cha_Ingresos.Series["Ingresos"].IsValueShownAsLabel = true;
                cha_Ingresos.DataBind();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "CARGA_INGRESOS_CHART()");
            }

        }


        /*Metodo para cargar la informacion de las ganancias, generales de todas las sucursales, por una instancia
         a la clase Gastos e Ingresos*/
        private void GANANCIA_UBICACIONES()
        {
            try
            {

                foreach (var series in cha_Ganancia.Series)
                {
                    series.Points.Clear();
                }

                for (int j = Convert.ToInt32(cbo_Ubicacion.Items.Count) - 1; j >= 0; j--)
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "GANANCIA_UBICACIONES()");
            }
        }

        /*Metodo para cargar la informacion de las ganancias, generales de todas las sucursales por mes, por una instancia
         a la clase Gastos e Ingresos*/
        private void GANANCIA_UBICACIONES_MES()
        {
            try
            {

                foreach (var series in cha_Ganancia.Series)
                {
                    series.Points.Clear();
                }

                for (int j = Convert.ToInt32(cbo_Ubicacion.Items.Count) - 1; j >= 0; j--)
                {
                    var Ubicacion = cbo_Ubicacion.GetItemText(cbo_Ubicacion.Items[j]);
                    objingresos.Ubicacion = Ubicacion;
                    objingresos.CARGA_INGRESOsTOTALES_UBICACION_MES();
                    objingresos.CARGA_GASTOSTOTALES_UBICACION_MES();
                    cha_Ganancia.Series["Ganancias"].Points.AddXY(Ubicacion, objingresos.Ganancia);
                    objingresos.GastoNuevo = "0";
                    objingresos.IngresoNuevo = "0";
                    objingresos.Ganancia = 0;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "GANANCIA_UBICACIONES_MES()");

            }
        }

        /*Metodo para cargar la informacion de las ganancias, generales de todas las sucursales por año, por una instancia
         a la clase Gastos e Ingresos*/
        private void GANANCIA_UBICACIONES_AÑO()
        {
            try
            {

                foreach (var series in cha_Ganancia.Series)
                {
                    series.Points.Clear();
                }

                for (int j = Convert.ToInt32(cbo_Ubicacion.Items.Count) - 1; j >= 0; j--)
                {
                    var Ubicacion = cbo_Ubicacion.GetItemText(cbo_Ubicacion.Items[j]);
                    objingresos.Ubicacion = Ubicacion;
                    objingresos.CARGA_INGRESOsTOTALES_UBICACION_AÑO();
                    objingresos.CARGA_GASTOSTOTALES_UBICACION_AÑO();
                    cha_Ganancia.Series["Ganancias"].Points.AddXY(Ubicacion, objingresos.Ganancia);
                    objingresos.GastoNuevo = "0";
                    objingresos.IngresoNuevo = "0";
                    objingresos.Ganancia = 0;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "GANANCIA_UBICACIONES_AÑO()");

            }
        }

        /*Metodo para cargar la informacion de las sucursales, por una instancia
         a la clase Usuarios*/
        private void CARGA_UBICACION()
        {
            try
            {

                DataSet ds;
                ds = objusuarios.CARGA_UBICACION();
                cbo_Ubicacion.DataSource = ds.Tables[0];
                cbo_Ubicacion.DisplayMember = ds.Tables[0].Columns["Descripcion"].ColumnName.ToString();
                cbo_Ubicacion.ValueMember = ds.Tables[0].Columns["Id_Ubicacion"].ColumnName.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "CARGA_UBICACION()");

            }
        }

        /*Metodo para cargar la informacion de los gastos, generales de todas las sucursales, por una instancia
         a la clase Gastos e Ingresos*/
        private void CARGA_GASTOS_CHART()
        {
            try
            {

                cha_Gastos.DataSource = objingresos.CARGA_LISTA_GASTOS();
                cha_Gastos.Series["Gastos"].YValueMembers = "Gastos";
                cha_Gastos.Series["Gastos"].XValueMember = "Ubicacion";
                cha_Gastos.Series["Gastos"].IsValueShownAsLabel = true;
                cha_Gastos.DataBind();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "CARGA_GASTOS_CHART()");

            }
        }

        /*Metodo para cargar la informacion de los ingresos, generales de todas las sucursales por mes, por una instancia
         a la clase Gastos e Ingresos*/
        private void CARGA_INGRESOS_MES()
        {
            try
            {

                objingresos.Mes = Convert.ToInt32(cbo_Mes.SelectedIndex) + 1;
                objingresos.Año = Convert.ToInt32(txt_Año.Text);
                cha_Ingresos.DataSource = objingresos.CARGA_INGRESO_MES();
                cha_Ingresos.Series["Ingresos"].YValueMembers = "Ingreso";
                cha_Ingresos.Series["Ingresos"].XValueMember = "Ubicacion";
                cha_Ingresos.Series["Ingresos"].IsValueShownAsLabel = true;
                cha_Ingresos.DataBind();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "CARGA_INGRESOS_MES()");

            }
        }

        /*Metodo para cargar la informacion de los ingresos, generales de todas las sucursales por año, por una instancia
         a la clase Gastos e Ingresos*/
        private void CARGA_INGRESOS_AÑO()
        {
            try
            {

                objingresos.Año = Convert.ToInt32(txt_Año.Text);
                cha_Ingresos.DataSource = objingresos.CARGA_INGRESO_AÑO();
                cha_Ingresos.Series["Ingresos"].YValueMembers = "Ingreso";
                cha_Ingresos.Series["Ingresos"].XValueMember = "Ubicacion";
                cha_Ingresos.Series["Ingresos"].IsValueShownAsLabel = true;
                cha_Ingresos.DataBind();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "CARGA_INGRESOS_AÑO()");

            }
        }

        /*Metodo para cargar la informacion de los gastos, generales de todas las sucursales por mes, por una instancia
         a la clase Gastos e Ingresos*/
        private void CARGA_GASTOS_MES()
        {
            try
            {

                objingresos.Mes = Convert.ToInt32(cbo_Mes.SelectedIndex) + 1;
                objingresos.Año = Convert.ToInt32(txt_Año.Text);
                cha_Gastos.DataSource = objingresos.CARGA_GASTO_MES();
                cha_Gastos.Series["Gastos"].YValueMembers = "Gastos";
                cha_Gastos.Series["Gastos"].XValueMember = "Ubicacion";
                cha_Gastos.Series["Gastos"].IsValueShownAsLabel = true;
                cha_Gastos.DataBind();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "CARGA_GASTOS_MES()");

            }
        }

        /*Metodo para cargar la informacion de los gastos, generales de todas las sucursales por año, por una instancia
         a la clase Gastos e Ingresos*/
        private void CARGA_GASTOS_AÑO()
        {
            try
            {

                objingresos.Año = Convert.ToInt32(txt_Año.Text);
                cha_Gastos.DataSource = objingresos.CARGA_GASTO_AÑO();
                cha_Gastos.Series["Gastos"].YValueMembers = "Gastos";
                cha_Gastos.Series["Gastos"].XValueMember = "Ubicacion";
                cha_Gastos.Series["Gastos"].IsValueShownAsLabel = true;
                cha_Gastos.DataBind();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "CARGA_GASTOS_AÑO()");

            }
        }


        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*Controladores eventos*/
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {

                if (rb_Mes.Checked == true)
                {
                    cbo_Mes.Visible = true;
                    txt_Año.Visible = true;
                    lbl_Mes.Visible = true;
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        /*Controladores eventos*/
        private void cbo_Ubicacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                rb_Ano.Visible = true;
                rb_Mes.Visible = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        /*Metodo que permite buscar la informacion, segun el metodo instanciado de la clase Gastos e Ingresos*/
        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            try
            {

                if (rb_Ano.Checked == false && rb_Mes.Checked == false)
                {
                    MessageBox.Show("Porfavor Seleccionar lo que se desea buscar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (rb_Mes.Checked == true)
                {

                    if (txt_Año.Text == string.Empty)
                    {
                        MessageBox.Show("Porfavor Seleccionar el Año a buscar para el Mes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                    {

                        CARGA_INGRESOS_MES();
                        CARGA_GASTOS_MES();
                        GANANCIA_UBICACIONES_MES();

                    }


                }
                else if (rb_Ano.Checked == true)
                {

                    CARGA_INGRESOS_AÑO();
                    CARGA_GASTOS_AÑO();
                    GANANCIA_UBICACIONES_AÑO();


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "btn_Buscar_Click");

            }


        }

        /*Controladores eventos*/
        private void rb_Ano_CheckedChanged(object sender, EventArgs e)
        {
            try
            {

                if (rb_Ano.Checked == true)
                {
                    txt_Año.Visible = true;
                    cbo_Mes.Visible = true;
                    lbl_Mes.Visible = true;
                    lbl_Ano.Visible = true;
                    cbo_Mes.Enabled = false;
                }
                else
                {
                    txt_Año.Visible = false;
                    cbo_Mes.Visible = false;
                    lbl_Mes.Visible = false;
                    lbl_Ano.Visible = false;
                    cbo_Mes.Enabled = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void pib_Top_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        /*Controladores eventos*/
        private void btn_Original_Click(object sender, EventArgs e)
        {
            CARGA_INGRESOS_CHART();
            CARGA_GASTOS_CHART();
            CARGA_UBICACION();
            GANANCIA_UBICACIONES();
            rb_Ano.Checked = false;
            rb_Mes.Checked = false;

        }

        /*Carga de Informacion en Graficos a nuevo formulario Ingresos*/
        private void cha_Ingresos_Click(object sender, EventArgs e)
        {
            try
            {
                frm_ListaIngresos ventana = new frm_ListaIngresos();
                ventana.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        /*Carga de Informacion en Graficos a nuevo formulario Gastos*/
        private void cha_Gastos_Click(object sender, EventArgs e)
        {
            try
            {

                frm_ListaGastos ventana = new frm_ListaGastos();
                ventana.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void txt_Año_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {

                if (char.IsNumber(e.KeyChar))
                {

                }
                else
                {
                    e.Handled = e.KeyChar != (char)Keys.Back;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
