using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Entidades
{
    public class Pacientes
    {
        //Hola Mundo
        public int Id { get; set; }
        public string NombreCompleto { get; set; }
        public string NumeroDocumento { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int Anios {  get; set; }
        public string Telefono { get; set; }
        public string Direccion {  get; set; }
        public string Patologia { get; set; }
        public Pacientes()
        {
            
        }

        public Pacientes(string nombreCompleto, string numeroDocumento, string telefono,
         DateTime fechaNacimiento, int anios, string direccion, string patologia)
        {
            NombreCompleto = nombreCompleto;
            NumeroDocumento = numeroDocumento;
            Anios = anios;
            Telefono = telefono;
            Direccion = direccion;
            Patologia = patologia;
        }
    }
}
