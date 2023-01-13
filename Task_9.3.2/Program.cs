namespace Task_9._3._2
{
    internal class Program
    {
        static int Differece (int a, int b)
        {
            return b - a;
        }

        public delegate int Result( int x, int y );

        static void Main(string[] args)
        {
            Result result = Differece;
            Console.WriteLine(result.Invoke(10, 20));

        }
    }
}