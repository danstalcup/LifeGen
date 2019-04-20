using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LifeGen.Models
{
    public class CharacterViewModel
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FullName => FirstName + " " + LastName;

        public string GenderString { get; set; }
        
        public DateTime DateOfBirth { get; set; }

        public string DateOfBirthString { get; set; }

        public List<string> Logs { get; set; }
    }
}
