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
    public class PacienteFichaIdentificacion : IPacienteFicha
    {

        
            private IRepositorioPacientes _repopPacientes;

            public PacienteFichaIdentificacion(IRepositorioPacientes repo)
            {
                _repopPacientes = repo;
            }

        public FichaPacienteDto obtenerFichaPaciente(string ci)
        {
            Pacientes pacienteEncontrado = _repopPacientes.FindDetalle(ci);

            FichaPacienteDto dto = PacienteMappers.FromPacienteFichaDto(pacienteEncontrado);
            return dto;
        }

        
        


    }
}
