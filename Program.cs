// See https://aka.ms/new-console-template for more information
using System;
namespace tp05
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, inverso = 0;

			Console.WriteLine("Ingrese un numero: ");
			numero = Convert.ToInt32(Console.ReadLine());

			if (numero > 0)
			{
				while (numero > 0)
				{
					inverso = inverso * 10 + numero % 10;
					numero = numero / 10;
				}
			}
			else
			{
				inverso = numero;
			}

			Console.WriteLine("Numero invertido: " + inverso);
        }
    }
}