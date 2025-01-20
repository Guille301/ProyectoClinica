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
                listaPacienteDto.id = P.Id;

                ret.Add(listaPacienteDto);
            }
            return ret;
        }

        public static PacienteDto FromPacienteToDtoPaciente(Pacientes dto)
        {
            PacienteDto paciente = new PacienteDto();
            paciente.NombreCompleto = dto.NombreCompleto;
            paciente.NumeroDocumento = dto.NumeroDocumento;
            paciente.Edad = dto.FechaNacimiento;
            paciente.id = dto.Id;
            return paciente;

        }





        public static PacienteDetalleDto FromPacienteDetalleToDtoPacienteDetalle(Pacientes dto)
        {
            PacienteDetalleDto paciente = new PacienteDetalleDto();
            paciente.Nombre = dto.NombreCompleto;
            paciente.Ci = dto.NumeroDocumento;
            paciente.fecha = dto.FechaNacimiento;
            paciente.Patologia = dto.Patologia;
            paciente.Telefono = dto.Telefono;
            paciente.Direccion = dto.Direccion;
            return paciente;

        }




        public static FichaPacienteDto FromPacienteFichaDto(Pacientes dto)
        {
            FichaPacienteDto paciente = new FichaPacienteDto();
            paciente.NombreCompleto = dto.NombreCompleto;
            paciente.NumeroDocumento = dto.NumeroDocumento;
            paciente.Telefono = dto.Telefono;
            paciente.Direccion = dto.Direccion;
            return paciente;

        }



        public static List<PacienteFiltroDto> FromDtoFiltrarPacientes(List<Pacientes> pacientes)
        {
            List<PacienteFiltroDto> ret = new List<PacienteFiltroDto>();


            

            foreach (Pacientes P in pacientes)
            {
                PacienteFiltroDto listaFiltroDto = new PacienteFiltroDto();
                listaFiltroDto.NombreCompleto = P.NombreCompleto;
                listaFiltroDto.NumeroDocumento = P.NumeroDocumento;
                listaFiltroDto.Edad = P.FechaNacimiento;
                ret.Add(listaFiltroDto);
            }
            return ret;
        }





    }
}
