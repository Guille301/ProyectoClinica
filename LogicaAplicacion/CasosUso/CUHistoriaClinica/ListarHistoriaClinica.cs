using DTOs.HistorialClinico;
using DTOs.Mappers;
using DTOs.Paciente;
using LogicaAplicacion.InterfaceCasosUso.ICUHistoriaClinica;
using LogicaNegocio.Entidades;
using LogicaNegocio.InterfacesRepositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAplicacion.CasosUso.CUHistoriaClinica
{
    public class ListarHistoriaClinica : IListarHistoriaClinica
    {


        private IRepositorioHistorialesClinicos _repoHistoria;
        private IRepositorioPacientes _repoPacientes;

        public ListarHistoriaClinica(IRepositorioHistorialesClinicos repo, IRepositorioPacientes repoP)
        {
            _repoHistoria = repo;
            _repoPacientes = repoP;
        }

        public List<ListarHistoriaClinicaDto> ListarHistoria(int id)
        {
            List<ListarHistoriaClinicaDto> dtoListarHistorias = null;

            try
            {

                Pacientes idPaciente = _repoPacientes.FindById(id);
                HistorialesClinicos idPacienteHistoria = _repoHistoria.FindByPacienteId(idPaciente.Id);
                if (idPaciente != null && idPacienteHistoria != null) 
                {
                    

                         dtoListarHistorias = HistorialClinicoMapper.FromListarHistorialDto(_repoHistoria.ListarHistoriaClinica(id));
                        

                    
               
                }
                  return dtoListarHistorias;


            }
            catch (Exception ex) 
            {
                throw new Exception($"Ocurrió un error al Listar la historia: {ex.Message}", ex);
            }

            
        }

        //public DTOs.HistorialClinico.ListarHistoriaClinicaDto FromListarHistorialDto(int id)
        //{
        //    HistorialesClinicos HistorialEncontrado = _repoHistoria.FindById(id);

        //    ListarHistoriaClinica dto = HistorialClinicoMapper.FromListarHistorialDto(HistorialEncontrado);
        //    return dto;
        //}




    }
}
