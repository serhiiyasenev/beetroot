using System;

namespace Class4
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Input X:");
                var isValidX = int.TryParse(Console.ReadLine(), out var x);
                if (!isValidX)
                {
                    Console.WriteLine("Invalid input X!");
                    break;
                }

                Console.WriteLine("Input Y:");
                var isValidY = int.TryParse(Console.ReadLine(), out var y);
                if (!isValidY)
                {
                    Console.WriteLine("Invalid input Y!");
                    break;
                }

                var a = Math.Min(x, y);
                var b = Math.Max(x, y);

                var result = 0;

                for (var temp = a; temp <= b; temp++)
                {
                    result += temp;
                }

                Console.WriteLine($"\nSum x...y: {result}");

                Console.ReadLine();
            }

        }
    }
}
