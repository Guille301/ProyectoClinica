using DTOs.HistorialClinico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAplicacion.InterfaceCasosUso.ICUHistoriaClinica
{
    public interface IEditarHistoriaClinica
    {

        EditarHistoriaDTO MostrarAntiguosValores(int id);
        void Ejecutar(EditarHistoriaDTO editDis);


    }
}
