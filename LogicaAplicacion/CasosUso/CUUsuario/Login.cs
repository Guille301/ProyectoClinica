using DTOs.Usuario;
using LogicaAplicacion.InterfaceCasosUso.ICUUsuario;
using LogicaNegocio.Entidades;
using LogicaNegocio.Exepciones.Usuario;
using LogicaNegocio.InterfacesRepositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAplicacion.CasosUso.CUUsuario
{
    public class Login:ICULogin
    {
        IRepositorioUsuarios _repoUsuarios;

        public Login(IRepositorioUsuarios repoUsuarios)
        {
            _repoUsuarios = repoUsuarios;
        }

        public DtoUsuarioLogin Logearse(DtoLogin dto)
        {

            DtoUsuarioLogin retorno = new DtoUsuarioLogin();
            Usuarios buscado = _repoUsuarios.FindByGmail(dto.Email);

            if (buscado != null)
            {
                if (VerifyPasswordConBcrypt(dto.Password, buscado.Password))
                {
                    retorno.Id = buscado.Id;
                    retorno.Email = buscado.Email;
                    retorno.Password = "";
                }
                else if (!VerifyPasswordConBcrypt(dto.Password, buscado.Password))
                {
                    throw new UsuarioCredencialesIncorrectasException("Contraseña incorrecta");
                }
            }
            else if (buscado == null)
            {
                throw new UsuarioNoEncontradoException("Por favor, ingresar un mail valido");
            }

            return retorno;

        }

        static string HashPasswordConBcrypt(string password, int workFactor)
        {
            // Generar el hash de la contraseña usando BCrypt
            return BCrypt.Net.BCrypt.HashPassword(password, workFactor);
        }

        static bool VerifyPasswordConBcrypt(string password, string hashedPassword)
        {
            // Verificar si la contraseña coincide con el hash
            return BCrypt.Net.BCrypt.Verify(password, hashedPassword);
        }

    }
}
