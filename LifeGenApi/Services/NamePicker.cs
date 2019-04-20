using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LifeGenCore;
using Troschuetz.Random;

namespace LifeGenApi.Services
{
    public class NamePicker
    {
        private TRandom Randomizer { get; }
        public NamePicker(TRandom randomizer)
        {
            this.Randomizer = randomizer;
        }

        public string GetFirstName(Gender gender)
        {
            switch (gender)
            {
                case Gender.Male:
                    return GetMaleFirstName();
                case Gender.Female:
                    return GetFemaleFirstName();
                default:
                    throw new Exception("Gender required for name");
            }
        }

        public string GetMaleFirstName()
        {
            var dataset = Data.Names.MaleFirstNames();
            return dataset[Randomizer.Next(dataset.Count)];
        }

        public string GetFemaleFirstName()
        {
            var dataset = Data.Names.FemaleFirstNames();
            return dataset[Randomizer.Next(dataset.Count)];
        }

        public string GetLastName()
        {
            var dataset = Data.Names.LastNames();
            return dataset[Randomizer.Next(dataset.Count)];
        }
    }
}
