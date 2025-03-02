using ClinicaMvc.Models;
using LogicaAplicacion.InterfaceCasosUso.ICUPaciente;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

public class HomeController : Controller
{
    private readonly ICUListarPaciente _CUListarPaciente;
    private readonly ICUPacienteFiltro _cUPacienteFiltro;
    private readonly ICUEliminarPaciente _cuEliminarPaciente;

    public HomeController(ICUListarPaciente cuListarPaciente, ICUPacienteFiltro cUPacienteFiltro, ICUEliminarPaciente cuEliminarPaciente)
    {
        _CUListarPaciente = cuListarPaciente;
        _cUPacienteFiltro = cUPacienteFiltro;
        _cuEliminarPaciente = cuEliminarPaciente;
    }

    public IActionResult Index(string? ci, string? nombre)
    {
        try
        {
            // Si se reciben parámetros de búsqueda, aplicar el filtro
            if (!string.IsNullOrEmpty(ci) || !string.IsNullOrEmpty(nombre))
            {
                var filtro = _cUPacienteFiltro.filtroPacientes(ci, nombre);
                return View(filtro);  // Devuelve la vista con la lista filtrada
            }

            // Si no hay parámetros de búsqueda, simplemente se muestran todos los pacientes
            var pacientes = _CUListarPaciente.ListarPacientes();
            return View(pacientes);
        }
        catch (Exception ex)
        {
            ViewBag.Error = ex.Message;
            return View();
        }
    }


    public IActionResult Delete(int id) 
    {

      _cuEliminarPaciente.Eliminar(id);
      return RedirectToAction("Index");
    }




    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
