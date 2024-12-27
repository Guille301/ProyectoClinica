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
    public class ListarPacientePorNombre : ICUListarPacienteNombre
    {

        private IRepositorioPacientes _repopPacientes;

        public ListarPacientePorNombre(IRepositorioPacientes repo)
        {
            _repopPacientes = repo;
        }
        public PacienteDto ObtenerPacientePorNombre(string nombre)
        {
            Pacientes pacienteEncontrado = _repopPacientes.FindByName(nombre);

            PacienteDto dto = PacienteMappers.FromPacienteToDtoPaciente(pacienteEncontrado);
            return dto;
        }
    }
}
