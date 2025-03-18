using DTOs.Usuario;
using LogicaAplicacion.InterfaceCasosUso.ICUUsuario;
using LogicaNegocio.Exepciones.Usuario;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ClinicaMvc.Controllers
{
    public class LoginController : Controller
    {
        ICULogin _CULogin;
        ICURegistro _CURegistro;

        public LoginController(ICULogin login,ICURegistro registro) 
        {
          _CULogin = login;
          _CURegistro = registro;
        }




        //--------------------------------------------------------------------------------

        //Metodo para logearse
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(DtoLogin dto)
        {

            try
            {
                DtoUsuarioLogin dtoLogin = _CULogin.Logearse(dto);
                HttpContext.Session.SetString("usuarioEmail", dtoLogin.Email);
                return RedirectToAction("Index", "Home"); // Modificar la redireccion
            }
            catch (UsuarioCredencialesIncorrectasException ex)
            {
                ViewBag.msg = ex.Message; //Unauthorized
                return View();
            }
            catch (UsuarioNoEncontradoException ex)
            {
                ViewBag.msg = ex.Message;
                return View(); //NotFound				

            }
            catch (Exception ex)
            {
                ViewBag.msg = ex.Message;
                return View(); ; //Internal Server Error
            }

        }



        // -------------------------------------------------------------------




        //Registro
        [Route("Registro")]
        public IActionResult Registro()
        {
            return View();
        }


        [Route("Registro")]
        [HttpPost]
        public IActionResult Registro(DtoRegistro dto)
        {
            try
            {
                _CURegistro.Registrar(dto);
                return RedirectToAction("Login");
            }
            catch (UsuarioPassworsNoCoincidenException ex) 
            {
                ViewBag.msg = ex.Message;
                return View();
            }
            catch (UsuarioYaExisteException ex)
            {
                ViewBag.msg = ex.Message;
                return View();
            }
            catch (Exception)
            {
                return View();
            }
            
        }



    }
}
