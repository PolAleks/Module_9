namespace Task_9._2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw new RankException("Ошибка!");
            }
            catch(RankException e)
            {
                Console.WriteLine(e.GetType());
            }
            finally
            {
                Console.WriteLine("Конец программы!");
            }
        }
    }
}