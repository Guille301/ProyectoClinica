using LogicaAplicacion.InterfaceCasosUso.ICUPaciente;
using LogicaNegocio.Entidades;
using LogicaNegocio.InterfacesRepositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAplicacion.CasosUso.CUPaciente
{
    public class EliminarPaciente : ICUEliminarPaciente
    {
        IRepositorioPacientes _repoPacientes;
        IRepositorioHistorialesClinicos _historialesClinicos;
        IRepositorioEvoluciones _evoluciones;

        public EliminarPaciente(IRepositorioPacientes repositorioPacientes, IRepositorioHistorialesClinicos repositorioHistorialesClinicos, IRepositorioEvoluciones repositorioEvoluciones)
        {
            _repoPacientes = repositorioPacientes;
            _historialesClinicos = repositorioHistorialesClinicos;
            _evoluciones = repositorioEvoluciones;
        }

        public void Eliminar(int id)
        {
            Pacientes pacienteEncontrado = _repoPacientes.FindById(id);
            HistorialesClinicos historialEncontrado = _historialesClinicos.FindByPacienteId(id);

            if (historialEncontrado != null) //Si tiene historial clinico lo borramos
            {
                _evoluciones.RemoveAllByHistoria(historialEncontrado.Id);
                _historialesClinicos.Remove(historialEncontrado.Id);
            }

            _repoPacientes.Remove(id);
        }

    }
}
