using System;
using RPG.Models.Players;

namespace RPG.BattleSystem
{
    public class BattleManager
    {
        public BattleManager()
        {
        }

        public void StartBattle(BasePlayer PlayerOne, BasePlayer PlayerTwo)
        {
            System.Console.WriteLine($"Starting Battle between {PlayerOne.Name} and {PlayerTwo.Name}!");
            System.Console.ReadLine();
        }

    }
}