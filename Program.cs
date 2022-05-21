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

			Regex web = new Regex(@"https?://\w+(\.\w+)*(\.\w{2,4})");
			Regex email = new Regex(@"(\w+\.?\w*)+(\@\w+)(\.\w{2,4})+");

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