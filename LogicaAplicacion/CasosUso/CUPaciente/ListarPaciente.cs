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
    public class ListarPaciente : ICUListarPaciente
    {
        private IRepositorioPacientes _repopPacientes;

        public ListarPaciente(IRepositorioPacientes repo)
        {
            _repopPacientes = repo;
        }
        public List<PacienteListaDto> ListarPacientes(string emailUsuario)
        {
            List<Pacientes> listaPacientes = _repopPacientes.FindAllPacientesByUsuarioEmail(emailUsuario);
            List<PacienteListaDto> dtoListarAtletas = PacienteMappers.FromListPacienteToListPacienteDto(listaPacientes);
            return dtoListarAtletas;
        }
    }
}
