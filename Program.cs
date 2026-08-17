namespace C__Fundamental.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)

        {
            string[] input = Console.ReadLine().Split();

            int a = int.Parse(input[0]);
            long b = long.Parse(input[1]);
            char c = char.Parse(input[2]);
            float d = float.Parse(input[3]);
            double e = double.Parse(input[4]);

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
        }
    }
}























