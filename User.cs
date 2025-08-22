namespace MyFirstCSharpApp
{
    class User
    {
        readonly Random random = new();
        public int rnd;
        private readonly List<int> numbers = [];
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
                    Console.WriteLine($"Ошибка, вы ввели не целое число. Введите ещё раз.");
                    i--;
                }
            }

            PrintInfo();
        }

        // Вычисление суммы через метод
        public virtual void PrintInfo()
        {
            int sum = 0;
            rnd = random.Next(1, 4);
            switch (rnd)
            {
                case 1:
                    {
                        sum = CalculateSum();
                    }
                    break;
                case 2:
                    {
                        sum = CalculateMultiplication();
                    }
                    break;

                case 3:
                    {
                        sum = CalculateAverage();
                    }
                    break;
                default:
                    break;
            }

            Console.WriteLine($"\nВведенные числа: {string.Join(", ", numbers)}");
            if (sum >= 0)
                Console.WriteLine($"Итого: {sum}");
            else if (sum < 0)
                Console.WriteLine("Сумма слишком велика");
        }
        // Метод для вычисления суммы
        private int CalculateSum()
        {
            int total = 0;
            foreach (int num in numbers)
            {
                total += num;
            }
            return total;
        }
        // Метод для вычисления суммы
        private int CalculateMultiplication()
        {
            int total = 0 + numbers[0];
            bool skip = true;
            foreach (int num in numbers)
            {
                if (skip)
                {
                    skip = false;
                    continue;
                }
                    
                total *= num;
            }
            return total;
        }
        // Метод для вычисления суммы
        private int CalculateAverage()
        {
            return (int)numbers.Average();
        }
    }   
}