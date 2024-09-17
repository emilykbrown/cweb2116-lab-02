using System;

namespace Lab02
{
    class User
    {
        private string name;
        private int age;

        // Constructor to initialize name and age
        public User(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        // Method to display user information (name and age)
        public void DisplayInfo()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
        }

        // Overloaded method to display user information (name, age, and hobby)
        public void DisplayInfo(string hobby)
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Hobby: " + hobby);
        }

        // Further overloaded method to display how many years left for retirement
        public void DisplayInfo(int yearsUntilRetirement)
        {
            Console.WriteLine(name + " has " + yearsUntilRetirement + " years left until retirement.");
        }

        // Helper method to calculate years until retirement
        public int CalculateYearsUntilRetirement()
        {
            int retirementAge = 65;
            return retirementAge - age;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Example of creating a User object with name and age
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your age: ");
            int age;
            while (!int.TryParse(Console.ReadLine(), out age))
            {
                Console.Write("Invalid input. Please enter a valid age: ");
            }

            User user = new User(name, age);

            // Display basic info (name and age)
            user.DisplayInfo();

            // Display info with hobby
            Console.Write("Enter your hobby: ");
            string hobby = Console.ReadLine();
            user.DisplayInfo(hobby);

            // Calculate and display years until retirement
            int yearsUntilRetirement = user.CalculateYearsUntilRetirement();
            user.DisplayInfo(yearsUntilRetirement);

            Console.ReadLine(); // Keep the console window open
        }
    }
}
