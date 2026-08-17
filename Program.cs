namespace C__Fundamental.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)

        {
            string[] data = Console.ReadLine().Split();
            long x, y;
            x = int.Parse(data[0]);
            y = int.Parse(data[1]);
            Console.WriteLine($"{x} + {y} = {x + y}");
            Console.WriteLine($"{x} * {y} = {x * y}");
            Console.WriteLine($"{x} - {y} = {x - y}");
        }
    }
}























