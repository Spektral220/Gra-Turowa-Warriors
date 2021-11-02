using System;

namespace Warriors
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new Logic.Game();
            game.Havoc();
            game.PrintResult();
        }
    }
}
