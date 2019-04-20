using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LifeGenCore;
using Troschuetz.Random;

namespace LifeGenApi.Services
{
    public class LifeSimulator
    {
        public const int DefaultTimePassageYears = 0;
        public const int DefaultTimePassageMonths = 3;

        public void SimulateLife(Life life, TRandom randomizer)
        {
            new TimeAdvancer().AdvanceTime(life, DefaultTimePassageYears, DefaultTimePassageMonths);
            new CharacterSimulator().SimulateCharacter(life.Character, life.CurrentDateTime, randomizer);
        }
    }
}
