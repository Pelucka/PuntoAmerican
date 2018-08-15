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
    public partial class frm_Formulario_Entrega : Form
    {
        Envios objenvi = new Envios();
        public frm_Formulario_Entrega()
        {
            InitializeComponent();
        }

        private void frm_Formulario_Entrega_Load(object sender, EventArgs e)
        {
            CARGAR_ENVIOS();
        }

        /*Metodo que carga dentro del datagridview todos los envios registrados de la sucursal actual*/
        private void CARGAR_ENVIOS()
        {
            try
            {
                objenvi.UbicacionLlegada = lb_Sucursal.Text;
                dgv_Entregas.DataSource = objenvi.ENVIOS_UBICACION().Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "CARGAR_ENVIOS()");


            }
        }

        /*Metodo para actualizar los datos de los entrega realizada, ESTADO Y FECHA*/
        private void ACTUALIZAR_ENTREGA()
        {
            try
            {

                int id = 0;
                int filaSeleccionada =
                     dgv_Entregas.Rows.GetRowCount(DataGridViewElementStates.Selected);
                if (filaSeleccionada == 1)
                {
                    foreach (DataGridViewRow rowPrincipal in dgv_Entregas.SelectedRows)
                    {
                        id = Convert.ToInt32(rowPrincipal.Cells["Id_Envio"].Value);

                    }


                    objenvi.Id = id;
                    objenvi.Estado = true;
                    objenvi.UPDATE_ENVIO();
                    if (objenvi.Validacion == "Actualizado")
                    {
                        MessageBox.Show("Entrega relizada", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CARGAR_ENVIOS();
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
                MessageBox.Show(ex.Message + "ACTUALIZAR_ENTREGA()");

            }


        }

        /*MEtodo para actualizar la ubicacion de los sacos, cambiando una vez se verifique la entrega*/
        private void ACTUALIZAR_SACOS()
        {

            try
            {

                string ids = "";
                int filaSeleccionada =
                     dgv_Entregas.Rows.GetRowCount(DataGridViewElementStates.Selected);
                if (filaSeleccionada == 1)
                {
                    foreach (DataGridViewRow rowPrincipal in dgv_Entregas.SelectedRows)
                    {
                        ids = Convert.ToString(rowPrincipal.Cells["Sacos"].Value).ToString();

                    }



                    try
                    {
                        string[] separadas;
                        separadas = ids.Split(',');
                        foreach (string i in separadas)
                        {

                            objenvi.Id = Convert.ToInt32(i);
                            objenvi.UbicacionLlegada = lb_Sucursal.Text;
                            objenvi.UPDATE_UBICACION_SACOS();

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error en Actualizar Sacos", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(ex.Message + "ACTUALIZAR_SACOS()");


            }
            
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            ACTUALIZAR_SACOS();
            ACTUALIZAR_ENTREGA();
        }

        /*Metodo para eliminar un envio que no se realizo correctamente*/
        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            try
            {

                ESTADO_TRUE();
                int id = 0;
                int filaSeleccionada =
                     dgv_Entregas.Rows.GetRowCount(DataGridViewElementStates.Selected);
                if (filaSeleccionada == 1)
                {
                    foreach (DataGridViewRow rowPrincipal in dgv_Entregas.SelectedRows)
                    {
                        id = Convert.ToInt32(rowPrincipal.Cells["Id_Envio"].Value);

                    }

                    objenvi.Id = id;
                    objenvi.DELETE_ENVIO();
                    if (objenvi.Validacion == "Eliminado")
                    {
                        MessageBox.Show("Entrega rechazada", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CARGAR_ENVIOS();
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
                MessageBox.Show(ex.Message + "btn_Cancelar_Click");
            }


        }

        /*Metodo para actualizar el estado de los sacos dentro de la BD*/
        private void ESTADO_TRUE()
        {
            try
            {

                string ids = "";
                int filaSeleccionada =
                     dgv_Entregas.Rows.GetRowCount(DataGridViewElementStates.Selected);
                if (filaSeleccionada == 1)
                {
                    foreach (DataGridViewRow rowPrincipal in dgv_Entregas.SelectedRows)
                    {
                        ids = Convert.ToString(rowPrincipal.Cells["Sacos"].Value).ToString();

                    }


                    try
                    {
                        string[] separadas;
                        separadas = ids.Split(',');
                        foreach (string i in separadas)
                        {

                            objenvi.Id = Convert.ToInt32(i);
                            objenvi.Estado = true;
                            objenvi.UPDATE_ESTADO_SACOS();

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error en Estado True", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(ex.Message + "ESTADO_TRUE()");


            }



        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
