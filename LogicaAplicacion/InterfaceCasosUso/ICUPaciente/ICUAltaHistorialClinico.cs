using DTOs.HistorialClinico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAplicacion.InterfaceCasosUso.ICUPaciente
{
    public interface ICUAltaHistorialClinico
    {
        DtoAltaHistorialClinico FichaHistorialClinico(int id);
        void AltaHistorialCl(DtoAltaHistorialClinico dto);
    }
}
