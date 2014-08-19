using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DAC
{
    public class MetodosDatos
    {
        /*CrearComando: Este metodo nos servira para crear un comando sql estandard como un select el cual sera regresado por su metodo return*/
        public static SqlCommand CrearComando()
        {
            string _cadenaConexion = Configuracion.CadenaConexion;
            SqlConnection _conexion = new SqlConnection();
            _conexion.ConnectionString = _cadenaConexion;
            SqlCommand _comando = new SqlCommand();
            _comando = _conexion.CreateCommand();
            _comando.CommandType = CommandType.Text;
            return _comando;
        }
        /*CrearComandoProc: Este metodo al igual que el anterior nos crea un comando sql, 
         * pero con la diferencia que este metodo nos creara nuestro comando de manera que 
         * pueda ejecutar nuestro procedimiento almacenado que establecimos anteriormente.*/
        public static SqlCommand CrearComandoProc(string procedimiento)
        {
            string _cadenaConexion = Configuracion.CadenaConexion;
            SqlConnection _conexion = new SqlConnection(_cadenaConexion);
            SqlCommand _comando = new SqlCommand(procedimiento, _conexion);
            _comando.CommandType = CommandType.StoredProcedure;
            return _comando;
        }
        /*EjecutarComandoProc: 
        Este metodo obtiene como parametro un comando sql que proviene de el metodo anterior CrearComandoProc, 
        este metodo ejecuta el procedimineto almacenado que se le ha asignado al comando. 
        En la siguiente clase que agregaremos veremos como se le asigna el procedimiento almacenado a este comando.*/
        public static int EjecutarComandoProc(SqlCommand comando)
        {
            try
            {
                comando.Connection.Open();
                int c = Convert.ToInt32(comando.ExecuteScalar());
                return c;
            }
            catch { throw; }
            finally
            {
                comando.Connection.Dispose();
                comando.Connection.Close();
            }
        }
        //otro :D
       /*EjecutarComandoSelect:
         * Este metodo ejecutara un comando select el cual nos regresara un datatable con todos los registros que se encuentren 
         * en alguna tabla dada, toma como parametro el comando que contiene la sentencia sql select.*/
        public static DataTable EjecutarComandoSelect(SqlCommand comando)
        {
            DataTable _tabla = new DataTable();
            try
            {
                comando.Connection.Open();
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comando;
                adaptador.Fill(_tabla);
            }
            catch (Exception ex)
            { throw ex; }
            finally
            { comando.Connection.Close(); }
            return _tabla;
        }
        /**/
    }
}
