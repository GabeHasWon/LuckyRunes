using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;

namespace LuckyRunes.RuneEvents.PlayerEvents
{
    public class RandomTeleportEvent : PlayerEvent
    {
        public override string Name => "Random Teleport";
        public override string Message => "Teleports the player to a random location, as if they drank a teleportation potion";
        public override float Impact => 2f;
        public override float Chaos => 0.1f;

        public override void PlayerEffect(Player player)
        {
            Main.PlaySound(SoundID.Item, player.Center, 6);

			if (Main.netMode == NetmodeID.SinglePlayer)
				player.TeleportationPotion();
			else if (Main.netMode == NetmodeID.MultiplayerClient && player.whoAmI == Main.myPlayer)
				NetMessage.SendData(MessageID.TeleportationPotion, -1, -1, null, 0, 0f, 0f, 0f, 0, 0, 0);
		}
    }
}
