using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Exepciones.Usuario
{
    public class UsuarioYaExisteException:Exception
    {
        public UsuarioYaExisteException() : base()
        {

        }

        public UsuarioYaExisteException(string? message) : base(message)
        {
        }

        public UsuarioYaExisteException(string? message, Exception? innerException) : base(message, innerException)
        {

        }
    }
}
