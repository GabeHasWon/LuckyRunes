using Terraria;

namespace LuckyRunes.RuneEvents
{
    public abstract class DayLuckEvent : PlayerEvent
    {
        public override float Impact => 1;

        public override void PlayerEffect(Player player)
        {
            // Find buff
            int buff = -1;

            while (buff == -1) // TODO Test for deadlocks.
            {
                int index = Main.rand.Next(0, Main.debuff.Length);

                if (Main.debuff[index] == Debuff)
                    buff = index;
            }

            player.AddBuff(buff, 60 * 15);
        }

        public abstract bool Debuff { get; }
        public abstract int Duration { get; }

        public override string Message => $"Gain a random {(Debuff ? "debuff" : "buff")} for {Duration} seconds";
    }
}
