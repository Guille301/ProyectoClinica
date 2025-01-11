using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs.HistorialClinico
{
    public class EditarHistoriaDTO
    {

        public int id { get; set; }
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
