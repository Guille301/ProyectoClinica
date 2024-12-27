using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Exepciones.Usuario
{
    public class UsuarioCredencialesIncorrectasException:Exception
    {
        public UsuarioCredencialesIncorrectasException() : base()
        {

        }

        public UsuarioCredencialesIncorrectasException(string? message) : base(message)
        {
        }

        public UsuarioCredencialesIncorrectasException(string? message, Exception? innerException) : base(message, innerException)
        {

        }
    }
}
