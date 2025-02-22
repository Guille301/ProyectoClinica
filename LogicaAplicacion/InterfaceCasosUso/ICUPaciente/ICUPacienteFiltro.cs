using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTOs.Paciente;

namespace LogicaAplicacion.InterfaceCasosUso.ICUPaciente
{
    public interface ICUPacienteFiltro
    {
        public IEnumerable<PacienteListaDto> filtroPacientes(string? ci, string? nombre);
    }
}
