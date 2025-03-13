using Parcial.Clases;
using Parcial.Models;
using System.Collections.Generic;
using System.Web.Http;

namespace Parcial.Controllers
{
    [RoutePrefix("api/TipoViviendas")]
    public class TipoViviendasController : ApiController
    {
        [HttpGet]
        [Route("ConsultarTodos")]
        public List<TipoVivienda> ConsultarTodos()
        {
            clsTipoVivienda tipoVivienda = new clsTipoVivienda();
            return tipoVivienda.ConsultarTodos();
        }

        [HttpGet]
        [Route("Consultar/{ID}")]
        public TipoVivienda Consultar(int ID)
        {
            clsTipoVivienda tipoVivienda = new clsTipoVivienda();
            return tipoVivienda.Consultar(ID);
        }

        [HttpPost]
        [Route("Insertar")]
        public string Insertar([FromBody] TipoVivienda tipoVivienda)
        {
            clsTipoVivienda clsTipoVivienda = new clsTipoVivienda();
            return clsTipoVivienda.Insertar(tipoVivienda);
        }

        [HttpPut]
        [Route("Actualizar")]
        public string Actualizar([FromBody] TipoVivienda tipoVivienda)
        {
            clsTipoVivienda clsTipoVivienda = new clsTipoVivienda();
            return clsTipoVivienda.Actualizar(tipoVivienda);
        }

        [HttpDelete]
        [Route("Eliminar/{ID}")]
        public string Eliminar(int ID)
        {
            clsTipoVivienda clsTipoVivienda = new clsTipoVivienda();
            return clsTipoVivienda.Eliminar(ID);
        }
    }
}
