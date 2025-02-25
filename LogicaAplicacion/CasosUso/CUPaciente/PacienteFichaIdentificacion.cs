using DTOs.HistorialClinico;
using DTOs.Mappers;
using DTOs.Paciente;
using LogicaAplicacion.CasosUso.CUHistoriaClinica;
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
            private IRepositorioHistorialesClinicos _historialesClinicos;

            public PacienteFichaIdentificacion(IRepositorioPacientes repo,IRepositorioHistorialesClinicos historialesClinicos)
            {
                _repopPacientes = repo;
                _historialesClinicos = historialesClinicos;
            }

        public FichaPacienteDto obtenerFichaPaciente(int id)
        {
            HistorialesClinicos encontrarHistorialClinica = _historialesClinicos.FindByPacienteId(id);


            Pacientes pacienteEncontrado = _repopPacientes.FindById(id);
            FichaPacienteDto dto = PacienteMappers.FromPacienteFichaDto(pacienteEncontrado);

            if (encontrarHistorialClinica != null) 
            {

                dto.MotivoDeConsulta = encontrarHistorialClinica.MotivoDeConsulta;
                dto.EnfermedadActual = encontrarHistorialClinica.EnfermedadActual;
                dto.Antecedentes = encontrarHistorialClinica.Antecedentes;
                dto.HabitosPSB = encontrarHistorialClinica.HabitosPSB;
                dto.ExamenFisico = encontrarHistorialClinica.ExamenFisico;
                dto.Diagnostico = encontrarHistorialClinica.Diagnostico;
                dto.ExameneLaboratorio = encontrarHistorialClinica.ExameneLaboratorio;
                dto.Tratamiento = encontrarHistorialClinica.Tratamiento;
                dto.idHistorialClinico = encontrarHistorialClinica.Id;

            }
            return dto;
        }

        public FichaPacienteDto obtenerFichaYAltaHistorialPaciente(HistoriaAltaDto dto) 
        {
            HistorialesClinicos nuevaHistorialClinica = HistorialClinicoMapper.FromDtoToHistorialClinicoToHistorialClinico(dto);
            
            _historialesClinicos.Add(nuevaHistorialClinica);

            HistorialesClinicos recuperarHistorialClinica = _historialesClinicos.FindByPacienteId(dto.PacienteId);

            Pacientes pacienteEncontrado = _repopPacientes.FindById(dto.PacienteId);
            FichaPacienteDto retorno = PacienteMappers.FromPacienteFichaDto(pacienteEncontrado);
            retorno.MotivoDeConsulta = dto.MotivoDeConsulta;
            retorno.EnfermedadActual = dto.EnfermedadActual;
            retorno.Antecedentes = dto.Antecedentes;
            retorno.HabitosPSB = dto.HabitosPSB;
            retorno.ExamenFisico = dto.ExamenFisico;
            retorno.Diagnostico = dto.Diagnostico;
            retorno.ExameneLaboratorio = dto.ExameneLaboratorio;
            retorno.Tratamiento = dto.Tratamiento;
            retorno.idHistorialClinico = recuperarHistorialClinica.Id;
            return retorno;
        }
        


    }
}
