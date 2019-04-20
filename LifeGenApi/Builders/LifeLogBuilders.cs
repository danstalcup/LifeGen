using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LifeGenCore;
using LifeGenApi.Services.Extensions;
using Troschuetz.Random;

namespace LifeGenApi.Builders
{
    public class LifeLogFactories
    {
        public static LifeLog BuildLog_Birth(Character character)
        {
            var dateOfBirth = character.DateOfBirth;
            return new LifeLog
            {
                TimeStamp =  dateOfBirth,
                Log = $"{character.Name()} was born on {dateOfBirth.ToShortDateString()}"
            };
        }

        public static LifeLog BuildLog_Aged(Character character, DateTime timeAfterSim)
        {
            var numberMonths = (timeAfterSim.Year - character.DateSimulatedTo.Year) * 12 +
                         (timeAfterSim.Month - character.DateSimulatedTo.Month);
            bool isBirthday = timeAfterSim.Month == character.DateOfBirth.Month && timeAfterSim.Day == character.DateOfBirth.Day;
            var yearDifference = timeAfterSim.Year - character.DateOfBirth.Year;

            return new LifeLog
            {
                TimeStamp = timeAfterSim,
                Log = $"{character.Name()} aged {numberMonths} months {(isBirthday ? $"and is now {yearDifference}!" : "." )}"
            };
        }

        public static LifeLog BuildLog_Death(Character character)
        {
            return new LifeLog
            {
                TimeStamp = character.DateOfDeath.Value,
                Log = $"{character.Name()} died on {character.DateOfDeath.Value.ToShortDateString()}."
            };
        }
    }
}
