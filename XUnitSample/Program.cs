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


            Console.ReadLine();
        }
    }
}