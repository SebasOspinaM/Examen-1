using Parcial.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;

namespace Parcial.Clases
{
    public class clsVivienda
    {
        private ITM_ViviendasEntities2 iTM_Viviendas = new ITM_ViviendasEntities2();

        public List<Vivienda> ConsultarTodos()
        {
            return iTM_Viviendas.Viviendas.OrderBy(v => v.TamanoMetrosCuadrados).ToList();
        }

        public Vivienda Consultar(int ViviendaID)
        {
            return iTM_Viviendas.Viviendas.FirstOrDefault(v => v.ViviendaID == ViviendaID);
        }

        public string Insertar(Vivienda vivienda)
        {
            try
            {
                iTM_Viviendas.Viviendas.Add(vivienda);
                iTM_Viviendas.SaveChanges();
                return "Vivienda insertada correctamente";
            }
            catch (Exception ex)
            {
                return "Error al insertar la vivienda: " + ex.Message;
            }
        }

        public string Actualizar(Vivienda vivienda)
        {
            try
            {
                Vivienda viv = Consultar(vivienda.ViviendaID);
                if (viv == null)
                {
                    return "Vivienda no existe";
                }

                iTM_Viviendas.Viviendas.AddOrUpdate(vivienda);
                iTM_Viviendas.SaveChanges();
                return "Vivienda actualizada correctamente";
            }
            catch (Exception ex)
            {
                return "Error al actualizar la vivienda: " + ex.Message;
            }
        }

        public string Eliminar(int ViviendaID)
        {
            try
            {
                Vivienda viv = Consultar(ViviendaID);
                if (viv == null)
                {
                    return "Vivienda no existe";
                }

                iTM_Viviendas.Viviendas.Remove(viv);
                iTM_Viviendas.SaveChanges();
                return "Vivienda eliminada correctamente";
            }
            catch (Exception ex)
            {
                return "Error al eliminar la vivienda: " + ex.Message;
            }
        }
    }
}
