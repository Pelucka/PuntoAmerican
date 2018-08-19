using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using DAL;
using System.Xml;
using System.Xml.Linq;

namespace BLL
{
    public class CrecionXML
    {

        #region Propiedades
        private string _Año;

        public string Año
        {
            get { return _Año; }
            set { _Año = value; }
        }
        private string _Mes;

        public string Mes
        {
            get { return _Mes; }
            set { _Mes = value; }
        }

        private string _Mesfin;

        public string Mesfin
        {
            get { return _Mesfin; }
            set { _Mesfin = value; }
        }


        private string _Dia;

        public string Dia
        {
            get { return _Dia; }
            set { _Dia = value; }
        }

        private string _Diafin;

        public string Diafin
        {
            get { return _Diafin; }
            set { _Diafin = value; }
        }



        private string _Ubicacion;

        public string Ubicacion
        {
            get { return _Ubicacion; }
            set { _Ubicacion = value; }
        }



        private string _Consecutivo;

        public string Consecutivo
        {
            get { return _Consecutivo; }
            set { _Consecutivo = value; }
        }

        private string _Consecutivofin;

        public string Consecutivofin
        {
            get { return _Consecutivofin; }
            set { _Consecutivofin = value; }
        }

        private string _Secuencia;

        public string Secuencia
        {
            get { return _Secuencia; }
            set { _Secuencia = value; }
        }
        private string _Secuenciafin;

        public string Secuenciafin
        {
            get { return _Secuenciafin; }
            set { _Secuenciafin = value; }
        }

        private string _CodSeguridad;

        public string CodSeguridad
        {
            get { return _CodSeguridad; }
            set { _CodSeguridad = value; }
        }

        private string _Fecha;

        public string Fecha
        {
            get { return _Fecha; }
            set { _Fecha = value; }
        }

        private string _Fechafin;

        public string Fechafin
        {
            get { return _Fechafin; }
            set { _Fechafin = value; }
        }

        private string _Añofin;

        public string Añofin
        {
            get { return _Añofin; }
            set { _Añofin = value; }
        }


        //----------DATOS DE SELECT_DATOS_XML_EMISOR----------//
        private string _Nombre;

        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }

        private string _Tipo_Identificacion;

        public string Tipo_Identificacion
        {
            get { return _Tipo_Identificacion; }
            set { _Tipo_Identificacion = value; }
        }

        private string _Cedula;

        public string Cedula
        {
            get { return _Cedula; }
            set { _Cedula = value; }
        }

        private string _Provincia;

        public string Provincia
        {
            get { return _Provincia; }
            set { _Provincia = value; }
        }

        private String _Canton;

        public String Canton
        {
            get { return _Canton; }
            set { _Canton = value; }
        }
        private string _Distrito;

        public string Distrito
        {
            get { return _Distrito; }
            set { _Distrito = value; }
        }

        private string _Barrio;

        public string Barrio
        {
            get { return _Barrio; }
            set { _Barrio = value; }
        }
        private string _Desc_Ubica;

        public string Desv_Ubica
        {
            get { return _Desc_Ubica; }
            set { _Desc_Ubica = value; }
        }
        private string _Telefono;

        public string Telefono
        {
            get { return _Telefono; }
            set { _Telefono = value; }
        }


        private string _TipoIdentificacionfin;

        public string TipoIdentificacionfin
        {
            get { return _TipoIdentificacionfin; }
            set { _TipoIdentificacionfin = value; }
        }


        private string _Cedulafin;

        public string Cedulafin
        {
            get { return _Cedulafin; }
            set { _Cedulafin = value; }
        }

        private string _Provinciafin;

        public string Provinciafin
        {
            get { return _Provinciafin; }
            set { _Provinciafin = value; }
        }

        private string _Cantonfin;

        public string Cantonfin
        {
            get { return _Cantonfin; }
            set { _Cantonfin = value; }
        }

        private string _Distritofin;

        public string Distritofin
        {
            get { return _Distritofin; }
            set { _Distritofin = value; }
        }
        private string _Barriofin;

        public string Barriofin
        {
            get { return _Barriofin; }
            set { _Barriofin = value; }
        }

        private string _Certificado;

        public string Certificado
        {
            get { return _Certificado; }
            set { _Certificado = value; }
        }

        private string _Usuario_Hacienda;

        public string Usuario_Hacienda
        {
            get { return _Usuario_Hacienda; }
            set { _Usuario_Hacienda = value; }
        }

        private string _Password_Hacienda;

        public string Password_Hacienda
        {
            get { return _Password_Hacienda; }
            set { _Password_Hacienda = value; }
        }


        //----------------------------------------//
        //----------DATOS DE SELECT_DATOS_XML_RECEPTOR----------//

        private string _NombreRE;

        public string NombreRE
        {
            get { return _NombreRE; }
            set { _NombreRE = value; }
        }

        private string _Tipo_IdentificacionRE;

        public string Tipo_IdentificacionRE
        {
            get { return _Tipo_IdentificacionRE; }
            set { _Tipo_IdentificacionRE = value; }
        }

        private string _CedulaRE;

        public string CedulaRE
        {
            get { return _CedulaRE; }
            set { _CedulaRE = value; }
        }

        private string _ProvinciaRE;

        public string ProvinciaRE
        {
            get { return _ProvinciaRE; }
            set { _ProvinciaRE = value; }
        }

        private String _CantonRE;

        public String CantonRE
        {
            get { return _CantonRE; }
            set { _CantonRE = value; }
        }
        private string _DistritoRE;

        public string DistritoRE
        {
            get { return _DistritoRE; }
            set { _DistritoRE = value; }
        }

        private string _BarrioRE;

        public string BarrioRE
        {
            get { return _BarrioRE; }
            set { _BarrioRE = value; }
        }
        private string _Desc_UbicaRE;

        public string Desv_UbicaRE
        {
            get { return _Desc_UbicaRE; }
            set { _Desc_UbicaRE = value; }
        }
        private string _TelefonoRE;

        public string TelefonoRE
        {
            get { return _TelefonoRE; }
            set { _TelefonoRE = value; }
        }


        private string _TipoIdentificacionfinRE;

        public string TipoIdentificacionfinRE
        {
            get { return _TipoIdentificacionfinRE; }
            set { _TipoIdentificacionfinRE = value; }
        }


        private string _CedulafinRE;

        public string CedulafinRE
        {
            get { return _CedulafinRE; }
            set { _CedulafinRE = value; }
        }

        private string _ProvinciafinRE;

        public string ProvinciafinRE
        {
            get { return _ProvinciafinRE; }
            set { _ProvinciafinRE = value; }
        }

        private string _CantonfinRE;

        public string CantonfinRE
        {
            get { return _CantonfinRE; }
            set { _CantonfinRE = value; }
        }

        private string _DistritofinRE;

        public string DistritofinRE
        {
            get { return _DistritofinRE; }
            set { _DistritofinRE = value; }
        }
        private string _BarriofinRE;

        public string BarriofinRE
        {
            get { return _BarriofinRE; }
            set { _BarriofinRE = value; }
        }
        private string _CorreoRE;

        public string CorreoRE
        {
            get { return _CorreoRE; }
            set { _CorreoRE = value; }
        }
        //------------------------------------------------//
        private int _Clientes;

        public int Clientes
        {
            get { return _Clientes; }
            set { _Clientes = value; }
        }
        private string _CondicionVenta;

        public string CondificionVenta
        {
            get { return _CondicionVenta; }
            set { _CondicionVenta = value; }
        }

        private string _CodicionVentafin;

        public string CondicionVentafin
        {
            get { return _CodicionVentafin; }
            set { _CodicionVentafin = value; }
        }


        private string _MediodePago;

        public string MediodePago
        {
            get { return _MediodePago; }
            set { _MediodePago = value; }
        }

        private string _MediodePagofin;

        public string MediodePagofin
        {
            get { return _MediodePagofin; }
            set { _MediodePagofin = value; }
        }

        private DateTime _FechaFull;

        public DateTime FechaFull
        {
            get { return _FechaFull; }
            set { _FechaFull = value; }
        }
        private String _DineroTotal;

        public String DineroTotal
        {
            get { return _DineroTotal; }
            set { _DineroTotal = value; }
        }

        private string _Login;

        public string Login
        {
            get { return _Login; }
            set { _Login = value; }
        }
        private string _Validacion;

        public string Validacion
        {
            get { return _Validacion; }
            set { _Validacion = value; }
        }

        //-- VENTAS --//
        private string _Descuento;

        public string Descuento
        {
            get { return _Descuento; }
            set { _Descuento = value; }
        }

        private string _Cantidad;

        public string Cantidad
        {
            get { return _Cantidad; }
            set { _Cantidad = value; }
        }

        private string _Precio;

        public string Precio
        {
            get { return _Precio; }
            set { _Precio = value; }
        }

        private string _Total;

        public string Total
        {
            get { return _Total; }
            set { _Total = value; }
        }

        private string _Cod_Articulo;

        public string Cod_Articulo
        {
            get { return _Cod_Articulo; }
            set { _Cod_Articulo = value; }
        }

        private string _Id_VentaTotal;

        public string Id_VentaTotal
        {
            get { return _Id_VentaTotal; }
            set { _Id_VentaTotal = value; }
        }

        private string _Descripcion;

        public string Descripcion
        {
            get { return _Descripcion; }
            set { _Descripcion = value; }
        }

        private int _qweasd;

        public int qweasd
        {
            get { return _qweasd; }
            set { _qweasd = value; }
        }


        #endregion
        #region Variables Privadas
        SqlConnection conexion;
        DataSet ds;
        string sql;
        string mensaje_error = string.Empty;
        int numero_error = 0;
        #endregion
        #region Metodos
        public void CREAR_COD_SEGURIDAD()
        {
            
                int minLength = 8;
                int maxLength = 8;
                string allchars = "123456789";
                StringBuilder contra = new StringBuilder();
                Random rd = new Random();
                int contratamaño = rd.Next(minLength, maxLength + 1);
                while (contratamaño-- > 0)
                    contra.Append(allchars[rd.Next(allchars.Length)]);
                _CodSeguridad = contra.ToString();



            
        }
        public void SELECT_FECHA()
        {
            /*Verificacion de la conexion al servidor*/
            conexion = cls_DAL.trae_conexion("PuntoAmericano", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                /*Instancia a un Procedimiento Almacenado*/
                sql = " USP_ERROR_INSERT";
                ParamStruct[] parametros = new ParamStruct[2];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@msgerror", SqlDbType.VarChar, mensaje_error);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@numerror", SqlDbType.Int, numero_error);
                cls_DAL.conectar(conexion, ref mensaje_error, ref numero_error);
                cls_DAL.ejecuta_sqlcommand(conexion, sql, true, parametros, ref mensaje_error, ref numero_error);
                cls_DAL.desconectar(conexion, ref mensaje_error, ref numero_error);

            }
            else
            {
                /*Instancia a un Procedimiento Almacenado*/
                sql = "USP_FECHA_SELECT_POR_SEPARADO";
                ds = cls_DAL.ejecuta_dataset(conexion, sql, true, ref mensaje_error, ref numero_error);
                if (numero_error != 0)
                {
                    /*Instancia a un Procedimiento Almacenado*/
                    sql = "USP_ERROR_INSERT";
                    ParamStruct[] parametross = new ParamStruct[2];
                    cls_DAL.agregar_datos_estructura_parametros(ref parametross, 0, "@msgerror", SqlDbType.VarChar, mensaje_error);
                    cls_DAL.agregar_datos_estructura_parametros(ref parametross, 1, "@numerror", SqlDbType.Int, numero_error);
                    cls_DAL.ejecuta_sqlcommand(conexion, sql, true, parametross, ref mensaje_error, ref numero_error);
                    cls_DAL.desconectar(conexion, ref mensaje_error, ref numero_error);

                }
                else
                {
                    /*Validacion de la contraseña*/
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        _Dia = ds.Tables[0].Rows[0]["Dia"].ToString();
                        _Mes = ds.Tables[0].Rows[0]["Mes"].ToString();
                        _Año= ds.Tables[0].Rows[0]["Año"].ToString();
                        _Fecha= ds.Tables[0].Rows[0]["Fecha"].ToString();
                        cls_DAL.desconectar(conexion, ref mensaje_error, ref numero_error);
                        _Añofin = _Año.Substring(2);
                        if (_Dia.Length < 2)
                        {
                            int valor = 2 - _Dia.Length;
                            for (int i = 0; i < valor; i++)
                            {
                                _Diafin = _Diafin + "0";
                            }
                            _Diafin = _Diafin + _Dia;

                        }
                        else
                        {
                            _Diafin = _Dia;
                        }
                        if(_Mes.Length < 2)
                        {
                            int valor = 2 - _Mes.Length;
                            for (int i = 0; i < valor; i++)
                            {
                                _Mesfin = _Mesfin + "0";
                            }
                            _Mesfin = _Mesfin + _Mes;
                        }
                        else
                        {
                            _Mesfin = _Mes;
                        }

                  

                    }
                    else
                    {
                        MessageBox.Show("Problema al Seleccionar la Fecha", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cls_DAL.desconectar(conexion, ref mensaje_error, ref numero_error);

                    }


                }
            }
        }
        public void SELECT_SUCURSAL()
        {
            /*Verificacion de la conexion al servidor*/
            conexion = cls_DAL.trae_conexion("PuntoAmericano", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                /*Instancia a un Procedimiento Almacenado*/
                sql = " USP_ERROR_INSERT";
                ParamStruct[] parametros = new ParamStruct[2];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@msgerror", SqlDbType.VarChar, mensaje_error);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@numerror", SqlDbType.Int, numero_error);
                cls_DAL.conectar(conexion, ref mensaje_error, ref numero_error);
                cls_DAL.ejecuta_sqlcommand(conexion, sql, true, parametros, ref mensaje_error, ref numero_error);
                cls_DAL.desconectar(conexion, ref mensaje_error, ref numero_error);

            }
            else
            {
                /*Instancia a un Procedimiento Almacenado*/
                sql = "USP_UBICACION_SELECT_CONSECUTIVO_SUCURSAL";
                ParamStruct[] parametros = new ParamStruct[1];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@descrip", SqlDbType.VarChar, _Ubicacion);
                ds = cls_DAL.ejecuta_dataset(conexion, sql, true, parametros, ref mensaje_error, ref numero_error);
                if (numero_error != 0)
                {
                    /*Instancia a un Procedimiento Almacenado*/
                    sql = "USP_ERROR_INSERT";
                    ParamStruct[] parametross = new ParamStruct[2];
                    cls_DAL.agregar_datos_estructura_parametros(ref parametross, 0, "@msgerror", SqlDbType.VarChar, mensaje_error);
                    cls_DAL.agregar_datos_estructura_parametros(ref parametross, 1, "@numerror", SqlDbType.Int, numero_error);
                    cls_DAL.ejecuta_sqlcommand(conexion, sql, true, parametross, ref mensaje_error, ref numero_error);
                    cls_DAL.desconectar(conexion, ref mensaje_error, ref numero_error);

                }
                else
                {
                    /*Validacion de la contraseña*/
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        _Consecutivo = ds.Tables[0].Rows[0]["consecutivo"].ToString();
                        cls_DAL.desconectar(conexion, ref mensaje_error, ref numero_error);
                        if (_Consecutivo.Length < 3)
                        {
                            int valor = 3 - _Consecutivo.Length;
                            for (int i = 0; i < valor; i++)
                            {
                                _Consecutivofin = _Consecutivofin + "0";
                            }
                            _Consecutivofin = _Consecutivofin + _Consecutivo;
                            valor = 0;
                        }

                    }
                    else
                    {
                        MessageBox.Show("Problema al Seleccionar la Identificacion", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cls_DAL.desconectar(conexion, ref mensaje_error, ref numero_error);

                    }


                }
            }
        }
        public void SELECT_SECUENCIA()
        {
            /*Verificacion de la conexion al servidor*/
            conexion = cls_DAL.trae_conexion("PuntoAmericano", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                /*Instancia a un Procedimiento Almacenado*/
                sql = " USP_ERROR_INSERT";
                ParamStruct[] parametros = new ParamStruct[2];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@msgerror", SqlDbType.VarChar, mensaje_error);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@numerror", SqlDbType.Int, numero_error);
                cls_DAL.conectar(conexion, ref mensaje_error, ref numero_error);
                cls_DAL.ejecuta_sqlcommand(conexion, sql, true, parametros, ref mensaje_error, ref numero_error);
                cls_DAL.desconectar(conexion, ref mensaje_error, ref numero_error);

            }
            else
            {
                /*Instancia a un Procedimiento Almacenado*/
                sql = "USP_UBICACION_SELECT_SECUENCIA";
                ParamStruct[] parametros = new ParamStruct[1];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@descrip", SqlDbType.VarChar, _Ubicacion);
                ds = cls_DAL.ejecuta_dataset(conexion, sql, true, parametros, ref mensaje_error, ref numero_error);
                if (numero_error != 0)
                {
                    /*Instancia a un Procedimiento Almacenado*/
                    sql = "USP_ERROR_INSERT";
                    ParamStruct[] parametross = new ParamStruct[2];
                    cls_DAL.agregar_datos_estructura_parametros(ref parametross, 0, "@msgerror", SqlDbType.VarChar, mensaje_error);
                    cls_DAL.agregar_datos_estructura_parametros(ref parametross, 1, "@numerror", SqlDbType.Int, numero_error);
                    cls_DAL.ejecuta_sqlcommand(conexion, sql, true, parametross, ref mensaje_error, ref numero_error);
                    cls_DAL.desconectar(conexion, ref mensaje_error, ref numero_error);

                }
                else
                {
                    /*Validacion de la contraseña*/
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        _Secuencia = ds.Tables[0].Rows[0]["Secuencia"].ToString();
                        cls_DAL.desconectar(conexion, ref mensaje_error, ref numero_error);
                        if (_Secuencia.Length < 10)
                        {
                            int valor = 10 - _Secuencia.Length;
                            for (int i = 0; i < valor; i++)
                            {
                                _Secuenciafin = _Secuenciafin + "0";
                            }
                            _Secuenciafin = _Secuenciafin + _Secuencia;
                            valor = 0;
                        }

                    }
                    else
                    {
                        MessageBox.Show("Problema al Seleccionar la Identificacion", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cls_DAL.desconectar(conexion, ref mensaje_error, ref numero_error);

                    }


                }
            }
        }
        public void SELECT_DATOS_XML()
        {
            /*Verificacion de la conexion al servidor*/
            conexion = cls_DAL.trae_conexion("PuntoAmericano", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                /*Instancia a un Procedimiento Almacenado*/
                sql = " USP_ERROR_INSERT";
                ParamStruct[] parametros = new ParamStruct[2];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@msgerror", SqlDbType.VarChar, mensaje_error);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@numerror", SqlDbType.Int, numero_error);
                cls_DAL.conectar(conexion, ref mensaje_error, ref numero_error);
                cls_DAL.ejecuta_sqlcommand(conexion, sql, true, parametros, ref mensaje_error, ref numero_error);
                cls_DAL.desconectar(conexion, ref mensaje_error, ref numero_error);

            }
            else
            {
                /*Instancia a un Procedimiento Almacenado*/
                sql = "USP_UBICACION_SELECT_DATOS_XML";
                ParamStruct[] parametros = new ParamStruct[1];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@descr", SqlDbType.VarChar, _Ubicacion);
                ds = cls_DAL.ejecuta_dataset(conexion, sql, true, parametros, ref mensaje_error, ref numero_error);
                if (numero_error != 0)
                {
                    /*Instancia a un Procedimiento Almacenado*/
                    sql = "USP_ERROR_INSERT";
                    ParamStruct[] parametross = new ParamStruct[2];
                    cls_DAL.agregar_datos_estructura_parametros(ref parametross, 0, "@msgerror", SqlDbType.VarChar, mensaje_error);
                    cls_DAL.agregar_datos_estructura_parametros(ref parametross, 1, "@numerror", SqlDbType.Int, numero_error);
                    cls_DAL.ejecuta_sqlcommand(conexion, sql, true, parametross, ref mensaje_error, ref numero_error);
                    cls_DAL.desconectar(conexion, ref mensaje_error, ref numero_error);

                }
                else
                {
                    /*Validacion de la contraseña*/
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        _Nombre = ds.Tables[0].Rows[0]["Nombre"].ToString();
                        _Tipo_Identificacion = ds.Tables[0].Rows[0]["Tipo_Identificacion"].ToString(); 
                        _Cedula = ds.Tables[0].Rows[0]["Cedula"].ToString();
                        _Provincia = ds.Tables[0].Rows[0]["Provincia"].ToString();
                        _Canton = ds.Tables[0].Rows[0]["Canton"].ToString();
                        _Distrito = ds.Tables[0].Rows[0]["Distrito"].ToString();
                        _Barrio = ds.Tables[0].Rows[0]["Barrio"].ToString();
                        _Desc_Ubica = ds.Tables[0].Rows[0]["Desc_Ubica"].ToString();
                        _Telefono = ds.Tables[0].Rows[0]["Telefono"].ToString();
                        _Certificado = ds.Tables[0].Rows[0]["Certificado"].ToString();
                        _Usuario_Hacienda = ds.Tables[0].Rows[0]["Usuario_Hacienda"].ToString();
                        _Password_Hacienda = ds.Tables[0].Rows[0]["Password_Hacienda"].ToString();

                        cls_DAL.desconectar(conexion, ref mensaje_error, ref numero_error);
                        if (_Tipo_Identificacion.Length < 2)
                        {
                            int valor = 2 - _Tipo_Identificacion.Length;
                            for (int i = 0; i < valor; i++)
                            {
                                _TipoIdentificacionfin = _TipoIdentificacionfin + "0";
                            }
                            _TipoIdentificacionfin = _TipoIdentificacionfin + _Tipo_Identificacion;
                            valor = 0;
                        }
                        if (_Cedula.Length < 12)
                        {
                            int valor = 12 - _Cedula.Length;
                            for (int i = 0; i < valor; i++)
                            {
                                _Cedulafin = _Cedulafin + "0";
                            }
                            _Cedulafin = _Cedulafin + _Cedula;
                            valor = 0;
                        }
                        if (_Provincia.Length < 2)
                        {
                            
                            int valor = 2 - _Provincia.Length;
                            for (int i = 0; i < valor; i++)
                            {
                                _Provinciafin = _Provinciafin + "0";
                            }
                            _Provinciafin = _Provinciafin + _Provincia;
                            valor = 0;
                        }
                        else
                        {
                            _Provinciafin = _Provincia;
                        }
                        if (_Canton.Length < 2)
                        {

                            int valor = 2 - _Canton.Length;
                            for (int i = 0; i < valor; i++)
                            {
                                _Cantonfin = _Cantonfin + "0";
                            }
                            _Cantonfin = _Cantonfin + _Canton;
                            valor = 0;
                        }
                        else
                        {
                            _Cantonfin = _Canton;
                        }
                        if (_Distrito.Length < 2)
                        {

                            int valor = 2 - _Distrito.Length;
                            for (int i = 0; i < valor; i++)
                            {
                                _Distritofin = _Distritofin + "0";
                            }
                            _Distritofin = _Distritofin + _Distrito;
                            valor = 0;
                        }
                        else
                        {
                            _Distritofin = _Distrito;
                        }
                        if (_Barrio.Length < 2)
                        {

                            int valor = 2 - _Barrio.Length;
                            for (int i = 0; i < valor; i++)
                            {
                                _Barriofin = _Barriofin + "0";
                            }
                            _Barriofin = _Barriofin + _Barrio;
                            valor = 0;
                        }
                        else
                        {
                            _Barriofin = _Barrio;
                        }

                    }
                    else
                    {
                        MessageBox.Show("Problema al Seleccionar la Identificacion", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cls_DAL.desconectar(conexion, ref mensaje_error, ref numero_error);

                    }


                }
            }
        }
        public void SELECT_DATOS_XML_RECEPTOR()
        {
            /*Verificacion de la conexion al servidor*/
            conexion = cls_DAL.trae_conexion("PuntoAmericano", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                /*Instancia a un Procedimiento Almacenado*/
                sql = " USP_ERROR_INSERT";
                ParamStruct[] parametros = new ParamStruct[2];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@msgerror", SqlDbType.VarChar, mensaje_error);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@numerror", SqlDbType.Int, numero_error);
                cls_DAL.conectar(conexion, ref mensaje_error, ref numero_error);
                cls_DAL.ejecuta_sqlcommand(conexion, sql, true, parametros, ref mensaje_error, ref numero_error);
                cls_DAL.desconectar(conexion, ref mensaje_error, ref numero_error);

            }
            else
            {
                /*Instancia a un Procedimiento Almacenado*/
                sql = "USP_SELECT_DATOS_XML_RECEPTOR";
                ParamStruct[] parametros = new ParamStruct[1];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@idcliente", SqlDbType.Int, _Clientes);
                ds = cls_DAL.ejecuta_dataset(conexion, sql, true, parametros, ref mensaje_error, ref numero_error);
                if (numero_error != 0)
                {
                    /*Instancia a un Procedimiento Almacenado*/
                    sql = "USP_ERROR_INSERT";
                    ParamStruct[] parametross = new ParamStruct[2];
                    cls_DAL.agregar_datos_estructura_parametros(ref parametross, 0, "@msgerror", SqlDbType.VarChar, mensaje_error);
                    cls_DAL.agregar_datos_estructura_parametros(ref parametross, 1, "@numerror", SqlDbType.Int, numero_error);
                    cls_DAL.ejecuta_sqlcommand(conexion, sql, true, parametross, ref mensaje_error, ref numero_error);
                    cls_DAL.desconectar(conexion, ref mensaje_error, ref numero_error);

                }
                else
                {
                    /*Validacion de la contraseña*/
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        _NombreRE = ds.Tables[0].Rows[0]["Nombre"].ToString();
                        _Tipo_IdentificacionRE = ds.Tables[0].Rows[0]["Tipo_Identificacion"].ToString();
                        _CedulaRE = ds.Tables[0].Rows[0]["Identificacion"].ToString();
                        _ProvinciaRE = ds.Tables[0].Rows[0]["Cod_Provincia"].ToString();
                        _CantonRE = ds.Tables[0].Rows[0]["Cod_Canton"].ToString();
                        _DistritoRE = ds.Tables[0].Rows[0]["Cod_Distrito"].ToString();
                        _BarrioRE = ds.Tables[0].Rows[0]["Cod_Barrio"].ToString();
                        _Desc_UbicaRE = ds.Tables[0].Rows[0]["Desc_Ubicacion"].ToString();
                        _TelefonoRE = ds.Tables[0].Rows[0]["Telefono"].ToString();
                        _CorreoRE = ds.Tables[0].Rows[0]["Correo"].ToString();
                        cls_DAL.desconectar(conexion, ref mensaje_error, ref numero_error);
                        if (_Tipo_IdentificacionRE.Length < 2)
                        {
                            int valor = 2 - _Tipo_IdentificacionRE.Length;
                            for (int i = 0; i < valor; i++)
                            {
                                _TipoIdentificacionfinRE = _TipoIdentificacionfinRE + "0";
                            }
                            _TipoIdentificacionfinRE = _TipoIdentificacionfinRE + _Tipo_IdentificacionRE;
                            valor = 0;
                        }
                        if ((_CedulaRE.Length) < 12)
                        {
                            int valor = 12 - _CedulaRE.Length;
                            for (int i = 0; i < valor; i++)
                            {
                                _CedulafinRE = _CedulafinRE + "0";
                            }
                            _CedulafinRE = _CedulafinRE + _CedulaRE;
                            valor = 0;
                        }
                        if ((_ProvinciaRE.Length) < 2)
                        {

                            int valor = 2 - _ProvinciaRE.Length;
                            for (int i = 0; i < valor; i++)
                            {
                                _ProvinciafinRE = _ProvinciafinRE + "0";
                            }
                            _ProvinciafinRE = _ProvinciafinRE + _ProvinciaRE;
                            valor = 0;
                        }
                        else
                        {
                            _ProvinciafinRE = _ProvinciaRE;
                        }
                        if ((_CantonRE.Length) < 2)
                        {

                            int valor = 2 - _CantonRE.Length;
                            for (int i = 0; i < valor; i++)
                            {
                                _CantonfinRE = _CantonfinRE + "0";
                            }
                            _CantonfinRE = _CantonfinRE + _CantonRE;
                            valor = 0;
                        }
                        else
                        {
                            _CantonfinRE = _CantonRE;
                        }
                        if ((_DistritoRE.Length) < 2)
                        {

                            int valor = 2 - _DistritoRE.Length;
                            for (int i = 0; i < valor; i++)
                            {
                                _DistritofinRE = _DistritofinRE + "0";
                            }
                            _DistritofinRE = _DistritofinRE + _DistritoRE;
                            valor = 0;
                        }
                        else
                        {
                            _DistritofinRE = _DistritoRE;
                        }
                        if ((_BarrioRE.Length) < 2)
                        {

                            int valor = 2 - _BarrioRE.Length;
                            for (int i = 0; i < valor; i++)
                            {
                                _BarriofinRE = _BarriofinRE + "0";
                            }
                            _BarriofinRE = _BarriofinRE + _BarrioRE;
                            valor = 0;
                        }
                        else
                        {
                            _BarriofinRE = _BarrioRE;
                        }

                    }
                    else
                    {
                        MessageBox.Show("Problema al Seleccionar la Identificacion", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cls_DAL.desconectar(conexion, ref mensaje_error, ref numero_error);

                    }


                }
            }
        }
        public void SELECT_DATOS_XML_TRAIDOS()
        {
            if (_CondicionVenta.Length < 2)
            {
                int valor = 2 - _CondicionVenta.Length;
                for (int i = 0; i < valor; i++)
                {
                    _CodicionVentafin = _CodicionVentafin + "0";
                }
                _CodicionVentafin = _CodicionVentafin + _CondicionVenta;
                valor = 0;

            }
            if (_MediodePago.Length < 2)
            {
                int valor = 2 - _MediodePago.Length;
                for (int i = 0; i < valor; i++)
                {
                    _MediodePagofin = _MediodePagofin + "0";
                }
                _MediodePagofin = _MediodePagofin + _MediodePago;
                valor = 0;

            }
        }
        public bool INSERT_VENTATOTALES()
        {
            /*Verificacion de la conexion al servidor*/
            conexion = cls_DAL.trae_conexion("PuntoAmericano", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                /*Instancia a un Procedimiento Almacenado*/
                sql = " USP_ERROR_INSERT";
                ParamStruct[] parametros = new ParamStruct[2];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@msgerror", SqlDbType.VarChar, mensaje_error);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@numerror", SqlDbType.Int, numero_error);
                cls_DAL.conectar(conexion, ref mensaje_error, ref numero_error);
                cls_DAL.ejecuta_sqlcommand(conexion, sql, true, parametros, ref mensaje_error, ref numero_error);
                cls_DAL.desconectar(conexion, ref mensaje_error, ref numero_error);
                MessageBox.Show("1" + mensaje_error + "  " + numero_error);
                return false;
            }
            else
            {
                /*Instancia a un Procedimiento Almacenado*/
                sql = "USP_VENTASTOTALES_INSERT";
                ParamStruct[] parametros = new ParamStruct[10];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@cod_factura", SqlDbType.VarChar, _Secuencia);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@ubicacion", SqlDbType.VarChar, _Ubicacion);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 2, "@fecha", SqlDbType.DateTime, _FechaFull);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 3, "@dinerototal", SqlDbType.VarChar, _DineroTotal);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 4, "@login", SqlDbType.VarChar, _Login);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 5, "@cliente", SqlDbType.Int, _Clientes);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 6, "@impuesto", SqlDbType.Int, 0);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 7, "@condicionventa", SqlDbType.Int, Convert.ToInt32(_CondicionVenta));
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 8, "@mediodepago", SqlDbType.Int, Convert.ToInt32( _MediodePago));
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 9, "@codseguridad", SqlDbType.NChar, Convert.ToInt32( _CodSeguridad));
                cls_DAL.conectar(conexion, ref mensaje_error, ref numero_error);
                cls_DAL.ejecuta_sqlcommand(conexion, sql, true, parametros, ref mensaje_error, ref numero_error);
                if (numero_error != 0)
                {
                    /*Instancia a un Procedimiento Almacenado*/
                    sql = "USP_ERROR_INSERT";
                    ParamStruct[] parametross = new ParamStruct[2];
                    cls_DAL.agregar_datos_estructura_parametros(ref parametross, 0, "@msgerror", SqlDbType.VarChar, mensaje_error);
                    cls_DAL.agregar_datos_estructura_parametros(ref parametross, 1, "@numerror", SqlDbType.Int, numero_error);
                    cls_DAL.ejecuta_sqlcommand(conexion, sql, true, parametross, ref mensaje_error, ref numero_error);
                    cls_DAL.desconectar(conexion, ref mensaje_error, ref numero_error);
                    MessageBox.Show("2" + mensaje_error + "  " + numero_error);
                    return true;
                }
                else
                {

                    /*Verificacion de la inserccion*/
                    cls_DAL.desconectar(conexion, ref mensaje_error, ref numero_error);
                    _Validacion = "Insertado";
                    return true;
                }
            }
        }
        public bool UPDATE_SECUENCIA()
        {
            /*Verificacion de la conexion al servidor*/
            conexion = cls_DAL.trae_conexion("PuntoAmericano", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                /*Instancia a un Procedimiento Almacenado*/
                sql = " USP_ERROR_INSERT";
                ParamStruct[] parametros = new ParamStruct[2];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@msgerror", SqlDbType.VarChar, mensaje_error);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@numerror", SqlDbType.Int, numero_error);
                cls_DAL.conectar(conexion, ref mensaje_error, ref numero_error);
                cls_DAL.ejecuta_sqlcommand(conexion, sql, true, parametros, ref mensaje_error, ref numero_error);
                cls_DAL.desconectar(conexion, ref mensaje_error, ref numero_error);
                MessageBox.Show("1" + mensaje_error + "  " + numero_error);
                return false;
            }
            else
            {
                /*Instancia a un Procedimiento Almacenado*/
                sql = "USP_UBICACION_UPDATE_SECUENCIA";
                ParamStruct[] parametros = new ParamStruct[2];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@ubica", SqlDbType.VarChar, _Ubicacion);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@secuencia", SqlDbType.Int, _Secuencia);
                cls_DAL.conectar(conexion, ref mensaje_error, ref numero_error);
                cls_DAL.ejecuta_sqlcommand(conexion, sql, true, parametros, ref mensaje_error, ref numero_error);
                if (numero_error != 0)
                {
                    /*Instancia a un Procedimiento Almacenado*/
                    sql = "USP_ERROR_INSERT";
                    ParamStruct[] parametross = new ParamStruct[2];
                    cls_DAL.agregar_datos_estructura_parametros(ref parametross, 0, "@msgerror", SqlDbType.VarChar, mensaje_error);
                    cls_DAL.agregar_datos_estructura_parametros(ref parametross, 1, "@numerror", SqlDbType.Int, numero_error);
                    cls_DAL.ejecuta_sqlcommand(conexion, sql, true, parametross, ref mensaje_error, ref numero_error);
                    cls_DAL.desconectar(conexion, ref mensaje_error, ref numero_error);
                    MessageBox.Show("2" + mensaje_error + "  " + numero_error);
                    return true;
                }
                else
                {

                    /*Verificacion de la inserccion*/
                    cls_DAL.desconectar(conexion, ref mensaje_error, ref numero_error);
                    _Validacion = "Actualizado";
                    return true;
                }
            }
        }
        public bool INSERT_VENTAS()
        {
            /*Verificacion de la conexion al servidor*/
            conexion = cls_DAL.trae_conexion("PuntoAmericano", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                /*Instancia a un Procedimiento Almacenado*/
                sql = " USP_ERROR_INSERT";
                ParamStruct[] parametros = new ParamStruct[2];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@msgerror", SqlDbType.VarChar, mensaje_error);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@numerror", SqlDbType.Int, numero_error);
                cls_DAL.conectar(conexion, ref mensaje_error, ref numero_error);
                cls_DAL.ejecuta_sqlcommand(conexion, sql, true, parametros, ref mensaje_error, ref numero_error);
                cls_DAL.desconectar(conexion, ref mensaje_error, ref numero_error);
                MessageBox.Show("1" + mensaje_error + "  " + numero_error);
                return false;
            }
            else
            {
                /*Instancia a un Procedimiento Almacenado*/
                sql = "USP_VENTAS_INSERT";
                ParamStruct[] parametros = new ParamStruct[8];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@cant", SqlDbType.Int, Convert.ToInt32(_Cantidad));
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@desc", SqlDbType.Int, Convert.ToInt32(_Descuento));
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 2, "@precio", SqlDbType.VarChar, _Precio);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 3, "@total", SqlDbType.VarChar, _Total);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 4, "@codart", SqlDbType.Int, Convert.ToInt32(_Cod_Articulo));
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 5, "@idventatotal", SqlDbType.Int, Convert.ToInt32(_Id_VentaTotal));
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 6, "@descrip", SqlDbType.VarChar, _Descripcion);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 7, "@ubicacion", SqlDbType.VarChar, _Ubicacion);
                cls_DAL.conectar(conexion, ref mensaje_error, ref numero_error);
                cls_DAL.ejecuta_sqlcommand(conexion, sql, true, parametros, ref mensaje_error, ref numero_error);
                if (numero_error != 0)
                {
                    /*Instancia a un Procedimiento Almacenado*/
                    sql = "USP_ERROR_INSERT";
                    ParamStruct[] parametross = new ParamStruct[2];
                    cls_DAL.agregar_datos_estructura_parametros(ref parametross, 0, "@msgerror", SqlDbType.VarChar, mensaje_error);
                    cls_DAL.agregar_datos_estructura_parametros(ref parametross, 1, "@numerror", SqlDbType.Int, numero_error);
                    cls_DAL.ejecuta_sqlcommand(conexion, sql, true, parametross, ref mensaje_error, ref numero_error);
                    cls_DAL.desconectar(conexion, ref mensaje_error, ref numero_error);
                    MessageBox.Show("2" + mensaje_error + "  " + numero_error);
                    return true;
                }
                else
                {

                    /*Verificacion de la inserccion*/
                    cls_DAL.desconectar(conexion, ref mensaje_error, ref numero_error);
                    _Validacion = "Insertado";
                    return true;
                }
            }
        }
        public DataSet FACTURA_SELECT()
        {
            /*Verificacion de la conexion al servidor*/
            conexion = cls_DAL.trae_conexion("PuntoAmericano", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                /*Instancia a un Procedimiento Almacenado*/
                sql = " USP_ERROR_INSERT";
                ParamStruct[] parametros = new ParamStruct[2];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@msgerror", SqlDbType.VarChar, mensaje_error);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@numerror", SqlDbType.Int, numero_error);
                cls_DAL.conectar(conexion, ref mensaje_error, ref numero_error);
                cls_DAL.ejecuta_sqlcommand(conexion, sql, true, parametros, ref mensaje_error, ref numero_error);
                cls_DAL.desconectar(conexion, ref mensaje_error, ref numero_error);
                return null;
            }
            else
            {
                /*Instancia a un Procedimiento Almacenado*/
                sql = "USP_FACTURA_SELECT";
                ParamStruct[] parametros = new ParamStruct[2];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@codigo", SqlDbType.Int, Convert.ToInt32(_qweasd));
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@ubicacion", SqlDbType.VarChar,(_Ubicacion));
                ds = cls_DAL.ejecuta_dataset(conexion, sql, true, parametros, ref mensaje_error, ref numero_error);


                if (numero_error != 0)
                {
                    /*Instancia a un Procedimiento Almacenado*/
                    sql = " USP_ERROR_INSERT";
                    ParamStruct[] parametroSs = new ParamStruct[2];
                    cls_DAL.agregar_datos_estructura_parametros(ref parametroSs, 0, "@msgerror", SqlDbType.VarChar, mensaje_error);
                    cls_DAL.agregar_datos_estructura_parametros(ref parametroSs, 1, "@numerror", SqlDbType.Int, numero_error);
                    cls_DAL.conectar(conexion, ref mensaje_error, ref numero_error);
                    cls_DAL.ejecuta_sqlcommand(conexion, sql, true, parametroSs, ref mensaje_error, ref numero_error);
                    cls_DAL.desconectar(conexion, ref mensaje_error, ref numero_error);
                    return null;
                }
                else
                {
                    return ds;
                }
            }
        }

        #endregion




    }
}
