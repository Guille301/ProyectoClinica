using DTOs.HistorialClinico;
using DTOs.Paciente;
using LogicaAplicacion.CasosUso.CUPaciente;
using LogicaAplicacion.InterfaceCasosUso.ICUHistoriaClinica;
using LogicaAplicacion.InterfaceCasosUso.ICUPaciente;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Security.Claims;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Proyecto_Clinica.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HistoriaClinicaController : ControllerBase
    {



        private readonly IPacienteFicha _fichaPaciente;
        private readonly IAgregrarHistoriaClinica _agregarHistoria;
        private readonly IEditarHistoriaClinica _editarHistoriaClinica;
        private readonly IListarHistoriaClinica _listarHistoriaClinica;


        public HistoriaClinicaController(IPacienteFicha PacienteFicha,IAgregrarHistoriaClinica AgrergarHistoria, IEditarHistoriaClinica editarHistoriaClinica, IListarHistoriaClinica listarHistoriaClinica)
        {
            _fichaPaciente = PacienteFicha;
            _agregarHistoria = AgrergarHistoria;
            _editarHistoriaClinica = editarHistoriaClinica;
            _listarHistoriaClinica = listarHistoriaClinica;


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
        public IActionResult Update(int id, [FromBody] EditarHistoriaDTO Dto)
        {
            try
            {

                _editarHistoriaClinica.Ejecutar(Dto,id);

               

                return NoContent(); // Código 204: Actualización exitosa sin contenido
            }
            catch (Exception ex)
            {
                return BadRequest(new { mensaje = ex.Message });
            }
        }





        [HttpGet("Listar HistoriaClinica")]

        public IActionResult GetHistoriaClinica(int id)
        {

            try
            {

                return Ok(_listarHistoriaClinica.ListarHistoria(id));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { mensaje = "Ocurrió un error inesperado: " + ex.Message });
            }
        }








        // DELETE api/<HistoriaClinicaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
