using LogicaNegocio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.InterfacesRepositorios
{
    public interface IRepositorioEvoluciones:IRepositorioIRepositorio<Evolucion>
    {
        List<Evolucion> ListarEvolucionesConFiltro(int? id);
<<<<<<< HEAD
=======
        void RemoveAllByHistoria(int idHistoria);
>>>>>>> bf58e0f (se mejoro la interfaz del dashboard)
    }
}
