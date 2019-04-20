using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Troschuetz.Random;

namespace LifeGenApi.Services.Extensions
{
    public static class TRandomExtensions
    {
        public static decimal NextDecimal(this TRandom randomizer)
        {
            return Convert.ToDecimal(randomizer.NextDouble());
        }
    }
}