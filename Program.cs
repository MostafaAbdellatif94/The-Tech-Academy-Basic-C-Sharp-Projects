using System;

// Namespace groups related classes together
namespace StudentDailyReport
{
    // Main class for the application
    class Program
    {
        // Main method is the entry point of the program
        static void Main(string[] args)
        {
            // Print school name
            Console.WriteLine("Academy of Learning Career College");

            // Print report title
            Console.WriteLine("Student Daily Report");

            // Ask the user for their name
            Console.WriteLine("What is your name?");

            // Store the user's name as a string
            string studentName = Console.ReadLine();

            // Ask which course the student is on
            Console.WriteLine("What course are you on?");

            // Store the course name
            string courseName = Console.ReadLine();

            // Ask for the current page number
            Console.WriteLine("What page number?");

            // Convert the user's input into an integer
            int pageNumber = Convert.ToInt32(Console.ReadLine());

            // Ask if the student needs help
            Console.WriteLine("Do you need help with anything? Please answer true or false.");

            // Convert the input into a Boolean value
            bool needsHelp = Convert.ToBoolean(Console.ReadLine());

            // Ask about positive experiences
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");

            // Store the response
            string positiveExperiences = Console.ReadLine();

            // Ask for additional feedback
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");

            // Store the feedback
            string otherFeedback = Console.ReadLine();

            // Ask how many hours the student studied
            Console.WriteLine("How many hours did you study today?");

            // Convert the input into a decimal number
            decimal studyHours = Convert.ToDecimal(Console.ReadLine());

            // Example math operation in C#
            // Adds 1 bonus study hour to total hours
            decimal totalHours = studyHours + 1;

            // Display total study hours after math operation
            Console.WriteLine("Total study hours with bonus hour: " + totalHours);

            // Final message to the student
            Console.WriteLine("Thank you for your answers. An Instructor will respond shortly. Have a great day!");

            // Prevents the console window from closing immediately
            Console.ReadLine();
        }
    }
}
