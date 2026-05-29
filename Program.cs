using System;

// Namespace groups related classes together
namespace PackageExpress
{
    // Main class of the application
    class Program
    {
        // Main method is the entry point of the program
        static void Main(string[] args)
        {
            // Display welcome message
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // Ask the user for the package weight
            Console.WriteLine("Please enter the package weight:");

            // Convert user input into a decimal data type
            decimal weight = Convert.ToDecimal(Console.ReadLine());

            // Check if the package is too heavy
            if (weight > 50)
            {
                // Display error message if weight exceeds limit
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");

                // End the program
                Console.ReadLine();
                return;
            }

            // Ask the user for the package width
            Console.WriteLine("Please enter the package width:");

            // Store width value
            decimal width = Convert.ToDecimal(Console.ReadLine());

            // Ask the user for the package height
            Console.WriteLine("Please enter the package height:");

            // Store height value
            decimal height = Convert.ToDecimal(Console.ReadLine());

            // Ask the user for the package length
            Console.WriteLine("Please enter the package length:");

            // Store length value
            decimal length = Convert.ToDecimal(Console.ReadLine());

            // Calculate the total dimensions
            decimal dimensionsTotal = width + height + length;

            // Check if the package dimensions are too large
            if (dimensionsTotal > 50)
            {
                // Display error message
                Console.WriteLine("Package too big to be shipped via Package Express.");

                // End the program
                Console.ReadLine();
                return;
            }

            // Calculate the shipping quote
            // Multiply dimensions together, multiply by weight, then divide by 100
            decimal quote = (width * height * length * weight) / 100;

            // Display the quote formatted as currency
            Console.WriteLine("Your estimated total for shipping this package is: $" + quote.ToString("0.00"));

            // Thank the user
            Console.WriteLine("Thank you!");

            // Prevent the console window from closing immediately
            Console.ReadLine();
        }
    }
}
