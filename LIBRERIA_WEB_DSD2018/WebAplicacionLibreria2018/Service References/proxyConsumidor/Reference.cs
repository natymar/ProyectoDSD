﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebAplicacionLibreria2018.proxyConsumidor {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="proxyConsumidor.IClientService")]
    public interface IClientService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientService/ObtenerCliente", ReplyAction="http://tempuri.org/IClientService/ObtenerClienteResponse")]
        WScliente.Dominio.cliente ObtenerCliente(int idCliente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientService/ObtenerCliente", ReplyAction="http://tempuri.org/IClientService/ObtenerClienteResponse")]
        System.Threading.Tasks.Task<WScliente.Dominio.cliente> ObtenerClienteAsync(int idCliente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientService/ListarAllClientes", ReplyAction="http://tempuri.org/IClientService/ListarAllClientesResponse")]
        WScliente.Dominio.cliente[] ListarAllClientes();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientService/ListarAllClientes", ReplyAction="http://tempuri.org/IClientService/ListarAllClientesResponse")]
        System.Threading.Tasks.Task<WScliente.Dominio.cliente[]> ListarAllClientesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientService/BuscarCliente", ReplyAction="http://tempuri.org/IClientService/BuscarClienteResponse")]
        WScliente.Dominio.cliente[] BuscarCliente(string filtro);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientService/BuscarCliente", ReplyAction="http://tempuri.org/IClientService/BuscarClienteResponse")]
        System.Threading.Tasks.Task<WScliente.Dominio.cliente[]> BuscarClienteAsync(string filtro);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientService/CrearCliente", ReplyAction="http://tempuri.org/IClientService/CrearClienteResponse")]
        void CrearCliente(WScliente.Dominio.cliente c);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientService/CrearCliente", ReplyAction="http://tempuri.org/IClientService/CrearClienteResponse")]
        System.Threading.Tasks.Task CrearClienteAsync(WScliente.Dominio.cliente c);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IClientServiceChannel : WebAplicacionLibreria2018.proxyConsumidor.IClientService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ClientServiceClient : System.ServiceModel.ClientBase<WebAplicacionLibreria2018.proxyConsumidor.IClientService>, WebAplicacionLibreria2018.proxyConsumidor.IClientService {
        
        public ClientServiceClient() {
        }
        
        public ClientServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ClientServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ClientServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ClientServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WScliente.Dominio.cliente ObtenerCliente(int idCliente) {
            return base.Channel.ObtenerCliente(idCliente);
        }
        
        public System.Threading.Tasks.Task<WScliente.Dominio.cliente> ObtenerClienteAsync(int idCliente) {
            return base.Channel.ObtenerClienteAsync(idCliente);
        }
        
        public WScliente.Dominio.cliente[] ListarAllClientes() {
            return base.Channel.ListarAllClientes();
        }
        
        public System.Threading.Tasks.Task<WScliente.Dominio.cliente[]> ListarAllClientesAsync() {
            return base.Channel.ListarAllClientesAsync();
        }
        
        public WScliente.Dominio.cliente[] BuscarCliente(string filtro) {
            return base.Channel.BuscarCliente(filtro);
        }
        
        public System.Threading.Tasks.Task<WScliente.Dominio.cliente[]> BuscarClienteAsync(string filtro) {
            return base.Channel.BuscarClienteAsync(filtro);
        }
        
        public void CrearCliente(WScliente.Dominio.cliente c) {
            base.Channel.CrearCliente(c);
        }
        
        public System.Threading.Tasks.Task CrearClienteAsync(WScliente.Dominio.cliente c) {
            return base.Channel.CrearClienteAsync(c);
        }
    }
}
