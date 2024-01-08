namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Welcome to the temperature converter!");
            Console.WriteLine("Press 1 to convert F to C. Press 2 to convert C to F.");

            var userChoice = Console.ReadLine();
            if(userChoice == "1")
            {
                Console.WriteLine("We'll convert F to C.");
                Console.WriteLine("Enter the temperature in fahrenheit you wish to convert.");
                decimal temp = decimal.Parse(Console.ReadLine());
                Console.WriteLine(TempConverter.FahrenheitToCelsius(temp));
         
            }
            else if (userChoice == "2")
            {
                Console.WriteLine("We'll convert C to F.");
                Console.WriteLine("Enter the temperature in celsius you wish to convert.");
                decimal temp = decimal.Parse(Console.ReadLine());
                Console.WriteLine(TempConverter.CelsiusToFahrenheit(temp));
            }
            else
            {
                Console.WriteLine("Please choose either 1 or 2.");
            }
        }
    }
}
