using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LifeGenCore;

namespace LifeGenDal
{
    public interface ILifeGenDb
    {        
        Character GetActiveCharacter();

        void AddCharacter(Character character);

        void UpdateCharacter(Character character);
    }
}
