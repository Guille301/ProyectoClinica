

using LogicaAccesoDatos;
using LogicaAccesoDatos.Repositorios;
using LogicaAplicacion.CasosUso.CUEvolucion;
using LogicaAplicacion.CasosUso.CUHistoriaClinica;
using LogicaAplicacion.CasosUso.CUPaciente;
using LogicaAplicacion.CasosUso.CUUsuario;
using LogicaAplicacion.InterfaceCasosUso.ICUEvolucion;
using LogicaAplicacion.InterfaceCasosUso.ICUHistoriaClinica;
using LogicaAplicacion.InterfaceCasosUso.ICUPaciente;
using LogicaAplicacion.InterfaceCasosUso.ICUUsuario;
using LogicaNegocio.InterfacesRepositorios;
using Microsoft.EntityFrameworkCore;

namespace webApp
{
    public class Program
    {
        public static void Main(string[] args)
        {

            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddSession();

            //Inyecciones

            //CASOS DE USO
            builder.Services.AddScoped<IAltaPaciente, AltaPaciente>();
            builder.Services.AddScoped<ICUListarPaciente, ListarPaciente>();
            builder.Services.AddScoped<ICULogin, Login>();
            builder.Services.AddScoped<IAltaEvolucion, CUAltaEvolucion>();
            builder.Services.AddScoped<ICUListarEvoluciones, CUListarEvolucion>();
            //builder.Services.AddScoped<ICUAltaHistorialClinico, AltaHistorialClinico>();
            builder.Services.AddScoped<ICUPacienteDetalle, PacienteDetalle>();
            builder.Services.AddScoped<ICUPacienteFiltro, PacienteFiltro>();
            builder.Services.AddScoped<IPacienteFicha, PacienteFichaIdentificacion>();
            builder.Services.AddScoped<IAgregrarHistoriaClinica, AltaHistoriaClinica>();
            builder.Services.AddScoped<IEditarHistoriaClinica, EditarHistoriaClinicaCU>();
            builder.Services.AddScoped<IListarHistoriaClinica, ListarHistoriaClinica>();




            //REPOS
            builder.Services.AddScoped<IRepositorioUsuarios, RepositorioUsuarios>();
            builder.Services.AddScoped<IRepositorioPacientes, RepositorioPacientes>();
            builder.Services.AddScoped<IRepositorioHistorialesClinicos, RepositorioHistorialesClinicos>();
            builder.Services.AddScoped<IRepositorioEvoluciones, RepositorioEvoluciones>();






            /*DbContext*/
            builder.Services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("ConexionClinica")));



            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();


            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseSession();
            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
