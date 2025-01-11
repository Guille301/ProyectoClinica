using DTOs.Evolucion;
using DTOs.Mappers;
using DTOs.Paciente;
using LogicaAplicacion.InterfaceCasosUso.ICUEvolucion;
using LogicaNegocio.Entidades;
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
        public List<EvolucionListaDto> ListarEvoluciones(int id)
        {

            
            try
            {
               
                List<EvolucionListaDto> dtoListarEvoluciones = EvolucionMappers.FromListEvolucionToListEvolucionDto(_repoEvolucion.ListarEvolucionesConFiltro(id));
                return dtoListarEvoluciones;
            }
            catch (Exception ex)
            {

                throw new Exception($"Ocurrió un error al intentar hacer la evolucion: {ex.Message}", ex);
            }

   
        }
    }
}
