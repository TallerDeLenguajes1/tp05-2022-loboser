// See https://aka.ms/new-console-template for more information
using System;
namespace tp05
{
    class Program
    {
        static void Main(string[] args)
        {
            int longitudDeCadena;
            string cadena1, cadena2;
            int resultado;

            Console.WriteLine("Ingrese una cadena de caracteres: ");
            cadena1 = Console.ReadLine();
            longitudDeCadena = cadena1.Length;


            cadena2 = "Algunas letras de la cadena: ";

            for (int i = 0; i < longitudDeCadena; i++)
            {
                cadena2 += cadena1[i] + " ";
                i+= 2;
            }

            Console.WriteLine(cadena2);
            Console.WriteLine("Longitud de la cadena: " + longitudDeCadena);

            Console.WriteLine("\nIngrese otra cadena de caracteres: ");
            cadena2 = Console.ReadLine();

            cadena1 = String.Concat(cadena1,cadena2);
            Console.WriteLine("\nCadenas Concatenadas: " + cadena1);
            
            cadena1 = cadena1.Substring(0, longitudDeCadena);
            Console.WriteLine("\nSubcadena: " + cadena1);
        }
    }
}