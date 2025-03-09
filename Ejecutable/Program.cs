using System;
using System.Diagnostics;
<<<<<<< HEAD
using System.Threading;
=======
using System.IO;
>>>>>>> bf58e0f (se mejoro la interfaz del dashboard)

class Program
{
    static void Main(string[] args)
    {
<<<<<<< HEAD
        string rutaProyecto = @"C:\Users\juanp\OneDrive\Desktop\ProyectoClinica\ClinicaMvc";  // Cambia esta ruta a la de tu proyecto MVC
        string url = "http://localhost:5062/Login/Login"; // Cambia a la URL de tu proyecto MVC
=======
        // Obtiene la ruta del directorio donde está el ejecutable
        string directorioEjecutable = AppDomain.CurrentDomain.BaseDirectory;

        // Construye la ruta del proyecto MVC (suponiendo que 'ClinicaMvc' está en el mismo directorio que el ejecutable)
        string rutaProyecto = Path.Combine(directorioEjecutable, "ClinicaMvc"); // Ajusta si el nombre de la carpeta es diferente

        string url = "http://localhost:5062/Login/Login"; // URL de la vista del login de tu proyecto MVC
>>>>>>> bf58e0f (se mejoro la interfaz del dashboard)

        try
        {
            // Iniciar el servidor MVC usando 'dotnet run'
            var proceso = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "dotnet",
<<<<<<< HEAD
                    Arguments = "run",
                    WorkingDirectory = rutaProyecto, // Directorio del proyecto MVC
=======
                    Arguments = "run", // El comando 'dotnet run' se ejecutará dentro de la carpeta de tu proyecto MVC
                    WorkingDirectory = rutaProyecto, // Directorio donde está el proyecto MVC
>>>>>>> bf58e0f (se mejoro la interfaz del dashboard)
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                }
            };
            proceso.Start();

            // Esperar un tiempo para que el servidor se inicie (ajusta según lo que necesites)
            Console.WriteLine("Iniciando el servidor MVC...");
<<<<<<< HEAD
            Thread.Sleep(5000); // Puedes aumentar este tiempo si tu servidor tarda más en arrancar
=======
>>>>>>> bf58e0f (se mejoro la interfaz del dashboard)

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
