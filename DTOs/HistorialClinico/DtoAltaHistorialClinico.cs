using DTOs.Paciente;
using LogicaNegocio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs.HistorialClinico
{
    public class DtoAltaHistorialClinico
    {
        public int IdPaciente { get; set; }
        public PacienteDto Paciente { get; set; }
        public string RazonDeConsulta { get; set; }
        public string Antecedentes { get; set; }
        public string HabitosPSB { get; set; }
        public string ExamenFisico { get; set; }
        public string Diagnostico { get; set; }
        public string ImagenLaboratorio { get; set; }
        public string Tratamiento { get; set; }

    }
}
