using System;

class Program
{
    static void Main()
    {
        int[] numbers = new int[5];
        Console.WriteLine("Введите 5 чисел:");

        // Запрос чисел
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Число {i+1}: ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        // Вычисление суммы через метод
        int sum = CalculateSum(numbers);
        
        Console.WriteLine($"\nВведенные числа: {string.Join(", ", numbers)}");
        Console.WriteLine($"Сумма чисел: {sum}");
    }

    // Метод для вычисления суммы
    static int CalculateSum(int[] array)
    {
        int total = 0;
        foreach (int num in array)
        {
            total += num;
        }
        return total;
    }
}