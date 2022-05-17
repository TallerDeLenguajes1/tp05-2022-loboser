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

            while (bandera == 0)
            {
                Console.WriteLine("1. Sumar\n2. Restar\n3. Multiplicar\n4. Dividir");
                aux = Convert.ToInt32(Console.ReadLine());
                        
                Console.WriteLine("Ingresar el primer numero: ");
                int x;
                x = Convert.ToInt32(Console.ReadLine()); 

                Console.WriteLine("Ingresar el segundo numero: ");
                int y;
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

                Console.WriteLine("Desea realizar otro calculo? (1 = Si)");
                int i = Convert.ToInt32(Console.ReadLine());
                if(i != 1){
                    bandera++;
                }
            }
        }
    }
}
