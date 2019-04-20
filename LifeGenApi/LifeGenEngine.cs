using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LifeGenApi.Builders;
using LifeGenCore;
using LifeGenApi.Services;
using LifeGenDal;
using Troschuetz.Random;

namespace LifeGenApi
{
    public class LifeGenEngine
    {
        public Life Life { get; protected set; }

        public ILifeGenDb Database { get; set; }

        internal TRandom Randomizer { get; set; }

        public LifeGenEngine()
        {
            Randomizer = new TRandom();
            Database = new LifeGenDb();
            var character = Database.GetActiveCharacter();
            if (character == null)
            {
                Life = new LifeBuilder().WithRandomizedDefaults(Randomizer).Build();
                Database.AddCharacter(Life.Character);
            }
            else
            {
                Life = new LifeBuilder().WithExistingCharacter(Randomizer, character).Build();
            }
        }

        public void Sim()
        {
            new LifeSimulator().SimulateLife(Life, Randomizer);
            Database.UpdateCharacter(Life.Character);
        }

        public void NewCharacter()
        {
            Life.Character = new CharacterBuilder().WithRandomizedDefaults(Randomizer).Build();
            Database.AddCharacter(Life.Character);
        }
    }
}
