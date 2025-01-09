using DTOs.HistorialClinico;
using DTOs.Mappers;
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
    public class EditarHistoriaClinicaCU : IEditarHistoriaClinica
    {


        private readonly IRepositorioHistorialesClinicos _repoHistoriales;
        

        public EditarHistoriaClinicaCU(IRepositorioHistorialesClinicos repoHistoriales)
        {
            _repoHistoriales = repoHistoriales;
        }




        public void Ejecutar(EditarHistoriaDTO editDis, int id)
        {
            try
            {

                HistorialesClinicos His = HistorialClinicoMapper.FromEditarHistoria(editDis,id);
                _repoHistoriales.Update(His);

            }
           
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }






    }
}
