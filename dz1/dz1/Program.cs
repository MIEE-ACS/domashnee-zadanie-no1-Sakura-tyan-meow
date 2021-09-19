using System;

namespace dz1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("введите число");
            
            int m = Convert.ToInt32(Console.ReadLine());
            int a = m % 10000 / 1000;
            Console.WriteLine( $"разряд тысяч : {a}");
        }
    }
}
