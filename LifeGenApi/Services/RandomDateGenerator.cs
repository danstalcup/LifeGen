using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Troschuetz.Random;

namespace LifeGenApi.Services
{
    public class RandomDateGenerator
    {
        public DateTime GetRandomDate(DateTime minimum, DateTime maximum, TRandom randomizer)
        {
            var rangeAsTimeSpan = maximum - minimum;
            var rangeInDays = rangeAsTimeSpan.Days;
            var randomNumberOfDaysSinceMin = randomizer.Next(rangeInDays);
            var randomDate = minimum.AddDays(randomNumberOfDaysSinceMin);            
            return randomDate;
        }
    }
}
