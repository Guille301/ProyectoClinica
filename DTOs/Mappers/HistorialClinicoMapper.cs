using DTOs.HistorialClinico;
using DTOs.Paciente;
using LogicaNegocio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace DTOs.Mappers
{
    public class HistorialClinicoMapper
    {
        //public static HistorialesClinicos DtoHistorialClinicoToHisorialClinico(DtoAltaHistorialClinico dto) 
        //{
        //    HistorialesClinicos retorno = new HistorialesClinicos();
        //    retorno.MotivoDeConsulta = dto.RazonDeConsulta;
        //    retorno.EnfermedadActual = dto.Enfem

        //    return retorno; 
        //}





        public static List<ListarHistoriaClinicaDto> FromListarHistorialDto(List<HistorialesClinicos> historia)
        {
            List<ListarHistoriaClinicaDto> ret = new List<ListarHistoriaClinicaDto>();

            foreach (HistorialesClinicos h in historia) 
            { 
               ListarHistoriaClinicaDto histo = new ListarHistoriaClinicaDto();
                histo.MotivoDeConsulta = h.MotivoDeConsulta;
                histo.EnfermedadActual = h.EnfermedadActual;
                histo.Antecedentes = h.Antecedentes;
                histo.HabitosPSB = h.HabitosPSB;
                histo.ExamenFisico = h.ExamenFisico;
                histo.Diagnostico = h.Diagnostico;
                histo.ExameneLaboratorio = h.ExameneLaboratorio;
                histo.Tratamiento = h.Tratamiento;
                ret.Add(histo);
            }

            


            return ret;

        }










        public static HistorialesClinicos FromEditarHistoria(EditarHistoriaDTO edit)
        {
            HistorialesClinicos retorno = new HistorialesClinicos();
        
            retorno.Id = edit.Id;
            retorno.MotivoDeConsulta = edit.MotivoDeConsulta;
            retorno.Antecedentes = edit.Antecedentes;
            retorno.HabitosPSB = edit.HabitosPSB;
            retorno.ExamenFisico = edit.ExamenFisico;
            retorno.Diagnostico = edit.Diagnostico;
            retorno.ExameneLaboratorio = edit.ExameneLaboratorio;
            retorno.Tratamiento = edit.Tratamiento;

            return retorno;
        }

        




        public static HistorialesClinicos FromDtoToHistorialClinico(HistoriaAltaDto dto, int idPaciente)
        {
            return new HistorialesClinicos
            {
                PacienteId = idPaciente, 
                MotivoDeConsulta = dto.MotivoDeConsulta,
                EnfermedadActual = dto.EnfermedadActual,
                Antecedentes = dto.Antecedentes,
                HabitosPSB = dto.HabitosPSB,
                ExamenFisico = dto.ExamenFisico,
                Diagnostico = dto.Diagnostico,
                ExameneLaboratorio = dto.ExameneLaboratorio,
                Tratamiento = dto.Tratamiento
            };
        }



        public static HistorialesClinicos FromDtoToHistorialClinicoToHistorialClinico(HistoriaAltaDto dto)
        {
            HistorialesClinicos retorno = new HistorialesClinicos();
            retorno.PacienteId = dto.PacienteId;
            retorno.MotivoDeConsulta = dto.MotivoDeConsulta;
              retorno.EnfermedadActual = dto.EnfermedadActual;
                retorno.Antecedentes = dto.Antecedentes;
                retorno.HabitosPSB = dto.HabitosPSB;
                retorno.ExamenFisico = dto.ExamenFisico;
                retorno.Diagnostico = dto.Diagnostico;
                retorno.ExameneLaboratorio = dto.ExameneLaboratorio;
                retorno.Tratamiento = dto.Tratamiento;
           return retorno;
        }


        public static EditarHistoriaDTO FromHistorialClinicoToEditarHistoriaDto(HistorialesClinicos historia) 
        {
            EditarHistoriaDTO retorno = new EditarHistoriaDTO();
            retorno.Id = historia.Id;
            retorno.IdPaciente = historia.PacienteId;
            retorno.MotivoDeConsulta = historia.MotivoDeConsulta;
            retorno.EnfermedadActual = historia.EnfermedadActual;
            retorno.Antecedentes = historia.Antecedentes;
            retorno.HabitosPSB = historia.HabitosPSB;
            retorno.ExamenFisico = historia.ExamenFisico;
            retorno.Diagnostico = historia.Diagnostico;
            retorno.ExameneLaboratorio = historia.ExameneLaboratorio;
            retorno.Tratamiento = historia.Tratamiento;
            return retorno;
        }





    }
}
