using Parcial.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace Parcial.Clases
{
	public class clsAgencia
	{
		private ITM_ViviendasEntities2 iTM_Viviendas = new ITM_ViviendasEntities2();
        public Agencia agencia { get; set; }

		public string Insertar()
		{
			try
			{
                iTM_Viviendas.Agencias.Add(agencia);
                iTM_Viviendas.SaveChanges();
                return "Agencia insertada correctamente";
            }
			catch (Exception ex)
			{
				return "Error al insertar al empleado: " + ex.Message;
			}
		}
		public string Actualizar()
		{
			try
			{
				Agencia age = Consultar(agencia.Nombre);
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
				return "Error al actualizar a la agencia: " + ex.Message;
			}
			
		}

		public Agencia Consultar(string nombre)
		{
			Agencia age = iTM_Viviendas.Agencias.FirstOrDefault(e => e.Nombre == nombre);
			return age;
		}

		public string Eliminar()
		{
			try
			{
				Agencia age = Consultar(agencia.Nombre);
				if(age == null)
				{
					return "Agencia no existe";
				}

				iTM_Viviendas.Agencias.Remove(age);
				iTM_Viviendas.SaveChanges();
				return "Agencia eliminada correctamente";

            }
			catch (Exception ex)
			{
				return "Error al eliminar al empleado: " + ex.Message;
			}
		}


    }
}