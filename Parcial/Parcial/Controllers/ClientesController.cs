using Parcial.Clases;
using Parcial.Models;
using System.Collections.Generic;
using System.Web.Http;

namespace Parcial.Controllers
{
    [RoutePrefix("api/Clientes")]
    public class ClientesController : ApiController
    {
        [HttpGet]
        [Route("ConsultarTodos")]
        public List<Cliente> ConsultarTodos()
        {
            clsCliente cliente = new clsCliente();
            return cliente.ConsultarTodos();
        }

        [HttpGet]
        [Route("Consultar/{ID}")]
        public Cliente Consultar(int ID)
        {
            clsCliente cliente = new clsCliente();
            return cliente.Consultar(ID);
        }

        [HttpPost]
        [Route("Insertar")]
        public string Insertar([FromBody] Cliente cliente)
        {
            clsCliente clsCliente = new clsCliente();
            return clsCliente.Insertar(cliente);
        }

        [HttpPut]
        [Route("Actualizar")]
        public string Actualizar([FromBody] Cliente cliente)
        {
            clsCliente clsCliente = new clsCliente();
            return clsCliente.Actualizar(cliente);
        }

        [HttpDelete]
        [Route("Eliminar/{ID}")]
        public string Eliminar(int ID)
        {
            clsCliente clsCliente = new clsCliente();
            return clsCliente.Eliminar(ID);
        }
    }
}
