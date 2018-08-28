using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using BLL;
using Flujo_Contable.Otros;
using Flujo_Contable.Clientes;
using System.Xml;
using Flujo_Contable.Caja.Factura;
using BLL.FacturaElect;

namespace Flujo_Contable
{
    public partial class frm_IngresoCaja : Form
    {
        string Numero = string.Empty;
        frm_Clientes objclientes = new frm_Clientes();
        BLL.Caja cj = new BLL.Caja();
        Bitacora objBitacora = new Bitacora();
        Firma objfirma = new Firma();
        CrecionXML objCreaXML = new CrecionXML();
        string Clave = string.Empty;
        int idventa = 0;

        public frm_IngresoCaja()
        {
            InitializeComponent();
            
            lbl_ValidarEliminar.Text = "0";
        }




        /*Metodo para ingresar informacion a la tabla Ventas y Ventas Totales, por medio de la instancia a un metodo
         dentro de la clase Caja*/
        private void btn_Pagar_Click(object sender, EventArgs e)
        {
            objCreaXML.MediodePago = cbo_MediodePago.SelectedValue.ToString();
            objCreaXML.CondificionVenta = cbo_CondiciondeVenta.SelectedValue.ToString();
            objCreaXML.Ubicacion = lbl_Ubicacion.Text;
            objCreaXML.Clientes = Convert.ToInt32(lbl_IdCliente.Text);
            objCreaXML.SELECT_DATOS_XML();
            objCreaXML.SELECT_DATOS_XML_RECEPTOR();
            objCreaXML.SELECT_DATOS_XML_TRAIDOS();
            objCreaXML.SELECT_FECHA();
            objCreaXML.SELECT_SUCURSAL();
            objCreaXML.SELECT_SECUENCIA();
            objCreaXML.CREAR_COD_SEGURIDAD();
            CREAR_XML();
            objCreaXML.FechaFull = Convert.ToDateTime( objCreaXML.Año + "-" + objCreaXML.Mes + "-" + objCreaXML.Dia + " " + objCreaXML.Fecha);
            objCreaXML.DineroTotal = lbl_DineroaPagar.Text;
            objCreaXML.Login = lbl_Usuario.Text;
            objCreaXML.INSERT_VENTATOTALES();
            if(objCreaXML.Validacion =="Insertado")
            {
                int valor = 0;
                valor = dgv_Consecutivos.Rows.Count;
                for (int i = 0; i < valor; i++)
                {
                    objCreaXML.Descripcion = dgv_Consecutivos.Rows[i].Cells[1].Value.ToString();
                    objCreaXML.Descuento = dgv_Consecutivos.Rows[i].Cells[5].Value.ToString();
                    objCreaXML.Cantidad = dgv_Consecutivos.Rows[i].Cells[2].Value.ToString();
                    objCreaXML.Precio = dgv_Consecutivos.Rows[i].Cells[3].Value.ToString();
                    objCreaXML.Total = dgv_Consecutivos.Rows[i].Cells[7].Value.ToString();
                    objCreaXML.Cod_Articulo = dgv_Consecutivos.Rows[i].Cells[8].Value.ToString();
                    objCreaXML.Id_VentaTotal = objCreaXML.Secuencia;
                    objCreaXML.INSERT_VENTAS();

                }
                try
                {
                    objCreaXML.qweasd = Convert.ToInt32( objCreaXML.Id_VentaTotal);
                    

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "CARGA_FACTURA()");
                }
                
                objCreaXML.UPDATE_SECUENCIA();
                valor = 0;
                if(objCreaXML.Validacion == "Actualizado")
                {
                    string Clave = "fe-" + "506" + objCreaXML.Diafin + objCreaXML.Mesfin + objCreaXML.Añofin + objCreaXML.Cedulafin + objCreaXML.Consecutivofin + "00001" + "01" + objCreaXML.Secuenciafin + "1" + objCreaXML.CodSeguridad;
                    string Clave2 = "506" + objCreaXML.Diafin + objCreaXML.Mesfin + objCreaXML.Añofin + objCreaXML.Cedulafin + objCreaXML.Consecutivofin + "00001" + "01" + objCreaXML.Secuenciafin + "1" + objCreaXML.CodSeguridad;
                    //--AQUI VA EL FIRMADOR DEL CERTIFICADO--//
                    this.FIRMADOR(Clave,objCreaXML.Certificado);
                    objCreaXML.Secuencia = Convert.ToString(Convert.ToInt32(objCreaXML.Secuencia) + 1);
                    //--AQUI TERMINA EL FIRMADOR DEL CERTIFICADO--//
                    //--AQUI VA EL INICIO DE ENVIO A HACIENDA--//

                    XmlDocument xmlElectronica = new XmlDocument();
                    //xmlElectronica.Load("D:\\Documents\\Facturas\\" + Clave + "firmado.xml");
                    xmlElectronica.Load("D:\\Proyectos\\PuntoAmerican\\Ejemplos_Factura\\" + Clave + "firmado.xml");
                    Emisor myEmisor = new Emisor();
                    myEmisor.numeroIdentificacion = objCreaXML.Cedula;
                    myEmisor.TipoIdentificacion = objCreaXML.TipoIdentificacionfin;

                    Receptor myReceptor = new Receptor();
                    if ((objCreaXML.Tipo_IdentificacionRE.Trim().Length > 0))
                    {
                        myReceptor.sinReceptor = false;
                        myReceptor.numeroIdentificacion = objCreaXML.CedulaRE;
                        myReceptor.TipoIdentificacion = objCreaXML.TipoIdentificacionfinRE;
                    }
                    else
                    {
                        myReceptor.sinReceptor = true;
                    }

                    Recepcion myRecepcion = new Recepcion();
                    myRecepcion.emisor = myEmisor;
                    myRecepcion.receptor = myReceptor;

                    myRecepcion.clave = Clave2;
                    myRecepcion.fecha = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:sszzz");
                    myRecepcion.comprobanteXml = Funciones.EncodeStrToBase64(xmlElectronica.OuterXml);

                    xmlElectronica = null;

                    string Token = "";
                    Token = getToken();
                    Comunicacion enviaFactura = new Comunicacion();
                    enviaFactura.EnvioDatos(Token, myRecepcion);


                    string jsonEnvio = "";
                    jsonEnvio = enviaFactura.jsonEnvio;
                    string jsonRespuesta = "";
                    jsonRespuesta = enviaFactura.jsonRespuesta;
                    System.IO.StreamWriter outputFile = new System.IO.StreamWriter("D:\\Proyectos\\PuntoAmerican\\Ejemplos_Factura\\" + Clave + "_03_jsonEnvio.txt");
                    outputFile.Write(jsonEnvio);
                    outputFile.Close();
                    outputFile = new System.IO.StreamWriter("D:\\Proyectos\\PuntoAmerican\\Ejemplos_Factura\\" + Clave + "_04_jsonRespuesta.txt");
                    outputFile.Write(jsonRespuesta);
                    outputFile.Close();
                    if (!(enviaFactura.xmlRespuesta == null))
                    {
                        enviaFactura.xmlRespuesta.Save("D:\\Proyectos\\PuntoAmerican\\Ejemplos_Factura\\" + Clave + "_05_RESP.xml");
                    }
                    else
                    {
                        outputFile = new System.IO.StreamWriter("D:\\Proyectos\\PuntoAmerican\\Ejemplos_Factura\\" + Clave + "_05_RESP_SinRespuesta.txt");
                        outputFile.Write("");
                        outputFile.Close();

                    }
                    MessageBox.Show(enviaFactura.mensajeRespuesta);


                    //--AQUI TERMINA EL ENVIO A HACIENDA--//
                    objCreaXML.Año= string.Empty;
                    objCreaXML.Mes = string.Empty;
                    objCreaXML.Mesfin = string.Empty;
                    objCreaXML.Dia = string.Empty;
                    objCreaXML.Diafin = string.Empty;
                    objCreaXML.Ubicacion = string.Empty;
                    objCreaXML.Consecutivo = string.Empty;
                    objCreaXML.Consecutivofin = string.Empty;
                    objCreaXML.Secuencia = string.Empty;
                    objCreaXML.Secuenciafin = string.Empty;
                    objCreaXML.CodSeguridad = string.Empty;
                    objCreaXML.Fecha = string.Empty;
                    objCreaXML.Fechafin = string.Empty;
                    objCreaXML.Añofin = string.Empty;
                    objCreaXML.Nombre = string.Empty;
                    objCreaXML.Tipo_Identificacion = string.Empty;
                    objCreaXML.Cedula = string.Empty;
                    objCreaXML.Provincia = string.Empty;
                    objCreaXML.Canton = string.Empty;
                    objCreaXML.Distrito = string.Empty;
                    objCreaXML.Barrio = string.Empty;
                    objCreaXML.Desv_Ubica = string.Empty;
                    objCreaXML.Telefono = string.Empty;
                    objCreaXML.TipoIdentificacionfin = string.Empty;
                    objCreaXML.Cedulafin = string.Empty;
                    objCreaXML.Provinciafin = string.Empty;
                    objCreaXML.Cantonfin = string.Empty;
                    objCreaXML.Distritofin = string.Empty;
                    objCreaXML.Barriofin = string.Empty;
                    objCreaXML.NombreRE = string.Empty;
                    objCreaXML.CedulaRE = string.Empty;
                    objCreaXML.ProvinciaRE = string.Empty;
                    objCreaXML.CantonRE = string.Empty;
                    objCreaXML.DistritoRE = string.Empty;
                    objCreaXML.BarrioRE = string.Empty;
                    objCreaXML.Desv_UbicaRE = string.Empty;
                    objCreaXML.TelefonoRE = string.Empty;
                    objCreaXML.TipoIdentificacionfinRE = string.Empty;
                    objCreaXML.CedulafinRE = string.Empty;
                    objCreaXML.ProvinciafinRE = string.Empty;
                    objCreaXML.CantonfinRE = string.Empty;
                    objCreaXML.DistritofinRE = string.Empty;
                    objCreaXML.BarriofinRE = string.Empty;
                    objCreaXML.CorreoRE = string.Empty;
                    objCreaXML.Clientes = 0;
                    objCreaXML.CondificionVenta = string.Empty;
                    objCreaXML.CondicionVentafin = string.Empty;
                    objCreaXML.MediodePago = string.Empty;
                    objCreaXML.MediodePagofin = string.Empty;
                    objCreaXML.FechaFull = Convert.ToDateTime(null);
                    objCreaXML.DineroTotal = string.Empty;
                    objCreaXML.Login = string.Empty;
                    objCreaXML.Validacion = string.Empty;
                    dgv_Consecutivos.Rows.Clear();
                    lbl_DineroaPagar.Text = "0";
                    lbl_IdCliente.Text = string.Empty;
                    MessageBox.Show("Factura Hecha Satisfactoriamente");

                    



                }
            }

            CARGA_COD_FACTURA();


        }

        private void button13_Click(object sender, EventArgs e)
        {
            try
            {

                frm_Apartados ventana = new frm_Apartados();
                ventana.lbl_Ubicacion.Text = lbl_Ubicacion.Text;
                ventana.lbl_Usuario.Text = lbl_Usuario.Text;
                ventana.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /*Metodo para obtener acumulados de la informacion correspondiente a la venta realizada*/
        public void PRECIO_FINAL()
        {
            try
            {

                int A = 0, B = 0;
                string C = "", D = "";
                for (A = 0; A < dgv_Consecutivos.Rows.Count; A++)
                {
                    B += Convert.ToInt32(dgv_Consecutivos.Rows[A].Cells[7].Value);
                    C += (Convert.ToString(dgv_Consecutivos.Rows[A].Cells[1].Value).ToString()) + "\n";
                    D += (Convert.ToString(dgv_Consecutivos.Rows[A].Cells[7].Value).ToString()) + "\n";
                }
                lbl_DineroaPagar.Text = Convert.ToString(B);
                lb_Articulos.Text = C;
                lb_Montos.Text = D;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "PRECIO_FINAL()");

            }
        }

        /*Boton con informacion para agregar dentro del datagridview*/
        

        /*Boton con informacion para agregar dentro del datagridview*/
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                dgv_Consecutivos.Rows.Clear();
                lbl_DineroaPagar.Text = "0";
                lbl_IdCliente.Text = string.Empty;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        /*Metodo para elminar fila seleccionada con datos dentro del datagridview, relizando las modificaciones
         correpondientes a la venta*/
        private void btn_EliminarCelda_Click(object sender, EventArgs e)
        {
            try
            {

                if (lbl_ValidarEliminar.Text == "1")
                {
                    lbl_DineroaPagar.Text = (Convert.ToInt32(lbl_DineroaPagar.Text) - Convert.ToInt32(Numero)).ToString();
                    int rowIndex = dgv_Consecutivos.CurrentCell.RowIndex;
                    dgv_Consecutivos.Rows.RemoveAt(rowIndex);
                    lbl_ValidarEliminar.Text = "0";
                }
                else
                {
                    MessageBox.Show("Favor seleccionar el dinero a eliminar", "Error de Seleccion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "btn_EliminarCelda_Click");

            }


        }


        /*Metodo para la seleccion de filas de datos a eliminar*/
        private void dgv_Caja_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (dgv_Consecutivos.GetCellCount(DataGridViewElementStates.Selected) == 1)
                {
                    lbl_ValidarEliminar.Text = "1";
                    Numero = dgv_Consecutivos.Rows[e.RowIndex].Cells[5].Value.ToString();
                }
                else
                {
                    MessageBox.Show("Favor seleccionar el Dato a eliminar", "Error de Eliminacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "dgv_Caja_CellContentClick");

            }

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void txt_ClientePago_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_ClientePago_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_PrecioOtros_KeyPress(object sender, KeyPressEventArgs e)
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

        /*Metodo para abrir calculadora de escritorio*/
        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {

                Process.Start("Calc");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /*Metodo para editar filas dentro del datagridview*/
        private void dgv_Consecutivos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int cod;
            int codf;
            try
            {
               cod = Convert.ToInt32(dgv_Consecutivos.Rows[e.RowIndex].Cells[2].Value) * Convert.ToInt32(dgv_Consecutivos.Rows[e.RowIndex].Cells[3].Value);
                codf = cod - Convert.ToInt32(dgv_Consecutivos.Rows[e.RowIndex].Cells[5].Value);

                dgv_Consecutivos.Rows[e.RowIndex].Cells[7].Value = codf;
                PRECIO_FINAL();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "dgv_Consecutivos_CellEndEdit");

            }
        }

        /*Boton con informacion para agregar dentro del datagridview*/
       

        private void frm_IngresoCaja_Load(object sender, EventArgs e)
        {
           
            //CARGA_COD_FACTURA();
            CARGA_MEDIO_DE_PAGO();
            CARGA_CONDICION_VENTA();
            CARGA_ARTICULOS();
            CARGA_DEPARTAMENTOS();

        }

        /*Metodo para obtener segun metodo en clase Caja el numero de factura*/
        private void CARGA_COD_FACTURA()
        {
            try
            {

                cj.Ubicacion = lbl_Ubicacion.Text;
                cj.CARGA_CODFACTURA();

                using (frm_Factura ventana = new frm_Factura(cj.CodigoFinalFactura))
                {
                    ventana.ShowDialog();
                }
               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "CARGA_COD_FACTURA()");

            }
        }
        private void CARGA_ARTICULOS()
        {
            try
            {

                DataSet ds;
                ds = cj.CARGA_ARTICULOS();
                cbo_Articulo.DataSource = ds.Tables[0];
                cbo_Articulo.DisplayMember = ds.Tables[0].Columns["Descripcion"].ColumnName.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "CARGA_ARTICULOS()");
            }
        }
        private void CARGA_DEPARTAMENTOS()
        {
            try
            {

                DataSet ds;
                ds = cj.CARGA_DEPARTAMENTOS();
                cbo_Departamento.DataSource = ds.Tables[0];
                cbo_Departamento.DisplayMember = ds.Tables[0].Columns["Descripcion"].ColumnName.ToString();
                cbo_Departamento.ValueMember = ds.Tables[0].Columns["Departamento"].ColumnName.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "CARGA_DEPARTAMENTOS()");
            }
        }
        private void CARGA_MEDIO_DE_PAGO()
        {
            try
            {

                DataSet ds;
                ds = cj.CARGA_MEDIO_DE_PAGO();
                cbo_MediodePago.DataSource = ds.Tables[0];
                cbo_MediodePago.DisplayMember = ds.Tables[0].Columns["Descripcion"].ColumnName.ToString();
                cbo_MediodePago.ValueMember = ds.Tables[0].Columns["Cod_MedioPago"].ColumnName.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "CARGA_ROL()");
            }
        }

        private void CARGA_CONDICION_VENTA()
        {
            try
            {

                DataSet ds;
                ds = cj.CARGA_CONDICIONVENTA();
                cbo_CondiciondeVenta.DataSource = ds.Tables[0];
                cbo_CondiciondeVenta.DisplayMember = ds.Tables[0].Columns["Descripcion"].ColumnName.ToString();
                cbo_CondiciondeVenta.ValueMember = ds.Tables[0].Columns["Id_Condicion"].ColumnName.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "CARGA_ROL()");
            }
        }



        /*Boton con informacion para agregar dentro del datagridview*/
        

        /*Valores de controladores segun la seleccion de los mismos*/
       

        /*Valores de controladores segun la seleccion de los mismos*/
       

        /*Valores de controladores segun la seleccion de los mismos*/
       


        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*Valores de controladores segun la seleccion de los mismos*/

        /*Valores de controladores segun la seleccion de los mismos*/


        private void txt_CantidadOtros_KeyPress(object sender, KeyPressEventArgs e)
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

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void btn_Gastos_Click(object sender, EventArgs e)
        {
            frm_Gastos ventana = new frm_Gastos();
            ventana.Show();
        }

        private void btn_Clientes_Click(object sender, EventArgs e)
        {
            frm_Clientes ventana = new frm_Clientes();
            if (ventana.ShowDialog() == DialogResult.OK)
            {
                lbl_IdCliente.Text = ventana.Myval;
            }
        }

        private void rb_Articulo_CheckedChanged(object sender, EventArgs e)
        {
            cbo_Departamento.Enabled = false;
            cbo_Articulo.Enabled = true;

        }

        private void rb_Departamento_CheckedChanged(object sender, EventArgs e)
        {
            cbo_Articulo.Enabled = false;
            cbo_Departamento.Enabled = true;
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            if(cbo_Departamento.Enabled == true)
            {
                cj.Departamento = cbo_Departamento.Text;
                dgv_ListadeProductos.DataSource = cj.BUSQUEDA_DEPARTAMENTO().Tables[0];

            }
            else if (cbo_Articulo.Enabled == true)
            {
                cj.Articulos = cbo_Articulo.Text;
                dgv_ListadeProductos.DataSource = cj.BUSQUEDA_ARTICULOS().Tables[0];

            }
            else
            {
                MessageBox.Show("Debe de Elegir la Busqueda a Indicar");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dgv_ListadeProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int n = dgv_Consecutivos.Rows.Add();
                DataGridViewRow row = this.dgv_ListadeProductos.Rows[e.RowIndex];
                if(Convert.ToString(row.Cells["Descripcion_d"].Value) == "Casa y Cama")
                {
                    dgv_Consecutivos.Rows[n].Cells[1].Value = row.Cells["Descripcion"].Value;
                    dgv_Consecutivos.Rows[n].Cells[2].Value = 1;
                    dgv_Consecutivos.Rows[n].Cells[3].Value = row.Cells["Precio_1"].Value;
                    dgv_Consecutivos.Rows[n].Cells[5].Value = 0;
                    dgv_Consecutivos.Rows[n].Cells[6].Value = row.Cells["Impuesto"].Value;
                    dgv_Consecutivos.Rows[n].Cells[7].Value = Convert.ToInt32(dgv_Consecutivos.Rows[n].Cells[3].Value.ToString()) * Convert.ToInt32(dgv_Consecutivos.Rows[n].Cells[2].Value.ToString());
                    dgv_Consecutivos.Rows[n].Cells[8].Value = row.Cells["Cod_Articulo"].Value;
                    dgv_Consecutivos.Rows[n].Cells[9].Value = row.Cells["Unidad_Medida"].Value;
                    dgv_Consecutivos.Rows[n].Cells[3].ReadOnly = false;
                    PRECIO_FINAL();
                }
                else if (Convert.ToString(row.Cells["Descripcion_d"].Value) == "Articulos Varios")
                {
                    dgv_Consecutivos.Rows[n].Cells[1].Value = row.Cells["Descripcion"].Value;
                    dgv_Consecutivos.Rows[n].Cells[2].Value = 1;
                    dgv_Consecutivos.Rows[n].Cells[3].Value = row.Cells["Precio_1"].Value;
                    dgv_Consecutivos.Rows[n].Cells[5].Value = 0;
                    dgv_Consecutivos.Rows[n].Cells[6].Value = row.Cells["Impuesto"].Value;
                    dgv_Consecutivos.Rows[n].Cells[7].Value = Convert.ToInt32(dgv_Consecutivos.Rows[n].Cells[3].Value.ToString()) * Convert.ToInt32(dgv_Consecutivos.Rows[n].Cells[2].Value.ToString());
                    dgv_Consecutivos.Rows[n].Cells[8].Value = row.Cells["Cod_Articulo"].Value;
                    dgv_Consecutivos.Rows[n].Cells[9].Value = row.Cells["Unidad_Medida"].Value;
                    dgv_Consecutivos.Rows[n].Cells[3].ReadOnly = false;
                    dgv_Consecutivos.Rows[n].Cells[1].ReadOnly = false;
                    PRECIO_FINAL();
                }
                else
                {
                    dgv_Consecutivos.Rows[n].Cells[1].Value = row.Cells["Descripcion"].Value;
                    dgv_Consecutivos.Rows[n].Cells[2].Value = 1;
                    dgv_Consecutivos.Rows[n].Cells[3].Value = row.Cells["Precio_1"].Value;
                    dgv_Consecutivos.Rows[n].Cells[5].Value = 0;
                    dgv_Consecutivos.Rows[n].Cells[6].Value = row.Cells["Impuesto"].Value;
                    dgv_Consecutivos.Rows[n].Cells[7].Value = Convert.ToInt32(dgv_Consecutivos.Rows[n].Cells[3].Value.ToString()) * Convert.ToInt32(dgv_Consecutivos.Rows[n].Cells[2].Value.ToString());
                    dgv_Consecutivos.Rows[n].Cells[8].Value = row.Cells["Cod_Articulo"].Value;
                    dgv_Consecutivos.Rows[n].Cells[9].Value = row.Cells["Unidad_Medida"].Value;
                    PRECIO_FINAL();
                }
                
            }





     

            
        }

        public void CREAR_XML()
        {
            int valor = 0;

            XmlDocument doc = new XmlDocument();
            XmlNode docNode = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
            doc.AppendChild(docNode);
            XmlElement fe = doc.CreateElement("FacturaElectronica");
            fe.SetAttribute("xmlns", "https://tribunet.hacienda.go.cr/docs/esquemas/2017/v4.2/facturaElectronica");
            fe.SetAttribute("xmlns:ds", "http://www.w3.org/2000/09/xmldsig#");
            fe.SetAttribute("xmlns:vc", "http://www.w3.org/2007/XMLSchema-versioning");
            fe.SetAttribute("xmlns:xs", "http://www.w3.org/2001/XMLSchema");
            XmlElement clave = doc.CreateElement("Clave");
            clave.InnerText = "506" + objCreaXML.Diafin + objCreaXML.Mesfin + objCreaXML.Añofin + objCreaXML.Cedulafin + objCreaXML.Consecutivofin + "00001" + "01" + objCreaXML.Secuenciafin + "1" + objCreaXML.CodSeguridad;
            Clave = clave.InnerText;
            fe.AppendChild(clave);
            XmlElement NumeroConsecutivo = doc.CreateElement("NumeroConsecutivo");
            NumeroConsecutivo.InnerText = objCreaXML.Consecutivofin + "00001" + "01" + objCreaXML.Secuenciafin;
            fe.AppendChild(NumeroConsecutivo);
            XmlElement FechaEmision = doc.CreateElement("FechaEmision");
            FechaEmision.InnerText = objCreaXML.Año + "-" + objCreaXML.Mesfin + "-" + objCreaXML.Diafin + "T" + objCreaXML.Fecha;
            fe.AppendChild(FechaEmision);
            //---EMISOR--//
            XmlElement Emisor = doc.CreateElement("Emisor");

            XmlElement Nombre = doc.CreateElement("Nombre");
            Nombre.InnerText = objCreaXML.Nombre;
            Emisor.AppendChild(Nombre);
            XmlElement Identificacion = doc.CreateElement("Identificacion");
            XmlElement Tipo = doc.CreateElement("Tipo");
            Tipo.InnerText = objCreaXML.TipoIdentificacionfin;
            Identificacion.AppendChild(Tipo);
            XmlElement Numero = doc.CreateElement("Numero");
            Numero.InnerText = objCreaXML.Cedula;
            Identificacion.AppendChild(Numero);
            Emisor.AppendChild(Identificacion);
            Emisor.AppendChild(Identificacion);

            XmlElement Ubicacion = doc.CreateElement("Ubicacion");
            XmlElement Provincia = doc.CreateElement("Provincia");
            Provincia.InnerText = objCreaXML.Provincia;
            Ubicacion.AppendChild(Provincia);
            XmlElement Canton = doc.CreateElement("Canton");
            Canton.InnerText = objCreaXML.Cantonfin;
            Ubicacion.AppendChild(Canton);
            XmlElement Distrito = doc.CreateElement("Distrito");
            Distrito.InnerText = objCreaXML.Distritofin;
            Ubicacion.AppendChild(Distrito);
            XmlElement Barrio = doc.CreateElement("Barrio");
            Barrio.InnerText = objCreaXML.Barriofin;
            Ubicacion.AppendChild(Barrio);
            XmlElement OtrasSenas = doc.CreateElement("OtrasSenas");
            OtrasSenas.InnerText = objCreaXML.Desv_Ubica;
            Ubicacion.AppendChild(OtrasSenas);
            Emisor.AppendChild(Ubicacion);

            XmlElement Telefono = doc.CreateElement("Telefono");
            XmlElement CodigoPais = doc.CreateElement("CodigoPais");
            CodigoPais.InnerText = "506";
            Telefono.AppendChild(CodigoPais);
            XmlElement NumTelefono = doc.CreateElement("NumTelefono");
            NumTelefono.InnerText = objCreaXML.Telefono;
            Telefono.AppendChild(NumTelefono);
            Emisor.AppendChild(Telefono);

            XmlElement CorreoElectronico = doc.CreateElement("CorreoElectronico");
            CorreoElectronico.InnerText = "puntoamericano@gmail.com";
            Emisor.AppendChild(CorreoElectronico);

            fe.AppendChild(Emisor);
            //--FINEMISOR--//
            //--RECEPTOR--//
            XmlElement Receptor = doc.CreateElement("Receptor");
            XmlElement NombreRe = doc.CreateElement("Nombre");
            NombreRe.InnerText = objCreaXML.NombreRE;
            Receptor.AppendChild(NombreRe);

            XmlElement IdentificacionRe = doc.CreateElement("Identificacion");
            XmlElement TipoRE = doc.CreateElement("Tipo");
            TipoRE.InnerText = objCreaXML.TipoIdentificacionfinRE;
            IdentificacionRe.AppendChild(TipoRE);
            XmlElement NumeroRE = doc.CreateElement("Numero");
            NumeroRE.InnerText = objCreaXML.CedulaRE;
            IdentificacionRe.AppendChild(NumeroRE);
            Receptor.AppendChild(IdentificacionRe);

            XmlElement UbicacionRE = doc.CreateElement("Ubicacion");
            XmlElement ProvinciaRE = doc.CreateElement("Provincia");
            ProvinciaRE.InnerText = objCreaXML.Provincia;
            UbicacionRE.AppendChild(ProvinciaRE);
            XmlElement CantonRE = doc.CreateElement("Canton");
            CantonRE.InnerText = objCreaXML.CantonfinRE;
            UbicacionRE.AppendChild(CantonRE);
            XmlElement DistritoRE = doc.CreateElement("Distrito");
            DistritoRE.InnerText = objCreaXML.DistritofinRE;
            UbicacionRE.AppendChild(DistritoRE);
            XmlElement BarrioRE = doc.CreateElement("Barrio");
            BarrioRE.InnerText = objCreaXML.BarriofinRE;
            UbicacionRE.AppendChild(BarrioRE);
            XmlElement OtrasSenasRE = doc.CreateElement("OtrasSenas");
            OtrasSenasRE.InnerText = objCreaXML.Desv_UbicaRE;
            UbicacionRE.AppendChild(OtrasSenasRE);
            Receptor.AppendChild(UbicacionRE);

            XmlElement TelefonoRE = doc.CreateElement("Telefono");
            XmlElement CodigoPaisRE = doc.CreateElement("CodigoPais");
            CodigoPaisRE.InnerText = "506";
            TelefonoRE.AppendChild(CodigoPaisRE);
            XmlElement NumTelefonoRE = doc.CreateElement("NumTelefono");
            NumTelefonoRE.InnerText = objCreaXML.TelefonoRE;
            TelefonoRE.AppendChild(NumTelefonoRE);
            Receptor.AppendChild(TelefonoRE);

            XmlElement CorreoElectronicoRE = doc.CreateElement("CorreoElectronico");
            CorreoElectronicoRE.InnerText = objCreaXML.CorreoRE;
            Receptor.AppendChild(CorreoElectronicoRE);

            fe.AppendChild(Receptor);
            //--FINRECEPTOR--//
            //--CONDICIONVENTA--//
            XmlElement CondicionVenta = doc.CreateElement("CondicionVenta");
            CondicionVenta.InnerText = objCreaXML.CondicionVentafin;
            fe.AppendChild(CondicionVenta);
            //--FINCONDIFICIONVENTA--//
            //--MEDIOPAGO--//
            XmlElement MedioPago = doc.CreateElement("MedioPago");
            MedioPago.InnerText = objCreaXML.MediodePagofin;
            fe.AppendChild(MedioPago);
            //--FINMEDIOPAGO--//
            //--DETALLESERVICIO--//
            XmlElement DetalleServicio = doc.CreateElement("DetalleServicio");

            valor = dgv_Consecutivos.Rows.Count;
            for (int i = 0; i < valor; i++)
            {
                XmlElement LineaDetalle = doc.CreateElement("LineaDetalle");
                    XmlElement NumeroLinea = doc.CreateElement("NumeroLinea");
                    NumeroLinea.InnerText = Convert.ToString(i + 1);   
                    LineaDetalle.AppendChild(NumeroLinea);
                    XmlElement Codigo = doc.CreateElement("Codigo");
                        XmlElement TipoLD = doc.CreateElement("Tipo");
                        TipoLD.InnerText = "04";
                        Codigo.AppendChild(TipoLD);
                        XmlElement CodigoLD = doc.CreateElement("Codigo");
                        CodigoLD.InnerText = Convert.ToString(dgv_Consecutivos.Rows[i].Cells[8].Value);
                        Codigo.AppendChild(CodigoLD);
                    LineaDetalle.AppendChild(Codigo);
                    XmlElement Cantidad = doc.CreateElement("Cantidad");
                    Cantidad.InnerText = Convert.ToString(dgv_Consecutivos.Rows[i].Cells[2].Value);
                    LineaDetalle.AppendChild(Cantidad);
                    XmlElement UnidadMedida = doc.CreateElement("UnidadMedida");
                    UnidadMedida.InnerText = Convert.ToString(dgv_Consecutivos.Rows[i].Cells[9].Value);
                    LineaDetalle.AppendChild(UnidadMedida);
                    XmlElement Detalle = doc.CreateElement("Detalle");
                    Detalle.InnerText = Convert.ToString(dgv_Consecutivos.Rows[i].Cells[1].Value);
                    LineaDetalle.AppendChild(Detalle);
                    XmlElement PrecioUnitario = doc.CreateElement("PrecioUnitario");
                    PrecioUnitario.InnerText = Convert.ToString(dgv_Consecutivos.Rows[i].Cells[3].Value);
                    LineaDetalle.AppendChild(PrecioUnitario);
                    XmlElement MontoTotal = doc.CreateElement("MontoTotal");
                    MontoTotal.InnerText = Convert.ToString(Convert.ToInt32(dgv_Consecutivos.Rows[i].Cells[3].Value)* Convert.ToInt32(dgv_Consecutivos.Rows[i].Cells[2].Value));
                    LineaDetalle.AppendChild(MontoTotal);
                    if( Convert.ToInt32(dgv_Consecutivos.Rows[i].Cells[5].Value) >= 1)
                    {
                    XmlElement MontoDescuento = doc.CreateElement("MontoDescuento");
                    MontoDescuento.InnerText = Convert.ToString(Convert.ToInt32((Convert.ToInt32(dgv_Consecutivos.Rows[i].Cells[5].Value) * (Convert.ToInt32(dgv_Consecutivos.Rows[i].Cells[2].Value) * Convert.ToInt32(dgv_Consecutivos.Rows[i].Cells[3].Value))) / 100));
                    LineaDetalle.AppendChild(MontoDescuento);
                    XmlElement NaturalezaDescuento = doc.CreateElement("NaturalezaDescuento");
                    NaturalezaDescuento.InnerText = "Artículo con Defecto";
                    LineaDetalle.AppendChild(NaturalezaDescuento);
                    XmlElement SubTotal = doc.CreateElement("SubTotal");
                    SubTotal.InnerText = Convert.ToString(Convert.ToInt32(MontoTotal.InnerText) - Convert.ToInt32(MontoDescuento.InnerText));
                    LineaDetalle.AppendChild(SubTotal);
                    XmlElement MontoTotalLinea = doc.CreateElement("MontoTotalLinea");
                    MontoTotalLinea.InnerText = Convert.ToString(Convert.ToInt32(MontoTotal.InnerText) - Convert.ToInt32(MontoDescuento.InnerText));
                    LineaDetalle.AppendChild(MontoTotalLinea);
                }
                    else
                    {
                    XmlElement SubTotal = doc.CreateElement("SubTotal");
                    SubTotal.InnerText = Convert.ToString(Convert.ToInt32(MontoTotal.InnerText));
                    LineaDetalle.AppendChild(SubTotal);
                    XmlElement MontoTotalLinea = doc.CreateElement("MontoTotalLinea");
                    MontoTotalLinea.InnerText = Convert.ToString(Convert.ToInt32(MontoTotal.InnerText));
                    LineaDetalle.AppendChild(MontoTotalLinea);
                }
                DetalleServicio.AppendChild(LineaDetalle);
            }                
            fe.AppendChild(DetalleServicio);
            //--FINDETALLESERVICIO--//
            //--RESUMENFACTURA--//
            XmlElement ResumenFactura = doc.CreateElement("ResumenFactura");
                XmlElement CodigoMoneda = doc.CreateElement("CodigoMoneda");
                CodigoMoneda.InnerText = "CRC";
                ResumenFactura.AppendChild(CodigoMoneda);
                XmlElement TipoCambio = doc.CreateElement("TipoCambio");
                TipoCambio.InnerText = "1.00000";
                ResumenFactura.AppendChild(TipoCambio);
                XmlElement TotalServGravados = doc.CreateElement("TotalServGravados");
                TotalServGravados.InnerText = "0.00000";
                ResumenFactura.AppendChild(TotalServGravados);
                XmlElement TotalServExentos = doc.CreateElement("TotalServExentos");
                TotalServExentos.InnerText = "0.00000";
                ResumenFactura.AppendChild(TotalServExentos);
                XmlElement TotalMercanciasExentas = doc.CreateElement("TotalMercanciasExentas");
                TotalMercanciasExentas.InnerText = lbl_DineroaPagar.Text+".00000";
                ResumenFactura.AppendChild(TotalMercanciasExentas);
                XmlElement TotalGravado = doc.CreateElement("TotalGravado");
                TotalGravado.InnerText = "0.00000";
                ResumenFactura.AppendChild(TotalGravado);
                XmlElement TotalExento = doc.CreateElement("TotalExento");
                TotalExento.InnerText = lbl_DineroaPagar.Text+".00000";
                ResumenFactura.AppendChild(TotalExento);
                XmlElement TotalVenta = doc.CreateElement("TotalVenta");
                TotalVenta.InnerText = lbl_DineroaPagar.Text + ".00000";
                ResumenFactura.AppendChild(TotalVenta);
                XmlElement TotalDescuentos = doc.CreateElement("TotalDescuentos");
                TotalDescuentos.InnerText = "0.00000";
                ResumenFactura.AppendChild(TotalDescuentos);
                XmlElement TotalVentaNeta = doc.CreateElement("TotalVentaNeta");
                TotalVentaNeta.InnerText = lbl_DineroaPagar.Text+".00000";
                ResumenFactura.AppendChild(TotalVentaNeta);
                XmlElement TotalImpuesto = doc.CreateElement("TotalImpuesto");
                TotalImpuesto.InnerText = "0.00000";
                ResumenFactura.AppendChild(TotalImpuesto);
                XmlElement TotalComprobante = doc.CreateElement("TotalComprobante");
                TotalComprobante.InnerText = lbl_DineroaPagar.Text;
                ResumenFactura.AppendChild(TotalComprobante);
            fe.AppendChild(ResumenFactura);
            //--FINRESUMENFACTURA--//
            //--NORMATIVA--//
            XmlElement Normativa = doc.CreateElement("Normativa");
                XmlElement NumeroResolucion = doc.CreateElement("NumeroResolucion");
                NumeroResolucion.InnerText = "DGT-R-48-2016";
                Normativa.AppendChild(NumeroResolucion);
                XmlElement FechaResolucion = doc.CreateElement("FechaResolucion");
                FechaResolucion.InnerText = "07-10-2016 01:00:00";
                Normativa.AppendChild(FechaResolucion);
            fe.AppendChild(Normativa);
            //--FINNORMATIVA--//
            doc.AppendChild(fe);
            doc.Save("D:\\Proyectos\\PuntoAmerican\\Ejemplos_Factura\\fe-" + clave.InnerText+".xml");
            //doc.Save("D:\\Documents\\Facturas\\fe-"+clave.InnerText+".xml");
            valor = 0;
            


        }


        public void FIRMADOR(string clave,string certificado) 
        {
            string directorio = "D:\\Proyectos\\PuntoAmerican\\Ejemplos_Factura\\";
            //string directorio = "D:\\Documents\\Facturas\\";
            string nombreArchivo = directorio + clave;

            objfirma.FirmaXML_Xades(nombreArchivo, certificado);

        }

        public string getToken()
        {
            try
            {
                TokenHacienda iTokenHacienda = new TokenHacienda();
                iTokenHacienda.GetTokenHacienda(objCreaXML.Usuario_Hacienda,objCreaXML.Password_Hacienda);
                return iTokenHacienda.accessToken;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }


    

}
