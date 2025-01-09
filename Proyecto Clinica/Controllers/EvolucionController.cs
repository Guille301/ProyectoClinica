using DTOs.Evolucion;
using DTOs.Paciente;
using LogicaAplicacion.CasosUso.CUPaciente;
using LogicaAplicacion.InterfaceCasosUso.ICUEvolucion;
using LogicaAplicacion.InterfaceCasosUso.ICUPaciente;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Proyecto_Clinica.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EvolucionController : ControllerBase
    {
        private readonly IAltaEvolucion _cuAltaEvolucion;
        private readonly ICUListarEvoluciones _cUListarEvoluciones;

        public EvolucionController(IAltaEvolucion cuAltaEvolucion, ICUListarEvoluciones cuListarEvoluciones )
        {
            _cuAltaEvolucion = cuAltaEvolucion;
            _cUListarEvoluciones = cuListarEvoluciones;
        }


        [HttpPost("Alta Evolucion")]
        
        public IActionResult Create(EvolucionAltaDto altaEvolucionDto, int id)
        {
            try
            {
                _cuAltaEvolucion.Ejecutar(altaEvolucionDto, id);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { mensaje = "Ocurrió un error inesperado: " + ex.Message });
            }
        }




        [HttpGet("Listar Evoluciones")]

        public IActionResult GetEvoluciones()
        {

            try
            {

                return Ok(_cUListarEvoluciones.ListarEvoluciones());
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { mensaje = "Ocurrió un error inesperado: " + ex.Message });
            }
        }
    }
}
