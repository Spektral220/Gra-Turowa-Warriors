using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warriors.Models.Skills
{
    public class Shield_Warrior : Base_Skill
    {

        public int Wytrzymalosc { get; set; }
        public Shield_Warrior(string name, int cost, int expAddedAfterUse, int wytrzymalosc = 1) : base(name, cost, expAddedAfterUse)
        {
            Wytrzymalosc = wytrzymalosc;
        }
    }
}
