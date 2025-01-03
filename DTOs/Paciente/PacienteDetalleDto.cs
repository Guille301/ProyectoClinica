using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs.Paciente
{
    public  class PacienteDetalleDto
    {
        public string Nombre { get; set; }
        public string Ci { get; set; }
        public DateTime fecha { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string Patologia { get; set; }
    }
}
