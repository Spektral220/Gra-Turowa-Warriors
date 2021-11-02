using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warriors.Models.Characters
{
    public class Warrior : Character
    {
        public int Stamina { get; set; }

        public int Shield { get; set; }

        public Skills.Attack_Warrior[] Attacks { get; set; } = new Skills.Attack_Warrior[2];

        public Warrior(string name, int hp = 100, int exp = 0, int stamina = 100, int shield = 0) : base(name, hp, exp)
        {
            Stamina = stamina;
            Shield = shield;
        }

    }
}
