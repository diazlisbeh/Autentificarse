using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autentificarse.Clases
{
    public class Usuario : InterfaceUser
    {
        private string _usuario;
        private string _clave;
        private string _rool;

        public Usuario(string Usuario, string Clave, string Rool)
        {
            _usuario = Usuario;
            _clave = Clave;
            _rool = Rool;
        }
        public string Validar(string Usuario, string Clave, string Rool)
        {
            return Usuario + " " + Clave + " " + Rool;
        }
    }
}
