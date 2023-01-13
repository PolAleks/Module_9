namespace Task_9._3._4
{
    internal class Program
    {
        delegate void Calculate(int a, int b);
        static void Main(string[] args)
        {
            Calculate calc = Difference;
            calc += Sum;

            calc.Invoke(10, 20);
        }

        static void Difference (int a, int b)
        {
            int c = b - a;
            Console.WriteLine(c);
        }

        static void Sum (int a, int b)
        {
            int c = a + b;
            Console.WriteLine(c);
        }
    }
}