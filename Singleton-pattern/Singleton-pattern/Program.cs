using System;

namespace Singleton_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start.");

            var obj1 = Singleton.GetInstance();
            var obj2 = Singleton.GetInstance();

            if(obj1.Equals(obj2))
            {
                Console.WriteLine($"{ nameof(obj1) } and { nameof(obj2) } are the same.");
            }
            else
            {
                Console.WriteLine($"{ nameof(obj1) } and { nameof(obj2) } are not the same.");
            }

            Console.WriteLine("End.");
            Console.ReadLine();
        }
    }
}
