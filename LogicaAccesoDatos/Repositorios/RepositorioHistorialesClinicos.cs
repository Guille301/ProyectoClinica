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


        public void Update(HistorialesClinicos cambiado)
        {
            var disOriginal = _db.HistorialesClinicos.Find(cambiado.Id);
            try
            {
                disOriginal.MotivoDeConsulta = cambiado.MotivoDeConsulta;
                disOriginal.EnfermedadActual = cambiado.EnfermedadActual;
                disOriginal.Antecedentes = cambiado.Antecedentes;
                disOriginal.HabitosPSB = cambiado.HabitosPSB;
                disOriginal.ExamenFisico = cambiado.ExamenFisico;
                disOriginal.Diagnostico = cambiado.Diagnostico;
                disOriginal.ExameneLaboratorio = cambiado.ExameneLaboratorio;
                disOriginal.Tratamiento = cambiado.Tratamiento;




                _db.HistorialesClinicos.Update(disOriginal);
                _db.SaveChanges();
            }
            catch (Exception ex)
            {

                throw;
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

       
    }
}
