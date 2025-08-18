using System;

class Program
{
    static void Main(string[] args)
    {
        // 1. Запрашиваем имя
        Console.Write("Введите ваше имя: ");
        string name = Console.ReadLine(); // Читаем введёную строку

        // 2. Запрашиваем возраст
        Console.Write("Введите ваш возраст:");
        int age = Convert.ToInt32(Console.ReadLine()); // Читаем строку и преобразуем в число

        // 3. Выводим приветствие
        Console.WriteLine($"Привет, {name}!");

        // 4. Проверяем совершеннолетие и выводим результат
        if (age >= 18)
        {
            Console.WriteLine("Вы совершеннолетний.");
        }
        else
        {
            Console.WriteLine("Вы несовершеннолетний.");
        }
    }
}