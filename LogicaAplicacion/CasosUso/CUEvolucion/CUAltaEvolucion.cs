using DTOs.Evolucion;
using DTOs.Mappers;
using LogicaAplicacion.InterfaceCasosUso.ICUPaciente;
using LogicaNegocio.Entidades;
using LogicaNegocio.InterfacesRepositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAplicacion.CasosUso.CUEvolucion
{
    public class CUAltaEvolucion: IAltaEvolucion
    {



        private readonly IRepositorioEvoluciones _repoEvolucion;
        private readonly IRepositorioHistorialesClinicos _repoHistoriaClinica;



        public CUAltaEvolucion(IRepositorioEvoluciones repoEvo, IRepositorioHistorialesClinicos repoHistoriaClinica)
        {
            _repoEvolucion = repoEvo;
            _repoHistoriaClinica = repoHistoriaClinica; 
           

        }

      

        public void Ejecutar(EvolucionAltaDto EvolucionDTO, int id)
        {
          

            try
            {
                
             HistorialesClinicos evoIdHistoria = _repoHistoriaClinica.FindById(id);
               
                

                
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
