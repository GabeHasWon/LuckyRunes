using LuckyRunes.RuneEvents;
using Microsoft.Xna.Framework;
using ProjectT;
using System;
using System.Linq;
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
            if (Main.rand == null) //WHY is it null
                Main.rand = new UnifiedRandom((int)DateTime.Now.Ticks);

            if (message.StartsWith(RuneConfig.HelpPrefix))
            {
                string[] messageParams = message.Split(' ');

                if (messageParams.Length > 0)
                {
                    HelpMessage(messageParams[1].ToUpper());
                    return;
                }
            }

            if (message.StartsWith(Config.SpecificEventPrefix) && SpecificRuneEvent(viewer, message))
                return;

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
                Main.NewText($"{viewer.Name} bought: [c/{GetImpactColor(ev.Impact).Hex3()}:{ev.Name}]");
                string note = GetSecondParameter(message);
                if (note != string.Empty)
                    Main.NewText($"They say: {note}");
                ev?.Effects();
            }
        }

        private void HelpMessage(string section)
        {
            string[] randomEventQualifiers = new string[] { "ROLL", "RANDOM", "RANDOMEVENT", "ROLLEVENT" };
            string[] specificEventQualifiers = new string[] { "SPECIFIC", "CHOOSE", "SPECIFICEVENT" };
            string[] coinQualifiers = new string[] { "COIN", "COINS" };
            string[] bitQualifiers = new string[] { "BITS", "BIT" };
            
            if (section == string.Empty)
            {
                string sections = "ROLL, SPECIFIC, COIN, BITS";

                Calls.SendMessage($"This is the help section for Lucky Runes. Use {RuneConfig.HelpPrefix} {{section}} in order to look through a specific section.\n" +
                    $"Sections: {sections}");
            }
            else if (randomEventQualifiers.Any(x => x == section))
                Calls.SendMessage($"{Config.RuneCommandPrefix} rolls an event. Usage:\n{Config.RuneCommandPrefix} {{coin amount}} optional:{{message}}\n");
            else if (specificEventQualifiers.Any(x => x == section))
            {
                Calls.SendMessage($"\n\n{Config.SpecificEventPrefix} rolls a specific event. Usage:\n{Config.SpecificEventPrefix} {{name of event}} {{message}}\n" +
                    $"Buying a specific event will cost you three times more than rolling a random event of the same tier." +
                    $"Only use this when you're sure you want to have a specific impact on the game.");
            }
            else if (coinQualifiers.Any(x => x == section))
            {
                Calls.SendMessage($"Coins are a currency you use to buy events. How you get coins is configured by the streamer!");
            }
            else if (bitQualifiers.Any(x => x == section))
            {
                Calls.SendMessage($"Donating bits allows you to roll an event that occurs immediately in-game.\nThe thresholds are:\n" +
                    $"{Config.VeryLowBit} bits for very low impact events\n{Config.LowBit} bits for low impact events\n{Config.MediumBit} bits for medium impact events\n" +
                    $"{Config.HighBit} bits for high impact events\n{Config.VeryHighBit} bits for very high impact events\n");
            }
        }

        private bool SpecificRuneEvent(Viewer viewer, string message)
        {
            string[] messageParams = message.Split(' ');

            if (messageParams.Length > 0)
            {
                string name = messageParams[1];
                if (name != string.Empty)
                {
                    RuneEvent ev = RuneManager.GetEvent(name);

                    double coins = RuneManager.GetBitsFromImpact(ev.Impact) * Config.CoinRatio * 3;
                    if (viewer.Coins >= coins)
                        viewer.Coins -= coins;
                    else
                        return false;

                    Main.NewText($"{viewer.Name} bought: [c/{GetImpactColor(ev.Impact).Hex3()}:{ev.Name}]");
                    string note = GetSecondParameter(message);

                    if (note != string.Empty)
                        Main.NewText($"They say: {note}");
                    return true;
                }
            }
            return false;
        }

        private Color GetImpactColor(float impact)
        {
            if (impact <= 1f) //Very low impact
                return Color.White;
            else if (impact <= 3f) //Low impact
                return Color.Green;
            else if (impact <= 5f) //Medium impact
                return Color.Blue;
            else if (impact <= 7f) //High impact
                return Color.Purple;
            return Color.Gold; //Very high impact
        }

        private double GetCoinsFromMessage(string message)
        {
            string[] messageParams = message.Split(' ');

            if (messageParams.Length > 1 && double.TryParse(messageParams[1], out double coins))
                return coins;
            return 0;
        }

        private string GetSecondParameter(string message)
        {
            string[] messageParams = message.Split(' ');

            if (messageParams.Length > 2)
                return messageParams[2];
            return string.Empty;
        }

        private float GetImpactFromModMessage(string message)
        {
            string[] messageParams = message.Split(' ');

            if (messageParams.Length > 1 && float.TryParse(messageParams[1], out float impact))
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
        }

        public override void onConnected() => Main.NewText("Bot connected. Hi all!");

        public override void onConnectionError() => Main.NewText("Bot failed to connect. (Error)");

        public override void onDisconnected() => Main.NewText("Bot disconnected.");

        public override void onGiftedSubscription(Viewer viewer, string tier)
        {
            SubEvent();
            //viewer is recipient. Tier is either Tier1, Tier2 or Tier3
        }

        public override void onIncorrectLogin() => Main.NewText("Bot failed to connect. (Login Info)");

        //tiers are either: Prime, Tier1, Tier2, Tier3 or NotSet
        public override void onNewSubscriber(Viewer viewer, string tier) => SubEvent();

        public override void onReSubscriber(Viewer viewer, string tier) => SubEvent();

        private void SubEvent()
        {
            if (Config.SubSpecificName != "None")
                RuneManager.GetEvent(Config.SubImpact);
        }
    }
}
