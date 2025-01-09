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
        public static HistorialesClinicos DtoHistorialClinicoToHisorialClinico(DtoAltaHistorialClinico dto) 
        {
            HistorialesClinicos retorno = new HistorialesClinicos();

            retorno.HabitosPSB = dto.HabitosPSB;
            retorno.RazonDeConsulta = dto.RazonDeConsulta;
            retorno.Antecedentes = dto.Antecedentes;
            retorno.Diagnostico = dto.Diagnostico;
            retorno.ExamenFisico = dto.ExamenFisico;
            retorno.ImagenLaboratorio = dto.ImagenLaboratorio;
            retorno.Tratamiento = dto.Tratamiento;

            return retorno; 
        }





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
      








        public static HistorialesClinicos FromDtoAltaEventoToEvento(DtoAltaHistorialClinico dto)
        {
            HistorialesClinicos historia = new HistorialesClinicos();
            historia.HabitosPSB = dto.HabitosPSB;
            historia.RazonDeConsulta = dto.RazonDeConsulta;
            historia.Antecedentes = dto.Antecedentes;
            historia.Diagnostico = dto.Diagnostico;
            historia.ExamenFisico = dto.ExamenFisico;
            historia.ImagenLaboratorio = dto.ImagenLaboratorio;
            historia.Tratamiento = dto.Tratamiento;
           
            return historia;
        }





    }
}
