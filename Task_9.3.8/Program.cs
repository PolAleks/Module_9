namespace Task_9._3._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Action showMessage = ShowMessage;
            showMessage();

            Func<int, int, int, int> sum = Sum;
            int result = sum.Invoke(10, 20, 30);
            Console.WriteLine(result);

            Predicate<string> checkLength = CheckLength;
            Console.WriteLine(checkLength.Invoke("Hell0"));
        }

        static void ShowMessage()
        {
            Console.WriteLine("Привет МИР!");
        }

        static int Sum(int a, int b, int c)
        {
            return a + b + c;
        }

        static bool CheckLength(string _row)
        {
            if (_row.Length > 3)
                return true;
            return false;
        }
    }
}