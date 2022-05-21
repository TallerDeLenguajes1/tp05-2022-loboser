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
            string[] string_aux;


            Console.WriteLine("Ingrese una cadena de caracteres: ");
            cadena1 = Console.ReadLine();
            longitudDeCadena = cadena1.Length;
            
            //Algunas palabras de la cadena

            cadena2 = "Algunas letras de la cadena: ";

            for (int i = 0; i < longitudDeCadena; i++)
            {
                cadena2 += cadena1[i] + " ";
                i+= 2;
            }
            Console.WriteLine(cadena2);

            //Longitud de la cadena

            Console.WriteLine("Longitud de la cadena: " + longitudDeCadena);

            //Concatenar

            Console.WriteLine("\nIngrese otra cadena de caracteres: ");
            cadena2 = Console.ReadLine();
            cadena1 = String.Concat(cadena1,cadena2);
            Console.WriteLine("\nCadenas Concatenadas: " + cadena1);

            //Substring
            
            cadena1 = cadena1.Substring(0, longitudDeCadena);
            Console.WriteLine("\nSubcadena: " + cadena1);

            //Calculadora

            Calculadora();

            //Foreach

            
            foreach(char c in cadena1)
            {
                Console.Write(c + " ");
            }

            //Busqueda

            Console.WriteLine("\n\nIngrese una cadena para buscar en la primera: ");
            cadena2 = Console.ReadLine();
            if (cadena1.Contains(cadena2))
            {
                Console.WriteLine("Busqueda exitosa! (La cadena contiene a la que busco)");
            }
            else
            {
                Console.WriteLine("Busqueda fallida! (La cadena no contiene a la que busco)");
            }

            //Mayusculas y Minusculas

            Console.WriteLine($"\nCadena convertida en Mayusculas: {cadena1.ToUpper()}");
            Console.WriteLine($"Cadena convertida en Minusculas: {cadena1.ToLower()}");

            //Comparar

            Console.WriteLine("\nCadena para comparar: ");
            cadena2 = (Console.ReadLine());

            if (cadena1.CompareTo(cadena2) == 0)
            {
                Console.WriteLine("Las cadenas son iguales");
            }
            else
            {
                Console.WriteLine("Las cadenas son distintas");
            }
            
            //Split

            Console.WriteLine("\nIngrese una cadena separada por algun caracter: ");
            cadena2 = Console.ReadLine();

            Console.Write("\nIngrese el caracter separador de la cadena: ");
            string_aux = cadena2.Split(Console.ReadLine());
            
            Console.Write("\nCadena sin el separador: ");
            foreach (string s in string_aux)
            {
                Console.Write(s);
            }

            //Expresiones con operadores integrados

            Console.Write("\nIngrese una expresion sin espacios y de enteros para operar con (+, -, *, /), por ejemplo 100+10: ");
            cadena2 = Console.ReadLine();

            if (cadena2.Contains('+'))
            {
                string[] numero = cadena2.Split('+');
                Console.WriteLine($"La SUMA de {numero[0]} y {numero[1]} es igual a: {Convert.ToSingle(numero[0])+Convert.ToSingle(numero[1])}");
            }
            else if (cadena2.Contains('-'))
            {
                string[] numero = cadena2.Split('-');
                Console.WriteLine($"La RESTA de {numero[0]} y {numero[1]} es igual a: {Convert.ToSingle(numero[0])-Convert.ToSingle(numero[1])}");
            }
            else if (cadena2.Contains('*'))
            {
                string[] numero = cadena2.Split('*');
                Console.WriteLine($"La MULTIPLICACION de {numero[0]} por {numero[1]} es igual a: {Convert.ToSingle(numero[0])*Convert.ToSingle(numero[1])}");
            }
            else if (cadena2.Contains('/'))
            {
                string[] numero = cadena2.Split('/');
                if ((Convert.ToDouble(numero[1]) != 0))
                {
                    Console.WriteLine($"La DIVISION de {numero[0]} entre {numero[1]} es igual a: {Convert.ToSingle(numero[0])/Convert.ToSingle(numero[1])}");
                }
                else
                {
                    Console.WriteLine("\nNo se puede DIVIDIR en 0");
                }
            }
        }

        public static void Calculadora()
        {
            int aux, x, y;

            do
            {
                Console.WriteLine("\n\n1. Sumar\n2. Restar\n3. Multiplicar\n4. Dividir");
                aux = Convert.ToInt32(Console.ReadLine());
            } while (aux > 4 || aux < 1);

            Console.WriteLine("Ingresar el primer numero: ");
            x = Convert.ToInt32(Console.ReadLine()); 

            Console.WriteLine("Ingresar el segundo numero: ");
            y = Convert.ToInt32(Console.ReadLine());

            switch (aux)
            {
                case 1:
                    Console.WriteLine($"\nLa Suma entre {x} y de {y} es igual a: {x+y}\n\n");
                    break;
                case 2:
                    Console.WriteLine($"\nLa Resta entre {x} y de {y} es igual a: {x-y}\n\n");
                    break;
                case 3:
                    Console.WriteLine($"\nLa Multiplicacion entre {x} y de {y} es igual a: {x*y}\n\n");
                    break;
                case 4:
                    if (y != 0)
                    {
                        Console.WriteLine($"\nLa Division entre {x} y de {y} es igual a: {x/y}\n\n");
                    }
                    else
                    {
                        Console.WriteLine("\nNo se puede dividir entre 0\n\n");
                    }
                break;
            }
        }
    }
}