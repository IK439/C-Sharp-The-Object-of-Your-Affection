using System;
using System.Text;

namespace DatingProfile
{
    class Profile
    {
        private string Name { get; set; }
        private int Age { get; set; }
        private string City { get; set; }
        private string Country { get; set; }
        private string Pronouns { get; set; }
        private string[] Hobbies { get; set; }

        // Constructor for full profile
        public Profile(
            string name,
            int age,
            string city,
            string country,
            string pronouns = "they/them"
        )
        {
            Name = name;
            SetAge(age);
            City = city;
            Country = country;
            Pronouns = pronouns;
            Hobbies = Array.Empty<string>();
        }

        // Constructor for users with only name and age
        public Profile(string name, int age)
        {
            Name = name;
            SetAge(age);
            City = "Unknown";
            Country = "Unknown";
            Pronouns = "they/them";
            Hobbies = Array.Empty<string>();
        }

        // Ensures user is at least 18 years old
        private void SetAge(int age)
        {
            if (age < 18)
            {
                throw new ArgumentException("Users must be at least 18 years old.");
            }

            Age = age;
        }

        // Updates hobbies safely
        public void SetHobbies(string[] hobbies)
        {
            // Use empty array if hobbies is null
            Hobbies = hobbies ?? Array.Empty<string>();
        }

        // Builds and returns the profile text
        public string ViewProfile()
        {
            Console.WriteLine("***Dating Profile***\n");
            StringBuilder bio = new StringBuilder();

            bio.AppendLine($"Name: {Name}");
            bio.AppendLine($"Age: {Age}");
            bio.AppendLine($"City: {City}");
            bio.AppendLine($"Country: {Country}");
            bio.AppendLine($"Pronouns: {Pronouns}");
            bio.AppendLine("Hobbies:");

            if (Hobbies.Length == 0)
            {
                bio.AppendLine("None listed");
            }
            else
            {
                foreach (string hobby in Hobbies)
                {
                    bio.AppendLine($"- {hobby}");
                }
            }

            return bio.ToString();
        }
    }
}