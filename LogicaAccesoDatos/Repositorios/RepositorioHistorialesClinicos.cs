using LogicaNegocio.Entidades;
using LogicaNegocio.InterfacesRepositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAccesoDatos.Repositorios
{
    public class RepositorioHistorialesClinicos : IRepositorioHistorialesClinicos
    {

        private ApplicationDbContext _db;
        public RepositorioHistorialesClinicos(ApplicationDbContext db)
        {
            _db = db;
        }


        public void Add(HistorialesClinicos nuevo)
        {
            try
            {
                _db.HistorialesClinicos.Add(nuevo);
                _db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar el Historial clinico", ex);
            }
        }

        public List<HistorialesClinicos> FindAll()
        {
            throw new NotImplementedException();
        }

        public HistorialesClinicos FindById(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(HistorialesClinicos obj)
        {
            throw new NotImplementedException();
        }
    }
}
