using System;
using System.Collections.Generic;
using System.Text;
using GTANetworkAPI;

namespace WIZN.CMD
{
    class PlayerCMD : Script
    {
        [Command("b", "~o~Usage: /b [Local OOC Chat]", GreedyArg = true)]
        public void CMD_b(Player player, string message)
        {
            WIZN.Chat.Utils.Terdekat(player, $"{WIZN.Utils.Utils.ReturnRPName(player)}: (( {message} ))", 20, WIZN.Utils.Color.COLOR_WHITE);
        }
    }
}