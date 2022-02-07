using System;

namespace Class4._1
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

                Console.WriteLine("Allowed actions: '1' means '+', 2 means '-', 3 means '*', 4 means '/'");
                var isActionValid = int.TryParse(Console.ReadLine(), out var action);
                if (!isActionValid)
                {
                    Console.WriteLine("Please, use only a certain set of actions: 1, 2, 3 and 4");
                    break;
                }

                int? result = null;

                switch (action)
                {
                    case 1:
                        result = x + y;
                        break;
                    case 2:
                        result = x - y;
                        break;
                    case 3:
                        result = x * y;
                        break;
                    case 4:
                        if (y == 0)
                        {
                            Console.WriteLine("Divided by zero is prohibited!");
                            break;
                        }
                        result = x / y;
                        break;
                    default:
                        Console.WriteLine("Please, use only a certain set of actions: '1' means '+', 2 means '-', 3 means '*', 4 means '/'");
                        break;
                }

                if (result != null) Console.WriteLine($"\nResult: {result}");

                Console.ReadLine();
            }
        }
    }
}
