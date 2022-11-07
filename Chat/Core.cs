using System;
using System.Collections.Generic;
using System.Text;
using GTANetworkAPI;

namespace WIZN.Chat
{
    class Core : Script
    {
        [ServerEvent(Event.ChatMessage)]
        public void OnChatMessgae(Player player, string message)
        {
            Utils.Terdekat(player, $"{WIZN.Utils.Utils.ReturnRPName(player)} says: {message}.", 20.00, WIZN.Utils.Color.COLOR_WHITE);
        }
    }
}
