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
    public class Errores
    {
        /*Region de codigo que contiene las propiedades utilizadas dentro de la clase Errores*/
        #region Propiedades

        private string _Codigo;

        public string Codigo
        {
            get { return _Codigo; }
            set { _Codigo = value; }
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
         dentro de la clase Errores*/
        #region Metodos

        /*Metodo que permite obtenet una lista de todos los errores registrados*/
        public DataSet CARGA_LISTA_ERRORES()
        {
            conexion = cls_DAL.trae_conexion("Puntoamericano", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                return null;
            }
            else
            {
                /*Instancia a un Procedimiento Almacenado*/
                sql = "USP_ERROR_SELECT";
                ds = cls_DAL.ejecuta_dataset(conexion, sql, false, ref mensaje_error, ref numero_error);
                if (numero_error != 0)
                {
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
