using DTOs.HistorialClinico;
using DTOs.Mappers;
using LogicaAplicacion.InterfaceCasosUso.ICUHistoriaClinica;
using LogicaNegocio.Entidades;
using LogicaNegocio.InterfacesRepositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
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




        public void Ejecutar(EditarHistoriaDTO editDis)
        {
            try
            {

                HistorialesClinicos His = _repoHistoriales.FindById(editDis.HistorialId);
                His.MotivoDeConsulta = editDis.MotivoDeConsulta;
                His.Antecedentes = editDis.Antecedentes;
                His.HabitosPSB = editDis.HabitosPSB;
                His.ExamenFisico = editDis.ExamenFisico;
                His.Diagnostico = editDis.Diagnostico;
                His.ExameneLaboratorio = editDis.ExameneLaboratorio;
                His.Tratamiento = editDis.Tratamiento;
                //Mapealo de la manera tradicional

                _repoHistoriales.Update(His);
          
            }
           
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public EditarHistoriaDTO MostrarAntiguosValores(int id)
        {
           HistorialesClinicos encontrarHistorial = _repoHistoriales.FindByPacienteId(id);
            EditarHistoriaDTO retorno = HistorialClinicoMapper.FromHistorialClinicoToEditarHistoriaDto(encontrarHistorial);

            return retorno;
        }
    }
}
