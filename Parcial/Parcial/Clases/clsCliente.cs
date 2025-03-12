using Parcial.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace Parcial.Clases
{
    public class clsCliente
    {
        private ITM_ViviendasEntities2 iTM_Viviendas = new ITM_ViviendasEntities2();
        public Cliente cliente { get; set; }

        public string Insertar()
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

        public string Actualizar()
        {
            try
            {
                Cliente cli = Consultar(cliente.Nombre);
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

        public Cliente Consultar(string nombre)
        {
            return iTM_Viviendas.Clientes.FirstOrDefault(c => c.Nombre == nombre);
        }

        public string Eliminar()
        {
            try
            {
                Cliente cli = Consultar(cliente.Nombre);
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