using Class__POO;

Console.WriteLine("Ingreso de Usuarios");

Console.WriteLine("Usuario 1:");
User user1 = new User();
Console.WriteLine("Nombre: ");
user1.Nombre = Console.ReadLine();
Console.WriteLine("Usuario: ");
user1.UsuarioSys = Console.ReadLine();
Console.WriteLine("Contraseña: ");
user1.PasswordSys = Console.ReadLine();

Console.WriteLine("Usuario 2:");
User user2 = new User();
Console.WriteLine("Nombre: ");
user2.Nombre = Console.ReadLine();
Console.WriteLine("Usuario: ");
user2.UsuarioSys = Console.ReadLine();
Console.WriteLine("Contraseña: ");
user2.PasswordSys = Console.ReadLine();