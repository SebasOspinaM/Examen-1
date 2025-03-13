using Parcial.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;

namespace Parcial.Clases
{
    public class clsTipoVivienda
    {
        private ITM_ViviendasEntities2 iTM_Viviendas = new ITM_ViviendasEntities2();

        public List<TipoVivienda> ConsultarTodos()
        {
            return iTM_Viviendas.TipoViviendas.OrderBy(tv => tv.TipoViviendaID).ToList();
        }

        public TipoVivienda Consultar(int TipoViviendaID)
        {
            return iTM_Viviendas.TipoViviendas.FirstOrDefault(tv => tv.TipoViviendaID == TipoViviendaID);
        }

        public string Insertar(TipoVivienda tipoVivienda)
        {
            try
            {
                iTM_Viviendas.TipoViviendas.Add(tipoVivienda);
                iTM_Viviendas.SaveChanges();
                return "Tipo de vivienda insertado correctamente";
            }
            catch (Exception ex)
            {
                return "Error al insertar el tipo de vivienda: " + ex.Message;
            }
        }

        public string Actualizar(TipoVivienda tipoVivienda)
        {
            try
            {
                TipoVivienda tv = Consultar(tipoVivienda.TipoViviendaID);
                if (tv == null)
                {
                    return "Tipo de vivienda no existe";
                }

                iTM_Viviendas.TipoViviendas.AddOrUpdate(tipoVivienda);
                iTM_Viviendas.SaveChanges();
                return "Tipo de vivienda actualizado correctamente";
            }
            catch (Exception ex)
            {
                return "Error al actualizar el tipo de vivienda: " + ex.Message;
            }
        }

        public string Eliminar(int TipoViviendaID)
        {
            try
            {
                TipoVivienda tv = Consultar(TipoViviendaID);
                if (tv == null)
                {
                    return "Tipo de vivienda no existe";
                }

                iTM_Viviendas.TipoViviendas.Remove(tv);
                iTM_Viviendas.SaveChanges();
                return "Tipo de vivienda eliminado correctamente";
            }
            catch (Exception ex)
            {
                return "Error al eliminar el tipo de vivienda: " + ex.Message;
            }
        }
    }
}
