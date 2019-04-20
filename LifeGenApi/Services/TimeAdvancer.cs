using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LifeGenCore;

namespace LifeGenApi.Services
{
    public class TimeAdvancer
    {
        public void AdvanceTime(Life life, int years = 0, int months = 0, int days = 0, int hours = 0, int mins = 0, int secs = 0, int millisecs = 0, int ticks = 0)
        {
            life.CurrentDateTime = life.CurrentDateTime.AddYears(years).AddMonths(months).AddDays(days).AddHours(hours).AddMinutes(mins).AddSeconds(secs).AddMilliseconds(millisecs).AddTicks(ticks);
        }
    }
}
