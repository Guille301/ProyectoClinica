using DTOs.Mappers;
using DTOs.Paciente;
using LogicaAplicacion.InterfaceCasosUso.ICUPaciente;
using LogicaNegocio.Exepciones.Paciente;
using LogicaNegocio.InterfacesRepositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAplicacion.CasosUso.CUPaciente
{
    public class AltaPaciente : IAltaPaciente
    {

        private readonly IRepositorioPacientes _repoPaciente;


        public AltaPaciente(IRepositorioPacientes repoDisciplina)
        {
            _repoPaciente = repoDisciplina;

        }

        public void Ejecutar(PacienteAltaDto PacienteDTO, string usuarioEmail)
        {
            try
            {
                LogicaNegocio.Entidades.Pacientes pacExiste = _repoPaciente.FindByCI(PacienteDTO.NumeroDocumento);

                if (pacExiste == null)
                {
                    LogicaNegocio.Entidades.Pacientes pa = PacienteMappers.FromUsuarioPacienteAltaDto(PacienteDTO);
                    pa.UsuarioEmail = usuarioEmail;
                    _repoPaciente.Add(pa);
                }
                else
                {
                    throw new CIRepetidoException("Ese número de documento ya existe");
                }
            }
            catch (Exception ex)
            {
               
                throw new Exception($"Ocurrió un error al intentar registrar el paciente: {ex.Message}", ex);
            }
        }





    }
}
