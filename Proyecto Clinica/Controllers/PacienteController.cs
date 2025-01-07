using DTOs.Paciente;
using LogicaAplicacion.InterfaceCasosUso.ICUPaciente;
using Microsoft.AspNetCore.Authorization;
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
        private readonly ICUListarPaciente _ListarPaciente;
        private readonly ICUPacienteDetalle _cUPacienteDetalle;
        private readonly ICUPacienteFiltro _cUPacienteFiltro;

        public PacienteController(IAltaPaciente altaPaciente, ICUListarPaciente listarPaciente,   ICUPacienteDetalle cUPacienteDetalle, ICUPacienteFiltro cUPacienteFiltro)
        {
            _altaPaciente = altaPaciente;
            _ListarPaciente = listarPaciente;
            _cUPacienteDetalle = cUPacienteDetalle;
            _cUPacienteFiltro = cUPacienteFiltro;
        }

        [HttpPost]
        [Authorize]
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


        [HttpGet("Todos los Pacientes")]

        public IActionResult GetPacientes()
        {

            try
            {

                return Ok(_ListarPaciente.ListarPacientes());
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { mensaje = "Ocurrió un error inesperado: " + ex.Message });
            }
        }





        [HttpGet("Paciente Filtro")]

        public IActionResult filtrarPacientes([FromQuery] string? ci, [FromQuery] string? nombre)
        {

            try
            {
                var  filtro = _cUPacienteFiltro.filtroPacientes(ci, nombre);
                return Ok(filtro);
            }
            catch (Exception e)
            {
                return StatusCode(500);
            }
        }









        [HttpGet("Detalle Paciente")]

        public IActionResult ObtenerPacienteDetalle(int id)
        {

            try
            {
                PacienteDetalleDto dto = _cUPacienteDetalle.obtenerPacienteDetalle(id);
                return Ok(dto);
            }
            catch (Exception e)
            {
                return StatusCode(500);
            }
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
