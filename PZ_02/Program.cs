namespace PZ_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите m: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите n: ");
            double n = Convert.ToDouble(Console.ReadLine());
            double x, y, z = 0;
            if (m > 5)
            {
                x = Math.Sin(m + n);
            }
            else
            {
                x = n + 5 * Math.Sqrt(m * Math.Pow(n, 2) - 2.1 * n);
            }
            if (x <= 0)
            {
                y = Math.Log(m * n + x);
            }
            else
            {
                y = Math.Cos(m * x) * Math.Sin(n * x);
            }
            if(Math.Pow(m, 2) + 5 != 0)
            {
                z = (2 * x + 3 * y) / (Math.Pow(m, 2) + 5);
            }
            Console.WriteLine($"m = {m}");
            Console.WriteLine($"n = {n}");
            Console.WriteLine($"x = {x}");
            Console.WriteLine($"y = {y}");
            Console.WriteLine($"z = {z}");

        }
    }
}