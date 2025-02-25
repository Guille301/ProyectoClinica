using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs.Paciente
{
    public class FichaPacienteDto
    {

        //FICHA
        public int idPaciente { get; set; }
        public string NombreCompleto { get; set; }
        public string NumeroDocumento { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        //HISTORIALCLINICO 

        public int idHistorialClinico { get; set; }
        public string MotivoDeConsulta { get; set; }
        public string EnfermedadActual { get; set; }
        public string Antecedentes { get; set; }
        public string HabitosPSB { get; set; }
        public string ExamenFisico { get; set; }
        public string Diagnostico { get; set; }
        public string ExameneLaboratorio { get; set; }
        public string Tratamiento { get; set; }

    }
}
