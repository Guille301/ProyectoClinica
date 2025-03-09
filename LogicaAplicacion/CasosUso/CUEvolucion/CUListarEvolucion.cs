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
        private readonly IRepositorioHistorialesClinicos _repoHistorialesClinicos;



        public CUListarEvolucion(IRepositorioEvoluciones repoEvo, IRepositorioHistorialesClinicos repositorioHistorialesClinicos)
        {
            _repoEvolucion = repoEvo;
            _repoHistorialesClinicos = repositorioHistorialesClinicos;


        }
        public EvolucionPacienteDto ListarEvoluciones(int id)
        {

            
            try
            {
                EvolucionPacienteDto retorno = new EvolucionPacienteDto();
                HistorialesClinicos historialEncontrado = _repoHistorialesClinicos.FindByPacienteId(id);
              
                List<EvolucionListaDto> dtoListarEvoluciones = EvolucionMappers.FromListEvolucionToListEvolucionDto(_repoEvolucion.ListarEvolucionesConFiltro(historialEncontrado.Id));
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
