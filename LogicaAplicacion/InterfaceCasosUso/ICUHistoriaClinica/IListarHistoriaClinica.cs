using DTOs.Paciente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTOs.HistorialClinico;


namespace LogicaAplicacion.InterfaceCasosUso.ICUHistoriaClinica
{
    public interface IListarHistoriaClinica
    {

        ListarHistoriaClinicaDto FromListarHistorialDto(int id);

        

    }
}
