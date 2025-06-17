using System.ComponentModel.DataAnnotations.Schema;
using RPG.BattleSystem;
using RPG.Models.Players;

namespace RPG.Console;

public class Program
{
    public static void Main(string[] args)
    {
        var battleManager = new BattleManager();

        var player1 = new Player("Player 1");
        var player2 = new Player("Player 2");

        player1.Echo();
        player2.Echo();

        battleManager.StartBattle(player1, player2);
    }
}
