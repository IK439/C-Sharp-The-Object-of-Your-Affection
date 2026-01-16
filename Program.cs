using System;

namespace DatingProfile
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a profile with details
            Profile p = new Profile("Michelle Jones", 32, "New York", "USA", "she/her");

            // List of hobbies
            string[] hobbies =
            {
                "Practicing yoga and pilates",
                "Reading contemporary fiction and memoirs",
                "Exploring new coffee shops and cafes",
                "Taking photography walks around the city"
            };

            // Add hobbies to the profile
            p.SetHobbies(hobbies);

            // Display the profile
            Console.WriteLine(p.ViewProfile());
        }
    }
}