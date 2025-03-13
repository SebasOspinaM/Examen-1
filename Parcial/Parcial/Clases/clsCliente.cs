using Parcial.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;

namespace Parcial.Clases
{
    public class clsCliente
    {
        private ITM_ViviendasEntities2 iTM_Viviendas = new ITM_ViviendasEntities2();

        public List<Cliente> ConsultarTodos()
        {
            return iTM_Viviendas.Clientes.OrderBy(p => p.Nombre).ToList();
        }

        public Cliente Consultar(int ClienteID)
        {
            return iTM_Viviendas.Clientes.FirstOrDefault(e => e.ClienteID == ClienteID);
        }

        public string Insertar(Cliente cliente)
        {
            try
            {
                iTM_Viviendas.Clientes.Add(cliente);
                iTM_Viviendas.SaveChanges();
                return "Cliente insertado correctamente";
            }
            catch (Exception ex)
            {
                return "Error al insertar el cliente: " + ex.Message;
            }
        }

        public string Actualizar(Cliente cliente)
        {
            try
            {
                Cliente cli = Consultar(cliente.ClienteID);
                if (cli == null)
                {
                    return "Cliente no existe";
                }

                iTM_Viviendas.Clientes.AddOrUpdate(cliente);
                iTM_Viviendas.SaveChanges();
                return "Cliente actualizado correctamente";
            }
            catch (Exception ex)
            {
                return "Error al actualizar el cliente: " + ex.Message;
            }
        }

        public string Eliminar(int ClienteID)
        {
            try
            {
                Cliente cli = Consultar(ClienteID);
                if (cli == null)
                {
                    return "Cliente no existe";
                }

                iTM_Viviendas.Clientes.Remove(cli);
                iTM_Viviendas.SaveChanges();
                return "Cliente eliminado correctamente";
            }
            catch (Exception ex)
            {
                return "Error al eliminar el cliente: " + ex.Message;
            }
        }
    }
}
