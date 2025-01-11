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
                throw new Exception("Error al agregar el paciente", ex);
            }
        }

        public List<Pacientes> FindAll()
        {
            return _db.Pacientes.OrderBy(a => a.NombreCompleto).ToList();
        }





        public List<Pacientes> FiltroPacientes(string? ci, string? nombre)
        {
            try
            {
                var query = _db.Pacientes.AsQueryable();

                // Filtro por documento
                if (!string.IsNullOrWhiteSpace(ci))
                {
                    query = query.Where(e => e.NumeroDocumento.StartsWith(ci));
                }

                // Filtro por nombre completo
                if (!string.IsNullOrWhiteSpace(nombre))
                {
                    query = query.Where(e => e.NombreCompleto.ToLower().Contains(nombre.ToLower()));
                }


              

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("No se encontraron Pacientes ", ex);
            }
        }




        public Pacientes FindDetalle(string ci)
        {
            return _db.Pacientes.Where(p => p.NumeroDocumento == ci).FirstOrDefault();
        }




        public Pacientes FindByCI(string numeroDoc)
        {
            try
            {
                var paciente = _db.Pacientes.Where(u => u.NumeroDocumento == numeroDoc).FirstOrDefault();
                return paciente;
            }
            catch (Exception ex)
            {
                throw new Exception("Error", ex);
            }
        }











        public Pacientes FindById(int id)
        {
            return _db.Pacientes.Find(id);
        }



        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Pacientes obj)
        {
            throw new NotImplementedException();
        }

        public object FindByCI(int pacienteId)
        {
            throw new NotImplementedException();
        }
    }
}
