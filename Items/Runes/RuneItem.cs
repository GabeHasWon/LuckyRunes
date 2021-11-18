using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace LuckyRunes.Items.Runes
{
    public abstract class RuneItem : ModItem
    {
        /// <summary>The impact of the event that will be rolled on use.</summary>
        public abstract float Impact { get; }

        public sealed override void SetDefaults()
        {
            item.width = 32;
            item.height = 40;
            item.useAnimation = item.useTime = 15;
            item.maxStack = 99;
            item.useStyle = ItemUseStyleID.HoldingUp;
            item.value = Item.sellPrice(silver: 10);
            item.rare = ItemRarityID.Blue;
            item.UseSound = SoundID.Item1;
            item.consumable = false;
            item.autoReuse = false;
            SetRarityValue();
        }

        public abstract void SetRarityValue();

        public override bool UseItem(Player player)
        {
            var ev = RuneManager.GetEvent(Impact);
            if (ev != null)
                ev.Effects();
            return ev != null;
        }
    }
}
