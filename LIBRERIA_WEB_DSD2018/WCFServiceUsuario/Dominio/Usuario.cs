using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WCFServiceUsuario.Dominio
{
    [DataContract]
    public class Usuario
    {
        [DataMember]
        public int codigoUsuario { get; set; }

        [DataMember]
        public string nombreUsuario { get; set; }

        [DataMember]
        public string apePaternoUsuario { get; set; }

        [DataMember]
        public string apeMaternoUsuario { get; set; }

        [DataMember]
        public string claveUsuario { get; set; }


        [DataMember(IsRequired =false)]

        public string estadoUsuario { get; set; }


        [DataMember]
        public string nivelAcceso { get; set; }

    }
}