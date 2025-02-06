using DTOs.Paciente;
using LogicaAplicacion.InterfaceCasosUso.ICUPaciente;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ClinicaMvc.Controllers
{
    public class PacienteController : Controller
    {

        private readonly IAltaPaciente _altaPaciente;
        private readonly ICUListarPaciente _ListarPaciente;
        private readonly ICUPacienteDetalle _cUPacienteDetalle;
        private readonly ICUPacienteFiltro _cUPacienteFiltro;


        public PacienteController(IAltaPaciente altaPaciente, ICUListarPaciente listarPaciente, ICUPacienteDetalle cUPacienteDetalle, ICUPacienteFiltro cUPacienteFiltro)
        {
            _altaPaciente = altaPaciente;
            _ListarPaciente = listarPaciente;
            _cUPacienteDetalle = cUPacienteDetalle;
            _cUPacienteFiltro = cUPacienteFiltro;
        }


        public ActionResult Create()
        {
            
                return View();
            
           
        }

        [HttpPost]
        //[Authorize]
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
                var filtro = _cUPacienteFiltro.filtroPacientes(ci, nombre);
                return Ok(filtro);
            }
            catch (Exception e)
            {
                return StatusCode(500);
            }
        }









        [HttpGet("DetallePaciente/{id}")]


        public IActionResult ObtenerPacienteDetalle(int id)
        {

            try
            {
                PacienteDetalleDto dto = _cUPacienteDetalle.obtenerPacienteDetalle(id);
                return View(dto);
            }
            catch (Exception e)
            {
                return StatusCode(500);
            }
        }

    }
}
