using System;

// See https://aka.ms/new-console-template for more information
namespace tp05
{
    class Program
    {
        static void Main(string[] args)
        {
            int bandera = 0;
            int aux = 0;    
            int x;
            int y;

            while (bandera == 0)
            {
                Console.WriteLine("1. Sumar\n2. Restar\n3. Multiplicar\n4. Dividir");
                aux = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingresar el primer numero: ");
                x = Convert.ToInt32(Console.ReadLine()); 

                Console.WriteLine("Ingresar el segundo numero: ");
                y = Convert.ToInt32(Console.ReadLine());

                switch (aux)
                {
                    case 1:
                        Console.WriteLine(x + y);
                        break;
                    case 2:
                        Console.WriteLine(x - y);
                        break;
                    case 3:
                        Console.WriteLine(x * y);
                        break;
                    case 4:
                        Console.WriteLine(x / y);
                        break;
                }

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
                x = Convert.ToInt32(Console.ReadLine()); 

                Console.WriteLine("Ingresar el segundo numero: ");
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
