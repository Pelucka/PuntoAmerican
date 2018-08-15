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
    public class Login
    {
        /*Region de codigo que contiene las propiedades utilizadas dentro de la clase Login*/
        #region Propiedades
        private string _LoginU;

        public string LoginU
        {
            get { return _LoginU; }
            set { _LoginU = value; }
        }


        private string _Contra;

        public string Contra
        {
            get { return _Contra; }
            set { _Contra = value; }
        }

        private string _Ubicacion;

        public string Ubicacion
        {
            get { return _Ubicacion; }
            set { _Ubicacion = value; }
        }

        private string _Rol;

        public string Rol
        {
            get { return _Rol; }
            set { _Rol = value; }
        }
        private string _LoginSalida;

        public string LoginSalida
        {
            get { return _LoginSalida; }
            set { _LoginSalida = value; }
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
         dentro de la clase Login*/
        #region Metodos

        /*Metodo que permite realizar el ingreso al sistema, segun el usuario registrado*/
        public void LOGIN()
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
                sql = "USP_USUARIOS_LOGIN";
                ParamStruct[] parametros = new ParamStruct[2];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@login", SqlDbType.VarChar, _LoginU);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@contra", SqlDbType.VarChar, _Contra);
                ds = cls_DAL.ejecuta_dataset(conexion, sql, true, parametros, ref mensaje_error, ref numero_error);
                if (numero_error != 0)
                {
                    if (numero_error == 40615)
                    {
                        MessageBox.Show("Permisos en la Base Denegados ", "Sin Permisos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        /*Instancia a un Procedimiento Almacenado*/
                        sql = "USP_ERROR_INSERT";
                        ParamStruct[] parametross = new ParamStruct[2];
                        cls_DAL.agregar_datos_estructura_parametros(ref parametross, 0, "@msgerror", SqlDbType.VarChar, mensaje_error);
                        cls_DAL.agregar_datos_estructura_parametros(ref parametross, 1, "@numerror", SqlDbType.Int, numero_error);
                        cls_DAL.ejecuta_sqlcommand(conexion, sql, true, parametross, ref mensaje_error, ref numero_error);
                        cls_DAL.desconectar(conexion, ref mensaje_error, ref numero_error);
                    }
                }
                
                   
                else
                {
                    /*Se valida la informacion solicitada*/
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        _LoginSalida = ds.Tables[0].Rows[0]["Login"].ToString();
                        _Ubicacion = ds.Tables[0].Rows[0]["Ubicacion"].ToString();
                        _Rol = ds.Tables[0].Rows[0]["Rol"].ToString();
                        cls_DAL.desconectar(conexion, ref mensaje_error, ref numero_error);

                    }
                    else
                    {
                        MessageBox.Show("Usuario o Contraseña Invalidos", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cls_DAL.desconectar(conexion, ref mensaje_error, ref numero_error);

                    }


                }
            }
        }


        #endregion





    }
}
