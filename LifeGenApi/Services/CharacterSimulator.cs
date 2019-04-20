using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LifeGenApi.Builders;
using LifeGenCore;
using LifeGenApi.Data;
using LifeGenApi.Services.Extensions;
using Troschuetz.Random;

namespace LifeGenApi.Services
{
    public class CharacterSimulator
    {
        public void SimulateCharacter(Character character, DateTime toDateTime, TRandom randomizer)
        {
            var totalMonths = 12 * LifeSimulator.DefaultTimePassageYears + LifeSimulator.DefaultTimePassageMonths;
            var totalYears = totalMonths / 12.0M;
            var deathPercentage = Actuary.DeathPercentage(character.Gender, character.AgeInYears(toDateTime));
            var adjustedDeathPercentage = deathPercentage * totalYears;
            if (randomizer.NextDecimal() < adjustedDeathPercentage)
            {
                character.DateOfDeath = new RandomDateGenerator().GetRandomDate(character.DateSimulatedTo, toDateTime, randomizer);
                character.LifeLogs.Add(LifeLogFactories.BuildLog_Death(character));
            }
            else
            {
                character.LifeLogs.Add(LifeLogFactories.BuildLog_Aged(character, toDateTime));
            }

            character.DateSimulatedTo = toDateTime;
        }
    }
}
