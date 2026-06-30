using System;

namespace PackageExpressAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display the welcome message to the user.
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // Ask the user to enter the package weight.
            Console.WriteLine("Please enter the package weight:");

            // Convert the user's input from a string to a decimal number.
            decimal weight = Convert.ToDecimal(Console.ReadLine());

            // Check if the package weight is greater than 50.
            if (weight > 50)
            {
                // Display an error message if the package is too heavy.
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");

                // Keep the console window open until the user presses Enter.
                Console.ReadLine();

                // End the program.
                return;
            }

            // Ask the user to enter the package width.
            Console.WriteLine("Please enter the package width:");

            // Convert the user's input from a string to a decimal number.
            decimal width = Convert.ToDecimal(Console.ReadLine());

            // Ask the user to enter the package height.
            Console.WriteLine("Please enter the package height:");

            // Convert the user's input from a string to a decimal number.
            decimal height = Convert.ToDecimal(Console.ReadLine());

            // Ask the user to enter the package length.
            Console.WriteLine("Please enter the package length:");

            // Convert the user's input from a string to a decimal number.
            decimal length = Convert.ToDecimal(Console.ReadLine());

            // Add the width, height, and length together to get the total dimensions.
            decimal totalDimensions = width + height + length;

            // Check if the total dimensions are greater than 50.
            if (totalDimensions > 50)
            {
                // Display an error message if the package is too large.
                Console.WriteLine("Package too big to be shipped via Package Express.");

                // Keep the console window open until the user presses Enter.
                Console.ReadLine();

                // End the program.
                return;
            }

            // Multiply the width, height, and length together.
            decimal dimensionProduct = width * height * length;

            // Multiply the dimension product by the package weight.
            decimal shippingTotal = dimensionProduct * weight;

            // Divide the shipping total by 100 to get the shipping quote.
            decimal quote = shippingTotal / 100;

            // Display the shipping quote as a dollar amount with two decimal places.
            Console.WriteLine("Your estimated total for shipping this package is: $" + quote.ToString("0.00"));

            // Display a thank you message.
            Console.WriteLine("Thank you!");

            // Keep the console window open until the user presses Enter.
            Console.ReadLine();
        }
    }
}
