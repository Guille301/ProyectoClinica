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

        public List<Evolucion> ListarEvolucionesConFiltro(int? id)
        {
            var retorno = _db.Evoluciones.Where(e=>e.IdHistoria == id).ToList();
            return retorno;
        }

        public void Remove(int id)
        {
            Evolucion evolucionEncontrado = FindById(id);
            _db.Remove(evolucionEncontrado);
            _db.SaveChanges();
        }


        public void RemoveAllByHistoria(int idHistoria)
        {
            try
            {
                // Encontramos todas las evoluciones relacionadas con el IdHistoria
                var evolucionesAEliminar = _db.Evoluciones.Where(e => e.IdHistoria == idHistoria).ToList();

                // Verificamos si hay evoluciones a eliminar
                if (evolucionesAEliminar.Any())
                {
                    _db.Evoluciones.RemoveRange(evolucionesAEliminar); // Eliminamos todas las evoluciones encontradas
                    _db.SaveChanges(); // Guardamos los cambios
                }
                else
                {
                    // Si no se encuentran evoluciones para el IdHistoria, podrías lanzar una excepción o manejarlo de otra manera
                    throw new Exception("No se encontraron evoluciones para el historial clínico especificado.");
                }
            }
            catch (Exception ex)
            {
                // Si ocurre algún error, se lanza una excepción
                throw new Exception("Error al eliminar las evoluciones para el historial clínico", ex);
            }
        }




        public void Update(Evolucion obj)
        {
            throw new NotImplementedException();
        }
    }
}
