namespace MyFirstCSharpApp
{
    static class User
    {
        public static void UserCalculate(int BaseNumber)
        {
            List<int> numbers = [];
            Console.WriteLine($"Введите {BaseNumber} чисел:");

            // Запрос чисел
            for (int i = 0; i < BaseNumber; i++)
            {
                Console.Write($"Число {i + 1}: ");
                try
                {
                    numbers.Add(Convert.ToInt32(Console.ReadLine()));
                }
                catch (Exception)
                {
                    Console.WriteLine($"Ошибка, вы ввели не целое число. Введите ещё раз.");
                    i--;
                }
            }

            // Вычисление суммы через метод
            int sum = CalculateSum(numbers);

            Console.WriteLine($"\nВведенные числа: {string.Join(", ", numbers)}");
            Console.WriteLine($"Сумма чисел: {sum}");
        }
        // Метод для вычисления суммы
        private static int CalculateSum(List<int> list)
        {
            int total = 0;
            foreach (int num in list)
            {
                total += num;
            }
            return total;
        }
    }   
}