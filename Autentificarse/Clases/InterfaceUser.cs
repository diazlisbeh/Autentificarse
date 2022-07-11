using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autentificarse.Clases
{
    public interface InterfaceUser 
    {
        public string ValidarS(string Usuario, string Clave, string TipoLogin, string Rool);
    }

    public interface InterfaceUserDB
    {
        public string ValidarDB(string Usuario, string Clave, string TipoLogin);
    }

    public interface InterfaceUserSis
    {
        public string ValidarSis(string Usuario, string Clave, string TipoLogin, string Validador);
    }
}
