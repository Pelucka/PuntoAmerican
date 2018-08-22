using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DAL;
using System.Data;
using System.Windows.Forms;

namespace BLL
{
    public class Caja
    {
        /*Region de Código que contiene las propiedades utilizadas dentro de la clase Caja*/
        #region Propiedades        

        private string _Departamento;

        public string Departamento
        {
            get { return _Departamento; }
            set { _Departamento = value; }
        }

        private string _Venta;

        public string Venta
        {
            get { return _Venta; }
            set { _Venta = value; }
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

        private string _Ubicacion;

        public string Ubicacion
        {
            get { return _Ubicacion; }
            set { _Ubicacion = value; }
        }

        private string _Total;

        public string Total
        {
            get { return _Total; }
            set { _Total = value; }
        }

        private string _CodigoFactura;

        public string CodigoFactura
        {
            get { return _CodigoFactura; }
            set { _CodigoFactura = value; }
        }


        private string _TipoPago;

        public string TipoPago
        {
            get { return _TipoPago; }
            set { _TipoPago = value; }
        }

        private string _DineroTotal;

        public string DineroTotal
        {
            get { return _DineroTotal; }
            set { _DineroTotal = value; }
        }

        private string _CantidadPagar;

        public string CantidadPagar
        {
            get { return _CantidadPagar; }
            set { _CantidadPagar = value; }
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

        private string _Descripcion;

        public string Descripcion
        {
            get { return _Descripcion; }
            set { _Descripcion = value; }
        }


        //--- CARGA COD FACTURA ---//
        private string _Prefijo;

        public string Prefijo
        {
            get { return _Prefijo; }
            set { _Prefijo = value; }
        }

        private string _Secuencia;

        public string Secuencia
        {
            get { return _Secuencia; }
            set { _Secuencia = value; }
        }

        private string _CodigoFinalFactura;

        public string CodigoFinalFactura
        {
            get { return _CodigoFinalFactura; }
            set { _CodigoFinalFactura = value; }
        }
        //-------------------------------------//

        private string _Articulos;

        public string Articulos
        {
            get { return _Articulos; }
            set { _Articulos = value; }
        }



        #endregion
        /*Region de Código para el control de la conexión al servidor*/
        #region Variables Privadas       
        SqlConnection conexion;
        DataSet ds;
        string sql;
        string mensaje_error = string.Empty;
        int numero_error = 0;
        #endregion
        /*Region de Código que Contiene los Metodos instanciados a Procedimientos Almacenados que son utilizados
         dentro de la clase Caja*/
        #region Metodos

        /*Metodo el cual realiza la conexion al servidor, para posteriormente conectar con un Procedimiento
         Almacenado el cual, provoca el insertar los datos en la tabla Ventas*/
        public bool INSERT_VENTAS()
        {
            conexion = cls_DAL.trae_conexion("PuntoAmericano", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                /*Llamado al Procedimiento dentro de la BD*/
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
                /*Llamado al Procedimiento dentro de la BD*/
                sql = "USP_VENTAS_INSERT";
                ParamStruct[] parametros = new ParamStruct[7];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@depart", SqlDbType.VarChar, _Departamento);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@venta", SqlDbType.VarChar, _Venta);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 2, "@cantidad", SqlDbType.VarChar, _Cantidad);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 3, "@precio", SqlDbType.VarChar, _Precio);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 4, "@ubicacion", SqlDbType.VarChar, _Ubicacion);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 5, "@total", SqlDbType.VarChar, _Total);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 6, "@codfactura", SqlDbType.VarChar, _CodigoFactura);

                cls_DAL.conectar(conexion, ref mensaje_error, ref numero_error);
                cls_DAL.ejecuta_sqlcommand(conexion, sql, true, parametros, ref mensaje_error, ref numero_error);
                if (numero_error != 0)
                {
                    /*Llamado al Procedimiento dentro de la BD*/
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
                    /*Validación de Insercción*/
                    cls_DAL.desconectar(conexion, ref mensaje_error, ref numero_error);
                    _Validacion = "Insertado";
                    return true;
                }
            }
        }

        /*Metodo que realiza la instancia a un Procedimiento Almacenado dentro de la BD, permite insertar
         la información dentro de la Tabla Ventas Totales*/
        public bool INSERT_VENTASTOTALES()
        {
            conexion = cls_DAL.trae_conexion("PuntoAmericano", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                /*Llamado al Procedimiento dentro de la BD*/
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
                /*Llamado al Procedimiento dentro de la BD*/
                sql = "USP_VENTASTOTALES_INSERT";
                ParamStruct[] parametros = new ParamStruct[10];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@cod_factura", SqlDbType.VarChar, _CodigoFinalFactura);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@ubicacion", SqlDbType.VarChar, _DineroTotal);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 2, "@fecha", SqlDbType.VarChar, _Ubicacion);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 3, "@dinerototal", SqlDbType.VarChar, _CodigoFactura);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 4, "@login", SqlDbType.VarChar, _Login);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 5, "@descripcion", SqlDbType.VarChar, _Descripcion);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 6, "@cliente", SqlDbType.VarChar, _Descripcion);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 7, "@impuesto", SqlDbType.VarChar, _Descripcion);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 8, "@condicionventa", SqlDbType.VarChar, _Descripcion);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 9, "@mediodepago", SqlDbType.VarChar, _Descripcion);
                cls_DAL.conectar(conexion, ref mensaje_error, ref numero_error);
                cls_DAL.ejecuta_sqlcommand(conexion, sql, true, parametros, ref mensaje_error, ref numero_error);

                if (numero_error != 0)
                {
                    /*Llamado al Procedimiento dentro de la BD*/
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
                    /*Validación de Insercción*/
                    cls_DAL.desconectar(conexion, ref mensaje_error, ref numero_error);
                    _Validacion = "Insertado";
                    return true;
                }
            }
        }

        /*Metodo que permite obtener por medio de la instancia a un Procedimiento Almacenado, el prefijo de las
         ubicaciones de cada una de las Sucursales de la Empresa, por medio de el nombre de la Sucursal*/
        public void CARGA_CODFACTURA()
        {
            conexion = cls_DAL.trae_conexion("PuntoAmericano", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                /*Llamado al Procedimiento dentro de la BD*/
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
                /*Llamado al Procedimiento dentro de la BD*/
                sql = "USP_UBICACION_SELECT_PREFIJO_SECUENCIA";
                ParamStruct[] parametros = new ParamStruct[1];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@Descrip", SqlDbType.VarChar, _Ubicacion);
                ds = cls_DAL.ejecuta_dataset(conexion, sql, true, parametros, ref mensaje_error, ref numero_error);


                if (numero_error != 0)
                {
                    /*Llamado al Procedimiento dentro de la BD*/
                    sql = " USP_ERROR_INSERT";
                    ParamStruct[] parametroSs = new ParamStruct[2];
                    cls_DAL.agregar_datos_estructura_parametros(ref parametroSs, 0, "@msgerror", SqlDbType.VarChar, mensaje_error);
                    cls_DAL.agregar_datos_estructura_parametros(ref parametroSs, 1, "@numerror", SqlDbType.Int, numero_error);
                    cls_DAL.conectar(conexion, ref mensaje_error, ref numero_error);
                    cls_DAL.ejecuta_sqlcommand(conexion, sql, true, parametroSs, ref mensaje_error, ref numero_error);
                    cls_DAL.desconectar(conexion, ref mensaje_error, ref numero_error);
                }
                else
                {
                    /*Se obtienen los datos deseados por medio de la busqueda realizada*/
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        _CodigoFinalFactura = ds.Tables[0].Rows[0]["id"].ToString();
                    }
                    else
                    {
                        _CodigoFinalFactura = "Error";
                    }
                }
            }
        }

        /*Metodo que permite la actualizacion de la secuencia dentro de los codigos de facturas, de manera
         que se obtiene los articulos vendidos al un mismo cliente*/
        public bool ACTUALIZA_SECUENCIA_FACTURA()
        {
            conexion = cls_DAL.trae_conexion("PuntoAmericano", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                /*Llamado al Procedimiento dentro de la BD*/
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
                /*Llamado al Procedimiento dentro de la BD*/
                string SecuenciaNueva = Convert.ToString(Convert.ToInt32(_Secuencia) + 1);
                sql = "USP_UBICACION_UPDATE_SECUENCIA";
                ParamStruct[] parametros = new ParamStruct[2];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@ubica", SqlDbType.VarChar, _Ubicacion);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@secuencia", SqlDbType.VarChar, SecuenciaNueva);
                cls_DAL.conectar(conexion, ref mensaje_error, ref numero_error);
                cls_DAL.ejecuta_sqlcommand(conexion, sql, true, parametros, ref mensaje_error, ref numero_error);
                if (numero_error != 0)
                {
                    /*Llamado al Procedimiento dentro de la BD*/
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
                    /*Validación de la Actualizacion realizada*/
                    cls_DAL.desconectar(conexion, ref mensaje_error, ref numero_error);
                    _Validacion = "Actualizado";
                    return true;
                }
            }
        }
        public DataSet CARGA_CONDICIONVENTA()
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
                sql = "USP_CONDICION_VENTA_SELECT_ALL";
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

        public DataSet CARGA_MEDIO_DE_PAGO()
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
                sql = "USP_MEDIOS_DE_PAGO_SELECT_ALL";
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

        public DataSet CARGA_ARTICULOS()
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
                sql = "USP_ARTICULOS_SELECT_NOMBRE";
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

        public DataSet CARGA_DEPARTAMENTOS()
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
                sql = "USP_DEPARTAMENTOS_SELECT_ALL";
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

        public DataSet BUSQUEDA_ARTICULOS()
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
                sql = "USP_ARTICULOS_SELECT_ARTICULOS_DESCRIPCION";
                ParamStruct[] parametros = new ParamStruct[1];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@Articulo", SqlDbType.VarChar, _Articulos);
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

        public DataSet BUSQUEDA_DEPARTAMENTO()
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
                sql = "USP_ARTICULOS_SELECT_ARTICULOS_DEPARTAMENTO";
                ParamStruct[] parametros = new ParamStruct[1];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@Departamento", SqlDbType.VarChar, _Departamento);
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
