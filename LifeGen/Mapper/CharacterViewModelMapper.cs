using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LifeGen.Models;
using LifeGenCore;

namespace LifeGen.Mapper
{
    public class CharacterViewModelMapper
    {
        public static CharacterViewModel ToViewModel(Character entity)
        {
            return new CharacterViewModel
            {
                FirstName   = entity.FirstName,
                LastName = entity.LastName,
                GenderString = entity.Gender == Gender.Male ? "Male" : "Female",
                DateOfBirth = entity.DateOfBirth,
                DateOfBirthString = entity.DateOfBirth.ToShortDateString(),
                Logs = entity.LifeLogs.Select(ll => $"{ll.TimeStamp.ToShortDateString()} - {ll.Log}").ToList()
            };
        }
    }
}
