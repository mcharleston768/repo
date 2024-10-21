namespace DivisionAndConversionExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter the first number: ");
            string firstnum = Console.ReadLine();

            Console.Write("Enter the second number: ");
            string secondnum = Console.ReadLine();

            DivideAndConvert(firstnum, secondnum);
        }

        static void DivideAndConvert(string num1, string num2)
        {
            try
            {
                int number1 = int.Parse(num1);
                int number2 = int.Parse(num2);

                int quotient = number1 / number2;

                Console.WriteLine($"The dividen result is: {quotient}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Error: Please enter valid integers.");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An unexpected error occurred: {ex.Message}");

                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();

            }
        }
    }
}