using DTOs.Evolucion;
using DTOs.Mappers;
using DTOs.Paciente;
using LogicaAplicacion.InterfaceCasosUso.ICUEvolucion;
using LogicaNegocio.InterfacesRepositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAplicacion.CasosUso.CUEvolucion
{
    public class CUListarEvolucion : ICUListarEvoluciones
    {

        private readonly IRepositorioEvoluciones _repoEvolucion;



        public CUListarEvolucion(IRepositorioEvoluciones repoEvo)
        {
            _repoEvolucion = repoEvo;


        }
        public List<EvolucionListaDto> ListarEvoluciones()
        {
            List<EvolucionListaDto> dtoListarEvoluciones = EvolucionMappers.FromListEvolucionToListEvolucionDto(_repoEvolucion.FindAll());
            return dtoListarEvoluciones;
        }
    }
}
