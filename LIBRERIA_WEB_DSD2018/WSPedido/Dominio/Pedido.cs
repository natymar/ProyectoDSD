using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WSPedido.Dominio
{
    [DataContract]
    public class Pedido
    {
        [DataMember]
        public int IdPedido { get; set; }

        [DataMember]
        public int DniCli { get; set; }

        [DataMember]
        public string NombreCli { get; set; }

        [DataMember]
        public string CorreoCli { get; set; }

        [DataMember]
        public string Estado { get; set; }

        [DataMember]
        public byte[] Archivo { get; set; }

        [DataMember]
        public DateTime FechaPed { get; set; }
    }
}