using LogicaNegocio.Entidades;
using LogicaNegocio.InterfacesRepositorios;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAccesoDatos.Repositorios
{
    public class RepositorioPacientes : IRepositorioPacientes
    {

        private ApplicationDbContext _db;
        public RepositorioPacientes(ApplicationDbContext db)
        {
            _db = db;
        }

        public void Add(Pacientes nuevo)
        {
            try
            {
                _db.Pacientes.Add(nuevo);
                _db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar el usuario", ex);
            }
        }

        public List<Pacientes> FindAll()
        {
            return _db.Pacientes.OrderBy(a => a.NombreCompleto).ToList();
        }

        public Pacientes FindById(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Pacientes obj)
        {
            throw new NotImplementedException();
        }
    }
}
