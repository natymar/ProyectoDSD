using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ServicioProductos.Dominio
{
    [DataContract]
    public class Producto
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public string marca { get; set; }
        [DataMember]
        public string nombre { get; set; }
        [DataMember]
        public decimal precio { get; set; }
        [DataMember]
        public int cantidad { get; set; }
        [DataMember]
        public string estado { get; set; }
    }
}