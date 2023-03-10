namespace Task_9._3._7
{
    internal class Program
    {
        delegate void ShowMessageDelegate();
        delegate int SumDelegate(int a, int b, int c);
        delegate bool CheckLengthDelegate(string _row);
        static void Main(string[] args)
        {
            ShowMessageDelegate showMessage = ShowMessage;
            showMessage();

            SumDelegate sum = Sum;
            Console.WriteLine(sum(1, 2, 3));

            CheckLengthDelegate checkLength = CheckLength;
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