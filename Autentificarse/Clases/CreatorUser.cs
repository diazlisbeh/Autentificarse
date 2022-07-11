using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autentificarse.Clases
{
    public abstract class CreatorUser
    {        public abstract InterfaceUser ValidarS();
    }
    public abstract class CreatorUserDB
    {
        public abstract InterfaceUserDB ValidarDB();
    }
    public abstract class CreatorUserSis
    {
        public abstract InterfaceUserSis ValidarSis();
    }

}
