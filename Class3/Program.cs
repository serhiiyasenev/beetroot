using System;

namespace Class3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input x:");
            var x = int.Parse(Console.ReadLine());
            Console.WriteLine("Input y:");
            var y = int.Parse(Console.ReadLine());

            var first = -6 * Math.Pow(x, 3) + 5 * Math.Pow(x, 2) - 10 * x +15;
            var second = Math.Abs(x) * Math.Sin(x);
            var third = 2 * Math.PI * x;
            var fourth = Math.Max(x, y);

            Console.WriteLine($"first: '{first}'");
            Console.WriteLine($"second: '{second}'");
            Console.WriteLine($"third: '{third}'");
            Console.WriteLine($"fourth: '{fourth}'");

            var daysToNewYear = (new DateTime(DateTime.Today.Year, 12, 31) - DateTime.Today).Days;
            Console.WriteLine($"'{daysToNewYear}' days left to New Year");

            var daysPassedFromNewYear = (DateTime.Today - new DateTime(DateTime.Today.Year, 1, 1)).Days;
            Console.WriteLine($"'{daysPassedFromNewYear}' days passed from New Year");

            Console.ReadKey();
        }
    }
}
