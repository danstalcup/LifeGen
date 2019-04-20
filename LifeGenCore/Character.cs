using System;
using System.Collections.Generic;

namespace LifeGenCore
{
    public class Character : LifeGenEntity
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Gender Gender { get; set; }

        public List<LifeLog> LifeLogs { get; set; } = new List<LifeLog>();

        public DateTime DateOfBirth { get; set; }

        public DateTime? DateOfDeath { get; set; } = null;

        public DateTime DateSimulatedTo { get; set; }

        public bool IsAlive => DateOfDeath == null;

        public bool IsActive { get; set; }
    }
}
