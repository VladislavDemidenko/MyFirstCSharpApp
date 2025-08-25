namespace MyFirstCSharpApp
{
    class Calculator : User
    {
        private string OperationType = "";

        // Переопределенный метод
        public override void PrintInfo(string operations)
        {
            int sum = 0;
            switch (operations)
            {
                case "+":
                    {
                        sum = CalculateSum();
                        OperationType = "Вычисление суммы";
                    }
                    break;
                case "*":
                    {
                        sum = CalculateMultiplication();
                        OperationType = "Вычисление произведения";
                    }
                    break;

                case "x":
                    {
                        sum = CalculateAverage();
                        OperationType = "Вычисление среднего";
                    }
                    break;
                default:
                    break;
            }

            Console.WriteLine($"Тип операции: {OperationType}");

            Console.WriteLine($"\nВведенные числа: {string.Join(", ", numbers)}");
            if (sum >= 0)
                Console.WriteLine($"Итого: {sum}");
            else if (sum < 0)
                Console.WriteLine("Полученное значение слишком велико");
        }

        // Метод для вычисления суммы
        private int CalculateSum()
        {
            int total = 0;
            try
            {
                foreach (int num in numbers)
                {
                    checked
                    {
                        total += num;
                    }
                }
            }
            catch (OverflowException)
            {
                total = -1;
            }
            return total;
        }
        // Метод для вычисления произведения
        private int CalculateMultiplication()
        {
            int total = 0 + numbers[0];
            bool skip = true;
            try
            {
                foreach (int num in numbers)
                {
                    if (skip)
                    {
                        skip = false;
                        continue;
                    }

                    checked // Не знал про такой код, нашёл в интернете
                    {
                        total *= num;
                    }
                }
            }
            catch (OverflowException)
            {
                total = -1;
            }

            return total;
        }
        // Метод для вычисления среднего
        private int CalculateAverage()
        {
            return (int)numbers.Average();
        }
    }
}