namespace Task_9._3._13
{
    internal class Program
    {
        delegate int RandomNumberDelegate();
        static void Main(string[] args)
        {
            RandomNumberDelegate rnd = delegate()
            {
                return new Random().Next(0, 100);
            };
            Console.WriteLine(rnd.Invoke());
        }
    }
}