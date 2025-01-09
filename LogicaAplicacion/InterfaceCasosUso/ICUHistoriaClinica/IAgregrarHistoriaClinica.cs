using DTOs.HistorialClinico;
using DTOs.Paciente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAplicacion.InterfaceCasosUso.ICUHistoriaClinica
{
    public interface IAgregrarHistoriaClinica
    {

        public void Ejecutar(HistoriaAltaDto PacienteDTO,int idPaciente);



    }
}
