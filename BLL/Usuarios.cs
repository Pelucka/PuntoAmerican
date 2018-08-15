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
using System.Net.Mail;
using System.Net;

namespace BLL
{
    public class usuarios
    {

        /*Region de codigo que contiene las propiedades utilizadas dentro de la clase Usuarios*/
        #region Propiedades

        private int _Codigo;

        public int Codigo
        {
            get { return _Codigo; }
            set { _Codigo = value; }
        }

        private string _Nombre;

        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }

        private string _Apellidos;

        public string Apellidos
        {
            get { return _Apellidos; }
            set { _Apellidos = value; }
        }

        private string _Telefono;

        public string Telefono
        {
            get { return _Telefono; }
            set { _Telefono = value; }
        }
        private string _Correo;

        public string Correo
        {
            get { return _Correo; }
            set { _Correo = value; }
        }

        private int _Ubicacion;

        public int Ubicacion
        {
            get { return _Ubicacion; }
            set { _Ubicacion = value; }
        }
        private string _Login;

        public string Login
        {
            get { return _Login; }
            set { _Login = value; }
        }

        private string _Contrasena;

        public string Constrasena
        {
            get { return _Contrasena; }
            set { _Contrasena = value; }
        }

        private int _Rol;

        public int Rol
        {
            get { return _Rol; }
            set { _Rol = value; }
        }

        private string _Validacion;

        public string Validacion
        {
            get { return _Validacion; }
            set { _Validacion = value; }
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
         dentro de la clase Usuarios*/
        #region Metodos

        /*Metodo para insertar datos de los usuarios a utilizar el sistema, informacion guardar en la tabla Usuarios*/
        public bool INSERT_USUARIOS()
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
                sql = "USP_USUARIOS_INSERT";
                ParamStruct[] parametros = new ParamStruct[8];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@Nomb", SqlDbType.VarChar, _Nombre);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@Apell", SqlDbType.VarChar, _Apellidos);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 2, "@Tel", SqlDbType.VarChar, _Telefono);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 3, "@Correo", SqlDbType.VarChar, _Correo);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 4, "@Ubica", SqlDbType.Int, _Ubicacion);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 5, "@Rol", SqlDbType.Int, _Rol);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 6, "@Login", SqlDbType.VarChar, _Login);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 7, "@Contra", SqlDbType.VarChar, _Contrasena);
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

        /*Metodo que permite obtener un listado completo de las ubicaciones registrada en Ubicaciones*/
        public DataSet CARGA_UBICACION()
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

        /*Metodo que permite obtener un listado de la roles registrados*/
        public DataSet CARGA_ROL()
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
                sql = "USP_ROLES_SELECT_ALL";
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

        /*Metodo que permite obtner un listado de los usuarios registrados dentro de la BD*/
        public DataSet CARGA_USUARIOS()
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
                sql = "USP_USUARIOS_SELECT";
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

        /*Metodo que permite actualizar la informacion de los usuarios dentro de la tabla Usuarios*/
        public bool UPDATE_USUARIOS_NOPASSWORD()
        {
            /*Verificacion de la Conexion al servidor*/
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
                sql = "USP_USUARIOS_UPDATE";
                ParamStruct[] parametros = new ParamStruct[8];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@Nomb", SqlDbType.VarChar, _Nombre);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@Apell", SqlDbType.VarChar, _Apellidos);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 2, "@Tel", SqlDbType.VarChar, _Telefono);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 3, "@Correo", SqlDbType.VarChar, _Correo);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 4, "@Ubica", SqlDbType.Int, _Ubicacion);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 5, "@Rol", SqlDbType.Int, _Rol);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 6, "@Login", SqlDbType.VarChar, _Login);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 7, "@Cod", SqlDbType.Int, _Codigo);
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
                    /*Verificacion de la Actualizacion*/
                    cls_DAL.desconectar(conexion, ref mensaje_error, ref numero_error);
                    _Validacion = "Actualizado";
                    return true;
                }
            }
        }

        /*Metodo que permite actualizar password del usuario dentro de la tabla usuarios*/
        public bool UPDATE_USUARIOS_CONPASSWORD()
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
                sql = "USP_USUARIOS_UPDATE_PASSWORD";
                ParamStruct[] parametros = new ParamStruct[2];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@Login", SqlDbType.VarChar, _Login);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@Contra", SqlDbType.VarChar, _Contrasena);
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
                    /*Verificacion de la actualizacion*/
                    cls_DAL.desconectar(conexion, ref mensaje_error, ref numero_error);
                    _Validacion = "Actualizado";
                    return true;
                }
            }
        }

        /*Metodo que permite Eliminar la informacion dentro de la tabla Usuarios por medio del ID*/
        public bool DELETE_USUARIOS()
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
                sql = "USP_USUARIOS_DELETE";
                ParamStruct[] parametros = new ParamStruct[1];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@Cod", SqlDbType.Int, _Codigo);
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
                    /*Verificacion de la eliminacion*/
                    cls_DAL.desconectar(conexion, ref mensaje_error, ref numero_error);
                    _Validacion = "Eliminado";
                    return true;
                }
            }
        }

        /*Metodo que permite buscar la informacion de los usuarios por medio del Login*/
        public DataSet BUSQUEDA_LOGIN()
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
                sql = "USP_USUARIOS_SELECT_LOGIN";
                ParamStruct[] parametros = new ParamStruct[1];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@log", SqlDbType.VarChar, _Login);
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

        /*Metodo que permite buscar la informacion de los usuarios por medio del nombre del usuario*/
        public DataSet BUSQUEDA_USUARIOS()
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
                sql = "USP_USUARIOS_SELECT_NOMBRE";
                ParamStruct[] parametros = new ParamStruct[1];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@nom", SqlDbType.VarChar, _Nombre);
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

        /*Metodo para el envio de la contraseña al usuario por medio de correo electronico*/
        public void ENVIO_DE_CONTRASEÑA()
        {

            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.UseDefaultCredentials = false;
            NetworkCredential netCred = new NetworkCredential("sigpuntoamericano@gmail.com", "sigpuntoamericanov1");
            smtp.Credentials = netCred;
            smtp.EnableSsl = true;

            MailMessage mmsg = new MailMessage("sigpuntoamericano@gmail.com", _Correo);
            mmsg.Subject = "Contraseña Punto Americano";
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Punto Americano" + Environment.NewLine);
            sb.AppendLine("Su contraseña es: " + _Contrasena + Environment.NewLine);
            sb.AppendLine("Favor no responder este mensaje" + Environment.NewLine);
            mmsg.Body = sb.ToString();
            mmsg.IsBodyHtml = false;
            smtp.Send(mmsg);


        }

        /*Metodo que genera una contraseña de forma aleatoria*/
        public void RANDOM_CONTRASEÑA()
        {
            int minLength = 7;
            int maxLength = 8;
            string allchars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            StringBuilder contra = new StringBuilder();
            Random rd = new Random();
            int contratamaño = rd.Next(minLength, maxLength + 1);
            while (contratamaño-- > 0)
                contra.Append(allchars[rd.Next(allchars.Length)]);
            _Contrasena = contra.ToString();



        }

        /*Metodo que permite seleccionar la contraseña segun el usuario registrado*/
        public void SELECT_CONTRASEÑA_USUARIO()
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
                sql = "USP_USUARIOS_SELECT_CONTRA";
                ParamStruct[] parametros = new ParamStruct[1];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@usu", SqlDbType.VarChar, _Login);
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
                        _Contrasena = ds.Tables[0].Rows[0]["Contraseña"].ToString();
                        cls_DAL.desconectar(conexion, ref mensaje_error, ref numero_error);

                    }
                    else
                    {
                        MessageBox.Show("No se encontro la Contraseña", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cls_DAL.desconectar(conexion, ref mensaje_error, ref numero_error);

                    }


                }
            }
        }

        #endregion




    }
}
