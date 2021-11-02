using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warriors.Models.Characters;
using Warriors.Models.Skills;

namespace Warriors.Logic
{
    public class Defend
    {
        public Warrior Attacker { get; set; }

        public Defend(Warrior attacker)
        {
            Attacker = attacker;
        }
        public bool ShieldAttempt(Shield_Warrior usedShield)
        {
            if (!CanShield(usedShield))
            {
                return false;
            }

            Attacker.Stamina -= usedShield.Cost;
            Attacker.Exp += usedShield.ExpAddedAfterUse;
            Attacker.Shield += usedShield.Wytrzymalosc;
            Console.WriteLine($"{Attacker.Name} użył {usedShield.Name} na kolejny atak ");
            return true;
        }
        private bool CanShield(Shield_Warrior usedShield)
        {
            if (Attacker.Stamina - usedShield.Cost < 0)
            {
                Console.WriteLine($"{Attacker.Name}, nie założył tarczy - za mało many");
                return false;
            }
            return true;
        }

    }
}
