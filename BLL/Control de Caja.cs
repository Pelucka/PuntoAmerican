using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Windows.Forms;

namespace BLL
{
    public class ControldeCaja
    {
        /*Region de codigo que contiene las propiedades utlizadas dentro de la clase Contron de Caja*/
        #region Propiedades
        private int _M5;

        public int M5
        {
            get { return _M5; }
            set { _M5 = value; }
        }
        private int _M10;

        public int M10
        {
            get { return _M10; }
            set { _M10 = value; }
        }

        private int _M25;

        public int M25
        {
            get { return _M25; }
            set { _M25 = value; }
        }

        private int _M50;

        public int M50
        {
            get { return _M50; }
            set { _M50 = value; }
        }

        private int _M100;

        public int M100
        {
            get { return _M100; }
            set { _M100 = value; }
        }

        private int _M500;

        public int M500
        {
            get { return _M500; }
            set { _M500 = value; }
        }

        private int _B1000;

        public int B1000
        {
            get { return _B1000; }
            set { _B1000 = value; }
        }

        private int _B2000;

        public int B2000
        {
            get { return _B2000; }
            set { _B2000 = value; }
        }
        private int _B5000;

        public int B5000
        {
            get { return _B5000; }
            set { _B5000 = value; }
        }

        private int _B10000;

        public int B10000
        {
            get { return _B10000; }
            set { _B10000 = value; }
        }

        private int _B20000;

        public int B20000
        {
            get { return _B20000; }
            set { _B20000 = value; }
        }

        private int _B50000;

        public int B50000
        {
            get { return _B50000; }
            set { _B50000 = value; }
        }

        private int _InicioCaja;

        public int InicioCaja
        {
            get { return _InicioCaja; }
            set { _InicioCaja = value; }
        }
        private string _Ubicacion;

        public string Ubicacion
        {
            get { return _Ubicacion; }
            set { _Ubicacion = value; }
        }
        private string _Usuario;

        public string Usuario
        {
            get { return _Usuario; }
            set { _Usuario = value; }
        }

        private string _Validacion;

        public string Validacion
        {
            get { return _Validacion; }
            set { _Validacion = value; }
        }

        private string _InicioCajaparaFinCaja;

        public string InicioCajaparaFinCaja
        {
            get { return _InicioCajaparaFinCaja; }
            set { _InicioCajaparaFinCaja = value; }
        }
        private string _DineroTotalDia;

        public string DineroTotalDia
        {
            get { return _DineroTotalDia; }
            set { _DineroTotalDia = value; }
        }
        private string _Gastos;

        public string Gastos
        {
            get { return _Gastos; }
            set { _Gastos = value; }
        }

        private string _TotaldelDia;

        public string TotaldelDia
        {
            get { return _TotaldelDia; }
            set { _TotaldelDia = value; }
        }

        private string _FinCaja;

        public string FinCaja
        {
            get { return _FinCaja; }
            set { _FinCaja = value; }
        }

        private string _Total;

        public string Total
        {
            get { return _Total; }
            set { _Total = value; }
        }






        #endregion
        /*Region de codigo que contiene las variables privadas para la conexion al servidor*/
        #region Variables Privadas
        SqlConnection conexion;
        DataSet ds;
        string sql;
        string mensaje_error = string.Empty;
        int numero_error = 0;
        #endregion
        /*Region de codigo que contiene los metodos instaciados a Procedimientos Almacenados necesitados 
        dentro de la clase Control de Caja*/
        #region Metodos

        /*Metodo que permite Instanciar a un procedimiento almacenado para la inserccion de informacion dentro de
         la tabla Control*/
        public bool INSERT_INICIO_CAJA()
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
                sql = "USP_CONTROL_INSERT_INICIOCAJA";
                ParamStruct[] parametros = new ParamStruct[15];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@5", SqlDbType.VarChar, _M5);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@10", SqlDbType.VarChar, _M10);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 2, "@25", SqlDbType.VarChar, _M25);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 3, "@50", SqlDbType.VarChar, _M50);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 4, "@100", SqlDbType.VarChar, _M100);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 5, "@500", SqlDbType.VarChar, _M500);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 6, "@1000", SqlDbType.VarChar, _B1000);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 7, "@2000", SqlDbType.VarChar, _B2000);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 8, "@5000", SqlDbType.VarChar, _B5000);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 9, "@10000", SqlDbType.VarChar, _B10000);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 10, "@20000", SqlDbType.VarChar, _B20000);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 11, "@50000", SqlDbType.VarChar, _B50000);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 12, "@IniCaja", SqlDbType.VarChar, _InicioCaja);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 13, "@ubi", SqlDbType.VarChar, _Ubicacion);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 14, "@usu", SqlDbType.VarChar, _Usuario);

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

        /*Metodo que permite obtener el Inicio de caja segun la ubicacion de la surcusal*/
        public void SELECT_INICIO_CAJA()
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

            }
            else
            {
                /*Instancia a un Procedimiento Almacenado*/
                sql = "USP_CONTROL_SELECT_INICIOCAJA";
                ParamStruct[] parametros = new ParamStruct[1];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@ubi", SqlDbType.VarChar, _Ubicacion);
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
                    /*Validacion de la obtencion el Inicio de Caja segun la ubicacion*/
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        _InicioCajaparaFinCaja = ds.Tables[0].Rows[0]["InicioCaja"].ToString();
                        cls_DAL.desconectar(conexion, ref mensaje_error, ref numero_error);

                    }
                    else
                    {
                        _Validacion = "Error";
                        MessageBox.Show("No se Encontro el Saldo Inicial", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cls_DAL.desconectar(conexion, ref mensaje_error, ref numero_error);

                    }


                }
            }
        }


        /*Metodo que permite obtener las ventas realizadas diariamente*/
        public void SELECT_VENTAS_DEL_DIA()
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

            }
            else
            {
                /*Instancia a un Procedimiento Almacenado*/
                sql = "USP_CONTROL_SELECT_DINEROTOTAL";
                ParamStruct[] parametros = new ParamStruct[1];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@ubi", SqlDbType.VarChar, _Ubicacion);
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
                    /*Validacion de la Informacion obtenida por medio de la seleccion*/
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        _DineroTotalDia = ds.Tables[0].Rows[0]["DineroTotal"].ToString();
                        cls_DAL.desconectar(conexion, ref mensaje_error, ref numero_error);
                        if (_DineroTotalDia == "")
                        {
                            _DineroTotalDia = "0";
                        }

                    }
                    else
                    {

                        MessageBox.Show("No se Encontro el Saldo Inicial", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cls_DAL.desconectar(conexion, ref mensaje_error, ref numero_error);

                    }


                }
            }
        }

        /*Metodo que permite obtener los gastos realizados dentro del Día*/
        public void SELECT_GASTOS_DEL_DIA()
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

            }
            else
            {
                /*Instancia a un Procedimiento Almacenado*/
                sql = "USP_CONTROL_SELECT_GASTOS_HOY";
                ParamStruct[] parametros = new ParamStruct[1];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@ubi", SqlDbType.VarChar, _Ubicacion);
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
                    /*Validacion de la informacion solicitada por medio del metodo*/
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        _Gastos = ds.Tables[0].Rows[0]["Gastos"].ToString();
                        cls_DAL.desconectar(conexion, ref mensaje_error, ref numero_error);
                        if (_Gastos == "")
                        {
                            _Gastos = "0";
                        }

                    }
                    else
                    {
                        _Gastos = "0";
                        MessageBox.Show("No se Encontro el Gasto Total", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cls_DAL.desconectar(conexion, ref mensaje_error, ref numero_error);

                    }


                }
            }
        }

        /*Metodo que permite la Actualizacion de los datos del Final de Caja*/
        public bool UPDATE_FIN_CAJA()
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
                sql = "USP_CONTROL_UPDATE_INICIOCAJA";
                ParamStruct[] parametros = new ParamStruct[16];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@5", SqlDbType.VarChar, _M5);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@10", SqlDbType.VarChar, _M10);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 2, "@25", SqlDbType.VarChar, _M25);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 3, "@50", SqlDbType.VarChar, _M50);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 4, "@100", SqlDbType.VarChar, _M100);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 5, "@500", SqlDbType.VarChar, _M500);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 6, "@1000", SqlDbType.VarChar, _B1000);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 7, "@2000", SqlDbType.VarChar, _B2000);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 8, "@5000", SqlDbType.VarChar, _B5000);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 9, "@10000", SqlDbType.VarChar, _B10000);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 10, "@20000", SqlDbType.VarChar, _B20000);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 11, "@50000", SqlDbType.VarChar, _B50000);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 12, "@FinCaja", SqlDbType.VarChar, _FinCaja);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 13, "@ubi", SqlDbType.VarChar, _Ubicacion);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 14, "@usu", SqlDbType.VarChar, _Usuario);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 15, "@total", SqlDbType.VarChar, _Total);

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
                    /*Validacion de la Actualizacion*/
                    cls_DAL.desconectar(conexion, ref mensaje_error, ref numero_error);
                    _Validacion = "Actualizado";
                    return true;
                }
            }

        }

        /*Metodo que permite obtener el total que se realizo durante el día*/
        public void TOTAL_DEL_DIA()
        {
            _TotaldelDia = (Convert.ToDecimal(_InicioCajaparaFinCaja) + Convert.ToDecimal(_DineroTotalDia) - Convert.ToDecimal(_Gastos)).ToString();
        }


        #endregion


    }
}
