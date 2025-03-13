using Parcial.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;

namespace Parcial.Clases
{
    public class clsVenta
    {
        private ITM_ViviendasEntities2 iTM_Viviendas = new ITM_ViviendasEntities2();

        public List<Venta> ConsultarTodos()
        {
            return iTM_Viviendas.Ventas.OrderBy(v => v.FechaVenta).ToList();
        }

        public Venta Consultar(int VentaID)
        {
            return iTM_Viviendas.Ventas.FirstOrDefault(v => v.VentaID == VentaID);
        }

        public string Insertar(Venta venta)
        {
            try
            {
                iTM_Viviendas.Ventas.Add(venta);
                iTM_Viviendas.SaveChanges();
                return "Venta insertada correctamente";
            }
            catch (Exception ex)
            {
                return "Error al insertar la venta: " + ex.Message;
            }
        }

        public string Actualizar(Venta venta)
        {
            try
            {
                Venta vta = Consultar(venta.VentaID);
                if (vta == null)
                {
                    return "Venta no existe";
                }

                iTM_Viviendas.Ventas.AddOrUpdate(venta);
                iTM_Viviendas.SaveChanges();
                return "Venta actualizada correctamente";
            }
            catch (Exception ex)
            {
                return "Error al actualizar la venta: " + ex.Message;
            }
        }

        public string Eliminar(int VentaID)
        {
            try
            {
                Venta vta = Consultar(VentaID);
                if (vta == null)
                {
                    return "Venta no existe";
                }

                iTM_Viviendas.Ventas.Remove(vta);
                iTM_Viviendas.SaveChanges();
                return "Venta eliminada correctamente";
            }
            catch (Exception ex)
            {
                return "Error al eliminar la venta: " + ex.Message;
            }
        }
    }
}
