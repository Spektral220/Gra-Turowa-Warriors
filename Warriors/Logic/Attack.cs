using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warriors.Models.Characters;
using Warriors.Models.Skills;

namespace Warriors.Logic
{
    public class Attack
    {
        public Warrior Attacker { get; set; }
        public Warrior Defender { get; set; }
        public Attack(Warrior attacker, Warrior defender)
        {
            Attacker = attacker;
            Defender = defender;
        }
        public bool AttackAttempt(Attack_Warrior usedAttack)
        {
            if (!CanAttack(usedAttack))
            {
                return false;
            }

            if(Defender.Shield > 0)
            {
                Attacker.Stamina -= usedAttack.Cost;
                Attacker.Exp += usedAttack.ExpAddedAfterUse;
                Defender.Hp -= usedAttack.Damage / 2;
                Console.WriteLine($"{Attacker.Name} użył {usedAttack.Name} na {Defender.Name} i zadał {usedAttack.Damage / 2} obrażeń ");
                Console.WriteLine($"{Attacker.Name} zyskał {usedAttack.ExpAddedAfterUse} pkt doświadczenia");
                Defender.Shield--;
                
            }
            else
            {
                Attacker.Stamina -= usedAttack.Cost;
                Attacker.Exp += usedAttack.ExpAddedAfterUse;
                Defender.Hp -= usedAttack.Damage;
                Console.WriteLine($"{Attacker.Name} użył {usedAttack.Name} na {Defender.Name} i zadał {usedAttack.Damage} obrażeń ");
                Console.WriteLine($"{Attacker.Name} zyskał {usedAttack.ExpAddedAfterUse} pkt doświadczenia");
            }
            
            if (Defender.Hp <= 0)
            {
                Console.WriteLine($"{Defender.Name} zdechł");
            }
            return true;
        }
        private bool CanAttack(Attack_Warrior usedAttack)
        {
            if (Attacker.Hp <= 0)
            {
                Console.WriteLine($"{Attacker.Name} nie wykona ataku ponieważ został zabity");
                return false;
            }
            if (Attacker.Stamina - usedAttack.Cost < 0)
            {
                Console.WriteLine($"{Attacker.Name}, nie wykonano ataku - za mało many");
                return false;
            }
            return true;

        }
            

    }
}
