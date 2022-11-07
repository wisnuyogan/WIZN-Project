using System;
using System.Collections.Generic;
using System.Text;
using GTANetworkAPI;

namespace WIZN.Chat
{
    class Utils
    {
        public static void Terdekat(Player player, string message, double radius, string color)
        {
            List<Player> playerTerdekat = NAPI.Player.GetPlayersInRadiusOfPlayer(radius, player);
            foreach (Player item in playerTerdekat)
            {
                if (item.Dimension != player.Dimension)
                {
                    continue;
                }
                else
                {
                    item.SendChatMessage($"{color}{message}");
                }
            }
        }
    }
}
