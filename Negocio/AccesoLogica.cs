using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DAC;

namespace Negocio
{
    public class AccesoLogica
    {
        AccesoDatos acceso = new AccesoDatos();

        //INSERTAR UNA CATEGORIA DE EQUIPOS
        public int Insertar_Categoria(int id, string nombre)
        {
            return acceso.Insertar_Categoria(id, nombre);
        }

        //INSERTAR UN EQUIPO
        public int INSERTAR_Equipo(int categoria, string nombre, int cantidad, string serie)
        {
            return acceso.INSERTAR_Equipo(categoria, nombre, cantidad, serie);
        }

        //INSERTAR UN BRIGADA
        public int INSERTAR_Brigada(string nombre, string grupo, int semestre, string tipo)
        {
            return acceso.INSERTAR_Brigada(nombre, grupo, semestre, tipo);
        }
         //ELIMINAR EQUPO ASIGNADO
        public int ELIMINAR_equipo_practica(int equipo)
        {
            return acceso.ELIMINAR_equipo_practica(equipo);
        }
        //INSERTAR ALUMNO
        public int INSERTAR_Alumno(string cuenta, int brigada, string nombre, string grupo, string telefono)
        {
            return acceso.INSERTAR_Alumno(cuenta,brigada,nombre,grupo,telefono);
        }

        //ELIMINAR DE SOLICITUD
        public int EliminarSolicitud(int solicitud)
        {
            return acceso.EliminarSolicitud(solicitud);
        }

         //INSERTAR UNA MATERIA
        public int INSERTAR_Materia(string nombre)
        {
            return acceso.INSERTAR_Materia(nombre);
        }
          //ELIMINAR EQUIPOS SELECCIONADO
        public int QuitarEquipos(int solicitud_detalle_codigo)
        {
            return acceso.QuitarEquipos(solicitud_detalle_codigo);
        }

        //INSERTAR UNA PROFESOR
        public int INSERTAR_Profesor(int codigo, string nombre)
        {
            return acceso.INSERTAR_Profesor(codigo, nombre);
        }

         //INSERTAR UNA PRACTICA
        public int INSERTAR_Practica(int numero, string nombre, int materia)
        {
            return acceso.INSERTAR_Practica(numero, nombre, materia);
        }

        //ASIGNAR PRACTICAS A PROFESORES
        public int INSERTAR_Practica_Profesor(int profesor, int practica)
        {
            return acceso.INSERTAR_Practica_Profesor(profesor, practica);
        }

        //ASIGNAR EQUIPOS A PRACTICAS
        public int INSERTAR_Practica_Equipo(int practica, int equipo)
        {
            return acceso.INSERTAR_Practica_Equipo(practica, equipo);
        }
         //INSERTAR SOLICITUD
        public int INSERTAR_Solicitud(int brigada, string fecha, string hora_s, string hora_e, int practica, int maestro, bool estado, int turno)
        {
            return acceso.INSERTAR_Solicitud(brigada, fecha, hora_s, hora_e, practica, maestro, estado, turno);
        }

         //RECEPCION DE EQUIPOS
        public int RecibirEquipos(int solicitud)
        {
            return acceso.RecibirEquipos(solicitud);
        }

        //INSERTAR SOLICITUD_DETALLE
        public int INSERTAR_Solicitud_detalle(int solicitud, int equipo, int cantidad)
        {
            return acceso.INSERTAR_Solicitud_detalle(solicitud, equipo, cantidad);
        }

        //OBTENER USUARIOS
        public static DataTable ObtenerUsuarios()
        {
            return AccesoDatos.ObtenerUsuarios();
        }
        //obtener la ultima solicitud
        public static DataTable ObtenerUltimaSolicitud()
        {
            return AccesoDatos.ObtenerUltimaSolicitud();
        }

         //OBTENER ULTIMO TURNO
        public static DataTable ObtenerUltimoTurno(string fecha)
        {
            return AccesoDatos.ObtenerUltimoTurno(fecha);
        }
         //OBTENER SOLICITUD POR FECHA
        public static DataTable ObtenerSolicitudPorFecha(string fecha)
        {
            return AccesoDatos.ObtenerSolicitudPorFecha(fecha);
        }

        //obtener solicitud por codigo de solicitud
        public static DataTable ObtenerSolicitudPorCodigo(int codigo)
        {
            return AccesoDatos.ObtenerSolicitudPorCodigo(codigo);
        }
        //obtener alumnos por brigada
        public static DataTable ObtenerAlumnoBrigada(string brigada)
        {
            return AccesoDatos.ObtenerAlumnoBrigada(brigada);
        }
        //obtener solicitud_detalle
        public static DataTable ObtenerSolicitudDetalle(string solicitud)
        {
            return AccesoDatos.ObtenerSolicitudDetalle(solicitud);
        }
        //obtener folio
        public static DataTable ObtenerFolio()
        {
            return AccesoDatos.ObtenerFolio();
        }

    }
}
