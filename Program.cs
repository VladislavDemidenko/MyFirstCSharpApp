namespace MyFirstCSharpApp
{
    class Program
    {
        private const int BaseNumber = 5;
        static void Main()
        {
            User user = new();
            user.UserManagement(BaseNumber);

            Console.WriteLine("\n\n");

            Calculator userCalc = new();
            userCalc.UserManagement(BaseNumber);
        }
    }   
}