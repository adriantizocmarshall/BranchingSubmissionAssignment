using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingSubmissionAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Planet Express! Please follow the instructions below.");
            Console.ReadLine(); // Additional ReadLine() statements throughout for cleanliness of console
            Console.WriteLine("Please enter the weight of your package in pounds.");
            string weight = Console.ReadLine(); // Stores weight as a string for later integer conversion
            Console.ReadLine();
            if (Convert.ToInt32(weight) < 50) // Checks if entered weight is less than or equal to 50 pounds
                // If true, asks for package dimensions
            {
                Console.WriteLine("Please enter the package width in inches.");
                string width = Console.ReadLine();
                Console.ReadLine();
                Console.WriteLine("Please enter the package height in inches.");
                string height = Console.ReadLine();
                Console.ReadLine();
                Console.WriteLine("Please enter the package length in inches.");
                string length = Console.ReadLine();
                Console.ReadLine();
                int dimensions = Convert.ToInt32(length) + Convert.ToInt32(width) + Convert.ToInt32(height);
                if (dimensions > 50) // Checks if dimensions are greater than or equal to 50
                {
                    // If true, declines user and terminates program
                    Console.WriteLine("Package too big to be shipped via Planet Express. Have a nice day!");
                    Console.ReadLine();
                }
                else
                {
                    // If false, calculates quote by multiplying dimensions and weight, then dividing by 100 to get final quote
                    int total = Convert.ToInt32(length) * Convert.ToInt32(width) * Convert.ToInt32(height);
                    int quote = total * Convert.ToInt32(weight) / 100;
                    Console.WriteLine("Your estimated total for shipping this package is: $" + quote);
                    Console.ReadLine();
                    Console.WriteLine("Thank you!");
                    Console.ReadLine();
                }
            }
            else if (Convert.ToInt32(weight) >= 50)
            {
                // If package weight is greater than or equal to 50 pounds, declines user
                Console.WriteLine("Your package is too heavy to be shipped via Planet Express. Have a nice day!");
                Console.ReadLine();
            }
        }
    }
}
