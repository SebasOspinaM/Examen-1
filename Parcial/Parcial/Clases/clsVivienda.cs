using Parcial.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace Parcial.Clases
{
    public class clsVivienda
    {
        private ITM_ViviendasEntities2 iTM_Viviendas = new ITM_ViviendasEntities2();
        public Vivienda vivienda { get; set; }

        public string Insertar()
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

        public string Actualizar()
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

        public Vivienda Consultar(int viviendaID)
        {
            return iTM_Viviendas.Viviendas.FirstOrDefault(v => v.ViviendaID == viviendaID);
        }

        public string Eliminar()
        {
            try
            {
                Vivienda viv = Consultar(vivienda.ViviendaID);
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