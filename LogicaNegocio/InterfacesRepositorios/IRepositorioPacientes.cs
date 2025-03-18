using LogicaNegocio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.InterfacesRepositorios
{
    public interface IRepositorioPacientes:IRepositorioIRepositorio<Pacientes>
    {

        public void Add(Pacientes paciente);

        List<Pacientes> FiltroPacientes(string? ci , string? nombre,string emailUsuario);

        List<Pacientes> FindAllPacientesByUsuarioEmail(string usuarioEmail);
        public Pacientes FindByCI(string ci);
        
    }
}
