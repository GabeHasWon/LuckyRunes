using System;
using Terraria;
using Terraria.ID;

namespace LuckyRunes.RuneEvents.CloverEvents
{
    public class MergeMagicEvent : PlayerEvent
    {
        public override string Name => "Merge Magic";
        public override string Message => "Health and Mana potions are combined into Restoration Potions";

        public override void PlayerEffect(Player player)
        {
            int 
                totalLife = 0, 
                totalMana = 0;

            for (int i = 0; i < player.inventory.Length; ++i)
            {
                switch (player.inventory[i].type)
                {
                    case ItemID.HealingPotion:
                        ++totalLife;
                        break;
                    case ItemID.ManaPotion:
                        ++totalMana;
                        break;
                }
            }

            totalLife = totalMana = Math.Min(totalLife, totalMana);
            int restoration = 0;

            for (int i = 0; i < player.inventory.Length && totalLife > 0; ++i)
            {
                Item item = player.inventory[i];
                
                if (item.type == ItemID.HealingPotion)
                {
                    var removed = Math.Min(item.stack, totalLife);

                    item.stack -= removed;
                    totalLife -= removed;

                    restoration += removed;
                }
                else if (item.type == ItemID.ManaPotion)
                {
                    var delta = totalMana - totalLife;

                    if (delta > 0)
                    {
                        int removed = Math.Min(item.stack, delta);

                        item.stack -= removed;
                        delta -= removed;
                    }

                    totalMana = totalLife + delta;
                }
            }
        }
    }
}
