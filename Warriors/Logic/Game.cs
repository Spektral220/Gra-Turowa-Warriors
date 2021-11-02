using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warriors.Models.Characters;
using Warriors.Models.Skills;

namespace Warriors.Logic
{
    public class Game
    {
        public Warrior Warrior1 { get; set; }
        public Warrior Warrior2 { get; set; }
        public Warrior Warrior3 { get; set; }
        public Attack_Warrior Attack1 { get; set; }
        public Attack_Warrior Attack2 { get; set; }
        public Shield_Warrior Shield { get; set; }

        public Game()
        {
            CreateWarrior();
            CreateAttack();
            AssignAttack();
        }
        private void CreateWarrior()
        {
            Warrior1 = new Warrior("Marek");
            Warrior2 = new Warrior("Stachu");
            Warrior3 = new Warrior("Grześ");
        }
        private void CreateAttack()
        {
            Attack1 = new Attack_Warrior("Pięści", 10, 10, 10);
            Attack2 = new Attack_Warrior("Kopnięcia", 10, 10, 10);
            Shield = new Shield_Warrior("Blok", 10, 10, 1);
        }
        private void AssignAttack()
        {
            Warrior1.Attacks[0] = Attack1;
            Warrior1.Attacks[1] = Attack2;

            Warrior2.Attacks[0] = Attack1;
            Warrior2.Attacks[1] = Attack2;

            Warrior3.Attacks[0] = Attack1;
            Warrior3.Attacks[1] = Attack2;

        }
        public void Havoc()
        {
            Console.Write("Ile rund chcesz zagrać: ");
            int lRund = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            do
            {
                i++;
                Move_Warrior1();
                Move_Warrior2();
                Move_Warrior3();
            } while (i < lRund);
        }

        public void Move_Warrior1()
        {
            Console.WriteLine($"HP: {Warrior1.Hp}___Nazwa postaci: {Warrior1.Name}___Stamina: {Warrior1.Stamina}___Shield: {Warrior1.Shield}");
            Console.WriteLine($"Wybierz 1 aby zaatakować {Attack1.Name} lub wybierz 2 aby zaatakować {Attack2.Name}");
            Console.WriteLine($"Wybierz 3 aby urzyć {Shield.Name}");
            Console.Write("Co chcesz aby twoja postać wykonała");
            string wybor = Console.ReadLine();
            switch (wybor)
            {
                case "1":
                    {
                        Console.WriteLine($"Kogo chcesz zaatakować? Wybierz: (1) -{Warrior2.Name} lub (2) -{Warrior3.Name}");
                        string jakaPostac = Console.ReadLine();
                        switch (jakaPostac)
                        {
                            case "1":
                                {
                                    var Warrior1VS = new Attack(Warrior1, Warrior2);
                                    Warrior1VS.AttackAttempt(Attack1);
                                    break;
                                }
                            case "2":
                                {

                                    var Warriord1VS = new Attack(Warrior1, Warrior3);
                                    Warriord1VS.AttackAttempt(Attack1);
                                    break;
                                }
                            default:
                                break;
                        }

                        break;
                    }
                case "2":
                    {
                        Console.WriteLine($"Kogo chcesz zaatakować? Wybierz: (1) -{Warrior2.Name} lub (2) -{Warrior3.Name}");
                        string jakaPostac = Console.ReadLine();
                        switch (jakaPostac)
                        {
                            case "1":
                                {
                                    var Warrior1VS = new Attack(Warrior1, Warrior2);
                                    Warrior1VS.AttackAttempt(Attack2);
                                    break;
                                }
                            case "2":
                                {

                                    var Warriord1VS = new Attack(Warrior1, Warrior3);
                                    Warriord1VS.AttackAttempt(Attack2);
                                    break;
                                }
                            default:
                                break;
                        }

                        break;
                    }
                case "3":
                    {
                        Console.WriteLine("Założyłeś tarczę!!!");
                        var WarriorShieldOn = new Defend(Warrior1);
                        WarriorShieldOn.ShieldAttempt(Shield);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Wybrałeś inny klawisz!!!");
                        break;
                    }
            }
        }
        public void Move_Warrior2()
        {
            Console.WriteLine($"HP: {Warrior2.Hp} __{Warrior2.Name}__{Warrior2.Stamina}");
            Console.WriteLine($"Wybierz 1 aby zaatakować {Attack1.Name} lub wybierz 2 aby zaatakować {Attack2.Name}");
            Console.Write("Co chcesz aby twoja postać wykonała");
            string wybor = Console.ReadLine();
            switch (wybor)
            {
                case "1":
                    {
                        Console.WriteLine($"Kogo chcesz zaatakować? Wybierz: (1) -{Warrior1.Name} lub (2) -{Warrior3.Name}");
                        string jakaPostac = Console.ReadLine();
                        switch (jakaPostac)
                        {
                            case "1":
                                {
                                    var Warrior1VS = new Attack(Warrior2, Warrior1);
                                    Warrior1VS.AttackAttempt(Attack1);
                                    break;
                                }
                            case "2":
                                {

                                    var Warriord1VS = new Attack(Warrior2, Warrior3);
                                    Warriord1VS.AttackAttempt(Attack1);
                                    break;
                                }
                            default:
                                break;
                        }

                        break;
                    }
                case "2":
                    {
                        Console.WriteLine($"Kogo chcesz zaatakować? Wybierz: (1) -{Warrior1.Name} lub (2) -{Warrior3.Name}");
                        string jakaPostac = Console.ReadLine();
                        switch (jakaPostac)
                        {
                            case "1":
                                {
                                    var Warrior1VS = new Attack(Warrior2, Warrior1);
                                    Warrior1VS.AttackAttempt(Attack2);
                                    break;
                                }
                            case "2":
                                {

                                    var Warriord1VS = new Attack(Warrior2, Warrior3);
                                    Warriord1VS.AttackAttempt(Attack2);
                                    break;
                                }
                            default:
                                break;
                        }

                        break;
                    }
                case "3":
                    {
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Wybrałeś inny klawisz!!!");
                        break;
                    }
            }
        }
        public void Move_Warrior3()
        {
            Console.WriteLine($"HP: {Warrior3.Hp} __{Warrior3.Name}__{Warrior3.Stamina}");
            Console.WriteLine($"Wybierz 1 aby zaatakować {Attack1.Name} lub wybierz 2 aby zaatakować {Attack2.Name}");
            Console.Write("Co chcesz aby twoja postać wykonała");
            string wybor = Console.ReadLine();
            switch (wybor)
            {
                case "1":
                    {
                        Console.WriteLine($"Kogo chcesz zaatakować? Wybierz: (1) -{Warrior1.Name} lub (2) -{Warrior2.Name}");
                        string jakaPostac = Console.ReadLine();
                        switch (jakaPostac)
                        {
                            case "1":
                                {
                                    var Warrior1VS = new Attack(Warrior3, Warrior1);
                                    Warrior1VS.AttackAttempt(Attack1);
                                    break;
                                }
                            case "2":
                                {

                                    var Warriord1VS = new Attack(Warrior3, Warrior2);
                                    Warriord1VS.AttackAttempt(Attack1);
                                    break;
                                }
                            default:
                                break;
                        }

                        break;
                    }
                case "2":
                    {
                        Console.WriteLine($"Kogo chcesz zaatakować? Wybierz: (1) -{Warrior1.Name} lub (2) -{Warrior2.Name}");
                        string jakaPostac = Console.ReadLine();
                        switch (jakaPostac)
                        {
                            case "1":
                                {
                                    var Warrior1VS = new Attack(Warrior3, Warrior1);
                                    Warrior1VS.AttackAttempt(Attack2);
                                    break;
                                }
                            case "2":
                                {

                                    var Warriord1VS = new Attack(Warrior3, Warrior2);
                                    Warriord1VS.AttackAttempt(Attack2);
                                    break;
                                }
                            default:
                                break;
                        }

                        break;
                    }
                case "3":
                    {
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Wybrałeś inny klawisz!!!");
                        break;
                    }
            }
        }
        public void PrintResult()
        {
            Console.WriteLine($"{Warrior1.Name}: HP = {Warrior1.Hp}, EXP = {Warrior1.Exp}, Mana = {Warrior1.Stamina}");
            Console.WriteLine($"{Warrior2.Name}: HP = {Warrior2.Hp}, EXP = {Warrior2.Exp}, Mana = {Warrior2.Stamina}");
            Console.WriteLine($"{Warrior3.Name}: HP = {Warrior3.Hp}, EXP = {Warrior3.Exp}, Mana = {Warrior3.Stamina}");
        }




    }
}
