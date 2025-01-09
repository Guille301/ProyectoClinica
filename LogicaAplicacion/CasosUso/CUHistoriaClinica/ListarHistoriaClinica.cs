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

        public ListarHistoriaClinica(IRepositorioHistorialesClinicos repo)
        {
            _repoHistoria = repo;
        }

        public ListarHistoriaClinicaDto FromListarHistorialDto(int id)
        {
            throw new NotImplementedException();
        }

        //public DTOs.HistorialClinico.ListarHistoriaClinicaDto FromListarHistorialDto(int id)
        //{
        //    HistorialesClinicos HistorialEncontrado = _repoHistoria.FindById(id);

        //    ListarHistoriaClinica dto = HistorialClinicoMapper.FromListarHistorialDto(HistorialEncontrado);
        //    return dto;
        //}




    }
}
