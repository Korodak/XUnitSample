namespace XUnitSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            var calculator = new Calculator();

            Console.WriteLine($"Suma 1+2 = {calculator.Add(1, 2)}");
            Console.WriteLine($"Odejmowanie 1-2 = {calculator.Subtract(1, 2)}");
            Console.WriteLine($"Dzielenie 1/2 = {calculator.Divide(1, 2)}");
            Console.WriteLine($"Test User length = {calculator.AddUser("12345678")}");
            Console.WriteLine($"Test ą = {calculator.AddUser("Anąta")}");
            Console.WriteLine($"Test OK User = {calculator.AddUser("Jan")}");


            Console.ReadLine();
        }
    }
}