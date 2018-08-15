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

namespace Flujo_Contable.Clientes
{
    public partial class frm_Clientes : Form
    {
        clientes objclientes = new clientes();
        Otrosn objotros = new Otrosn();

        int CodigoUbicacion = 0;
        public BLL.Caja objcaja { get; set; }

        private string myval;
        public string Myval
        {
            get { return myval; }
            set { myval = value; }
        }

        public frm_Clientes()
        {
            InitializeComponent();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbo_Identificacion_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
        }

        private void btn_Identificador_Click(object sender, EventArgs e)
        {
            if (msk_Consulta.Text == string.Empty)
            {
                MessageBox.Show("Favor Agregar la Idenficicacion a Consultar");
            }
            else
            {
                objclientes.Tipo = 2;
                objclientes.Identificacion = Convert.ToDecimal(msk_Consulta.Text);
                dgv_Clientes.DataSource = objclientes.BUSQUEDA_CLIENTE().Tables[0];
            }
            
        }

        private void btn_Telefono_Click(object sender, EventArgs e)
        {
            if(msk_Consulta.Text == string.Empty)
            {
                MessageBox.Show("Favor Agregar el Numero a Consultar");
            }
            else
            {
                objclientes.Tipo = 1;
                objclientes.Identificacion = Convert.ToDecimal(msk_Consulta.Text);
                dgv_Clientes.DataSource = objclientes.BUSQUEDA_CLIENTE().Tables[0];
            }
            
        }

        private void btn_Refrescar_Click(object sender, EventArgs e)
        {
            btn_Agregar.Enabled = true;
            grb_DatosCliente.Enabled = true;
            cbo_Identificacion.Text = string.Empty;
            btn_Identificador.Enabled = true;
            btn_Telefono.Enabled = true;
            msk_Consulta.Text = string.Empty;
            txt_Correo.Text = string.Empty;
            msk_Identificacion.Text = string.Empty;
            txt_Nombre.Text = string.Empty;
            msk_Telefono.Text = string.Empty;
            btn_Telefono.Enabled = false;
            btn_Identificador.Enabled = false;
        }

        private void cbo_Identificacion_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbo_Identificacion.Text == "Telefono")
            {
                btn_Identificador.Enabled = false;
                btn_Telefono.Enabled = true;
                msk_Consulta.Enabled = true;

            }
            else if (cbo_Identificacion.Text != "Telefono")
            {
                btn_Identificador.Enabled = true;
                btn_Telefono.Enabled = false;
                msk_Consulta.Enabled = true;

            }
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            objclientes.Nombre = txt_Nombre.Text;
            objclientes.Telefono = Convert.ToInt32(msk_Telefono.Text.Replace("-",string.Empty));
            objclientes.Identificacion = Convert.ToDecimal(msk_Identificacion.Text.Replace("-",string.Empty));
            objclientes.Correo = txt_Correo.Text;
            objclientes.TipoIdentificacion =  Convert.ToInt32(cbo_Identif.SelectedValue);
            objotros.Provincia = Convert.ToInt32(cbo_Provincia.SelectedValue);
            objotros.Canton = Convert.ToInt32(cbo_Canton.SelectedValue);
            objotros.Distrito = Convert.ToInt32(cbo_Distrito.SelectedValue);
            objotros.Barrio = Convert.ToInt32(cbo_Barrio.SelectedValue);
            objotros.SELECT_CODIGO_DE_UBICACION();
            CodigoUbicacion = objotros.CodigoUbicacion;
            objclientes.CodigoUbicacion = CodigoUbicacion;
            objclientes.DescUbicacion = txt_UbicacionExacta.Text;
            objclientes.INSERT_CLIENTES();
            if(objclientes.Validacion == "Insertado")
            {
                MessageBox.Show("Cliente Insertado");
            }

        }

        private void frm_Clientes_Load(object sender, EventArgs e)
        {
            CARGA_TIPO_IDENTIFICACION();
            CARGA_UBICACION();
        }

        public string SendText
        {
            get
            {
                return txt_Nombre.Text;
            }
        }

        private void dgv_Clientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dgv_Clientes.Rows[e.RowIndex];
                    cbo_Identif.SelectedValue = row.Cells["Tipo_Identificacion"].Value;
                    String palabrafinal = string.Empty;
                    msk_Identificacion.Text = row.Cells["Identificacion"].Value.ToString();                                    
                    txt_Nombre.Text = row.Cells["Nombre"].Value.ToString();
                    txt_Correo.Text = row.Cells["Correo"].Value.ToString();
                    msk_Telefono.Text = row.Cells["Telefono"].Value.ToString();
                    lbl_IDCliente.Text = row.Cells["Id_Cliente"].Value.ToString();
                    

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "dgv_Clientes Error CellContentClick");

            }
        }
        private void CARGA_TIPO_IDENTIFICACION()
        {
            try
            {

                DataSet ds;
                ds = objclientes.CARGA_TIPO_IDENTIFICACION();
                cbo_Identif.DataSource = ds.Tables[0];
                cbo_Identif.DisplayMember = ds.Tables[0].Columns["Descripcion"].ColumnName.ToString();
                cbo_Identif.ValueMember = ds.Tables[0].Columns["Id_Identificacion"].ColumnName.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "CARGA_ROL()");
            }
        }

        private void btn_Seleccionar_Click(object sender, EventArgs e)
        {
            Myval = lbl_IDCliente.Text;

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

        private void cbo_Barrio_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txt_UbicacionExacta.Enabled = true;
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
    }
}
