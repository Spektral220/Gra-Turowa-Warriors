using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warriors.Models.Characters
{
    public class Character
    {
        public string Name { get; set; }
        private int _hp;

        public int Hp
        {
            get { return _hp; }
            set { _hp = value < 0 ? 0 : value; }
            // If, else
        }

        public int Exp { get; set; }

        public Character(string name, int hp, int exp)
        {
            Name = name;
            Hp = hp;
            Exp = exp;
        }
    }
}
