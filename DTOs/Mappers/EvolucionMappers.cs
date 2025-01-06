using DTOs.Evolucion;
using DTOs.Paciente;

using LogicaNegocio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs.Mappers
{
    public class EvolucionMappers
    {


        public static LogicaNegocio.Entidades.Evolucion FromEvolucioAltaDto(EvolucionAltaDto PA)
        {
            return new LogicaNegocio.Entidades.Evolucion(PA.IdHistoria,PA.fecha,PA.DescripcionEvolucion);

        }

        





    }
}
