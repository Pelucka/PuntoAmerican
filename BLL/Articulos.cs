using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace BLL
{
   public class Articulos
    {
        #region Propiedades
        private int _Codigo;

        public int Codigo
        {
            get { return _Codigo; }
            set { _Codigo = value; }
        }

        private string _Descripcion;

        public string Descripcion
        {
            get { return _Descripcion; }
            set { _Descripcion = value; }
        }

        private string _UnidadMedida;

        public string UnidadMedida
        {       
            get { return _UnidadMedida; }
            set { _UnidadMedida = value; }
        }
        private int  _Impuesto;

        public int Impuesto
        {
            get { return _Impuesto; }
            set { _Impuesto = value; }
        }
        private Boolean _Habilitar;

        public Boolean Habilitar
        {
            get { return _Habilitar; }
            set { _Habilitar = value; }
        }

        private int _Precio;

        public int Precio
        {
            get { return _Precio; }
            set { _Precio = value; }
        }

        private int _Departamento;

        public int Departamento
        {
            get { return _Departamento; }
            set { _Departamento = value; }
        }




        #endregion
        #region Variable Privadas
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

        public bool INSERT_ARTICULOS()
        {
            /*Verificacion de la conexion al servidor*/
            conexion = cls_DAL.trae_conexion("PuntoAmericano", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                /*Instancia a un Procedimiento Almacenado*/
                MessageBox.Show("Error en la Conexion" + mensaje_error + "  " + numero_error);
                return false;
            }
            else
            {
                /*Instancia a un Procedimiento Almacenado*/
                sql = "USP_ARTICULOS_INSERT";
                ParamStruct[] parametros = new ParamStruct[5];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@Descr", SqlDbType.VarChar, _Descripcion);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@UniMedi", SqlDbType.VarChar, _UnidadMedida);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 2, "@Impuesto", SqlDbType.Decimal, _Impuesto);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 3, "@Precio", SqlDbType.Int, _Precio);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 4, "@Departamento", SqlDbType.Int, _Departamento);
                cls_DAL.conectar(conexion, ref mensaje_error, ref numero_error);
                cls_DAL.ejecuta_sqlcommand(conexion, sql, true, parametros, ref mensaje_error, ref numero_error);
                if (numero_error != 0)
                {
                    /*Instancia a un Procedimiento Almacenado*/

                    MessageBox.Show("Error al Enviar los Datos" + mensaje_error + "  " + numero_error);
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

        public bool UPDATE_ARTICULOS()
        {
            /*Verificacion de la conexion al servidor*/
            conexion = cls_DAL.trae_conexion("PuntoAmericano", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                /*Instancia a un Procedimiento Almacenado*/
                MessageBox.Show("Error en la Conexion" + mensaje_error + "  " + numero_error);
                return false;
            }
            else
            {
                /*Instancia a un Procedimiento Almacenado*/
                sql = "USP_ARTICULOS_UPDATE";
                ParamStruct[] parametros = new ParamStruct[7];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@Descr", SqlDbType.VarChar, _Descripcion);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@UniMedi", SqlDbType.VarChar, _UnidadMedida);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 2, "@Impuesto", SqlDbType.Int, _Impuesto);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 3, "@Precio", SqlDbType.Int, _Precio);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 4, "@Activo", SqlDbType.Bit, _Habilitar);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 5, "@codarti", SqlDbType.Int, _Codigo);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 6, "@Departamento", SqlDbType.Int, _Departamento);
                cls_DAL.conectar(conexion, ref mensaje_error, ref numero_error);
                cls_DAL.ejecuta_sqlcommand(conexion, sql, true, parametros, ref mensaje_error, ref numero_error);
                if (numero_error != 0)
                {
                    /*Instancia a un Procedimiento Almacenado*/

                    MessageBox.Show("Error al Enviar los Datos" + mensaje_error + "  " + numero_error);
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
                sql = "USP_ARTICULOS_SELECT";
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
        public DataSet CARGA_IMPUESTOS()
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
                sql = "USP_IMPUESTOS_SELECT";
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

        public DataSet CARGA_DEPARTAMENTO()
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

        #endregion
    }
}
