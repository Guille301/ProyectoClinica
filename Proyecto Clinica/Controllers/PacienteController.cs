using DTOs.Paciente;
using LogicaAplicacion.InterfaceCasosUso.ICUPaciente;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Proyecto_Clinica.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PacienteController : ControllerBase
    {

        private readonly IAltaPaciente _altaPaciente;

        public PacienteController(IAltaPaciente altaPaciente)
        {
            _altaPaciente = altaPaciente;

        }

        [HttpPost]
        public IActionResult Create(PacienteAltaDto altaPacienteDto)
        {
            try
            {
                _altaPaciente.Ejecutar(altaPacienteDto);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { mensaje = "Ocurrió un error inesperado: " + ex.Message });
            }
        }








        // GET: api/<PacienteController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<PacienteController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }



        // PUT api/<PacienteController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PacienteController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
