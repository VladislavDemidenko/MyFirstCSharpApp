namespace MyFirstCSharpApp
{
    class Calculator : User
    {
        public string OperationType = "";

        // Переопределенный метод
        public override void PrintInfo()
        {
            base.PrintInfo(); // Вызов метода родителя
            switch (rnd)
            {
                case 1:
                    {
                        OperationType = "Вычисление суммы";
                    }
                    break;
                case 2:
                    {
                        OperationType = "Вычисление произведения";
                    }
                    break;

                case 3:
                    {
                        OperationType = "Вычисление среднего";
                    }
                    break;
                default:
                    break;
            }

            Console.WriteLine($"Тип операции: {OperationType}");
        }
    }
}