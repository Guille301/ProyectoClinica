using DTOs.Usuario;
using LogicaNegocio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs.Mappers
{
    public class UsuarioMappers
    {
        public static Usuarios FromDtoRegistroToUsuario(DtoRegistro dtoRegistro)
        {
            Usuarios retorno = new Usuarios();
            retorno.Email = dtoRegistro.Email;
            retorno.Password = dtoRegistro.Password;
            return retorno;
        }
    }
}
