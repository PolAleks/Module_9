namespace Task_9._4._2
{
    internal class Program
    {
        public delegate Car CarHandler();

        public static Lexus GetLexus()
        {
            return new Lexus();
        }
        static void Main(string[] args)
        {
            CarHandler carHandler = GetLexus;
            carHandler.Invoke();
        }
    }
    class Car 
    {
        public string Model { get; set; }
    }
    class Lexus : Car { }
}