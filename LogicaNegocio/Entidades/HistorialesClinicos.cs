using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Entidades
{
    public class HistorialesClinicos
    {
        private int v;

        public int Id { get; set; }
        public int PacienteId { get; set; }
        public Pacientes Paciente { get; set; }
        public string MotivoDeConsulta { get; set; }
        public string EnfermedadActual { get; set; }
        public string Antecedentes { get; set; }
        public string HabitosPSB { get; set; }
        public string ExamenFisico { get; set; }
        public string Diagnostico { get; set; }
        public string ExameneLaboratorio { get; set; }
        public string Tratamiento { get; set; }


        public HistorialesClinicos()
        {

        }

        public HistorialesClinicos(Pacientes paciente, string motivoDeConsulta, string enfermedadActual, string antecedentes, string habitosPSB, string examenFisico, string diagnostico, string exameneLaboratorio, string tratamiento)
        {
            Paciente = paciente;
            MotivoDeConsulta = motivoDeConsulta;
            EnfermedadActual = enfermedadActual;
            Antecedentes = antecedentes;
            HabitosPSB = habitosPSB;
            ExamenFisico = examenFisico;
            Diagnostico = diagnostico;
            ExameneLaboratorio = exameneLaboratorio;
            Tratamiento = tratamiento;
        }

        public HistorialesClinicos(int idpaciente,string motivoDeConsulta, string enfermedadActual, string antecedentes, string habitosPSB, string examenFisico, string diagnostico, string exameneLaboratorio, string tratamiento)
        {
            PacienteId = idpaciente;
            MotivoDeConsulta = motivoDeConsulta;
            EnfermedadActual = enfermedadActual;
            Antecedentes = antecedentes;
            HabitosPSB = habitosPSB;
            ExamenFisico = examenFisico;
            Diagnostico = diagnostico;
            ExameneLaboratorio = exameneLaboratorio;
            Tratamiento = tratamiento;
        }

      
    }
}
