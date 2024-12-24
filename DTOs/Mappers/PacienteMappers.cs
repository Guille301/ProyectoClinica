using DTOs.Paciente;
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

       



    }
}
