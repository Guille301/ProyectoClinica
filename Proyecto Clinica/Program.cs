
using LogicaAccesoDatos;
using LogicaAccesoDatos.Repositorios;
using LogicaAplicacion.CasosUso.CUEvolucion;
using LogicaAplicacion.CasosUso.CUHistoriaClinica;
using LogicaAplicacion.CasosUso.CUPaciente;
using LogicaAplicacion.CasosUso.CUUsuario;
using LogicaAplicacion.InterfaceCasosUso.ICUHistoriaClinica;
using LogicaAplicacion.InterfaceCasosUso.ICUPaciente;
using LogicaAplicacion.InterfaceCasosUso.ICUUsuario;
using LogicaNegocio.InterfacesRepositorios;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);




// Agregar servicios de CORS
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy.AllowAnyOrigin() // Permitir cualquier origen
              .AllowAnyHeader() // Permitir cualquier encabezado
              .AllowAnyMethod(); // Permitir cualquier método HTTP (GET, POST, etc.)
    });
});





// Configurar la cadena de conexión (desde appsettings.json)
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");//DefaultConnection debe coincidir con el nombre designado en el JSON.




// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

/*DbContext*/
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ConexionClinica")));



//Inyecciones

//CASOS DE USO
builder.Services.AddScoped<IAltaPaciente, AltaPaciente>();
builder.Services.AddScoped<ICUListarPaciente, ListarPaciente>();
builder.Services.AddScoped<ICULogin, Login>();
builder.Services.AddScoped<IAltaEvolucion, CUAltaEvolucion>();
//builder.Services.AddScoped<ICUAltaHistorialClinico, AltaHistorialClinico>();
builder.Services.AddScoped<ICUPacienteDetalle, PacienteDetalle>();
builder.Services.AddScoped<ICUPacienteFiltro, PacienteFiltro>();
builder.Services.AddScoped<IPacienteFicha, PacienteFichaIdentificacion>();
builder.Services.AddScoped<IAgregrarHistoriaClinica, AltaHistoriaClinica>();



//REPOS
builder.Services.AddScoped<IRepositorioUsuarios, RepositorioUsuarios>();
builder.Services.AddScoped<IRepositorioPacientes, RepositorioPacientes>();
builder.Services.AddScoped<IRepositorioHistorialesClinicos, RepositorioHistorialesClinicos>();
builder.Services.AddScoped<IRepositorioEvoluciones, RepositorioEvoluciones>();



//Confifuracion jsonWebToken

var clave = "UTzl^7yPl$5xrT6&{7RZCSG&O42MEK-89$CW1XXRrN(>XqIp{W4s2S5$>KT$6CG!2M]'ZlrqH-t%eI4.X9W~u#qO+oX£+[?7QDAa";
var claveEncriptada = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(clave));


builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
.AddJwtBearer(opt =>
{
    opt.TokenValidationParameters = new TokenValidationParameters
    {
        //Definir las verificaciones a realizar
        ValidateIssuer = false,
        ValidateAudience = false,
        ValidateLifetime = false,
        ValidateIssuerSigningKey = true,

        IssuerSigningKey = claveEncriptada
    };

});



var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();


app.UseAuthorization();
app.UseCors();
app.MapControllers();

app.Run();
