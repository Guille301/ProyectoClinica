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
                TempData["Mensaje"] = "Disciplina creada correctamente";
                return RedirectToAction("Index", "Home");
                
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View();
            }
        }






        //public IActionResult filtrarPacientes(string? ci, string? nombre)
        //{

        //    try
        //    {
        //        var filtro = _cUPacienteFiltro.filtroPacientes(ci, nombre);
        //        return View(filtro);
        //    }
        //    catch (Exception ex)
        //    {
        //        ViewBag.Error = ex.Message;
        //        return View();
        //    }
        //}








        public IActionResult ObtenerPacienteDetalle(int id)
        {

            try
            {
                PacienteDetalleDto dto = _cUPacienteDetalle.obtenerPacienteDetalle(id);
                return View(dto);
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View();
            }
        }

    }
}
