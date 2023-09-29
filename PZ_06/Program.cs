namespace PZ_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] massive = new double[20];
            for (int i = 0; i < 20; i++)
            {
                massive[i] = Math.Pow(2, i) / 2;
            }
            Array.Sort(massive);
            Array.Reverse(massive);
            Console.Write("\nМассив в порядке уменьшения: ");
            foreach(double j in massive) 
            {
                Console.Write($"{j} ");
            }
        }
    }
}