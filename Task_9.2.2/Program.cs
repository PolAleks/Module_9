namespace Task_9._2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw new ArgumentOutOfRangeException("Былли введены некорректные данные!");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.ParamName);
            }
            finally
            {
                Console.WriteLine("Работа приложения завершена!");
            }
        }
    }
}