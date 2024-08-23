using System.Timers;

namespace Ejercicio__7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, numM;
            Console.WriteLine("Escriba un numero entero");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Escriba otro numero entero");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Escriba otro numero entero");
            num3 = int.Parse(Console.ReadLine());

            numM = num1;
            if (num2>numM)
            {
                numM = num2;   
            }
            if (num3 > numM)
            {
                numM = num3;
               
            }
            Console.WriteLine("El numero mayor es: " + numM);
        }
    }
}
