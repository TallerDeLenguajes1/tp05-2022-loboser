// See https://aka.ms/new-console-template for more information
using System;
using System.Text.RegularExpressions;
namespace tp05
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena;

			Regex web = new Regex(@"(https?:\/\/)?(www\.)[-a-zA-Z0-9@:%._\+~#=]{2,256}\.[a-z]{2,4}\b([-a-zA-Z0-9@:%_\+.~#?&//=]*)|(https?:\/\/)?(www\.)?(?!ww)[-a-zA-Z0-9@:%._\+~#=]{2,256}\.[a-z]{2,4}\b([-a-zA-Z0-9@:%_\+.~#?&//=]*)");
			Regex email = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");

			Console.WriteLine("Ingrese un link: ");
			cadena = Console.ReadLine();

			if (web.IsMatch(cadena))
			{
				Console.WriteLine("\nEl link \"" + cadena + "\" es valido");
			}
			else
			{
				Console.WriteLine("\nEl link \"" + cadena + "\" es invalido");
			}

			Console.WriteLine("\nIngrese un email: ");
			cadena = Console.ReadLine();

			if (email.IsMatch(cadena))
			{
				Console.WriteLine("\nEl Mail \"" + cadena + "\" es valido");
			}
			else
			{
				Console.WriteLine("\nEl Mail \"" + cadena + "\" es invalido");
			}
        }
    }
}