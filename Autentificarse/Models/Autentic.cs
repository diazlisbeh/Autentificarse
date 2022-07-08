using System;
using System.Collections.Generic;

namespace Autentificarse.Models
{
    public partial class Autentic
    {
        public int Id { get; set; }
        public int IdType { get; set; }
        public string? Validador { get; set; }

        public virtual TypeLogin IdTypeNavigation { get; set; } = null!;
    }
}
