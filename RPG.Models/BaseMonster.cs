using System;
namespace RPG.Models;

public abstract class BaseMonster
{
    //Monster number
    public int Id { get; set; }

    //Monster name
    public MonsterType Type { get; set; }

    public string Name { get; set; }

    //Monster Health
    public int Hp { get; set; }

    //Base atk stat (phy & special)
    public int Attack { get; set; }

    //Base def stat (phy & special)
    public int Defense { get; set; }

    //Base speed stat (use to determine round order)
    public int Speed { get; set; }

    // Up to 4 moves
    //TODO: Add controls/restrictions for learning new moves
    //NOTE: When learning 5 move, need to replace one existing 4 moves
    public virtual IList<BattleMove> MoveList { get; set; }
}
