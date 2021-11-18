using LuckyRunes.RuneEvents;
using ProjectT;
using System;
using Terraria;
using Terraria.ModLoader;
using Terraria.Utilities;

namespace LuckyRunes
{
    class TwitchInput : TwitchHandler
    {
        /// <summary>Easy way to grab config.</summary>
        private static RuneConfig Config => ModContent.GetInstance<RuneConfig>();

        /// <summary>Automatically runs RuneManager's GetRandomMessageEvent if the message has >0 bits.</summary>
        /// <param name="viewer"></param>
        /// <param name="message"></param>
        /// <param name="bits"></param>
        public override void MessageHandler(Viewer viewer, string message, int bits)
        {
            Main.rand = new UnifiedRandom((int)DateTime.Now.Ticks);
            Main.NewText("Message Checked");

            
            float impact = 0f;
            if (bits > 0)
                impact = RuneManager.GetBitImpact(bits);
            else if(viewer.mod && message.StartsWith(Config.RuneCommandPrefix))
                impact = GetImpactFromModMessage(message);
            else if(message.StartsWith(Config.RuneCommandPrefix) && GetCoinsFromMessage(message) > 0 && viewer.Coins >= GetCoinsFromMessage(message))
            {
                viewer.Coins -= GetCoinsFromMessage(message);
                impact = RuneManager.GetBitImpact((int)(GetCoinsFromMessage(message) * Config.CoinRatio));
            }
            if (impact > 0)
            {
                RuneEvent ev = RuneManager.GetEvent(impact);
                if (ev != null)
                    ev.Effects();
            }
        }

        private double GetCoinsFromMessage(string message)
        {
            string[] messageParms = message.Split(' ');

            if (messageParms.Length > 1 && double.TryParse(messageParms[1], out double impact))
                return impact;
            return 0;
        }

        private float GetImpactFromModMessage(string message)
        {
            string[] messageParms = message.Split(' ');

            if (messageParms.Length > 1 && float.TryParse(messageParms[1], out float impact))
                return impact;
            return 0f;
        }

        public override void onCommunitySubscription(Viewer viewer, string tier)
        {
            //I'm not actually sure what this is yet. If you figure it out tell me.
        }

        public override void onBeingHosted(string Hoster, int AmountofViewers)
        {
            //BEWARE. this only gets the name of the hoster. NOT AN INSTANCE OF A VIEWER. 
            //A Viewer will be created once the hoster writes in chat like everyone else.

            //name says it all
        }

        public override void onConnected()
        {
            Main.NewText("Bot connected.");
        }

        public override void onConnectionError() => Main.NewText("Bot failed to connect. (Error)");

        public override void onDisconnected() => Main.NewText("Bot disconnected.");

        public override void onGiftedSubscription(Viewer viewer, string tier)
        {
            SubEvent();
            //viewer is recipient. Tier is either Tier1, Tier2 or Tier3
        }

        public override void onIncorrectLogin() => Main.NewText("Bot failed to connect. (Login Info)");

        public override void onNewSubscriber(Viewer viewer, string tier)
        {
            SubEvent();
            //tiers are either: Prime, Tier1, Tier2, Tier3 or NotSet
        }

        public override void onReSubscriber(Viewer viewer, string tier) => SubEvent();

        private void SubEvent()
        {
            if (Config.SubSpecificName != "None")
            {
                RuneManager.GetEvent(Config.SubImpact);
            }
        }
    }
}
