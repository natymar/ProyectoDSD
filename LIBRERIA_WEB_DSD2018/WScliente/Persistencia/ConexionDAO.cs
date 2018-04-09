using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WScliente.Dominio;

namespace WScliente.Persistencia
{
    public static  class ConexionDAO
    {
        static Conexion con = new Conexion();

        public static string getConexion()
        {
            return "server = ("+con._server+"); Integrated Security = yes;DataBase="+con._dbname;
        }
       
         
    }
}