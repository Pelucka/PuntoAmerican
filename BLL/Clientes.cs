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
   public class clientes
    {
        #region Propiedades
        private int _IdCliente;

        public int IdCliente
        {
            get { return _IdCliente; }
            set { _IdCliente = value; }
        }

        private string _Nombre;

        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }

        private decimal _identificacion;

        public decimal Identificacion
        {
            get { return _identificacion; }
            set { _identificacion = value; }
        }

        private string _Correo;

        public string Correo
        {
            get { return _Correo; }
            set { _Correo = value; }
        }

        private int _Telefono;

        public int Telefono
        {
            get { return _Telefono; }
            set { _Telefono = value; }
        }

        private int _Tipo;

        public int Tipo
        {
            get { return _Tipo; }
            set { _Tipo = value; }
        }

        private int _TipoIdentificacion;

        public int TipoIdentificacion
        {
            get { return _TipoIdentificacion; }
            set { _TipoIdentificacion = value; }
        }

        private int _CodigoUbicacion;

        public int CodigoUbicacion
        {
            get { return _CodigoUbicacion; }
            set { _CodigoUbicacion = value; }
        }
        private string _DescUbicacion;

        public string DescUbicacion
        {
            get { return _DescUbicacion; }
            set { _DescUbicacion = value; }
        }



        #endregion
        #region Variables Privadas
        SqlConnection conexion;
        DataSet ds;
        string sql;
        string mensaje_error = string.Empty;
        int numero_error = 0;
        private string _Validacion;

        public string Validacion
        {
            get { return _Validacion; }
            set { _Validacion = value; }
        }

        #endregion
        #region Metodos
        public bool INSERT_CLIENTES()
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
                sql = "USP_CLIENTES_INSERT";
                ParamStruct[] parametros = new ParamStruct[7];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@nombre", SqlDbType.VarChar, _Nombre);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@ident", SqlDbType.Decimal, _identificacion);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 2, "@correo", SqlDbType.VarChar, _Correo);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 3, "@telefono", SqlDbType.Int, _Telefono);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 4, "@tipoidenti", SqlDbType.Int, _TipoIdentificacion);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 5, "@codubica", SqlDbType.Int, _CodigoUbicacion);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 6, "@descubica", SqlDbType.VarChar, _DescUbicacion);
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
        public DataSet BUSQUEDA_CLIENTE()
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
                sql = "USP_CLIENTES_SELECT_ALL";
                ParamStruct[] parametros = new ParamStruct[2];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@busq", SqlDbType.Decimal, _identificacion);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@tipo", SqlDbType.Int, _Tipo);
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
        public DataSet CARGA_TIPO_IDENTIFICACION()
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
                sql = "USP_TIPO_IDENTIFICACION_SELECT";
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
        #endregion

    }
}
