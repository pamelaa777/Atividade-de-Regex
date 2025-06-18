using System;
using System.Text.RegularExpressions;
/*
class Program
{
    static void Main()
    {
        string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[!@#$%^&*()+=_\-{}\[\]:;""'?<>,.]).{7,16}$";
        Regex regex = new Regex(pattern);

        while (true)
        {
            Console.Write("Digite uma senha forte: ");
            string senha = Console.ReadLine();

            if (regex.IsMatch(senha))
            {
                Console.WriteLine("Senha forte! Parabéns.");
                break;
            }
            else
            {
                Console.WriteLine("Senha fraca. Tente novamente.");
            }
        }
    }
}
*/