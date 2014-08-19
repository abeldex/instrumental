using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAC
{
    public class Configuracion
    {
        static string cadenaConexion = @"Server=148.227.28.3;Database=Instrumental;User Id=sa;Password=Geode2530;";
        //static string cadenaConexion = @"Server=148.227.28.70;Database=TRAYECTORIA_ESCOLAR;User Id=admin;Password=Geode2530;";
        public static string CadenaConexion
        {
            get 
            { 
                return cadenaConexion; 
            }
        }
    }
}
