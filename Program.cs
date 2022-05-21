// See https://aka.ms/new-console-template for more information

using System;

// See https://aka.ms/new-console-template for more information
namespace tp05
{
    class Program
    {
        static void Main(string[] args)
        {
            int bandera = 0;

            while (bandera == 0)
            {
                double num;
                Console.WriteLine("Ingresar un Numero: ");
                num = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine($"Valor Abosoluto: {Math.Abs(num)}" );
                Console.WriteLine($"Al Cuadrado: {Math.Pow(num,2)}" );
                Console.WriteLine($"Raiz Cuadrada: {Math.Sqrt(num)}" );
                Console.WriteLine($"Seno: {Math.Sin(num)}" );
                Console.WriteLine($"Coseno: {Math.Cos(num)}" );
                Console.WriteLine($"Parte Entera: {Math.Truncate(num)}\n" );



                Console.WriteLine("Ingresar el primer numero: ");
                int x;
                x = Convert.ToInt32(Console.ReadLine()); 

                Console.WriteLine("Ingresar el segundo numero: ");
                int y;
                y = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"\nNumero Maximo: {Math.Max(x,y)}\n" );
                Console.WriteLine($"Numero Minimo: {Math.Min(x,y)}\n" );
                

                Console.WriteLine("Desea realizar otro calculo? (1 = Si)");
                int i = Convert.ToInt32(Console.ReadLine());
                if(i != 1){
                    bandera++;
                }
            }
        }
    }
}
