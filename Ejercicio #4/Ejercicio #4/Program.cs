namespace Ejercicio__4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double rad, result;
            Console.WriteLine("Calculo del area de un circulo");
            Console.WriteLine("Ingrese el radio del circulo");
            rad=double.Parse(Console.ReadLine());
            
            result= Math.PI*Math.Pow(2,rad);
            Console.WriteLine("El area del circulo es " + result);

            
        }
    }
}
