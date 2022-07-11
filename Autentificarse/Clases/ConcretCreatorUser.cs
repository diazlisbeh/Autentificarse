using System;
using System.Collections.Generic;

using System.Text;
using System.Threading.Tasks;

namespace Autentificarse.Clases
{
    public class ConcretCreatorUser : CreatorUser
    {
        private string _usuario;
        private string _clave;
        private string _tipologin;
        private string _rool;
        
        public ConcretCreatorUser(string Usuario, string Clave, string TipoLogin,  string Rool)
        {
            _usuario = Usuario;
            _clave = Clave;
            _tipologin = TipoLogin;
            _rool = Rool;
        }
        public override InterfaceUser ValidarS()
        {
            return new Usuarios(_usuario, _clave,_tipologin, _rool);
        }


    }

    public class ConcretCreatorUserDB : CreatorUserDB
    {
        private string _usuario;
        private string _clave;
        private string _tipologin;

        public ConcretCreatorUserDB(string Usuario, string Clave, string TipoLogin)
        {
            _usuario = Usuario;
            _clave = Clave;

            _tipologin = TipoLogin;
        }
        public override InterfaceUserDB ValidarDB()
        {
            return new UsuariosDB(_usuario, _clave, _tipologin);
        }


    }

    public class ConcretCreatorUserSis : CreatorUserSis
    {
        private string _usuario;
        private string _clave;
        private string _tipologin;
        private string _validar;

        public ConcretCreatorUserSis(string Usuario, string Clave, string TipoLogin,  string Validar)
        {
            _usuario = Usuario;
            _clave = Clave;
            _tipologin = TipoLogin;
            _validar = Validar;
        }
        public override InterfaceUserSis ValidarSis()
        {
            return new UsuariosSis(_usuario, _clave,_tipologin, _validar);
        }


    }


}
