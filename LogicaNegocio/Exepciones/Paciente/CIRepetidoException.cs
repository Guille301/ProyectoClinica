using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Exepciones.Paciente
{
    public class CIRepetidoException : Exception
    {

        public CIRepetidoException(string message) : base(message) { }


    }
}
