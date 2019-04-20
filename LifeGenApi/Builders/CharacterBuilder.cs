using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LifeGenCore;
using LifeGenApi.Services;
using Troschuetz.Random;

namespace LifeGenApi.Builders
{
    public class CharacterBuilder : BaseBuilder<Character>
    {        
        public override BaseBuilder<Character> WithRandomizedDefaults(TRandom randomizer)
        {            
            Entity = new Character();

            var namePicker = new NamePicker(randomizer);
            var gender = (Gender)(randomizer.Next(2)+1);
            Entity.Gender = gender;
            Entity.FirstName = namePicker.GetFirstName(gender);
            Entity.LastName = namePicker.GetLastName();
            Entity.DateOfBirth = new RandomDateGenerator().GetRandomDate(new DateTime(1980, 1, 1), new DateTime(2019, 1, 1), randomizer);
            Entity.DateSimulatedTo = Entity.DateOfBirth;
            Entity.LifeLogs.Add(LifeLogFactories.BuildLog_Birth(Entity));

            return this;
        }
    }
}
