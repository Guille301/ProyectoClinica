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
        public EvolucionPacienteDto ListarEvoluciones(int id)
        {

            
            try
            {
                EvolucionPacienteDto retorno = new EvolucionPacienteDto();  
                List<EvolucionListaDto> dtoListarEvoluciones = EvolucionMappers.FromListEvolucionToListEvolucionDto(_repoEvolucion.ListarEvolucionesConFiltro(id));
                retorno.IdPaciente = id;
                retorno.listaEvoluciones = dtoListarEvoluciones;
                return retorno;
            }
            catch (Exception ex)
            {

                throw new Exception($"Ocurrió un error al intentar hacer la evolucion: {ex.Message}", ex);
            }

   
        }
    }
}
