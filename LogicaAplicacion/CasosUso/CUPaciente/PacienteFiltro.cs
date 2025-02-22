using DTOs.Mappers;
using DTOs.Paciente;
using LogicaAplicacion.InterfaceCasosUso.ICUPaciente;
using LogicaNegocio.Entidades;
using LogicaNegocio.InterfacesRepositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAplicacion.CasosUso.CUPaciente
{
    public class PacienteFiltro : ICUPacienteFiltro
    {
        private IRepositorioPacientes _repopPacientes;

        public PacienteFiltro(IRepositorioPacientes repo)
        {
            _repopPacientes = repo;
        }
        public IEnumerable<PacienteListaDto> filtroPacientes(string? ci, string? nombre)
        {
            List<Pacientes> listaPacientes = _repopPacientes.FiltroPacientes(ci, nombre);

            //List<PacienteFiltroDto> DtoPaciente = PacienteMappers.FromDtoFiltrarPacientes(listaPacientes);
            List<PacienteListaDto> DtoPaciente = PacienteMappers.FromListPacienteToListPacienteDto(listaPacientes);

            return DtoPaciente;
        }
    }
}
