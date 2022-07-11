using Autentificarse.Clases;
using Autentificarse.Models;


Console.WriteLine("Dominio, DataBase, Sistem and Register");
string TypeLog = Console.ReadLine();

#region Login and Register
switch (TypeLog)
{
    case "Dominio":

        using (var Clogin = new AUTENTICARContext())
        {
            Console.WriteLine("Usuario:");
            string Uss = Console.ReadLine();
            Console.WriteLine("Clave:");
            string Cls = Console.ReadLine();
            Console.WriteLine("Tipo de login:");
            string Tpl = Console.ReadLine();
            Console.WriteLine("Rol:");
            string Rls = Console.ReadLine();
            
            CreatorUser usuario = new ConcretCreatorUser(Uss, Cls,Tpl, Rls);
            InterfaceUser MUser = usuario.ValidarS();
            string Valido = MUser.ValidarS(Uss, Cls,Tpl, Rls);

            using (var context = new AUTENTICARContext())
            {
                var user = context.Usuarios.FirstOrDefault(x => x.Usuario1 == Uss);
                var userLogin = context.TypeLogins.FirstOrDefault(x => x.TypeLogin1 == Tpl);
                if (Uss != user.Usuario1)
                {
                    Console.WriteLine($"El usuario : {user.Usuario1} Es incorrecta.");
                    break;
                }
                if (Cls != user.Clave)
                {
                    Console.WriteLine($"La clave del Usuario : {user.Usuario1} Es incorrecta.");
                    break;
                }
                if (Tpl != userLogin.TypeLogin1)
                {
                    Console.WriteLine($"El Tipo de login del Usuario : {userLogin.TypeLogin1} Es incorrecta.");
                    break;
                }
                if (Rls != user.Rool.Replace(" ", ""))
                {
                    Console.WriteLine($"El rol del Usuario : {user.Usuario1} Es incorrecta.");
                    break;
                }
                Console.WriteLine($"{Valido}");
            }
        }
        break;
    case "DataBase":

        using (var Clogin = new AUTENTICARContext())
        {
            Console.WriteLine("Usuario:");
            string Uss = Console.ReadLine();
            Console.WriteLine("Clave:");
            string Cls = Console.ReadLine();
            Console.WriteLine("Tipo de login:");
            string Tpl = Console.ReadLine();
            

            CreatorUserDB usuario = new ConcretCreatorUserDB(Uss, Cls, Tpl);
            InterfaceUserDB MUser = usuario.ValidarDB();
            string Valido = MUser.ValidarDB(Uss, Cls, Tpl);

            using (var context = new AUTENTICARContext())
            {
                var user = context.Usuarios.FirstOrDefault(x => x.Usuario1 == Uss);
                var userLogin = context.TypeLogins.FirstOrDefault(x => x.TypeLogin1 == Tpl);
                if (Uss != user.Usuario1)
                {
                    Console.WriteLine($"El usuario : {user.Usuario1} Es incorrecta.");
                    break;
                }
                if (Cls != user.Clave)
                {
                    Console.WriteLine($"La clave del Usuario : {user.Usuario1} Es incorrecta.");
                    break;
                }
                if (Tpl != userLogin.TypeLogin1)
                {
                    Console.WriteLine($"El Tipo de login del Usuario : {userLogin.TypeLogin1} Es incorrecta.");
                    break;
                }
                Console.WriteLine($"{Valido}");
            }
        }
        break;
    case "Sistem":

        using (var Clogin = new AUTENTICARContext())
        {
            Console.WriteLine("Usuario:");
            string Uss = Console.ReadLine();
            Console.WriteLine("Clave:");
            string Cls = Console.ReadLine();
            Console.WriteLine("Tipo de login");
            string Tpl = Console.ReadLine();
            Console.WriteLine("Validador");
            string Vl = Console.ReadLine();

            CreatorUserSis usuario = new ConcretCreatorUserSis(Uss, Cls,Tpl, Vl);
            InterfaceUserSis MUser = usuario.ValidarSis();
            string Valido = MUser.ValidarSis(Uss, Cls, Tpl, Vl);

            using (var context = new AUTENTICARContext())
            {
                var user = context.Usuarios.FirstOrDefault(x => x.Usuario1 == Uss);
                var userLogin = context.TypeLogins.FirstOrDefault(x => x.TypeLogin1 == Tpl);
                var validator = context.Autentics.FirstOrDefault(x => x.Validador == Vl);

                if (Uss != user.Usuario1)
                {
                    Console.WriteLine($"El usuario : {user.Usuario1} Es incorrecta.");
                    break;
                }
                if (Cls != user.Clave)
                {
                    Console.WriteLine($"La clave del Usuario : {user.Usuario1} Es incorrecta.");
                    break;
                }
                if (Tpl != userLogin.TypeLogin1)
                {
                    Console.WriteLine($"El Tipo de login del Usuario : {userLogin.TypeLogin1} Es incorrecta.");
                    break;
                }
                if (Vl != validator.Validador)
                {
                    Console.WriteLine($"El validador del Usuario : {Vl} Es incorrecta.");
                    break;
                }
                Console.WriteLine($"{Valido} Se Autentico Correctamente.");
            }
        }
        break;
    case "Actualizar":

        Console.WriteLine("Actualizar usuario");
        Console.WriteLine("Usuario:");
        string NoU = Console.ReadLine();
        Console.WriteLine("Tipo de login:");
        string TLU = Console.ReadLine();
        Console.WriteLine("Validador:");
        string VLU = Console.ReadLine();


        using (var context = new AUTENTICARContext())
        {
            var userdb = context.Usuarios.FirstOrDefault(x => x.Usuario1 == NoU);
            var validlist = new List<Autentic>()
            {
                new Autentic(){ Validador = VLU}
            };
            var userTl = new TypeLogin() {
                IdUser = userdb.Id,
                TypeLogin1 = TLU,
                Autentics = validlist,
            };
            
            context.TypeLogins.Add(userTl);
            context.SaveChanges();

            Console.WriteLine($"Usuario: {NoU} actualizado correctamente");
        }
        break;
    default:

        Console.WriteLine("Registrar");
        Console.WriteLine("Nombre:");
        string No = Console.ReadLine();
        Console.WriteLine("Apellido:");
        string Ap = Console.ReadLine();
        Console.WriteLine("Usuario:");
        string Us = Console.ReadLine();
        Console.WriteLine("Clave:");
        string Cl = Console.ReadLine();
        Console.WriteLine("Rol:");
        string Rl = Console.ReadLine();
        Console.WriteLine("TypeLogin:");
        string TL = Console.ReadLine();
        Console.WriteLine("Validador:");
        string VL = Console.ReadLine();

        using (var context = new AUTENTICARContext())
        {

            var user = new Autentificarse.Models.Usuario()
            {
                Nombre = No,
                Apellido = Ap,
                Usuario1 = Us,
                Clave = Cl,
                Rool = Rl,

                TypeLogins = new List<TypeLogin>()
                {
                    new TypeLogin()
                    {
                    TypeLogin1 = TL,
                    Autentics = new List<Autentic>(){
                        new Autentic(){ Validador = VL
                        },
                        }
                    },
                }
            };
            context.Usuarios.Add(user);
            context.SaveChanges();

            Console.WriteLine($"Usuario: {Us} Registrado correctamente");
            break;
        }

}
#endregion

