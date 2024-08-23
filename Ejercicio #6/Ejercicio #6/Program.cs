using System.ComponentModel.Design;

namespace Ejercicio__6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Escriba un numero entero");
            num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("Su numero es par");
            }
            else
            {
                Console.WriteLine("Su numero es impar");
            }
        }
    }
}
