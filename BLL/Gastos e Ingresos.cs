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

namespace BLL
{
    public class Gastos_e_Ingresos
    {
        /*Region de codigo que contiene las propiedades utilizadas dentro de la clase Gastos e Ingresos*/
        #region Propiedades
        private string _Gastos;

        public string Gastos
        {
            get { return _Gastos; }
            set { _Gastos = value; }
        }

        private string _Ingresos;

        public string Ingresos
        {
            get { return _Ingresos; }
            set { _Ingresos = value; }
        }

        private string _Ubicacion;

        public string Ubicacion
        {
            get { return _Ubicacion; }
            set { _Ubicacion = value; }
        }


        private string _Descripcion;

        public string Descripcion
        {
            get { return _Descripcion; }
            set { _Descripcion = value; }
        }

        private string _Validacion;

        public string Validacion
        {
            get { return _Validacion; }
            set { _Validacion = value; }
        }

        private string _TipoGasto;

        public string TipoGasto
        {
            get { return _TipoGasto; }
            set { _TipoGasto = value; }
        }

        private int _Mes;

        public int Mes
        {
            get { return _Mes; }
            set { _Mes = value; }
        }

        private int _Año;

        public int Año
        {
            get { return _Año; }
            set { _Año = value; }
        }

        private string _Usuario;

        public string Usuario
        {
            get { return _Usuario; }
            set { _Usuario = value; }
        }


        //-- Suma de los Datos --//
        private string _GastoNuevo;

        public string GastoNuevo
        {
            get { return _GastoNuevo; }
            set { _GastoNuevo = value; }
        }

        private string _IngresoNuevo;

        public string IngresoNuevo
        {
            get { return _IngresoNuevo; }
            set { _IngresoNuevo = value; }
        }

        private decimal _Ganancia;

        public decimal Ganancia
        {
            get { return _Ganancia; }
            set { _Ganancia = value; }
        }

        //-- Busquedas -- //
        private DateTime _Fechaini;

        public DateTime Fechaini
        {
            get { return _Fechaini; }
            set { _Fechaini = value; }
        }

        private DateTime _Fechafin;

        public DateTime Fechafin
        {
            get { return _Fechafin; }
            set { _Fechafin = value; }
        }


        private string _TipodePago;

        public string TipodePago
        {
            get { return _TipodePago; }
            set { _TipodePago = value; }
        }


        private int _Ubicacion2;

        public int Ubicacion2
        {
            get { return _Ubicacion2; }
            set { _Ubicacion2 = value; }
        }





        #endregion
        /*Region de Codigo que contiene las variables privadas para la conexion al servidor*/
        #region Variables Privadas
        SqlConnection conexion;
        DataSet ds;
        string sql;
        string mensaje_error = string.Empty;
        int numero_error = 0;
        #endregion
        /*Region de codigo que contiene los metodos instanciados a Procediemientos almacenados que son utilizados
         dentro de la clase Gastos e Ingresos*/
        #region Metodos

        /*Metodo que permite Insertar los gastos registrados dentro de la tabla Gastos*/
        public bool INSERT_GASTOS()
        {
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
                sql = "USP_GASTOS_INSERT";
                ParamStruct[] parametros = new ParamStruct[4];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@gast", SqlDbType.VarChar, _Gastos);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@desc", SqlDbType.VarChar, _Descripcion);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 2, "@ubi", SqlDbType.VarChar, _Ubicacion);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 3, "@tipogasto", SqlDbType.VarChar, _TipoGasto);

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
                    /*Validadicion de la Inserccion*/
                    cls_DAL.desconectar(conexion, ref mensaje_error, ref numero_error);
                    _Validacion = "Insertado";
                    return true;
                }
            }
        }

        /*Metodo que permite realizar la un registro de Ingreso a la tabla Ventas Totales*/
        public bool INSERT_INGRESO()
        {
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
                ParamStruct[] parametros = new ParamStruct[6];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@dinerototal", SqlDbType.VarChar, _Ingresos);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@ubicacion", SqlDbType.VarChar, _Ubicacion);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 2, "@descrip", SqlDbType.VarChar, _Descripcion);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 3, "@tipopago ", SqlDbType.VarChar, _TipodePago);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 4, "@login ", SqlDbType.VarChar, _Usuario);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 5, "@codfactura ", SqlDbType.VarChar, "Apartados");
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
                    /*Validacion de la Inserccion*/
                    cls_DAL.desconectar(conexion, ref mensaje_error, ref numero_error);
                    _Validacion = "Insertado";
                    return true;
                }
            }
        }

        /*Metodo que permite obtener la lista de los gastos registrado dentro de la BD*/
        public DataSet CARGA_LISTA_GASTOS()
        {
            conexion = cls_DAL.trae_conexion("Puntoamericano", ref mensaje_error, ref numero_error);
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
                sql = "USP_GASTOS_SELECT";

                ds = cls_DAL.ejecuta_dataset(conexion, sql, false, ref mensaje_error, ref numero_error);
                if (numero_error != 0)
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
                    return ds;

                }
            }
        }

        /*Metodo que permite obtener todos los ingresos registrados dentro de la BD*/
        public DataSet CARGA_LISTA_INGRESOS()
        {
            conexion = cls_DAL.trae_conexion("Puntoamericano", ref mensaje_error, ref numero_error);
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
                sql = "USP_VENTASTOTALES_SELECT";

                ds = cls_DAL.ejecuta_dataset(conexion, sql, false, ref mensaje_error, ref numero_error);
                if (numero_error != 0)
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
                    return ds;

                }
            }
        }

        /*Metodo que obtiene los ingresos segun la sucursal que se quiera*/
        public void CARGA_INGRESO_UBICACION()
        {
            conexion = cls_DAL.trae_conexion("Puntoamericano", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {

            }
            else
            {
                /*Instancia a un Procedimiento Almacenado*/
                sql = "USP_VENTASTOTALES_SELECT_UBICACION";

                ParamStruct[] parametros = new ParamStruct[1];

                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@ubi", SqlDbType.VarChar, _Ubicacion);
                //
                ds = cls_DAL.ejecuta_dataset(conexion, sql, true, parametros, ref mensaje_error, ref numero_error);

                if (numero_error != 0)
                {
                    //insertar en la tabla de errores

                }
                else
                {
                    /*Validaciones de la informacion solicitada*/
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        _IngresoNuevo = ds.Tables[0].Rows[0]["Ingresos"].ToString();

                    }
                    else
                    {
                        _IngresoNuevo = "0";
                    }
                }
            }
        }

        /*Metodo que obtiene los gastos por medio de la sucursal suministrada*/
        public void CARGA_GASTOS_UBICACION()
        {
            conexion = cls_DAL.trae_conexion("Puntoamericano", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {

            }
            else
            {
                /*Instancia a un Procedimiento Almacenado*/
                sql = "USP_GASTOS_SELECT_UBICACION";

                ParamStruct[] parametros = new ParamStruct[1];

                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@ubi", SqlDbType.VarChar, _Ubicacion);
                //
                ds = cls_DAL.ejecuta_dataset(conexion, sql, true, parametros, ref mensaje_error, ref numero_error);

                if (numero_error != 0)
                {
                    //insertar en la tabla de errores

                }
                else
                {
                    /*Se valida la informacion solicitada*/
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        _GastoNuevo = ds.Tables[0].Rows[0]["Gastos"].ToString();
                    }
                    else
                    {
                        _GastoNuevo = "0";
                    }
                    _Ganancia = Convert.ToDecimal(_IngresoNuevo) - Convert.ToDecimal(_GastoNuevo);
                }
            }
        }

        /*Metodo que permite Carga los ingresos obtenidos mensualmente*/
        public DataSet CARGA_INGRESO_MES()
        {
            conexion = cls_DAL.trae_conexion("Puntoamericano", ref mensaje_error, ref numero_error);
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
                sql = "USP_INGRESOSTOTALES_MES";

                ParamStruct[] parametros = new ParamStruct[2];


                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@mes", SqlDbType.Int, _Mes);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@año", SqlDbType.Int, _Año);

                ds = cls_DAL.ejecuta_dataset(conexion, sql, true, parametros, ref mensaje_error, ref numero_error);

                if (numero_error != 0)
                {
                    /*Instancia a un Procedimiento Almacenado*/
                    sql = " USP_ERROR_INSERT";
                    ParamStruct[] parametross = new ParamStruct[2];
                    cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@msgerror", SqlDbType.VarChar, mensaje_error);
                    cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@numerror", SqlDbType.Int, numero_error);
                    cls_DAL.conectar(conexion, ref mensaje_error, ref numero_error);
                    cls_DAL.ejecuta_sqlcommand(conexion, sql, true, parametros, ref mensaje_error, ref numero_error);
                    cls_DAL.desconectar(conexion, ref mensaje_error, ref numero_error);
                    return null;
                }
                else
                {
                    return ds;

                }

            }
        }

        /*Metodo que permite obtener los ingresos anuales*/
        public DataSet CARGA_INGRESO_AÑO()
        {
            conexion = cls_DAL.trae_conexion("Puntoamericano", ref mensaje_error, ref numero_error);
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
                sql = "USP_INGRESOSTOTALES_AÑO";

                ParamStruct[] parametros = new ParamStruct[1];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@año", SqlDbType.Int, _Año);
                ds = cls_DAL.ejecuta_dataset(conexion, sql, true, parametros, ref mensaje_error, ref numero_error);

                if (numero_error != 0)
                {
                    /*Instancia a un Procedimiento Almacenado*/
                    sql = " USP_ERROR_INSERT";
                    ParamStruct[] parametross = new ParamStruct[2];
                    cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@msgerror", SqlDbType.VarChar, mensaje_error);
                    cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@numerror", SqlDbType.Int, numero_error);
                    cls_DAL.conectar(conexion, ref mensaje_error, ref numero_error);
                    cls_DAL.ejecuta_sqlcommand(conexion, sql, true, parametros, ref mensaje_error, ref numero_error);
                    cls_DAL.desconectar(conexion, ref mensaje_error, ref numero_error);
                    return null;
                }
                else
                {
                    return ds;

                }

            }
        }

        /*Metodo que permite obtener los gastos mensuales*/
        public DataSet CARGA_GASTO_MES()
        {
            conexion = cls_DAL.trae_conexion("Puntoamericano", ref mensaje_error, ref numero_error);
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
                sql = "USP_GASTOSTOTALES_MES";

                ParamStruct[] parametros = new ParamStruct[2];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@mes", SqlDbType.Int, _Mes);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@año", SqlDbType.Int, _Año);
                ds = cls_DAL.ejecuta_dataset(conexion, sql, true, parametros, ref mensaje_error, ref numero_error);

                if (numero_error != 0)
                {
                    /*Instancia a un Procedimiento Almacenado*/
                    sql = " USP_ERROR_INSERT";
                    ParamStruct[] parametross = new ParamStruct[2];
                    cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@msgerror", SqlDbType.VarChar, mensaje_error);
                    cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@numerror", SqlDbType.Int, numero_error);
                    cls_DAL.conectar(conexion, ref mensaje_error, ref numero_error);
                    cls_DAL.ejecuta_sqlcommand(conexion, sql, true, parametros, ref mensaje_error, ref numero_error);
                    cls_DAL.desconectar(conexion, ref mensaje_error, ref numero_error);
                    return null;
                }
                else
                {
                    return ds;

                }

            }
        }

        /*Metodo que pemite obtener los gatos anuales*/
        public DataSet CARGA_GASTO_AÑO()
        {
            conexion = cls_DAL.trae_conexion("Puntoamericano", ref mensaje_error, ref numero_error);
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
                sql = "USP_GASTOSTOTALES_AÑO";

                ParamStruct[] parametros = new ParamStruct[1];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@año", SqlDbType.Int, _Año);
                ds = cls_DAL.ejecuta_dataset(conexion, sql, true, parametros, ref mensaje_error, ref numero_error);

                if (numero_error != 0)
                {
                    /*Instancia a un Procedimiento Almacenado*/
                    sql = " USP_ERROR_INSERT";
                    ParamStruct[] parametross = new ParamStruct[2];
                    cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@msgerror", SqlDbType.VarChar, mensaje_error);
                    cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@numerror", SqlDbType.Int, numero_error);
                    cls_DAL.conectar(conexion, ref mensaje_error, ref numero_error);
                    cls_DAL.ejecuta_sqlcommand(conexion, sql, true, parametros, ref mensaje_error, ref numero_error);
                    cls_DAL.desconectar(conexion, ref mensaje_error, ref numero_error);
                    return null;
                }
                else
                {
                    return ds;

                }

            }
        }

        /*Metodo que permite obtener todos los gatos dentro de una surcusal por mes*/
        public void CARGA_GASTOSTOTALES_UBICACION_MES()
        {
            conexion = cls_DAL.trae_conexion("Puntoamericano", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {

            }
            else
            {
                /*Instancia a un Procedimiento Almacenado*/
                sql = "USP_GASTOSTOTALES_UBICACION_MES";

                ParamStruct[] parametros = new ParamStruct[3];

                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@ubi", SqlDbType.VarChar, _Ubicacion);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@mes", SqlDbType.Int, _Mes);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 2, "@año", SqlDbType.Int, _Año);

                ds = cls_DAL.ejecuta_dataset(conexion, sql, true, parametros, ref mensaje_error, ref numero_error);

                if (numero_error != 0)
                {
                    //insertar en la tabla de errores

                }
                else
                {
                    /*Se valida que se obtenga los datos solicitados*/
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        _GastoNuevo = ds.Tables[0].Rows[0]["Gastos"].ToString();
                    }
                    else
                    {
                        _GastoNuevo = "0";
                    }
                    _Ganancia = Convert.ToDecimal(_IngresoNuevo) - Convert.ToDecimal(_GastoNuevo);
                }
            }
        }

        /*Metodo que permite obtener los gastos dentro de una sucursal por año*/
        public void CARGA_GASTOSTOTALES_UBICACION_AÑO()
        {
            conexion = cls_DAL.trae_conexion("Puntoamericano", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {

            }
            else
            {
                /*Instancia a un Procedimiento Almacenado*/
                sql = "USP_GASTOSTOTALES_UBICACION_AÑO";

                ParamStruct[] parametros = new ParamStruct[2];

                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@ubi", SqlDbType.VarChar, _Ubicacion);

                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@año", SqlDbType.Int, _Año);

                ds = cls_DAL.ejecuta_dataset(conexion, sql, true, parametros, ref mensaje_error, ref numero_error);

                if (numero_error != 0)
                {
                    //insertar en la tabla de errores

                }
                else
                {
                    /*Se valida los datos obtenidos*/
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        _GastoNuevo = ds.Tables[0].Rows[0]["Gastos"].ToString();
                    }
                    else
                    {
                        _GastoNuevo = "0";
                    }
                    _Ganancia = Convert.ToDecimal(_IngresoNuevo) - Convert.ToDecimal(_GastoNuevo);
                }
            }
        }

        /*Metodo que permite obtener los ingresos por sucursal del mes*/
        public void CARGA_INGRESOsTOTALES_UBICACION_MES()
        {
            conexion = cls_DAL.trae_conexion("Puntoamericano", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {

            }
            else
            {
                /*Instancia a un Procedimiento Almacenado*/
                sql = "USP_INGRESOSTOTALES_UBICACION_MES";

                ParamStruct[] parametros = new ParamStruct[3];

                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@ubi", SqlDbType.VarChar, _Ubicacion);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@mes", SqlDbType.Int, _Mes);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 2, "@año", SqlDbType.Int, _Año);

                ds = cls_DAL.ejecuta_dataset(conexion, sql, true, parametros, ref mensaje_error, ref numero_error);

                if (numero_error != 0)
                {
                    //insertar en la tabla de errores

                }
                else
                {
                    /*Se valida la informacion solicitada*/
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        _IngresoNuevo = ds.Tables[0].Rows[0]["Ingresos"].ToString();

                    }
                    else
                    {
                        _IngresoNuevo = "0";
                    }
                }
            }
        }

        /*Metodo que permite cargar los ingresos por sucursal anualmente*/
        public void CARGA_INGRESOsTOTALES_UBICACION_AÑO()
        {
            conexion = cls_DAL.trae_conexion("Puntoamericano", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {

            }
            else
            {
                /*Instancia a un Procedimiento Almacenado*/
                sql = "USP_INGRESOSTOTALES_UBICACION_AÑO";

                ParamStruct[] parametros = new ParamStruct[2];

                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@ubi", SqlDbType.VarChar, _Ubicacion);

                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@año", SqlDbType.Int, _Año);

                ds = cls_DAL.ejecuta_dataset(conexion, sql, true, parametros, ref mensaje_error, ref numero_error);

                if (numero_error != 0)
                {
                    //insertar en la tabla de errores

                }
                else
                {
                    /*Se valida la informacion solicitada*/
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        _IngresoNuevo = ds.Tables[0].Rows[0]["Ingresos"].ToString();

                    }
                    else
                    {
                        _IngresoNuevo = "0";
                    }
                }
            }
        }

        /*Metodo que permite obtener una lista de todos los gastos registrados hasta el momento*/
        public DataSet CARGA_LISTA_GASTOS_TODO()
        {
            conexion = cls_DAL.trae_conexion("Puntoamericano", ref mensaje_error, ref numero_error);
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
                sql = "USP_GASTOS_SELECT_ALL";

                ds = cls_DAL.ejecuta_dataset(conexion, sql, false, ref mensaje_error, ref numero_error);
                if (numero_error != 0)
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
                    return ds;

                }
            }
        }

        /*Metodo que permite obtener un listado de todos los ingresos registrados hasta el momento*/
        public DataSet CARGA_LISTA_INGRESOS_TODO()
        {
            conexion = cls_DAL.trae_conexion("Puntoamericano", ref mensaje_error, ref numero_error);
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
                sql = "USP_INGRESOS_SELECT_ALL";

                ds = cls_DAL.ejecuta_dataset(conexion, sql, false, ref mensaje_error, ref numero_error);
                if (numero_error != 0)
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
                    return ds;

                }
            }
        }

        /*Permite obtener un listado de las sucursales*/
        public DataSet CARGA_UBICACION()
        {
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
                sql = "USP_UBICACION_SELECT_ALL";
                ds = cls_DAL.ejecuta_dataset(conexion, sql, true, ref mensaje_error, ref numero_error);


                if (numero_error != 0)
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
                    return ds;
                }
            }
        }

        /*Metodo que permite obtener un listado de los gastos por fecha*/
        public DataSet BUSQUEDA_GASTOS_FECHA()
        {
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
                sql = "USP_GASTOS_SELECT_FECHA_ALL";
                ParamStruct[] parametros = new ParamStruct[2];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@fechaini", SqlDbType.Date, _Fechaini);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@fechafin", SqlDbType.Date, _Fechafin);
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

        /*Metodo que permite obtener un listado de los gastos segun el tipo de gasto*/
        public DataSet BUSQUEDA_GASTOS_TIPOGASTO()
        {
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
                sql = "USP_GASTOS_SELECT_TIPOGASTO_ALL";
                ParamStruct[] parametros = new ParamStruct[1];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@tipo", SqlDbType.VarChar, _TipoGasto);
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

        /*Metodo que permite relizar una busqueda de los gastos segun la sucursal*/
        public DataSet BUSQUEDA_GASTOS_UBICACION()
        {
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
                sql = "USP_GASTOS_SELECT_UBICACION_ALL";
                ParamStruct[] parametros = new ParamStruct[1];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@ubi", SqlDbType.Int, _Ubicacion2);
                ds = cls_DAL.ejecuta_dataset(conexion, sql, true, parametros, ref mensaje_error, ref numero_error);


                if (numero_error != 0)
                {
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

        /*Metodo que permite realizar una busqueda de los ingresos segun la fecha*/
        public DataSet BUSQUEDA_INGRESOS_FECHA()
        {
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
                sql = "USP_INGRESOS_SELECT_FECHA_ALL";
                ParamStruct[] parametros = new ParamStruct[2];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@fechaini", SqlDbType.Date, _Fechaini);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@fechafin", SqlDbType.Date, _Fechafin);
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

        /*Metodo que permite realizar una busqueda de los ingresos segun el tipo de pago*/
        public DataSet BUSQUEDA_INGRESOS_TIPOPAGO()
        {
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
                sql = "USP_INGRESOS_SELECT_TIPOPAGO_ALL";
                ParamStruct[] parametros = new ParamStruct[1];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@tipo", SqlDbType.VarChar, _TipoGasto);
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

        /*Metodo que permite realizar una busqueda de los ingresos segun la sucursal*/
        public DataSet BUSQUEDA_INGRESOS_UBICACION()
        {
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
                sql = "USP_INGRESOS_SELECT_UBICACION_ALL";
                ParamStruct[] parametros = new ParamStruct[1];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@ubi", SqlDbType.Int, _Ubicacion2);
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
