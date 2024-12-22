using LogicaNegocio.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAccesoDatos
{
    public class ApplicationDbContext:DbContext
    {
        DbSet<Usuarios> Usuarios {  get; set; }
        DbSet<Pacientes> Pacientes { get; set; }
        DbSet<HistorialesClinicos> HistorialesClinicos { get; set; }


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
