﻿using LogicaNegocio.Entidades;
using LogicaNegocio.InterfacesRepositorios;
using Microsoft.EntityFrameworkCore;
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
            _db.HistorialesClinicos.Update(cambiado);
            _db.SaveChanges();
        }





        public List<HistorialesClinicos> FindAll()
        {
            return _db.HistorialesClinicos.ToList();
        }

        public HistorialesClinicos FindById(int id)
        {
            return _db.HistorialesClinicos.Find(id);
        }

        public void Remove(int id)
        {
            HistorialesClinicos historialEncontrado = FindById(id);
            _db.Remove(historialEncontrado);
            _db.SaveChanges();
        }

        public List<HistorialesClinicos> ListarHistoriaClinica(int id)
        {
            return _db.HistorialesClinicos.Where(h => h.PacienteId == id).ToList();
        }


        public HistorialesClinicos FindByPacienteId(int pacienteId)
        {
            return _db.HistorialesClinicos.Include(h => h.Paciente).FirstOrDefault(h => h.PacienteId == pacienteId);
        }









    }
}
