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

namespace Flujo_Contable.Bodega
{
    public partial class frm_Articulos : Form
    {
        Articulos objarticulos = new Articulos();
        public frm_Articulos()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Articulo_Click(object sender, EventArgs e)
        {

            if (lbl_CodArticulo.Text == "Cod_Articulo")
            {
                objarticulos.Descripcion = txt_Descripcion.Text;
                objarticulos.Impuesto = Convert.ToInt32(cbo_Impuesto.SelectedValue);
                objarticulos.Precio = Convert.ToInt32(txt_Precio.Text);
                objarticulos.UnidadMedida = cbo_Medida.Text;
                objarticulos.Departamento = Convert.ToInt32(cbo_Departamento.SelectedValue);
                objarticulos.INSERT_ARTICULOS();
                if (objarticulos.Validacion == "Insertado")
                {
                    MessageBox.Show("Articulo Insertado", "Punto Americano", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CARGA_ARTICULOS();
                }
            }
            else
            {
                objarticulos.Descripcion = txt_Descripcion.Text;
                objarticulos.Impuesto = Convert.ToInt32(cbo_Impuesto.SelectedValue);
                objarticulos.Precio = Convert.ToInt32(txt_Precio.Text);
                objarticulos.UnidadMedida = cbo_Medida.Text;
                objarticulos.Codigo = Convert.ToInt32(lbl_CodArticulo.Text);
                objarticulos.Habilitar = Convert.ToBoolean(chk_Estado.Checked);
                objarticulos.Departamento = Convert.ToInt32(cbo_Departamento.SelectedValue);
                objarticulos.UPDATE_ARTICULOS();
                if (objarticulos.Validacion == "Actualizado")
                {
                    MessageBox.Show("Articulo Actualizado", "Punto Americano", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CARGA_ARTICULOS();
                }
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_Consecutivos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dgv_Articulos.Rows[e.RowIndex];
                    txt_Descripcion.Text = row.Cells["Descripcion"].Value.ToString();
                    cbo_Impuesto.SelectedValue = Convert.ToInt32(row.Cells["Impuesto"].Value.ToString());
                    txt_Precio.Text = row.Cells["Precio"].Value.ToString();
                    lbl_CodArticulo.Text = row.Cells["Cod_Articulo"].Value.ToString();
                    cbo_Medida.Text = row.Cells["Medida"].Value.ToString();
                    chk_Estado.Checked = Convert.ToBoolean(row.Cells["Activo"].Value.ToString());
                    chk_Estado.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frm_Articulos_Load(object sender, EventArgs e)
        {
            CARGA_ARTICULOS();
            CARGA_IMPUESTOS();
            CARGA_DEPARTAMENTO();

        }

        private void CARGA_ARTICULOS()
        {
            try
            {
                chk_Estado.Checked = true;
                chk_Estado.Enabled = false;
                lbl_CodArticulo.Text = "Cod_Articulo";
                Limpiar();
                CARGA_IMPUESTOS();
                dgv_Articulos.DataSource = objarticulos.CARGA_ARTICULOS().Tables[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "CARGA_ARTICULOS()");
            }
        }


        private void CARGA_IMPUESTOS()
        {
            try
            {

                DataSet ds;
                ds = objarticulos.CARGA_IMPUESTOS();
                cbo_Impuesto.DataSource = ds.Tables[0];
                cbo_Impuesto.DisplayMember = ds.Tables[0].Columns["Descripcion"].ColumnName.ToString();
                cbo_Impuesto.ValueMember = ds.Tables[0].Columns["Id_Impuesto"].ColumnName.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "CARGA_IMPUESTOS()");
            }
        }

        private void CARGA_DEPARTAMENTO()
        {
            try
            {

                DataSet ds;
                ds = objarticulos.CARGA_DEPARTAMENTO();
                cbo_Departamento.DataSource = ds.Tables[0];
                cbo_Departamento.DisplayMember = ds.Tables[0].Columns["Descripcion"].ColumnName.ToString();
                cbo_Departamento.ValueMember = ds.Tables[0].Columns["Departamento"].ColumnName.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "CARGA_DEPARTAMENTO()");
            }
        }

        private void Limpiar()
        {
            txt_Descripcion.Text = string.Empty;
            txt_Precio.Text = string.Empty;
            cbo_Medida.Text = string.Empty;
            cbo_Impuesto.Text = string.Empty;
        }

        

        private void cbo_Impuesto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_refrescar_Click(object sender, EventArgs e)
        {
            Limpiar();
            chk_Estado.Checked = true;
            chk_Estado.Enabled = false;
            lbl_CodArticulo.Text = "Cod_Articulo";
        }
    }
}
