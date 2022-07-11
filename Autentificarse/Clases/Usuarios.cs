using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autentificarse.Clases
{
    public class Usuarios : InterfaceUser
    {

        private string _usuario;
        private string _clave;
        private string _tipologin;
        private string _rool;

        public Usuarios(string Usuario, string Clave, string TipoLogin , string Rool)
        {
            _usuario = Usuario;
            _clave = Clave;
            _tipologin = TipoLogin;
            _rool = Rool;
        }
        public string ValidarS(string Usuario, string Clave, string TipoLogin, string Rool)
        {
            return "Usuario: "+Usuario +", Clave: " + Clave + ", Rol: " + Rool + ", Tipo de login: " + TipoLogin + " " + "Inicio correctamente el Dominio";
        }
    }

    public class UsuariosDB : InterfaceUserDB
    {

        private string _usuario;
        private string _clave;
        private string _tipologin;

        public UsuariosDB(string Usuario, string Clave, string TipoLogin)
        {
            _usuario = Usuario;
            _clave = Clave;
            _tipologin= TipoLogin;
        }
        public string ValidarDB(string Usuario, string Clave, string TipoLogin)
        {
            return "Usuario: " + Usuario + ", Clave: " + Clave + " , Tipo de login: " + TipoLogin  + " " + "Inicio correctamente la base de datos";
        }
    }

    public class UsuariosSis : InterfaceUserSis
    {

        private string _usuario;
        private string _clave;
        private string _tipologin;
        private string _validar;

        public UsuariosSis(string Usuario, string Clave, string TipoLogin, string Validar)
        {
            _usuario = Usuario;
            _clave = Clave;
            _tipologin = TipoLogin;
            _validar = Validar;
        }
        public string ValidarSis(string Usuario, string Clave,string TipoLogin, string Validar)
        {
            return "Usuario: " + Usuario + ", Clave: " + Clave + ", Rol: " + Validar + ", Tipo de login: "+ TipoLogin + "Inicio correctamente el Sistema";
        }
    }
}
