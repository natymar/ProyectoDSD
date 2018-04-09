using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WScliente.Dominio
{
    public  class Conexion
    {
        public string _dbname { set; get; }
        public string _server { set; get; }
        //private string _db { set; get; }
        public Conexion(string db,string server)
        {
            _dbname = db;
            _server = server;
        }
        public Conexion()
        {
            _dbname = "TiendaWeb";
            _server = "local";
        }
    }
}