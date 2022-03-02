using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace LuckyRunes.RuneEvents.PlayerEvents
{
    public class SansUndertaleEvent : PlayerEvent
    {
        public override string Name => "Sans Undertale";
        public override string Message => "Sans Undertale";
        public override float Impact => 5.1f;

        public override void PlayerEffect(Player player)
        {
            Main.PlaySound(SoundLoader.customSoundType, -1, -1, player.GetModPlayer<RunePlayer>().mod.GetSoundSlot(SoundType.Custom, "Sounds/SansUndertale"));
            NPC.NewNPC((int)player.Center.X - 200 + Main.rand.Next(400), (int)player.Center.Y + (Main.rand.NextBool()?1:-1) * 600, NPCID.DungeonGuardian);
        }
    }
}
