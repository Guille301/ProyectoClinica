using DTOs.HistorialClinico;
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


    }
}
