using LuckyRunes.Items.Runes;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace LuckyRunes.Items
{
    public class ArcaneOre : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Contains lucky magic");
        }

        public override void SetDefaults()
        {
            item.width = 16;
            item.height = 16;
            item.maxStack = 999;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.consumable = true;
            item.value = 0;
            item.createTile = ModContent.TileType<Tiles.ArcaneOreTile>();
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddTile(TileID.Hellforge);
            recipe.AddIngredient(this, 1);
            recipe.SetResult(ModContent.ItemType<VeryLowRune>());
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddTile(TileID.Hellforge);
            recipe.AddIngredient(this, 4);
            recipe.SetResult(ModContent.ItemType<LowRune>());
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddTile(TileID.Hellforge);
            recipe.AddIngredient(this, 16);
            recipe.SetResult(ModContent.ItemType<MediumRune>());
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddTile(TileID.Hellforge);
            recipe.AddIngredient(this, 64);
            recipe.SetResult(ModContent.ItemType<HighRune>());
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddTile(TileID.Hellforge);
            recipe.AddIngredient(this, 256);
            recipe.SetResult(ModContent.ItemType<VeryHighRune>());
            recipe.AddRecipe();
        }

    }
}
