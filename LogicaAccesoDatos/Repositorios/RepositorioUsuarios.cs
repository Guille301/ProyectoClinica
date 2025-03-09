using LogicaNegocio.Entidades;
using LogicaNegocio.InterfacesRepositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAccesoDatos.Repositorios
{
    public class RepositorioUsuarios : IRepositorioUsuarios
    {
        private ApplicationDbContext _context;

        public RepositorioUsuarios(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Add(Usuarios nuevo)
        {
            _context.Usuarios.Add(nuevo);
            _context.SaveChanges();
        }

        public List<Usuarios> FindAll()
        {
            return _context.Usuarios.ToList();
        }

        public Usuarios FindByGmail(string email)
        {
            Usuarios buscado = _context.Usuarios.Where(u => u.Email == email).SingleOrDefault();
            return buscado;
        }

        public Usuarios FindById(int id)
        {
            return _context.Usuarios.Find(id);
        }

        public void Remove(int id)
        {
            Usuarios usuarioEncontrado = FindById(id);
            _context.Usuarios.Remove(usuarioEncontrado);
            _context.SaveChanges();
        }

        public void Update(Usuarios obj)
        {
            _context.Usuarios.Update(obj);
            _context.SaveChanges();
        }
    }
}
