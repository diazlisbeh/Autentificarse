using System;
using System.Collections.Generic;

namespace Autentificarse.Models
{
    public partial class TypeLogin
    {
        public TypeLogin()
        {
            Autentics = new HashSet<Autentic>();
        }

        public int Id { get; set; }
        public int IdUser { get; set; }
        public string? TypeLogin1 { get; set; }

        public virtual Usuario IdUserNavigation { get; set; } = null!;
        public virtual ICollection<Autentic> Autentics { get; set; }
    }
}
