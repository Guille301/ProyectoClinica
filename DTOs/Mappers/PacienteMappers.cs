using DTOs.Paciente;
using LogicaNegocio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs.Mappers
{
    public class PacienteMappers
    {


        public static LogicaNegocio.Entidades.Pacientes FromUsuarioPacienteAltaDto(PacienteAltaDto PA)
        {
            return new LogicaNegocio.Entidades.Pacientes(PA.NombreCompleto, PA.NumeroDocumento,PA.FechaNacimiento,PA.Telefono,PA.Direccion,PA.Patologia);

        }

        public static List<PacienteListaDto> FromListPacienteToListPacienteDto(List<Pacientes> paciente)
        {
            List<PacienteListaDto> ret = new List<PacienteListaDto>();

            foreach (Pacientes P in paciente)
            {
                PacienteListaDto listaPacienteDto = new PacienteListaDto();
                listaPacienteDto.NombreCompleto = P.NombreCompleto;
                listaPacienteDto.NumeroDocumento = P.NumeroDocumento;
                listaPacienteDto.Edad = P.FechaNacimiento;
                ret.Add(listaPacienteDto);
            }
            return ret;
        }





    }
}
