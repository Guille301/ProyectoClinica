using DTOs.Evolucion;
using DTOs.Paciente;

using LogicaNegocio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTOs;

namespace DTOs.Mappers
{
    public class EvolucionMappers
    {


        public static LogicaNegocio.Entidades.Evolucion FromEvolucioAltaDto(EvolucionAltaDto PA, HistorialesClinicos ha)
        {
            return new LogicaNegocio.Entidades.Evolucion(PA.IdHistoria,PA.fecha,PA.DescripcionEvolucion,ha);

        }

        public static List<EvolucionListaDto> FromListEvolucionToListEvolucionDto(List<LogicaNegocio.Entidades.Evolucion> evolucion)
        {
            List<EvolucionListaDto> ret = new List<EvolucionListaDto>();

            foreach (LogicaNegocio.Entidades.Evolucion e in evolucion)
            {
                EvolucionListaDto listaEvoDto = new EvolucionListaDto();
                
                listaEvoDto.IdHistoria = e.IdHistoria;
                listaEvoDto.fecha = e.fecha;
                listaEvoDto.DescripcionEvolucion = e.DescripcionEvolucion;

                
                ret.Add(listaEvoDto);
            }
            return ret;
        }







    }
}
