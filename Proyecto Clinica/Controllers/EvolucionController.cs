using DTOs.Evolucion;
using DTOs.Paciente;
using LogicaAplicacion.CasosUso.CUPaciente;
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

        public EvolucionController(IAltaEvolucion cuAltaEvolucion)
        {
            _cuAltaEvolucion = cuAltaEvolucion;
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
    }
}
