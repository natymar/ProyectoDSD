using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WCFRESTPRDUCTOS.dominio
{
    [DataContract]
    public class productoRest
    {
        [DataMember]
        public int idproducto { get; set; }
        [DataMember]
        public string marca { get; set; }
        [DataMember]
        public string nombre { get; set; }
        [DataMember]
        public double precio { get; set; }
        [DataMember]
        public int cantidad { get; set; }
        [DataMember(IsRequired = false)]
        public string estado { get; set; }
    }
}