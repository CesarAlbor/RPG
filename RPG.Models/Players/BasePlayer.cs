using System;
namespace RPG.Models.Players
{
    public abstract class BasePlayer
    {
        public string Name { get; set; }

        // Current part. Max of 6
        //TODO: need control/restriction and swapping new monster with existing.
        public virtual IList<BaseMonster> Party { get; set; }
    }
}