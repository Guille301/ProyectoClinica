using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Exepciones.Usuario
{
    public class UsuarioPassworsNoCoincidenException:Exception
    {
        public UsuarioPassworsNoCoincidenException() : base()
        {

        }

        public UsuarioPassworsNoCoincidenException(string? message) : base(message)
        {
        }

        public UsuarioPassworsNoCoincidenException(string? message, Exception? innerException) : base(message, innerException)
        {

        }
    }
}
