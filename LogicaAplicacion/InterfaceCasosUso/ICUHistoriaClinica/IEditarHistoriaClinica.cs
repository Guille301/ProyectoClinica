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

<<<<<<< HEAD

        void Ejecutar(EditarHistoriaDTO editDis , int id);
=======
        EditarHistoriaDTO MostrarAntiguosValores(int id);
        void Ejecutar(EditarHistoriaDTO editDis);
>>>>>>> bf58e0f (se mejoro la interfaz del dashboard)


    }
}
