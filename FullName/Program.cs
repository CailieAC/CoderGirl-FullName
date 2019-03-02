using System;

namespace FullName
{
    public static class Program
    {
        public static void Main()
        {
            // TODO: Ask the user for their first name and then their last name.
            Console.Write("Enter your first name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter your last name: ");
            string lastName = Console.ReadLine();

            // TODO: Call a method called FullName that returns their full name.
            string fullName = FullName(firstName, lastName);

            // TODO: Output their full name.
            Console.WriteLine(fullName);
            Console.ReadLine();
        }

        // TODO: Create a method call FullName that takes the firstName and lastName as parameters.
        public static string FullName(string firstName, string LastName)
        {
            string fullName = firstName + " " + LastName;
            return fullName;
        }
    }
}
