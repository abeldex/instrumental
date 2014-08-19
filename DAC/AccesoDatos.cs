using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace DAC
{
    public class AccesoDatos
    {
        //INSERTAR UN TIPO_DE_EQUIPO
        public int Insertar_Categoria(int id, string nombre)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc("agregar_tipo_equipo");
            _comando.Parameters.AddWithValue("@eq_tipo_codigo", id);
            _comando.Parameters.AddWithValue("@eq_tipo_nombre", nombre);
            return MetodosDatos.EjecutarComandoProc(_comando);
        }

        //INSERTAR UN EQUIPO
        public int INSERTAR_Equipo(int categoria, string nombre, int cantidad, string serie)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc("agregar_equipo");
            _comando.Parameters.AddWithValue("@eq_tipo_codigo", categoria);
            _comando.Parameters.AddWithValue("@eq_nombre", nombre);
            _comando.Parameters.AddWithValue("@eq_stock", cantidad);
            _comando.Parameters.AddWithValue("@eq_serie", serie);
            return MetodosDatos.EjecutarComandoProc(_comando);
        }

        //INSERTAR UN BRIGADA
        public int INSERTAR_Brigada(string nombre, string grupo, int semestre, string tipo)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc("agregar_brigada");
            _comando.Parameters.AddWithValue("@bri_nombre", nombre);
            _comando.Parameters.AddWithValue("@bri_grupo", grupo);
            _comando.Parameters.AddWithValue("@bri_semestre", semestre);
            _comando.Parameters.AddWithValue("@bri_tipo", tipo);
            return MetodosDatos.EjecutarComandoProc(_comando);
        }

        //INSERTAR UN ALUMNO
        public int INSERTAR_Alumno(string cuenta, int brigada, string nombre, string grupo, string telefono)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc("agregar_alumno");
            _comando.Parameters.AddWithValue("@cuenta", cuenta);
            _comando.Parameters.AddWithValue("@brigada", brigada);
            _comando.Parameters.AddWithValue("@nombre", nombre);
            _comando.Parameters.AddWithValue("@grupo", grupo);
            _comando.Parameters.AddWithValue("@telefono", telefono);
            return MetodosDatos.EjecutarComandoProc(_comando);
        }

        //INSERTAR UNA MATERIA
        public int INSERTAR_Materia(string nombre)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc("agregar_materia");
            _comando.Parameters.AddWithValue("@materia_nombre", nombre);
            return MetodosDatos.EjecutarComandoProc(_comando);
        }

        //INSERTAR UNA PROFESOR
        public int INSERTAR_Profesor(int codigo, string nombre)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc("agregar_profesor");
            _comando.Parameters.AddWithValue("@profe_codigo", codigo);
            _comando.Parameters.AddWithValue("@profe_nombre", nombre);
            return MetodosDatos.EjecutarComandoProc(_comando);
        }

        //INSERTAR UNA PRACTICA
        public int INSERTAR_Practica(int numero, string nombre, int materia)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc("agregar_practica");
            _comando.Parameters.AddWithValue("@practica_numero", numero);
            _comando.Parameters.AddWithValue("@practica_nombre", nombre);
            _comando.Parameters.AddWithValue("@materia_codigo", materia);
            return MetodosDatos.EjecutarComandoProc(_comando);
        }

        //ELIMINAR EQUPO ASIGNADO
        public int ELIMINAR_equipo_practica(int equipo)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc("eliminar_equipos_practica");
            _comando.Parameters.AddWithValue("@codigo", equipo);
            return MetodosDatos.EjecutarComandoProc(_comando);
        }


        //ASIGNAR PRACTICAS A PROFESORES
        public int INSERTAR_Practica_Profesor(int profesor, int practica)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc("agregar_practica_profesor");
            _comando.Parameters.AddWithValue("@profesor_codigo", profesor);
            _comando.Parameters.AddWithValue("@practica_codigo", practica);
            return MetodosDatos.EjecutarComandoProc(_comando);
        }

        //ASIGNAR EQUIPOS A PRACTICAS
        public int INSERTAR_Practica_Equipo(int practica, int equipo)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc("agregar_practica_equipo");
            _comando.Parameters.AddWithValue("@eq_codigo", equipo);
            _comando.Parameters.AddWithValue("@practica_codigo", practica);
            return MetodosDatos.EjecutarComandoProc(_comando);
        }

        //INSERTAR SOLICITUD
        public int INSERTAR_Solicitud(int brigada, string fecha, string hora_s, string hora_e, int practica, int maestro, bool estado, int turno)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc("agregar_solicitud");
            _comando.Parameters.AddWithValue("@bri_codigo", brigada);
            _comando.Parameters.AddWithValue("@sol_fecha", fecha);
            _comando.Parameters.AddWithValue("@sol_hora_salida", hora_s);
            _comando.Parameters.AddWithValue("@sol_hora_entrega", hora_e);
            _comando.Parameters.AddWithValue("@practica_codigo", practica);
            _comando.Parameters.AddWithValue("@profesor_codigo", maestro);
            _comando.Parameters.AddWithValue("@estado", estado);
            _comando.Parameters.AddWithValue("@turno", turno);   
            return MetodosDatos.EjecutarComandoProc(_comando);
        }

        //INSERTAR SOLICITUD_DETALLE
        public int INSERTAR_Solicitud_detalle(int solicitud, int equipo, int cantidad)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc("agregar_solicitud_detalle");
            _comando.Parameters.AddWithValue("@sol_codigo", solicitud);
            _comando.Parameters.AddWithValue("@eq_codigo", equipo);
            _comando.Parameters.AddWithValue("@cantidad", cantidad);
            return MetodosDatos.EjecutarComandoProc(_comando);
        }

        //RECEPCION DE EQUIPOS
        public int RecibirEquipos(int solicitud)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc("recibir_equipos");
            _comando.Parameters.AddWithValue("@solicitud", solicitud);
            return MetodosDatos.EjecutarComandoProc(_comando);
        }

        //ELIMINAR EQUIPOS SELECCIONADO
        public int QuitarEquipos(int solicitud_detalle_codigo)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc("eliminar_solicitud_detalle_equipo");
            _comando.Parameters.AddWithValue("@sol_detalle_codigo", solicitud_detalle_codigo);
            return MetodosDatos.EjecutarComandoProc(_comando);
        }

        //ELIMINAR DE SOLICITUD
        public int EliminarSolicitud(int solicitud)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProc("eliminar_solicitud");
            _comando.Parameters.AddWithValue("@sol_codigo", solicitud);
            return MetodosDatos.EjecutarComandoProc(_comando);
        }

        //OBTENER LISTA DE USUARIOS
        public static DataTable ObtenerUsuarios()
        {
            SqlCommand _comando = MetodosDatos.CrearComando();
            _comando.CommandText = "select usuario_nombre AS NOMBRE, usuario_login AS USUARIO, usuario_administrar AS ADMINISTRAR, usuario_pedir AS PEDIR from A_USUARIOS";
            return MetodosDatos.EjecutarComandoSelect(_comando);
        }

        //OBTENER ULTIMA SOLICITUD
        public static DataTable ObtenerUltimaSolicitud()
        {
            SqlCommand _comando = MetodosDatos.CrearComando();
            _comando.CommandText = "select IDENT_CURRENT('solicitud')";
            return MetodosDatos.EjecutarComandoSelect(_comando);
        }

        //OBTENER ULTIMO TURNO
        public static DataTable ObtenerUltimoTurno(string fecha)
        {
            SqlCommand _comando = MetodosDatos.CrearComando();
            _comando.CommandText = "select COUNT(*) from solicitud where sol_fecha = '"+fecha+"'";
            return MetodosDatos.EjecutarComandoSelect(_comando);
        }
        //OBTENER SOLICITUD POR FECHA
        public static DataTable ObtenerSolicitudPorFecha(string fecha)
        {
            SqlCommand _comando = MetodosDatos.CrearComando();
            _comando.CommandText = "select sol.sol_codigo as SOLICITUD, sol.sol_fecha AS FECHA , sol.turno as TURNO, bri.bri_nombre AS BRIGADA, p.practica_nombre as PRACTICA, sol.estado AS ESTADO, sol.sol_hora_entrega AS ENTREGADO"+ 
            " from solicitud as sol, brigada as bri, practica as p where sol.bri_codigo = bri.bri_codigo and sol.practica_codigo = p.practica_codigo and sol_fecha = '"+fecha+"' order by sol.turno";
            return MetodosDatos.EjecutarComandoSelect(_comando);
        }
        //obtener solicitud por codigo de solicitud
        public static DataTable ObtenerSolicitudPorCodigo(int codigo)
        {
            SqlCommand _comando = MetodosDatos.CrearComando();
            _comando.CommandText = "select * from solicitud where sol_codigo = "+ codigo + "";
            return MetodosDatos.EjecutarComandoSelect(_comando);
        }
        //obtener alumnos por brigada
        public static DataTable ObtenerAlumnoBrigada(string brigada)
        {
            SqlCommand _comando = MetodosDatos.CrearComando();
            _comando.CommandText = "select al_cuenta as CUENTA, al_nombre as NOMBRE, al_telefono as TELEFONO from alumno where bri_codigo = " + brigada;
            return MetodosDatos.EjecutarComandoSelect(_comando);
        }

        //obtener folio
        public static DataTable ObtenerFolio()
        {
            SqlCommand _comando = MetodosDatos.CrearComando();
            _comando.CommandText = "SELECT IDENT_CURRENT('solicitud') AS FOLIO";
            return MetodosDatos.EjecutarComandoSelect(_comando);
        }

        //obtener solicitud detalle
        public static DataTable ObtenerSolicitudDetalle(string solicitud)
        {
            SqlCommand _comando = MetodosDatos.CrearComando();
            _comando.CommandText = "select et.eq_tipo_nombre as CATEGORIA, e.eq_serie as SERIE, e.eq_nombre AS EQUIPO, sd.cantidad AS SOLICITADO, e.eq_stock AS EXISTENCIA " +
            "from solicitud_detalle as sd, equipo as e, equipo_tipo as et " +
            "where sd.eq_codigo = e.eq_codigo and e.eq_tipo_codigo = et.eq_tipo_codigo and sd.sol_codigo = " + solicitud;
            return MetodosDatos.EjecutarComandoSelect(_comando);
        }
    }
}
