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

namespace Flujo_Contable.Ajustes
{
    public partial class frm_Formulario_de_Envio : Form
    {
        Envios objenvio = new Envios();
        Otrosn objotros = new Otrosn();
        Inventario objinven = new Inventario();


        public frm_Formulario_de_Envio()
        {
            InitializeComponent();
        }

        private void frm_Formulario_de_Envio_Load(object sender, EventArgs e)
        {
            CARGA_INVENTARIO();
            CARGAR_UBICACIONES_ENVIO();
        }

        /*Se obtiene la lista de los sacos que se encuentran dentro de la sucursal, se obtiene por medio
         del metodo establecido dentro de la clase Envios*/
        private void CARGA_INVENTARIO()
        {
            try
            {
                objenvio.Descripcion = lb_Sucursal.Text;
                objenvio.ID_UBICACION();
                int id = objenvio.Id;
                objenvio.Ubicacion = id;
                dgv_Inventario.DataSource = objenvio.BUSQUEDA_UBICACION().Tables[0];

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + "CARGA_INVENTARIO()");

            }

        }



        /*Se ingresan los datos requeridos dentro de la tabla Envios, pasando por parametro los datos 
         utlizados en los metodos declarados en la clase Envios*/
        private void btn_Enviar_Click(object sender, EventArgs e)
        {
            try
            {
                #region Validaciones
                if (txt_Nombre.Text == string.Empty)
                {
                    MessageBox.Show("Favor Ingresar un Nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_Nombre.Focus();
                    return;
                }
                else if (msk_Cedula.Text == string.Empty)
                {
                    MessageBox.Show("Favor Ingresar la cedula del conductor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    msk_Cedula.Focus();
                    return;
                }
                else if (txt_Placa.Text == string.Empty)
                {
                    MessageBox.Show("Favor Ingresar la Placa del Vehículo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_Placa.Focus();
                    return;
                }
                else if (txt_Descripcion.Text == string.Empty)
                {
                    MessageBox.Show("Favor Ingresar una descripcion del envio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_Descripcion.Focus();
                    return;
                }

                else if (cbo_Sucursales.Text == string.Empty)
                {
                    MessageBox.Show("Favor Ingresar una Ubicacion Correcta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cbo_Sucursales.Focus();
                    return;
                }
                else if (dgv_InventarioEnvio.Rows.Count == 1)
                {
                    MessageBox.Show("Favor Seleccionar los sacos a enviar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_Nombre.Focus();
                    return;
                }
                #endregion

                objenvio.Usuario = lb_Usuario.Text;
                objenvio.Nombre = txt_Nombre.Text;
                objenvio.Cedula = msk_Cedula.Text;
                objenvio.Placa = txt_Placa.Text;
                objenvio.UbicacionSalida = lb_Sucursal.Text;
                objenvio.UbicacionLlegada = cbo_Sucursales.Text;
                objenvio.Cantidad = dgv_InventarioEnvio.Rows.Count - 1;
                objenvio.Sacos = txt_Prueba.Text;
                objenvio.Descripcion = txt_Descripcion.Text;
                objenvio.Estado = false;
                objenvio.INSERT_ENVIO();


                if (objenvio.Validacion == "Insertado")
                {
                    MessageBox.Show("Envio Registrado Correctamente", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ACTUALIZAR_SACOS();
                    LIMPIAR_DATOS();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "btn_Enviar_Click");

            }



        }

        /*Se actualiza el estado de los sacos segun el envio realizado, instanciando metodo desde la clase*/
        private void ACTUALIZAR_SACOS()
        {

            try
            {
                string[] id_sacos;
                id_sacos = txt_Prueba.Text.Split(',');
                foreach (string i in id_sacos)
                {

                    objenvio.Id = Convert.ToInt32(i);
                    objenvio.Estado = false;
                    objenvio.UPDATE_ESTADO_SACOS();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en Actualizar Sacos", "Informacion",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /*Metodo para limpiar los datos del formulario*/
        private void LIMPIAR_DATOS()
        {
            try
            {
                txt_Nombre.Text = String.Empty;
                msk_Cedula.Text = String.Empty;
                txt_Placa.Text = String.Empty;
                txt_Descripcion.Text = String.Empty;
                cbo_Sucursales.Text = String.Empty;
                txt_Prueba.Text = String.Empty;
                CARGA_INVENTARIO();
                dgv_InventarioEnvio.Rows.Clear();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + "LIMPIAR_DATOS()");

            }
        }


        /*Metodo que permite cargar en combobox las sucursales registradas, instancia desde metodos de la clase*/
        private void CARGAR_UBICACIONES_ENVIO()
        {
            try
            {
                DataSet ds;
                ds = objotros.CARGA_LISTA_UBICACION_ALL();
                cbo_Sucursales.DataSource = ds.Tables[0];
                cbo_Sucursales.DisplayMember = ds.Tables[0].Columns["Descripcion"].ColumnName.ToString();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + "CARGAR_UBICACIONES_ENVIO()");

            }


        }

        /*Metodo que permite agregar en el datagridview a enviar los sacos que se tienen dentro de la sucursal*/
        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            try
            {

                int filaSeleccionada =
                     dgv_Inventario.Rows.GetRowCount(DataGridViewElementStates.Selected);
                if (filaSeleccionada == 1)
                {
                    foreach (DataGridViewRow rowPrincipal in dgv_Inventario.SelectedRows)
                    {

                        // Creamos un array con los valores que vamos a insertar
                        // en el segundo control DataGridView.

                        object[] values = {
                                                  rowPrincipal.Cells["Id_Saco"].Value,
                                                  rowPrincipal.Cells["Descripcion"].Value,
                                                  rowPrincipal.Cells["Ubicacion"].Value,
                                                  rowPrincipal.Cells["Login"].Value,
                                                  rowPrincipal.Cells["Fecha"].Value,
                                                  rowPrincipal.Cells["TipodeSaco"].Value};

                        // Creamos un nuevo objeto DataGridViewRow.

                        DataGridViewRow row = new DataGridViewRow();

                        // Creamos las celdas y las rellenamos con los valores existentes
                        // en el array.

                        row.CreateCells(dgv_InventarioEnvio, values);

                        // Añadimos la nueva fila al segundo control DataGridView.

                        txt_Prueba.Text = (Convert.ToString(rowPrincipal.Cells["Id_Saco"].Value).ToString() + "," + Convert.ToString(txt_Prueba.Text));

                        dgv_InventarioEnvio.Rows.Add(row);
                        dgv_Inventario.Rows.Remove(dgv_Inventario.CurrentRow);


                    }
                }
                else
                {

                    MessageBox.Show("Seleccione solo un producto.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button1);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "btn_Agregar_Click");

            }

        }

        /*Metodo que permite quitar algun saco que ha sido seleccionado*/
        private void btn_Quitar_Click(object sender, EventArgs e)
        {

            try
            {

               
                    foreach (DataGridViewRow rowPrincipal in dgv_InventarioEnvio.SelectedRows)
                    {

                        // Creamos un array con los valores que vamos a insertar
                        // en el segundo control DataGridView.

                        object[] values = {
                                                  rowPrincipal.Cells["Id_Saco1"].Value,
                                                  rowPrincipal.Cells["Descripcion1"].Value,
                                                  rowPrincipal.Cells["Ubicacion1"].Value,
                                                  rowPrincipal.Cells["Login1"].Value,
                                                  rowPrincipal.Cells["Fecha1"].Value,
                                                  rowPrincipal.Cells["TipodeSaco1"].Value};

                        // Creamos un nuevo objeto DataGridViewRow.



                        // Creamos las celdas y las rellenamos con los valores existentes
                        // en el array.



                        // Añadimos la nueva fila al segundo control DataGridView.

                        txt_Prueba.Text = Convert.ToString(rowPrincipal.Cells["Id_Saco1"].Value).ToString();



                        dgv_InventarioEnvio.Rows.Remove(dgv_InventarioEnvio.CurrentRow);

                        CARGA_INVENTARIO();
                    }
               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "btn_Quitar_Click");


            }

        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            LIMPIAR_DATOS();
        }

        private void txt_Nombre_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void msk_Cedula_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void msk_Cedula_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void msk_Cedula_KeyPress(object sender, KeyPressEventArgs e)
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
