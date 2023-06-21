using System;

namespace openClose
{
    class Program
    {
        static void Main(string[] args)
        {
            PermanentEmployee john = new PermanentEmployee(1, "John");
            TempEmployee david = new TempEmployee(2, "David");

            Console.WriteLine($"employee{john.ToString()}, John Bonus: {john.CalculateBonus(10000).ToString()}");
            Console.WriteLine($"employee{david.ToString()}, David Bonus: {david.CalculateBonus(15000).ToString()}");
        }
    }
}
