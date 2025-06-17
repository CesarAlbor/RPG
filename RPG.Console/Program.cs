using System.ComponentModel.DataAnnotations.Schema;
using RPG.BattleSystem;
using RPG.Models.Players;

namespace RPG.Console;

public class Program
{
    public static void Main(string[] args)
    {
        var battleManager = new BattleSystem.BattleManager();

        var player1 = new BasePlayer();
        var player2 = new Player();

        System.Console.ReadLine();
    }
}