using System;
using System.Collections.Generic;
using System.Text;
using GTANetworkAPI;

namespace WIZN.Utils
{
    class Utils
    {
        public static string ReturnRPName(Player player)
        {
            string RPName = player.Name.Replace("_", " ");
            return RPName;
        }
    }
}
