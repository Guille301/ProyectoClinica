using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs.Paciente
{
    public class PacienteListaDto
    {
        public string NombreCompleto { get; set; }
        public string NumeroDocumento { get; set; }
        public string Patologia { get; set; }
        public int id { get; set; }

        public DateTime Edad { get; set; }


    }
}
