using DTOs.Mappers;
using DTOs.Paciente;
using LogicaAplicacion.InterfaceCasosUso.ICUPaciente;
using LogicaNegocio.InterfacesRepositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAplicacion.CasosUso.CUPaciente
{
    public class ListarPaciente : ICUListarPaciente
    {
        private IRepositorioPacientes _repopPacientes;

        public ListarPaciente(IRepositorioPacientes repo)
        {
            _repopPacientes = repo;
        }
        public List<PacienteListaDto> ListarPacientes()
        {
            List<PacienteListaDto> dtoListarAtletas = PacienteMappers.FromListPacienteToListPacienteDto(_repopPacientes.FindAll());
            return dtoListarAtletas;
        }
    }
}
