using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Entidades
{
    public class Usuarios
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public Usuarios()
        {
            
        }

        public Usuarios(string email, string password)
        {
            Email = email;
            Password = password;
        }
    }
}
