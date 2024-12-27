using DTOs.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAplicacion.InterfaceCasosUso.ICUUsuario
{
    public interface ICULogin
    {
        DtoUsuarioLogin Logearse(DtoLogin dto);
    }
}
