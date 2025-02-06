using DTOs.HistorialClinico;
using DTOs.Paciente;
using LogicaAplicacion.InterfaceCasosUso.ICUHistoriaClinica;
using LogicaAplicacion.InterfaceCasosUso.ICUPaciente;
using Microsoft.AspNetCore.Mvc;

namespace ClinicaMvc.Controllers
{
    public class HistoriaClinicaController : Controller
    {


        private readonly IPacienteFicha _fichaPaciente;
        private readonly IAgregrarHistoriaClinica _agregarHistoria;
        private readonly IEditarHistoriaClinica _editarHistoriaClinica;
        private readonly IListarHistoriaClinica _listarHistoriaClinica;

        public HistoriaClinicaController(
            IPacienteFicha pacienteFicha,
            IAgregrarHistoriaClinica agregarHistoria,
            IEditarHistoriaClinica editarHistoriaClinica,
            IListarHistoriaClinica listarHistoriaClinica)
        {
            _fichaPaciente = pacienteFicha;
            _agregarHistoria = agregarHistoria;
            _editarHistoriaClinica = editarHistoriaClinica;
            _listarHistoriaClinica = listarHistoriaClinica;
        }

        public IActionResult ObtenerFichaPaciente(int id)
        {
            try
            {
                FichaPacienteDto dto = _fichaPaciente.obtenerFichaPaciente(id);
                return View(dto);  
            }
            catch (Exception e)
            {
                return View("Error"); 
            }
        }

        
        public IActionResult Create()
        {
            return View(new HistoriaAltaDto());  
        }

        
        [HttpPost]
        public IActionResult Create(HistoriaAltaDto altaDto, int id)
        {
            try
            {
                _agregarHistoria.Ejecutar(altaDto, id);
                return RedirectToAction("GetHistoriaClinica", new { id }); 
            }
            catch (Exception ex)
            {
                ViewBag.Error = "Ocurrió un error inesperado: " + ex.Message;
                return View(altaDto); 
            }
        }

        
        //public IActionResult Edit(int id)
        //{
        //    try
        //    {
        //        var historia = _editarHistoriaClinica.Ejecutar(id);
        //        if (historia == null)
        //        {
        //            return NotFound();
        //        }
        //        return View(historia);
        //    }
        //    catch (Exception ex)
        //    {
        //        return View("Error");
        //    }
        //}

        // POST para procesar la edición
        [HttpPost]
        public IActionResult Edit(int id, EditarHistoriaDTO dto)
        {
            try
            {
                _editarHistoriaClinica.Ejecutar(dto, id);
                return RedirectToAction("GetHistoriaClinica", new { id });
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View(dto);
            }
        }

        // Método para mostrar la lista de historias clínicas
        public IActionResult GetHistoriaClinica(int id)
        {
            try
            {
                var historias = _listarHistoriaClinica.ListarHistoria(id);
                return View(historias);
            }
            catch (Exception ex)
            {
                return View("Error");
            }
        }








    }
}
