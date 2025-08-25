using System.Text;

namespace MyFirstCSharpApp
{
    abstract class User
    {
        public readonly List<int> numbers = [];
        public void UserManagement(int BaseNumber)
        {
            Console.WriteLine($"Введите {BaseNumber} чисел:");

            // Запрос чисел
            for (int i = 0; i < BaseNumber; i++)
            {
                Console.Write($"Число {i + 1}: ");
                try
                {
                    //numbers.Add(random.Next(1, 1001));
                    numbers.Add(Convert.ToInt32(Console.ReadLine()));
                }
                catch (Exception)
                {
                    Console.WriteLine("Ошибка, вы ввели не целое число. Введите ещё раз.");
                    i--;
                }
            }

            Console.WriteLine("Введите тип операции ( * + x ):");
            bool operationsWhile = true;
            while (operationsWhile)
            {
                string operations = Console.ReadLine()?.ToString() ?? "NULL";

                if (operations == "*" || operations == "+" || operations == "x")
                {
                    PrintInfo(operations);
                    operationsWhile = false;
                }
                else
                {
                    Console.WriteLine("Введите любой из перечисленного символа. ( * / x )");
                }
            }
        }

        // Вычисление суммы через метод
        public abstract void PrintInfo(string operations);
    }
}