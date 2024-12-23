using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Entidades
{
    public class HistorialesClinicos
    {
        public int Id { get; set; }
        public Pacientes Paciente { get; set; }
        public string RazonDeConsulta { get; set; }
        public string Antecedentes { get; set; }
        public string HabitosPSB { get; set; }
        public string ExamenFisico { get; set; }
        public string Diagnostico {  get; set; }
        public string ImagenLaboratorio { get; set; }
        public string Tratamiento { get; set; }
        public List<Evolucion> evolucion { get; set; }

        public HistorialesClinicos()
        {
            
        }

        public HistorialesClinicos(Pacientes paciente, string razonDeConsulta, string antecedentes,
         string habitosPSB, string examenFisico, string diagnostico, string imagenLaboratorio, 
         string tratamiento, Evolucion evolucion)
        {
            Paciente = paciente;
            RazonDeConsulta = razonDeConsulta;
            Antecedentes = antecedentes;
            HabitosPSB = habitosPSB;
            ExamenFisico = examenFisico;
            Diagnostico = diagnostico;
            ImagenLaboratorio = imagenLaboratorio;
            Tratamiento = tratamiento;
            Evolucion = evolucion;
        }







    }
}
