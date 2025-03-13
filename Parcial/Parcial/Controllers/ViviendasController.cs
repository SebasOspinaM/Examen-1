using Parcial.Clases;
using Parcial.Models;
using System.Collections.Generic;
using System.Web.Http;

namespace Parcial.Controllers
{
    [RoutePrefix("api/Viviendas")]
    public class ViviendasController : ApiController
    {
        [HttpGet]
        [Route("ConsultarTodos")]
        public List<Vivienda> ConsultarTodos()
        {
            clsVivienda vivienda = new clsVivienda();
            return vivienda.ConsultarTodos();
        }

        [HttpGet]
        [Route("Consultar/{ID}")]
        public Vivienda Consultar(int ID)
        {
            clsVivienda vivienda = new clsVivienda();
            return vivienda.Consultar(ID);
        }

        [HttpPost]
        [Route("Insertar")]
        public string Insertar([FromBody] Vivienda vivienda)
        {
            clsVivienda clsVivienda = new clsVivienda();
            return clsVivienda.Insertar(vivienda);
        }

        [HttpPut]
        [Route("Actualizar")]
        public string Actualizar([FromBody] Vivienda vivienda)
        {
            clsVivienda clsVivienda = new clsVivienda();
            return clsVivienda.Actualizar(vivienda);
        }

        [HttpDelete]
        [Route("Eliminar/{ID}")]
        public string Eliminar(int ID)
        {
            clsVivienda clsVivienda = new clsVivienda();
            return clsVivienda.Eliminar(ID);
        }
    }
}
