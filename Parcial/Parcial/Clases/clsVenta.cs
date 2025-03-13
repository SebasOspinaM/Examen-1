using Parcial.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace Parcial.Clases
{
    public class clsVenta
    {
        private ITM_ViviendasEntities2 iTM_Viviendas = new ITM_ViviendasEntities2();
        public Venta venta { get; set; }

        public string Insertar()
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

        public string Actualizar()
        {
            try
            {
                Venta ven = Consultar(venta.VentaID);
                if (ven == null)
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

        public Venta Consultar(int ventaID)
        {
            return iTM_Viviendas.Ventas.FirstOrDefault(v => v.VentaID == ventaID);
        }

        public string Eliminar()
        {
            try
            {
                Venta ven = Consultar(venta.VentaID);
                if (ven == null)
                {
                    return "Venta no existe";
                }

                iTM_Viviendas.Ventas.Remove(ven);
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