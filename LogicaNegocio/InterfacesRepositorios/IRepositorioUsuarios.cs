﻿using LogicaNegocio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.InterfacesRepositorios
{
    public interface IRepositorioUsuarios:IRepositorioIRepositorio<Usuarios>
    {
        Usuarios FindByGmail(string email);
    }
}
