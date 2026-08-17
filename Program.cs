namespace C__Fundamental.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)

        {
            string[] data = Console.ReadLine().Split();
            long a, b;
            a = long.Parse(data[0]);
            b = long.Parse(data[1]);

            a %= 10;

            b %= 10;

            Console.WriteLine(b + a);



        }
    }
}


























