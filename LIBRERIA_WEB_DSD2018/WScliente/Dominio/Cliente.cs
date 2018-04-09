using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WScliente.Dominio
{
   
    [DataContract]
    public class cliente
    {
        [DataMember]
        public int idCliente { set; get; }
        [DataMember]
        public string nombre    {set;get;}
        [DataMember]
        public string apePater  {set;get;}
        [DataMember]
        public string apeMater  {set;get;}
        [DataMember]
        public int dni       {set;get;}
        [DataMember]
        public string correo    {set;get;}
        [DataMember]
        public string estado    { set; get; }
    }
}