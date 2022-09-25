using AppiTest.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AppiTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OperacionesController : ControllerBase
    {
        // GET: api/<OperacionesController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "1", "Andres","Hombre","33","1.70","75 kg" };
        }

        // POST api/<OperacionesController>
        [HttpPost]
        public ActionResult PostSuma([FromBody] Operaciones suma)
        {
            suma.resultado = suma.val1 + suma.val2 + suma.val3;
            return Ok(suma.resultado);
        }

    }
}
