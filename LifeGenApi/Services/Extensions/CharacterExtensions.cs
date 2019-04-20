using System;
using LifeGenCore;

namespace LifeGenApi.Services.Extensions
{
    public static class CharacterExtensions
    {
        public static int AgeInYears(this Character character, DateTime today)
        {
            
            var birthdate = character.DateOfBirth;                        
            
            // Calculate the age.
            var age = today.Year - birthdate.Year;
            // Go back to the year the person was born in case of a leap year
            if (birthdate > today.AddYears(-age)) age--;

            return age;
        }

        public static string Name(this Character character)
        {
            return character.FirstName + " " + character.LastName;
        }
    }
}
