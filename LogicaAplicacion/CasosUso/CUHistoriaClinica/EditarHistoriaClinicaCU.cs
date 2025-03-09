using DTOs.HistorialClinico;
using DTOs.Mappers;
using LogicaAplicacion.InterfaceCasosUso.ICUHistoriaClinica;
using LogicaNegocio.Entidades;
using LogicaNegocio.InterfacesRepositorios;
using System;
using System.Collections.Generic;
using System.Linq;
<<<<<<< HEAD
=======
using System.Net.Http.Headers;
>>>>>>> bf58e0f (se mejoro la interfaz del dashboard)
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




<<<<<<< HEAD
        public void Ejecutar(EditarHistoriaDTO editDis, int id)
=======
        public void Ejecutar(EditarHistoriaDTO editDis)
>>>>>>> bf58e0f (se mejoro la interfaz del dashboard)
        {
            try
            {

<<<<<<< HEAD
                HistorialesClinicos His = HistorialClinicoMapper.FromEditarHistoria(editDis,id);
                _repoHistoriales.Update(His);

=======
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
          
>>>>>>> bf58e0f (se mejoro la interfaz del dashboard)
            }
           
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

<<<<<<< HEAD





=======
        public EditarHistoriaDTO MostrarAntiguosValores(int id)
        {
           HistorialesClinicos encontrarHistorial = _repoHistoriales.FindByPacienteId(id);
            EditarHistoriaDTO retorno = HistorialClinicoMapper.FromHistorialClinicoToEditarHistoriaDto(encontrarHistorial);

            return retorno;
        }
>>>>>>> bf58e0f (se mejoro la interfaz del dashboard)
    }
}
