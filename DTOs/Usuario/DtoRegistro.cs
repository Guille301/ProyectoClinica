using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs.Usuario
{
    public class DtoRegistro
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfPassword { get; set; }
    }
}
