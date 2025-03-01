using DTOs.Evolucion;
using LogicaAplicacion.CasosUso.CUEvolucion;
using LogicaAplicacion.InterfaceCasosUso.ICUEvolucion;
using LogicaAplicacion.InterfaceCasosUso.ICUPaciente;
using Microsoft.AspNetCore.Mvc;

namespace ClinicaMvc.Controllers
{
    public class EvolucionController : Controller
    {

        private readonly IAltaEvolucion _cuAltaEvolucion;
        private readonly ICUListarEvoluciones _cUListarEvoluciones;

        public EvolucionController(IAltaEvolucion cuAltaEvolucion, ICUListarEvoluciones cuListarEvoluciones)
        {
            _cuAltaEvolucion = cuAltaEvolucion;
            _cUListarEvoluciones = cuListarEvoluciones;
        }

            // Método para listar evoluciones del paciente
            public IActionResult GetEvoluciones(int id)
            {
                try
                {
                    EvolucionPacienteDto evoluciones = _cUListarEvoluciones.ListarEvoluciones(id);
                    return View(evoluciones);
                }
                catch (Exception ex)
                {
                    ViewBag.Error = "Ocurrió un error inesperado: " + ex.Message;
                    return View("Error");
                }
            }

            // GET: Mostrar el formulario de creación
            public IActionResult Create(int id)
            {
                EvolucionAltaDto dto = new EvolucionAltaDto();
                dto.IdPaciente = id;
                return View(dto);
            }

            // POST: Procesar el alta de una evolución
            [HttpPost]
            public IActionResult Create(EvolucionAltaDto altaEvolucionDto)
            {
                try
                {
                    _cuAltaEvolucion.Ejecutar(altaEvolucionDto);
                    return RedirectToAction("GetEvoluciones", new { id = altaEvolucionDto.IdPaciente });
                }
                catch (Exception ex)
                {
                    ViewBag.Error = "Ocurrió un error inesperado: " + ex.Message;
                    return View(altaEvolucionDto);
                }
            }







        }
}
