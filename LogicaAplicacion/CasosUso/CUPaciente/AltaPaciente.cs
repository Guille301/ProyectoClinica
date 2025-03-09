using DTOs.Mappers;
using DTOs.Paciente;
using LogicaAplicacion.InterfaceCasosUso.ICUPaciente;
<<<<<<< HEAD
=======
using LogicaNegocio.Exepciones.Paciente;
>>>>>>> bf58e0f (se mejoro la interfaz del dashboard)
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

        public void Ejecutar(PacienteAltaDto PacienteDTO)
        {
            try
            {
                LogicaNegocio.Entidades.Pacientes pacExiste = _repoPaciente.FindByCI(PacienteDTO.NumeroDocumento);

                if (pacExiste == null)
                {
                    LogicaNegocio.Entidades.Pacientes pa = PacienteMappers.FromUsuarioPacienteAltaDto(PacienteDTO);
                    _repoPaciente.Add(pa);
                }
                else
                {
<<<<<<< HEAD
                    throw new Exception("Ese número de documento ya existe");
=======
                    throw new CIRepetidoException("Ese número de documento ya existe");
>>>>>>> bf58e0f (se mejoro la interfaz del dashboard)
                }
            }
            catch (Exception ex)
            {
               
                throw new Exception($"Ocurrió un error al intentar registrar el paciente: {ex.Message}", ex);
            }
        }





    }
}
