using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WScliente.Errores
{
    [DataContract]
    public class DuplicadoException
    {
        [DataMember]
        public string codigoError { set; get; }
        [DataMember]
        public string descripcionError { set; get; }
       
        
    }
}