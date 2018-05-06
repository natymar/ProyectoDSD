﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WSPedido.Dominio;
using WSPedido.Persistencia;

namespace WSPedido
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Pedidos" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Pedidos.svc o Pedidos.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Pedidos : IPedidos
    {
        private PedidoDAO pedidoDAO = new PedidoDAO();

        public Pedido CrearPedido(Pedido pedidoACrear)
        {
            return pedidoDAO.Crear(pedidoACrear);
        }

        public Pedido ObtenerPedido(int dni)
        {
            return pedidoDAO.Obtener(dni);
        }
    }
}
