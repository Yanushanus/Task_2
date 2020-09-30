using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter your c: ");
            long c = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine($" Your A= {a}\n Your B= {b}\n Your C= {c}");
        }
    }
}
