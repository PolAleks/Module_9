namespace Task_9._3._12
{
    internal class Program
    {
        delegate void ShowMessageDelegate(string name);
        static void Main(string[] args)
        {
            ShowMessageDelegate smd = (string _name) => { Console.WriteLine(_name); };
            
            smd.Invoke("Hello world!");
        }
    }
}