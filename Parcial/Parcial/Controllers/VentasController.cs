using Parcial.Clases;
using Parcial.Models;
using System.Collections.Generic;
using System.Web.Http;

namespace Parcial.Controllers
{
    [RoutePrefix("api/Ventas")]
    public class VentasController : ApiController
    {
        [HttpGet]
        [Route("ConsultarTodos")]
        public List<Venta> ConsultarTodos()
        {
            clsVenta venta = new clsVenta();
            return venta.ConsultarTodos();
        }

        [HttpGet]
        [Route("Consultar/{ID}")]
        public Venta Consultar(int ID)
        {
            clsVenta venta = new clsVenta();
            return venta.Consultar(ID);
        }

        [HttpPost]
        [Route("Insertar")]
        public string Insertar([FromBody] Venta venta)
        {
            clsVenta clsVenta = new clsVenta();
            return clsVenta.Insertar(venta);
        }

        [HttpPut]
        [Route("Actualizar")]
        public string Actualizar([FromBody] Venta venta)
        {
            clsVenta clsVenta = new clsVenta();
            return clsVenta.Actualizar(venta);
        }

        [HttpDelete]
        [Route("Eliminar/{ID}")]
        public string Eliminar(int ID)
        {
            clsVenta clsVenta = new clsVenta();
            return clsVenta.Eliminar(ID);
        }
    }
}
