using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Entidades
{
    public class Evolucion
    {

    public int IdPaciente { get; set; }
    public DateTime fecha { get; set; }
     public string DescripcionEvolucion { get; set; }

        public Evolucion(int idPaciente, DateTime fecha, string descripcionEvolucion)
        {
            IdPaciente = idPaciente;
            this.fecha = fecha;
            DescripcionEvolucion = descripcionEvolucion;
        }
    }
}
