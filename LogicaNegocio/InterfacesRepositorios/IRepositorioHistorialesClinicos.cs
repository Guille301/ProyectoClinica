﻿using LogicaNegocio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.InterfacesRepositorios
{
    public interface IRepositorioHistorialesClinicos:IRepositorioIRepositorio<HistorialesClinicos>
    {
        List<HistorialesClinicos> ListarHistoriaClinica(int id);

        HistorialesClinicos FindByPacienteId(int id);
    }
}
