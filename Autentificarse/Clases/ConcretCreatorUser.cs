using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autentificarse.Clases
{
    public class ConcretCreatorUser : CreatorUser
    {
        private string _usuario;
        private string _clave;
        private string _rool;
        
        public ConcretCreatorUser(string Usuario, string Clave, string Rool)
        {
            _usuario = Usuario;
            _clave = Clave;
            _rool = Rool;
        }
        public override InterfaceUser Validar()
        {
            return new Usuarios(_usuario, _clave, _rool);
        }


    }
}
