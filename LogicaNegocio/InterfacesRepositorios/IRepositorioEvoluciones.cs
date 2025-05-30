﻿using LogicaNegocio.Entidades;
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
        void RemoveAllByHistoria(int idHistoria);
        List<Evolucion> ListarEvolucionesByHistoriaId(int idHistoria);
    }
}
