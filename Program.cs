// See https://aka.ms/new-console-template for more information

class Program{
    static void Main(){
        int bandera = 0;
        int operacion;
        int aux = 0;

        while (bandera == 0)
        {
            Console.WriteLine("1. Sumar\n2. Restar\n3. Multiplicar\n4. Dividir");
            aux = Convert.ToInt32(Console.Read());
            Console.Clear();
            
            Console.WriteLine("Ingresar el primer numero: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Ingresar el segundo numero: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            switch (aux)
            {
                case 1:
                    operacion = x + y;
                    break;
                case 2:
                    operacion = x - y;
                    break;
                case 3:
                    operacion = x * y;
                    break;
                case 4:
                    operacion = x / y;
                    break;
            }
        }
    }
}