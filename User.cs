using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorningChallenges
{
    public class User
    {
        // Blank Constructor
        public User() { }

        // Full Constructor (blueprint)
        public User(string first, string last, int id, DateTime doB)
        {
            FirstName = first;
            LastName = last;
            DoB = doB;
            Id = id;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }
        public DateTime DoB { get; set; }

        //Bonus: Create a method that returns the full name of the user.

        public string FullName()
        {
            return $"{FirstName} {LastName}";
        }

        //Double Bonus: Create a method that returns the age of the user in years.

        public int Age()
        {
            TimeSpan ageSpan = DateTime.Now - DoB;
            double totalAgeInYears = ageSpan.TotalDays / 365.25;
            int years = Convert.ToInt32(Math.Floor(totalAgeInYears));
            return years;
        }
    }
}
