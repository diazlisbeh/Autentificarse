using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autentificarse.Clases
{
    public interface InterfaceUser 
    {
        public string Validar(string Usuario, string Clave, string Rool);
    }
}
