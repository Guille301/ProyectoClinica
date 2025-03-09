<<<<<<< HEAD
﻿using DTOs.Paciente;
=======
﻿using DTOs.HistorialClinico;
using DTOs.Paciente;
>>>>>>> bf58e0f (se mejoro la interfaz del dashboard)
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAplicacion.InterfaceCasosUso.ICUPaciente
{
    public interface IPacienteFicha
    {

        FichaPacienteDto obtenerFichaPaciente(int id);
<<<<<<< HEAD

=======
        FichaPacienteDto obtenerFichaYAltaHistorialPaciente(HistoriaAltaDto dto);
>>>>>>> bf58e0f (se mejoro la interfaz del dashboard)

    }
}
