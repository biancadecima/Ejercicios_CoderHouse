using System;

int counter = 5;
const string password = "coder2022";

while (counter != 0)
{
    Console.WriteLine("Ingrese la contraseña (tiene " + counter + " intentos)");
    string savedPassword = Console.ReadLine();
    if (savedPassword != null)
    {
        if (validatePasswordLength(savedPassword))
        {
            if (password == savedPassword)
            {
                string hiddenPassword;
                hiddenPassword = hidePassword(savedPassword);
                Console.WriteLine(hiddenPassword + " es correcta");
                counter = 0;
            }
            else
            {
                Console.WriteLine("Contraseña errónea");
                counter--;
            }
        }
        else
        {
            Console.WriteLine("Contraseña inválida por tener menos de 5 dígitos");
            counter--;
        }
    }


}
Console.WriteLine("Finalización del programa.");

bool validatePasswordLength(string password)
{
    if (password.Length >= 5)
    {
        return true;
    }
    else
    {
        return false;
    }
}

string hidePassword(string password)
{
    string hash = "";
    for (int i = 0; i < password.Length; i++)
    {
        hash += "*";
    }
    return hash;
}