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
    public class LifeBuilder : BaseBuilder<Life>
    {
        public override BaseBuilder<Life> WithRandomizedDefaults(TRandom randomizer)
        {
            var character = new CharacterBuilder().WithRandomizedDefaults(randomizer).Build();
            return WithExistingCharacter(randomizer, character);
        }

        public BaseBuilder<Life> WithExistingCharacter(TRandom randomizer, Character character)
        {
            Entity = new Life();

            FlushRandomizer(randomizer);

            Entity.Character = character;

            var lifeSimulator = new LifeSimulator();

            Entity.CurrentDateTime = Entity.Character.DateSimulatedTo;

            /*while (Entity.Character.IsAlive)
            {
                lifeSimulator.SimulateLife(Entity, randomizer);
            }      */

            return this;
        }

        private void FlushRandomizer(TRandom randomizer)
        {
            int NumClears = 4;
            for (int i = 0; i < NumClears; i++)
            {
                randomizer.Next();
            }
        }
    }
}