using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LifeGenCore;
using LiteDB;

namespace LifeGenDal
{
    public class LifeGenDb : ILifeGenDb
    {
        public const string Filename = "lifegen.db";

        internal LiteDatabase Database { get; set; }

        public Character GetActiveCharacter()
        {
            using (var db = new LiteDatabase(Filename))
            {
                var characters = db.GetCollection<Character>();
                var charactersList = characters.FindAll();
                return charactersList.FirstOrDefault(c => c.IsActive);
            }
        }

        public void AddCharacter(Character character)
        {
            using (var db = new LiteDatabase(Filename))
            {
                var characters = db.GetCollection<Character>();
                foreach (var formerCharacter in characters.FindAll())
                {
                    formerCharacter.IsActive = false;
                    characters.Update(formerCharacter);
                }

                character.IsActive = true;
                characters.Insert(character);
            }
        }

        public void UpdateCharacter(Character character)
        {
            using (var db = new LiteDatabase(Filename))
            {
                var characters = db.GetCollection<Character>();
                characters.Update(character);
            }
        }
    }
}
