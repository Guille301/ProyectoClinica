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

                LogicaNegocio.Entidades.Pacientes pa = PacienteMappers.FromUsuarioPacienteAltaDto(PacienteDTO);
                _repoPaciente.Add(pa);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }




    }
}
