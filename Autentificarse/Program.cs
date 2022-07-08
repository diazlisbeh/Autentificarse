using Autentificarse.Clases;
using Autentificarse.Models;


Console.WriteLine("Login or Register");
string TypeLog = Console.ReadLine();

#region Login and Register
switch (TypeLog)
{
    case "Login":

        using (var Clogin = new AUTENTICARContext())
        {
                Console.WriteLine("Usuario:");
                string Uss = Console.ReadLine();
                Console.WriteLine("Clave:");
                string Cls = Console.ReadLine();
                Console.WriteLine("Rool:");
                string Rls = Console.ReadLine();
                Console.WriteLine("Dominio, Sistem And DBMS");
                string Lg = Console.ReadLine();
                Console.WriteLine("Validador");
                string Vl = Console.ReadLine();

                CreatorUser usuario = new ConcretCreatorUser(Uss, Cls, Rls);
                InterfaceUser MUser = usuario.Validar();

                using (var context = new AUTENTICARContext())
                {
                    var user = context.Usuarios.FirstOrDefault(x => x.Usuario1 == Uss);
                    var typeLogin = context.TypeLogins.FirstOrDefault(x => x.TypeLogin1 == Lg);
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
                if (Rls != user.Rool.Replace(" ",""))
                {
                    Console.WriteLine($"El rol del Usuario : {user.Usuario1} Es incorrecta.");
                    break;
                }    
                if (Lg != typeLogin.TypeLogin1)
                {
                    Console.WriteLine($"El tipo de login del Usuario : {Lg} Es incorrecta.");
                    break;
                } 
                if (Vl != validator.Validador)
                {
                    Console.WriteLine($"El validador del Usuario : {Vl} Es incorrecta.");
                    break;
                }
                    Console.WriteLine($"Usuario : {user.Usuario1} se autentico correctamente.");
                }
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
        Console.WriteLine("Rool:");
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
                    new TypeLogin(){TypeLogin1 = TL,
                    Autentics = new List<Autentic>()
                    {
                        new Autentic(){ Validador = VL},
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

