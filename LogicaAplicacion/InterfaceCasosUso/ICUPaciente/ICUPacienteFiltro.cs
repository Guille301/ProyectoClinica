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
<<<<<<< HEAD
        public IEnumerable<PacienteFiltroDto> filtroPacientes(string? ci, string? nombre);
=======
        public IEnumerable<PacienteListaDto> filtroPacientes(string? ci, string? nombre);
>>>>>>> bf58e0f (se mejoro la interfaz del dashboard)
    }
}
