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





        //public static ListarHistoriaClinicaDto FromListarHistorialDto(HistorialesClinicos dto)
        //{
        //    ListarHistoriaClinicaDto histo = new ListarHistoriaClinicaDto();
        //    histo.RazonDeConsulta = dto.RazonDeConsulta;
        //    histo.Antecedentes = dto.Antecedentes;
        //    histo.HabitosPSB = dto.HabitosPSB;
        //    histo.ExamenFisico = dto.ExamenFisico;
        //    histo.Diagnostico = dto.Diagnostico;
        //    histo.ImagenLaboratorio = dto.ImagenLaboratorio;
        //    histo.Tratamiento = dto.Tratamiento;


        //    return histo;

        //}


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
