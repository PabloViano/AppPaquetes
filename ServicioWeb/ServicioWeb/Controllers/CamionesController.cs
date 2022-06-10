using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.ModelBinding;
using Logica;
using Entidades;

namespace ServicioWeb.Controllers
{
    [RoutePrefix("api/Servicios/Camiones")]
    Logica.Principal logica = new Principal
    public class CamionesController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        [Route("Get/{id]")]
        public IHttpActionResult Get([Required]int id)
        {
            return Ok(Logica.Principal.Camiones);
        }

        // POST api/<controller>
        [Route("Alta")]
        public IHttpActionResult Post(int numero, string marca, DateTime fechaDestino, decimal pesoMax)
        {
            return Ok(Logica.Principal.Alta(numero, marca, fechaDestino, pesoMax));
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}