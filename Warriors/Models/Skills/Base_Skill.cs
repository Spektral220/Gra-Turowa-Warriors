using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warriors.Models.Skills
{
    public class Base_Skill
    {
        public string Name { get; set; }
        public int Cost { get; set; }
        public int ExpAddedAfterUse { get; set; }

        public Base_Skill(string name, int cost, int expAddedAfterUse)
        {
            Name = name;
            Cost = cost;
            ExpAddedAfterUse = expAddedAfterUse;
        }

        public void Dupa()
        {
            Console.WriteLine("dominik/kontrola");
        }
    }
}
