using System;

namespace RPG.Models.Players;

// This will be a concrete class
public class Player : BasePlayer
{
    public Player(string name)
    {
        // Instantiates the player's name
        Name = name;
    }

    public void Echo()
    {
        Console.WriteLine($"I am {Name}");
    }
}
