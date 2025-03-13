using Parcial.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;

namespace Parcial.Clases
{
    public class clsAgencia
    {
        private ITM_ViviendasEntities2 iTM_Viviendas = new ITM_ViviendasEntities2();

        public List<Agencia> ConsultarTodos()
        {
            return iTM_Viviendas.Agencias.OrderBy(p => p.Nombre).ToList();
        }

        public Agencia Consultar(int AgenciaID)
        {
            return iTM_Viviendas.Agencias.FirstOrDefault(e => e.AgenciaID == AgenciaID);
        }

        public string Insertar(Agencia agencia)
        {
            try
            {
                iTM_Viviendas.Agencias.Add(agencia);
                iTM_Viviendas.SaveChanges();
                return "Agencia insertada correctamente";
            }
            catch (Exception ex)
            {
                return "Error al insertar la agencia: " + ex.Message;
            }
        }

        public string Actualizar(Agencia agencia)
        {
            try
            {
                Agencia age = Consultar(agencia.AgenciaID);
                if (age == null)
                {
                    return "Agencia no existe";
                }

                iTM_Viviendas.Agencias.AddOrUpdate(agencia);
                iTM_Viviendas.SaveChanges();
                return "Agencia actualizada correctamente";
            }
            catch (Exception ex)
            {
                return "Error al actualizar la agencia: " + ex.Message;
            }
        }

        public string Eliminar(int AgenciaID)
        {
            try
            {
                Agencia age = Consultar(AgenciaID);
                if (age == null)
                {
                    return "Agencia no existe";
                }

                iTM_Viviendas.Agencias.Remove(age);
                iTM_Viviendas.SaveChanges();
                return "Agencia eliminada correctamente";
            }
            catch (Exception ex)
            {
                return "Error al eliminar la agencia: " + ex.Message;
            }
        }
    }
}
