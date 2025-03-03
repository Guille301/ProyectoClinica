using System;
using System.Diagnostics;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // Obtiene la ruta del directorio donde está el ejecutable
        string directorioEjecutable = AppDomain.CurrentDomain.BaseDirectory;

        // Construye la ruta del proyecto MVC (suponiendo que 'ClinicaMvc' está en el mismo directorio que el ejecutable)
        string rutaProyecto = Path.Combine(directorioEjecutable, "ClinicaMvc"); // Ajusta si el nombre de la carpeta es diferente

        string url = "http://localhost:5062/Login/Login"; // URL de la vista del login de tu proyecto MVC

        try
        {
            // Iniciar el servidor MVC usando 'dotnet run'
            var proceso = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "dotnet",
                    Arguments = "run", // El comando 'dotnet run' se ejecutará dentro de la carpeta de tu proyecto MVC
                    WorkingDirectory = rutaProyecto, // Directorio donde está el proyecto MVC
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                }
            };
            proceso.Start();

            // Esperar un tiempo para que el servidor se inicie (ajusta según lo que necesites)
            Console.WriteLine("Iniciando el servidor MVC...");

            // Abrir el navegador en la URL del proyecto
            Process.Start(new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            });

            // Esperar a que el usuario cierre la aplicación
            Console.WriteLine("Servidor y navegador iniciados. Presiona cualquier tecla para cerrar...");
            Console.ReadKey();

            // Finalizar el proceso del servidor cuando el usuario cierre la aplicación
            proceso.Kill();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
