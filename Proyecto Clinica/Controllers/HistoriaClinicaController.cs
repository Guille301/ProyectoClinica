using DTOs.HistorialClinico;
using DTOs.Paciente;
using LogicaAplicacion.CasosUso.CUPaciente;
using LogicaAplicacion.InterfaceCasosUso.ICUHistoriaClinica;
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
        private readonly IAgregrarHistoriaClinica _agregarHistoria;



        public HistoriaClinicaController(IPacienteFicha PacienteFicha,IAgregrarHistoriaClinica AgrergarHistoria)
        {
            _fichaPaciente = PacienteFicha;
            _agregarHistoria = AgrergarHistoria;


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


        [HttpPost]
        //[Authorize]
        public IActionResult Create(HistoriaAltaDto altaDto,int id)
        {
            try
            {
                _agregarHistoria.Ejecutar(altaDto,id);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { mensaje = "Ocurrió un error inesperado: " + ex.Message });
            }
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
