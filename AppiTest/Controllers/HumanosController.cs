using AppiTest.Context;
using AppiTest.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AppiTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HumanosController : ControllerBase
    {

        private readonly HumanosContext context;

        public HumanosController(HumanosContext context)
        {
            this.context = context;
        }

        // GET: api/<HumanosController>
        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                return Ok(context.tHumanos.ToList());
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        // GET api/<HumanosController>/5
        [HttpGet("{id}", Name = "gId")]
        public ActionResult Get(int id)
        {
            try
            {
                var humano = context.tHumanos.FirstOrDefault(f => f.Id == id);
                return Ok(humano);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // POST api/<HumanosController>
        [HttpPost]
        public ActionResult Post([FromBody] Humanos humanos)
        {
            try
            {
                context.tHumanos.Add(humanos);
                context.SaveChanges();
                return CreatedAtRoute("gId", new { id = humanos.Id }, humanos);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        // PUT api/<HumanosController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Humanos humanos2)
        {
            try
            {
                if (humanos2.Id == id)
                {
                    context.Entry(humanos2).State = EntityState.Modified;
                    context.SaveChanges();
                    return CreatedAtRoute("gId", new {id = humanos2.Id }, humanos2);
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        // DELETE api/<HumanosController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            try
            {
                var humanos3 = context.tHumanos.FirstOrDefault(f => f.Id == id);
                if (humanos3 != null)
                {
                    context.tHumanos.Remove(humanos3);
                    context.SaveChanges();
                    return Ok(id);
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
