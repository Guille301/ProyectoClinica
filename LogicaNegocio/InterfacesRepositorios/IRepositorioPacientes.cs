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

        public Pacientes FindByCI(string numeroDoc);

        public Pacientes FindByName(string nombre);

        public Pacientes FindDetalle(int id);



    }
}
