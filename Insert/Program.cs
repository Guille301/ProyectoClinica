using Microsoft.Data.Sqlite;
using System;

namespace SQLiteInsertConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Cadena de conexión a la base de datos SQLite
                string connectionString = @"Data Source=C:\Users\juanp\OneDrive\Desktop\ProyectoClinica\ClinicaMvc\Database\Database.sqlite;";

                // Crea la conexión a SQLite
                using (var connection = new SqliteConnection(connectionString))
                {
                    // Abre la conexión
                    connection.Open();

                    // Define la consulta SQL para insertar datos
                    string query = @"
                        INSERT INTO Usuarios 
                        (Email, Password) 
                        VALUES 
                        (@Email, @Password);";

                    // Ejecuta la consulta
                    using (var command = new SqliteCommand(query, connection))
                    {
                        // Parámetros para evitar inyección SQL
                        command.Parameters.AddWithValue("@Email", "Seba@gmail.com");
                        command.Parameters.AddWithValue("@Password", "$2a$12$FsGhW0xtJ6kbIAEVneXKg.vvitZu1rLvaV0XZXXn1dFAAY8vafU5a");

                        command.ExecuteNonQuery();
                    }

                    Console.WriteLine("¡Insert realizado exitosamente!");
                }
            }
            catch (Exception ex)
            {
                // Captura cualquier excepción y muestra el mensaje de error
                Console.WriteLine($"Error: {ex.Message}");
                Console.WriteLine($"Detalles: {ex.StackTrace}");
            }
            finally
            {
                Console.WriteLine("Presiona cualquier tecla para salir.");
                Console.ReadKey();
            }
        }
    }
}