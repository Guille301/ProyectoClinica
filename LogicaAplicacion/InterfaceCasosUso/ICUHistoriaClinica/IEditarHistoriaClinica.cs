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


        void Ejecutar(EditarHistoriaDTO editDis , int id);


    }
}
