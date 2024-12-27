using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Exepciones.Usuario
{
    public class UsuarioNoEncontradoException:Exception
    {
        public UsuarioNoEncontradoException() : base()
        {

        }

        public UsuarioNoEncontradoException(string? message) : base(message)
        {
        }

        public UsuarioNoEncontradoException(string? message, Exception? innerException) : base(message, innerException)
        {

        }
    }
}
