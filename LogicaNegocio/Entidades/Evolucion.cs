using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LogicaNegocio.Entidades
{
    public class Evolucion
    {
        public int Id { get; set; } 

        public int IdHistoria { get; set; }
        public DateTime fecha { get; set; }
        public string DescripcionEvolucion { get; set; }

        [JsonIgnore]
        public HistorialesClinicos HistorialClinico { get; set; }

        public Evolucion()
        {
            
        }




        public Evolucion(int idHistoria, DateTime fecha, string descripcionEvolucion)
        {
            IdHistoria = idHistoria;
            this.fecha = fecha;
            DescripcionEvolucion = descripcionEvolucion;
        }

        public Evolucion(int idHistoria, DateTime fecha, string descripcionEvolucion, HistorialesClinicos historialClinico) : this(idHistoria, fecha, descripcionEvolucion)
        {
            HistorialClinico = historialClinico;
        }
    }
}
