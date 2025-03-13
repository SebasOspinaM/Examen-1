using Parcial.Clases;
using Parcial.Models;
using System.Collections.Generic;
using System.Web.Http;

namespace Parcial.Controllers
{
    [RoutePrefix("api/Agencias")]
    public class AgenciasController : ApiController
    {
        [HttpGet]
        [Route("ConsultarTodos")]
        public List<Agencia> ConsultarTodos()
        {
            clsAgencia agencia = new clsAgencia();
            return agencia.ConsultarTodos();
        }

        [HttpGet]
        [Route("Consultar/{ID}")]
        public Agencia Consultar(int ID)
        {
            clsAgencia agencia = new clsAgencia();
            return agencia.Consultar(ID);
        }

        [HttpPost]
        [Route("Insertar")]
        public string Insertar([FromBody] Agencia agencia)
        {
            clsAgencia clsAgencia = new clsAgencia();
            return clsAgencia.Insertar(agencia);
        }

        [HttpPut]
        [Route("Actualizar")]
        public string Actualizar([FromBody] Agencia agencia)
        {
            clsAgencia clsAgencia = new clsAgencia();
            return clsAgencia.Actualizar(agencia);
        }

        [HttpDelete]
        [Route("Eliminar/{ID}")]
        public string Eliminar(int ID)
        {
            clsAgencia clsAgencia = new clsAgencia();
            return clsAgencia.Eliminar(ID);
        }
    }
}
