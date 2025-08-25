using System.Runtime.CompilerServices;

namespace MyFirstCSharpApp
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите количество переменных");
            int BaseNumber;
            while (true)
            {
                try
                {
                    BaseNumber = int.Parse(Console.ReadLine()?.ToString() ?? "NULL");
                    if (BaseNumber >= 2)
                        break;
                    Console.WriteLine("Попробуйте ещё раз");
                }
                catch (Exception)
                {
                    Console.WriteLine("Попробуйте ещё раз");
                }
            }
            Calculator userCalc = new();
            userCalc.UserManagement(BaseNumber);
        }
    }   
}