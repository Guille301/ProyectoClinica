﻿using DTOs.HistorialClinico;
using DTOs.Paciente;
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
        FichaPacienteDto obtenerFichaYAltaHistorialPaciente(HistoriaAltaDto dto);

    }
}
