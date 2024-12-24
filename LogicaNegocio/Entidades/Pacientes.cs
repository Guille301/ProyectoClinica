using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Entidades
{
    public class Pacientes
    {  
        public int Id { get; set; }
        public string NombreCompleto { get; set; }
        public string NumeroDocumento { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Telefono { get; set; }
        public string Direccion {  get; set; }
        public string Patologia { get; set; }

        public HistorialesClinicos historialesClinicos { get; set; }
        
        public Pacientes()
        {
            
        }

        public Pacientes(string nombreCompleto, string numeroDocumento, DateTime fechaNacimiento, string telefono, string direccion, string patologia, HistorialesClinicos historialesClinicos)
        {
            NombreCompleto = nombreCompleto;
            NumeroDocumento = numeroDocumento;
            FechaNacimiento = fechaNacimiento;
            Telefono = telefono;
            Direccion = direccion;
            Patologia = patologia;
            this.historialesClinicos = historialesClinicos;
        }


        public Pacientes(string nombreCompleto, string numeroDocumento, DateTime fechaNacimiento, string telefono, string direccion, string patologia)
        {
            NombreCompleto = nombreCompleto;
            NumeroDocumento = numeroDocumento;
            FechaNacimiento = fechaNacimiento;
            Telefono = telefono;
            Direccion = direccion;
            Patologia = patologia;
        }

    }
}
