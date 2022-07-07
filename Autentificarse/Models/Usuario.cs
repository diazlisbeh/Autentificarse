using System;
using System.Collections.Generic;

namespace Autentificarse.Models
{
    public partial class Usuario
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? Usuario1 { get; set; }
        public string? Clave { get; set; }
        public string? Rool { get; set; }
        public string? Typelogin { get; set; }
    }
   
}
