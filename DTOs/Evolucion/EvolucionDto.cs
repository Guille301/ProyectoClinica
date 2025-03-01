using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs.Evolucion
{
    public class EvolucionPacienteDto
    {
        public int IdPaciente { get; set; }
        public List<EvolucionListaDto> listaEvoluciones { get; set; }

    }
}
