using LogicaNegocio.Entidades;
using LogicaNegocio.InterfacesRepositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAccesoDatos.Repositorios
{
    public class RepositorioEvoluciones : IRepositorioEvoluciones
    {
        private ApplicationDbContext _db;
        public RepositorioEvoluciones(ApplicationDbContext db)
        {
            _db = db;
        }

        public void Add(Evolucion nuevo)
        {
            try
            {
                _db.Evoluciones.Add(nuevo);
                _db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar el paciente", ex);
            }
        }

        public List<Evolucion> FindAll()
        {
            var  retorno = _db.Evoluciones.ToList();
            return retorno;
        }

        public Evolucion FindById(int id)
        {
            return _db.Evoluciones.Find(id);
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Evolucion obj)
        {
            throw new NotImplementedException();
        }
    }
}
