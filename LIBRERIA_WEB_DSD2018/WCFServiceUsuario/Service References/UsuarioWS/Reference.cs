﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCFServiceUsuario.UsuarioWS {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Usuario", Namespace="http://schemas.datacontract.org/2004/07/WCFServiceUsuario.Dominio")]
    [System.SerializableAttribute()]
    public partial class Usuario : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string apeMaternoUsuarioField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string apePaternoUsuarioField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string claveUsuarioField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int codigoUsuarioField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string estadoUsuarioField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nombreUsuarioField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string apeMaternoUsuario {
            get {
                return this.apeMaternoUsuarioField;
            }
            set {
                if ((object.ReferenceEquals(this.apeMaternoUsuarioField, value) != true)) {
                    this.apeMaternoUsuarioField = value;
                    this.RaisePropertyChanged("apeMaternoUsuario");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string apePaternoUsuario {
            get {
                return this.apePaternoUsuarioField;
            }
            set {
                if ((object.ReferenceEquals(this.apePaternoUsuarioField, value) != true)) {
                    this.apePaternoUsuarioField = value;
                    this.RaisePropertyChanged("apePaternoUsuario");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string claveUsuario {
            get {
                return this.claveUsuarioField;
            }
            set {
                if ((object.ReferenceEquals(this.claveUsuarioField, value) != true)) {
                    this.claveUsuarioField = value;
                    this.RaisePropertyChanged("claveUsuario");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int codigoUsuario {
            get {
                return this.codigoUsuarioField;
            }
            set {
                if ((this.codigoUsuarioField.Equals(value) != true)) {
                    this.codigoUsuarioField = value;
                    this.RaisePropertyChanged("codigoUsuario");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string estadoUsuario {
            get {
                return this.estadoUsuarioField;
            }
            set {
                if ((object.ReferenceEquals(this.estadoUsuarioField, value) != true)) {
                    this.estadoUsuarioField = value;
                    this.RaisePropertyChanged("estadoUsuario");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string nombreUsuario {
            get {
                return this.nombreUsuarioField;
            }
            set {
                if ((object.ReferenceEquals(this.nombreUsuarioField, value) != true)) {
                    this.nombreUsuarioField = value;
                    this.RaisePropertyChanged("nombreUsuario");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UsuarioException", Namespace="http://schemas.datacontract.org/2004/07/WCFServiceUsuario.Errores")]
    [System.SerializableAttribute()]
    public partial class UsuarioException : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CodigoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Codigo {
            get {
                return this.CodigoField;
            }
            set {
                if ((object.ReferenceEquals(this.CodigoField, value) != true)) {
                    this.CodigoField = value;
                    this.RaisePropertyChanged("Codigo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
                    this.DescriptionField = value;
                    this.RaisePropertyChanged("Description");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="UsuarioWS.IUsuarios")]
    public interface IUsuarios {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsuarios/CrearUsuario", ReplyAction="http://tempuri.org/IUsuarios/CrearUsuarioResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(WCFServiceUsuario.UsuarioWS.UsuarioException), Action="http://tempuri.org/IUsuarios/CrearUsuarioUsuarioExceptionFault", Name="UsuarioException", Namespace="http://schemas.datacontract.org/2004/07/WCFServiceUsuario.Errores")]
        WCFServiceUsuario.UsuarioWS.Usuario CrearUsuario(WCFServiceUsuario.UsuarioWS.Usuario usuarioACrear);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsuarios/CrearUsuario", ReplyAction="http://tempuri.org/IUsuarios/CrearUsuarioResponse")]
        System.Threading.Tasks.Task<WCFServiceUsuario.UsuarioWS.Usuario> CrearUsuarioAsync(WCFServiceUsuario.UsuarioWS.Usuario usuarioACrear);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsuarios/ObtenerUsuario", ReplyAction="http://tempuri.org/IUsuarios/ObtenerUsuarioResponse")]
        WCFServiceUsuario.UsuarioWS.Usuario ObtenerUsuario(int codigo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsuarios/ObtenerUsuario", ReplyAction="http://tempuri.org/IUsuarios/ObtenerUsuarioResponse")]
        System.Threading.Tasks.Task<WCFServiceUsuario.UsuarioWS.Usuario> ObtenerUsuarioAsync(int codigo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsuarios/ModificarUsuario", ReplyAction="http://tempuri.org/IUsuarios/ModificarUsuarioResponse")]
        WCFServiceUsuario.UsuarioWS.Usuario ModificarUsuario(WCFServiceUsuario.UsuarioWS.Usuario usuarioAModificar);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsuarios/ModificarUsuario", ReplyAction="http://tempuri.org/IUsuarios/ModificarUsuarioResponse")]
        System.Threading.Tasks.Task<WCFServiceUsuario.UsuarioWS.Usuario> ModificarUsuarioAsync(WCFServiceUsuario.UsuarioWS.Usuario usuarioAModificar);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsuarios/EliminarUsuario", ReplyAction="http://tempuri.org/IUsuarios/EliminarUsuarioResponse")]
        void EliminarUsuario(int dni);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsuarios/EliminarUsuario", ReplyAction="http://tempuri.org/IUsuarios/EliminarUsuarioResponse")]
        System.Threading.Tasks.Task EliminarUsuarioAsync(int dni);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsuarios/ListarUsuarios", ReplyAction="http://tempuri.org/IUsuarios/ListarUsuariosResponse")]
        WCFServiceUsuario.UsuarioWS.Usuario[] ListarUsuarios();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsuarios/ListarUsuarios", ReplyAction="http://tempuri.org/IUsuarios/ListarUsuariosResponse")]
        System.Threading.Tasks.Task<WCFServiceUsuario.UsuarioWS.Usuario[]> ListarUsuariosAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IUsuariosChannel : WCFServiceUsuario.UsuarioWS.IUsuarios, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class UsuariosClient : System.ServiceModel.ClientBase<WCFServiceUsuario.UsuarioWS.IUsuarios>, WCFServiceUsuario.UsuarioWS.IUsuarios {
        
        public UsuariosClient() {
        }
        
        public UsuariosClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public UsuariosClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UsuariosClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UsuariosClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WCFServiceUsuario.UsuarioWS.Usuario CrearUsuario(WCFServiceUsuario.UsuarioWS.Usuario usuarioACrear) {
            return base.Channel.CrearUsuario(usuarioACrear);
        }
        
        public System.Threading.Tasks.Task<WCFServiceUsuario.UsuarioWS.Usuario> CrearUsuarioAsync(WCFServiceUsuario.UsuarioWS.Usuario usuarioACrear) {
            return base.Channel.CrearUsuarioAsync(usuarioACrear);
        }
        
        public WCFServiceUsuario.UsuarioWS.Usuario ObtenerUsuario(int codigo) {
            return base.Channel.ObtenerUsuario(codigo);
        }
        
        public System.Threading.Tasks.Task<WCFServiceUsuario.UsuarioWS.Usuario> ObtenerUsuarioAsync(int codigo) {
            return base.Channel.ObtenerUsuarioAsync(codigo);
        }
        
        public WCFServiceUsuario.UsuarioWS.Usuario ModificarUsuario(WCFServiceUsuario.UsuarioWS.Usuario usuarioAModificar) {
            return base.Channel.ModificarUsuario(usuarioAModificar);
        }
        
        public System.Threading.Tasks.Task<WCFServiceUsuario.UsuarioWS.Usuario> ModificarUsuarioAsync(WCFServiceUsuario.UsuarioWS.Usuario usuarioAModificar) {
            return base.Channel.ModificarUsuarioAsync(usuarioAModificar);
        }
        
        public void EliminarUsuario(int dni) {
            base.Channel.EliminarUsuario(dni);
        }
        
        public System.Threading.Tasks.Task EliminarUsuarioAsync(int dni) {
            return base.Channel.EliminarUsuarioAsync(dni);
        }
        
        public WCFServiceUsuario.UsuarioWS.Usuario[] ListarUsuarios() {
            return base.Channel.ListarUsuarios();
        }
        
        public System.Threading.Tasks.Task<WCFServiceUsuario.UsuarioWS.Usuario[]> ListarUsuariosAsync() {
            return base.Channel.ListarUsuariosAsync();
        }
    }
}
