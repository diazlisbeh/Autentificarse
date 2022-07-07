using Autentificarse.Clases;
using Autentificarse.Models;


Console.WriteLine("Typo de login: Dominio, DBMS, Sistema");
string TypeLog = Console.ReadLine();


#region Login and Register
using (var Clogin = new AUTENTICARContext())
{
    var login = Clogin.Usuarios.ToList();
    foreach (var loginu in login)
    {
        if (TypeLog == loginu.Typelogin)
        {
            Console.WriteLine("Usuario:");
            string Us = Console.ReadLine();
            Console.WriteLine("Clave:");
            string Cl = Console.ReadLine();
            Console.WriteLine("Rool:");
            string Rl = Console.ReadLine();

            CreatorUser usuario = new ConcretCreatorUser(Us, Cl, Rl);
            InterfaceUser MUser = usuario.Validar();

            using (var context = new AUTENTICARContext())
            {
                var users = context.Usuarios.ToList();
                foreach (var user in users)
                {
                    if (Us == user.Usuario1)
                    {
                        if (Cl == user.Clave)
                        {
                            if (Rl == user.Rool)
                            {
                                Console.WriteLine($"Usuario : {user.Usuario1} se autentico correctamente.");
                            }
                            else
                            {
                                Console.WriteLine($"Credenciales incorrectas.");
                            }

                        }
                        else
                        {
                            Console.WriteLine($"Credenciales incorrectas.");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Credenciales incorrectas.");
                    }

                }
            }


        }
        else
        {
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
            Console.WriteLine("TypoLogin:");
            string Tl = Console.ReadLine();


            using (var context = new AUTENTICARContext())
            {
                var user = new Autentificarse.Models.Usuario()
                {
                    Nombre = No,
                    Apellido = Ap,
                    Usuario1 = Us,
                    Clave = Cl,
                    Rool = Rl,
                    Typelogin = Tl,

                };

                context.Usuarios.Add(user);
                context.SaveChanges();
                Console.WriteLine($"Usuario: {Us} Registrado correctamente");
            }
        }
     }
}


#endregion












