using DTOs.Evolucion;
using DTOs.Mappers;
using LogicaAplicacion.InterfaceCasosUso.ICUPaciente;
using LogicaNegocio.InterfacesRepositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAplicacion.CasosUso.CUEvolucion
{
    public class CUAltaEvolucion: IAltaEvolucion
    {



        private readonly IRepositorioEvoluciones _repoEvolucion;


        public CUAltaEvolucion(IRepositorioEvoluciones repoEvo)
        {
            _repoEvolucion = repoEvo;

        }

        public void Ejecutar(EvolucionAltaDto EvolucionDTO)
        {
            try
            {
                
                    LogicaNegocio.Entidades.Evolucion ev = EvolucionMappers.FromEvolucioAltaDto(EvolucionDTO);
                    _repoEvolucion.Add(ev);
                
            }
            catch (Exception ex)
            {

                throw new Exception($"Ocurrió un error al intentar hacer la evolucion: {ex.Message}", ex);
            }
        }
















    }
}
