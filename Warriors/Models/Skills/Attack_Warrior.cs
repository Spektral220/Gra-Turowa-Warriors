using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warriors.Models.Skills
{
    public class Attack_Warrior : Base_Skill
    {
        public int Damage { get; set; }

        public Attack_Warrior(string name, int cost, int expAddedAfterUse, int damage) : base(name, cost, expAddedAfterUse)
        {
            Damage = damage;
        }
    }
}
