using ClinicaMvc.Models;
using LogicaAplicacion.InterfaceCasosUso.ICUPaciente;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ClinicaMvc.Controllers
{
    public class HomeController : Controller
    {
        ICUListarPaciente _CUListarPaciente;

        public HomeController(ICUListarPaciente cuListarPaciente)
        {
            _CUListarPaciente = cuListarPaciente;
        }
        public IActionResult Index()
        {
            return View(_CUListarPaciente.ListarPacientes());
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
}
