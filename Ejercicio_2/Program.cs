using System.Data;

namespace Ejercicio_2
{
    public class Program
    {
        public static void Main()
        {
            int a = Sumar(5, 6);
            Console.WriteLine(a);
         
        }

        public static int Sumar(int a, int b)
        {
            return a + b;
        }
    }
}
