using DTOs.HistorialClinico;
using DTOs.Mappers;
using LogicaAplicacion.InterfaceCasosUso.ICUHistoriaClinica;
using LogicaAplicacion.InterfaceCasosUso.ICUPaciente;
using LogicaNegocio.Entidades;
using LogicaNegocio.InterfacesRepositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAplicacion.CasosUso.CUHistoriaClinica
{
    public class AltaHistoriaClinica : IAgregrarHistoriaClinica
    {

        private readonly IRepositorioHistorialesClinicos _repoHistoriales;
        private readonly IRepositorioPacientes _repoPacientes;

        public AltaHistoriaClinica(IRepositorioHistorialesClinicos repoHistoriales, IRepositorioPacientes repoPacientes)
        {
            _repoHistoriales = repoHistoriales;
            _repoPacientes = repoPacientes;
        }

        public void Ejecutar(HistoriaAltaDto historiaDto, int idPaciente)
        {
            try
            {
                // Mapear el DTO a la entidad HistorialClinico
                HistorialesClinicos historial = HistorialClinicoMapper.FromDtoToHistorialClinico(historiaDto, idPaciente);

                // Agregar el historial clínico al repositorio
                _repoHistoriales.Add(historial);
            }
            catch (Exception ex)
            {
                throw new Exception($"Ocurrió un error al registrar el historial clínico: {ex.Message}", ex);
            }
        }




    }
}
