using DTOs.Paciente;
using DTOs.Paciente.DTOs.Evolucion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAplicacion.InterfaceCasosUso.ICUPaciente
{
    public interface IAltaEvolucion
    {


        public void Ejecutar(EvolucionAltaDto EvolucionDTO);



    }
}
