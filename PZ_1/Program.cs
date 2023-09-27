namespace PZ_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 0;
            double b = 4;
            double c = 1;
            double result;

            result = 1.5 * Math.Pow(a - b, 2) / (Math.Abs(a - b) * c) + Math.Pow(10, 4) * Math.Sqrt(Math.Abs(a - b)) - 2.5 * (Math.Pow(a, 2) + 2.75) * Math.Sin(-2 * a) / 3 + Math.Pow(a, 2) * b * c;

            Console.WriteLine(result);
        }
    }
}