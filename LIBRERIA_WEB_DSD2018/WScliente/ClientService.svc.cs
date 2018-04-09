using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WScliente.Dominio;
using WScliente.Errores;
using WScliente.Persistencia;

namespace WScliente
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ClientService" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ClientService.svc o ClientService.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ClientService : IClientService
    {
        private ClienteDAO clienteDAO = new ClienteDAO();

        public List<cliente> BuscarCliente(string filtro)
        {
            return clienteDAO.BuscarCliente(filtro);
        }

        public void CrearCliente(cliente c)
        {
            if (clienteDAO.ObtenerCliente(c.dni)!=null)//existe
            {
                 new FaultException<DuplicadoException>(
                    new DuplicadoException() {
                        codigoError = "344eXD3",
                        descripcionError = "El cliente, ya exite "
                    }, new FaultReason("Error al intentar Registrar un cliente Duplicado")
                    );
            }
            clienteDAO.CrearCliente(c);
        }

        public List<cliente> ListarAllClientes()
        {
            return clienteDAO.ListarAllClientes();
        }

        public cliente ObtenerCliente(int idCliente)
        {
            return clienteDAO.ObtenerCliente(idCliente);
        }
    }
}
