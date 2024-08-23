namespace Ejercicio__3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float num1, num2, result;
            Console.WriteLine("Suma de dos numeros");
            Console.WriteLine("Ingrese primer numero entero");
            num1= float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero entero");
            num2= float.Parse(Console.ReadLine());

            result = num1 + num2;
            Console.WriteLine("El resultado es " + result);
            
        }
    }
}
