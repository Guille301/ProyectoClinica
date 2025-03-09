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

        public LoginController(ICULogin login) 
        {
          _CULogin = login;
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
                //HttpContext.Session.SetString("gmail", dtoLogin.Email);
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

    }
}
