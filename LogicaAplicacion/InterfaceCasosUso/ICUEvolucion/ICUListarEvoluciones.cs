using DTOs.Evolucion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAplicacion.InterfaceCasosUso.ICUEvolucion
{
    public interface ICUListarEvoluciones
    {
        public List<EvolucionListaDto> ListarEvoluciones();
    }
}
