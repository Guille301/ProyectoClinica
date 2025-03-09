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
    public class PacienteDetalle : ICUPacienteDetalle
    {
        private IRepositorioPacientes _repopPacientes;

        public PacienteDetalle(IRepositorioPacientes repo)
        {
            _repopPacientes = repo;
        }
        public PacienteDetalleDto obtenerPacienteDetalle(int id)
        {
            Pacientes pacienteEncontrado = _repopPacientes.FindById(id);

            PacienteDetalleDto dto = PacienteMappers.FromPacienteDetalleToDtoPacienteDetalle(pacienteEncontrado);
            return dto;
        }
    }
}
