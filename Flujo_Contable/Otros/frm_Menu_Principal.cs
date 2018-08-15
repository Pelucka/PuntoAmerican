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
using Flujo_Contable.Ajustes;
using Flujo_Contable.Otros;
using Flujo_Contable.Usuarios;
using System.Diagnostics;
using System.IO;
using Flujo_Contable.Bodega;

namespace Flujo_Contable
{
    public partial class frm_Menu_Principal : Form
    {
        Bitacora objBitacora = new Bitacora();
        Otrosn objOtros = new Otrosn();
        public frm_Menu_Principal()
        {
            InitializeComponent();
        }



        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        /*Consulta para el cerrar sesion*/
        private void reiniciarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                DialogResult dialogResult = MessageBox.Show("Desea Reiniciar Sesion ?", "Validacion de Datos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    objBitacora.Usuario = tsl_Usuario.Text;
                    objBitacora.Accion = "Cerrar Sesion";
                    objBitacora.Formulario = "Menu Principal";
                    objBitacora.Descripcion = "Cerro Sesion";
                    objBitacora.INSERT_BITACORA();
                    Application.Restart();

                }
                else if (dialogResult == DialogResult.No)
                {

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void informacionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Creador: Bryan Vargas Monge                                                                           Versión: 1.0                                                                                                       Correo: Bryvmonge@gmail.com", "Informacion de Creador", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        /*Metodo que permite realizar una busqueda de roles, para saber los modulos a los cuales tiene accesso
         el usuario, por medio de una instancia a la clase Otros*/
        private void BUSQUEDA_DE_ROLES()
        {
            try
            {

                objOtros.Login = tsl_Usuario.Text;
                objOtros.CARGA_LISTA_ROLES_USUARIO();

                btn_Caja.Enabled = objOtros.Caja;
                btn_ControlCaja.Enabled = objOtros.Control;
                btn_Inventario.Enabled = objOtros.Inventario;
                btn_Usuarios.Enabled = objOtros.Usuarios;
                btn_Ventas.Enabled = objOtros.IngresosyGastos;
                tsmi_Ajustes.Enabled = objOtros.Ajustes;
                tsmi_Administracion.Enabled = objOtros.Admin;
                tsmi_Traslados.Enabled = objOtros.Traslados;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }




        /*Se obtiene fecha y hora actual*/
        private void tm_Hora_Tick(object sender, EventArgs e)
        {
            try
            {

                tsl_Hora.Text = DateTime.Now.ToLongTimeString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /*Controladores enventos*/
        private void frm_Menu_Principal_Load(object sender, EventArgs e)
        {

            try
            {

                tm_Hora.Start();
                this.Hora();
                BUSQUEDA_DE_ROLES();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /*Se obtiene la hora actual*/
        private void Hora()
        {
            try
            {

                tsl_Fecha.Text = DateTime.Now.ToShortDateString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tsl_Ubicacion_Click(object sender, EventArgs e)
        {

        }

        /*Cambio de formulario y paso de informacion a controladores*/
        private void btn_Usuarios_Click(object sender, EventArgs e)
        {
            try
            {

                frm_Usuarios ventana = new frm_Usuarios();
                ventana.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void informacionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        /*Cambio de formulario y paso de informacion a controladores*/
        private void btn_Caja_Click(object sender, EventArgs e)
        {
            try
            {

                frm_Caja ventana = new frm_Caja();
                ventana.lbl_Ubicacion.Text = tsl_Ubicacion.Text;
                ventana.lbl_Usuario.Text = tsl_Usuario.Text;
                ventana.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /*Cambio de formulario y paso de informacion a controladores*/
        private void btn_Inventario_Click(object sender, EventArgs e)
        {
            try
            {

                frm_Menu_Inventario ventana = new frm_Menu_Inventario();
                ventana.lbl_Ubicacion.Text = tsl_Ubicacion.Text;
                ventana.lbl_Usuario.Text = tsl_Usuario.Text;
                ventana.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        /*Cambio de formulario y paso de informacion a controladores*/
        private void btn_Bitacora_Click(object sender, EventArgs e)
        {
            try
            {

                frm_Bitacora ventana = new frm_Bitacora();
                ventana.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /*Cambio de formulario y paso de informacion a controladores*/
        private void btn_Ventas_Click(object sender, EventArgs e)
        {
            try
            {

                frm_Ingresos_Mes ventana = new frm_Ingresos_Mes();
                ventana.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /*Cambio de formulario y paso de informacion a controladores*/
        private void btn_ControlCaja_Click(object sender, EventArgs e)
        {
            try
            {

                frm_MenuControlCaja ventana = new frm_MenuControlCaja();
                ventana.lbl_Usuario.Text = tsl_Usuario.Text;
                ventana.lbl_Ubicacion.Text = tsl_Ubicacion.Text;
                ventana.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }



        /*Cambio de formulario y paso de informacion a controladores*/
        private void btn_Errores_Click(object sender, EventArgs e)
        {
            try
            {
                frm_Errores ventana = new frm_Errores();
                ventana.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        /*Cambio de formulario y paso de informacion a controladores*/
        private void erroresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                frm_Errores ventana = new frm_Errores();
                ventana.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /*Cambio de formulario y paso de informacion a controladores*/
        private void rolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                frm_Roles ventana = new frm_Roles();
                ventana.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /*Cambio de formulario y paso de informacion a controladores*/
        private void ubicacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                frm_Ubicaciones ventana = new frm_Ubicaciones();
                ventana.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /*Cambio de formulario y paso de informacion a controladores*/
        private void tipoSacoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frm_Tipo_de_Saco ventana = new frm_Tipo_de_Saco();
                ventana.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /*Cambio de formulario y paso de informacion a controladores*/
        private void bitacoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                frm_Bitacora ventana = new frm_Bitacora();
                ventana.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void toolStripStatusLabel4_Click(object sender, EventArgs e)
        {

        }

        /*Cambio de formulario y paso de informacion a controladores*/
        private void gastosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                frm_Gastos ventana = new frm_Gastos();
                ventana.lbl_Ubicacion.Text = tsl_Ubicacion.Text;
                ventana.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /*Cambio de formulario y paso de informacion a controladores*/
        private void departamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                frm_Departamentos ventana = new frm_Departamentos();
                ventana.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        /*Cambio de formulario y paso de informacion a controladores*/
        private void enviosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            try
            {

                frm_Formulario_de_Envio envio = new frm_Formulario_de_Envio();
                envio.lb_Sucursal.Text = tsl_Ubicacion.Text;
                envio.lb_Usuario.Text = tsl_Usuario.Text;
                envio.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /*Cambio de formulario y paso de informacion a controladores*/
        private void recibidosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {

                frm_Formulario_Entrega envio = new frm_Formulario_Entrega();
                envio.lb_Sucursal.Text = tsl_Ubicacion.Text;
                envio.lb_Usuario.Text = tsl_Usuario.Text;
                envio.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /*Cambio de formulario y paso de informacion a controladores*/
        private void cambioContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                frm_CambioContraseña ventana = new frm_CambioContraseña();
                ventana.lbl_Usuario.Text = tsl_Usuario.Text;
                ventana.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /*Cambio de formulario y paso de informacion a controladores*/
        private void btn_Ventas_Click_1(object sender, EventArgs e)
        {
            try
            {

                frm_Ingresos_Mes ventana = new frm_Ingresos_Mes();
                ventana.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /*Cambio de formulario y paso de informacion a controladores*/
        private void btn_ControlCaja_Click_1(object sender, EventArgs e)
        {
            try
            {

                frm_MenuControlCaja ventana = new frm_MenuControlCaja();
                ventana.lbl_Usuario.Text = tsl_Usuario.Text;
                ventana.lbl_Ubicacion.Text = tsl_Ubicacion.Text;
                ventana.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /*Cambio de formulario y paso de informacion a controladores*/
        private void btn_Caja_Click_1(object sender, EventArgs e)
        {
            try
            {

                frm_Caja ventana = new frm_Caja();
                ventana.lbl_Ubicacion.Text = tsl_Ubicacion.Text;
                ventana.lbl_Usuario.Text = tsl_Usuario.Text;
                ventana.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /*Cambio de formulario y paso de informacion a controladores*/
        private void btn_Usuarios_Click_2(object sender, EventArgs e)
        {
            try
            {

                frm_Usuarios ventana = new frm_Usuarios();
                ventana.lbl_UsuarioLog.Text = tsl_Usuario.Text;
                ventana.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        /*Cambio de formulario y paso de informacion a controladores*/
        private void btn_Inventario_Click_2(object sender, EventArgs e)
        {
            try
            {
                frm_Menu_Inventario ventana = new frm_Menu_Inventario();
                ventana.lbl_Ubicacion.Text = tsl_Ubicacion.Text;
                ventana.lbl_Usuario.Text = tsl_Usuario.Text;                
                ventana.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /*Cambio de formulario y paso de informacion a controladores*/
        private void btn_ControlCaja_Click_2(object sender, EventArgs e)
        {
            try
            {

                frm_MenuControlCaja ventana = new frm_MenuControlCaja();
                ventana.lbl_Usuario.Text = tsl_Usuario.Text;
                ventana.lbl_Ubicacion.Text = tsl_Ubicacion.Text;
                ventana.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /*Cambio de formulario y paso de informacion a controladores*/
        private void btn_Caja_Click_2(object sender, EventArgs e)
        {
            try
            {

                frm_Caja ventana = new frm_Caja();
                ventana.lbl_Ubicacion.Text = tsl_Ubicacion.Text;
                ventana.lbl_Usuario.Text = tsl_Usuario.Text;
                ventana.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        /*Cambio de formulario y paso de informacion a controladores*/
        private void btn_Ventas_Click_2(object sender, EventArgs e)
        {
            try
            {

                frm_Ingresos_Mes ventana = new frm_Ingresos_Mes();
                ventana.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void salirToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            objBitacora.Usuario = tsl_Usuario.Text;
            objBitacora.Accion = "Cerro Sesion";
            objBitacora.Formulario = "Menu Principal";
            objBitacora.Descripcion = "Salida de la Aplicacion";
            objBitacora.INSERT_BITACORA();
            Application.Exit();
            Application.ExitThread();

        }

        private void manualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string wordPath = Path.Combine(Application.StartupPath,"Recursos\\Manual de Usuario.docx");
            Process.Start(wordPath);
        }

        private void articulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Articulos ventana = new frm_Articulos();
            ventana.Show();
        }
    }

}
