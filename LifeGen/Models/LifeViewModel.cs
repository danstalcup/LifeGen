using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LifeGen.Mapper;
using LifeGenApi;
using LifeGenCore;

namespace LifeGen.Models
{
    public class LifeViewModel
    {

        public LifeViewModel(LifeGenEngine engine)
        {
            this.Engine = engine;
        }

        public LifeGenEngine Engine { get; set; }

        public Life Life => Engine.Life;

        public CharacterViewModel Character => CharacterViewModelMapper.ToViewModel(Engine.Life.Character);
    }
}
