using DTOs.Mappers;
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
    public class Registro : ICURegistro
    {
        IRepositorioUsuarios _repoUsuarios;

        public Registro(IRepositorioUsuarios repoUsuarios)
        {
            _repoUsuarios = repoUsuarios;
        }
        public void Registrar(DtoRegistro dto)
        {
            Usuarios usuarioEncontrado = _repoUsuarios.FindByGmail(dto.Email);

            if (usuarioEncontrado != null)
            {
                throw new UsuarioYaExisteException("Ese Email ya esta Registrado");
            }

            if (dto.Password != dto.ConfPassword)
            {
                throw new UsuarioPassworsNoCoincidenException("Las Passwords no son las mismas");
            }


            dto.Password = HashPasswordConBcrypt(dto.Password,12);

            Usuarios nuevoUsuario = UsuarioMappers.FromDtoRegistroToUsuario(dto);

            _repoUsuarios.Add(nuevoUsuario);

        }




        static string HashPasswordConBcrypt(string password, int workFactor)
        {
            // Generar el hash de la contraseña usando BCrypt
            return BCrypt.Net.BCrypt.HashPassword(password, workFactor);
        }
    }
}
