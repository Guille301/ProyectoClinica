using DTOs.HistorialClinico;
using DTOs.Paciente;
using LogicaNegocio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
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










        public static HistorialesClinicos FromEditarHistoria(EditarHistoriaDTO edit, int idPaciente)
        {
            return new HistorialesClinicos(

            edit.id = idPaciente,
            edit.MotivoDeConsulta,
            edit.EnfermedadActual,
            edit.Antecedentes,
            edit.HabitosPSB,
            edit.ExamenFisico,
            edit.Diagnostico,
            edit.ExameneLaboratorio,
            edit.Tratamiento

                ) ;
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










    }
}
