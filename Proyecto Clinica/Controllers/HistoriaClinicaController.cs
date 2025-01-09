using DTOs.Paciente;
using LogicaAplicacion.InterfaceCasosUso.ICUPaciente;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Proyecto_Clinica.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HistoriaClinicaController : ControllerBase
    {



        private readonly IPacienteFicha _fichaPaciente;
  


        public HistoriaClinicaController(IPacienteFicha PacienteFicha)
        {
            _fichaPaciente = PacienteFicha;
           
        }


        [HttpGet("Ficha identificacion")]

        public IActionResult ObtenerFichaPaciente(int id)
        {

            try
            {
                FichaPacienteDto dto = _fichaPaciente.obtenerFichaPaciente(id);
                return Ok(dto);
            }
            catch (Exception e)
            {
                return StatusCode(500);
            }
        }








    

        // POST api/<HistoriaClinicaController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<HistoriaClinicaController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<HistoriaClinicaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
