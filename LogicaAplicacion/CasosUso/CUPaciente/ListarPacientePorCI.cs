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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LogicaAplicacion.CasosUso.CUPaciente
{
    public class ListarPacientePorCI : ICUListarPacienteCI
    {
        private IRepositorioPacientes _repopPacientes;

        public ListarPacientePorCI(IRepositorioPacientes repo)
        {
            _repopPacientes = repo;
        }

        public PacienteDto obtenerPacienteCi(string ci)
        {
            Pacientes pacienteEncontrado = _repopPacientes.FindByCI(ci);

            PacienteDto dto = PacienteMappers.FromPacienteToDtoPaciente(pacienteEncontrado);
            return dto;
        }
    }
}
