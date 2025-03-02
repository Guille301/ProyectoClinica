using System;
using System.Diagnostics;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        string rutaProyecto = @"C:\Users\juanp\OneDrive\Desktop\ProyectoClinica\ClinicaMvc";  // Cambia esta ruta a la de tu proyecto MVC
        string url = "http://localhost:5062/Login/Login"; // Cambia a la URL de tu proyecto MVC

        try
        {
            // Iniciar el servidor MVC usando 'dotnet run'
            var proceso = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "dotnet",
                    Arguments = "run",
                    WorkingDirectory = rutaProyecto, // Directorio del proyecto MVC
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
