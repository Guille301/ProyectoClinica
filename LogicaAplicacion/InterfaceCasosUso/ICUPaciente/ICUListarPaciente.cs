using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTOs.Paciente;

namespace LogicaAplicacion.InterfaceCasosUso.ICUPaciente
{
    public interface ICUListarPaciente
    {
        List<PacienteListaDto> ListarPacientes();
    }
}
