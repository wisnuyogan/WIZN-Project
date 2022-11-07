using System;
using GTANetworkAPI;

namespace WIZN
{
    public class Main : Script
    {
        public void ServerLog(string message)
        {
            NAPI.Util.ConsoleOutput($"[Log] {message}");
            return;
        }

        [ServerEvent(Event.ResourceStart)] //This type of event is mainly used for handling stuff after this resource has been initiated.
        public void ResourceStart()
        {
            ServerLog("The Gamemode Has Been Started.");
            NAPI.Server.SetGlobalServerChat(false);
        }

        [ServerEvent(Event.ResourceStop)] //This type of event is mainly used for handling stuff before resource termination.
        public void ResourceStop()
        {
            ServerLog("Server Will Be Terminated");
        }


        [ServerEvent(Event.ResourceStartEx)] //This event is triggered when a resource starts.
        public void OnResourceStartEx(string resourceName)
        {
            NAPI.Chat.SendChatMessageToAll($"Resource {resourceName} got started!");
        }



        [ServerEvent(Event.ResourceStopEx)] //This event is triggered when a resource stops.
        public void OnResourceStopEx(string resourceName)
        {
            NAPI.Chat.SendChatMessageToAll($"Resource {resourceName} is stopped!");
        }



        [ServerEvent(Event.Update)] //This event is used for iterating code at server's tickrate.
        public void OnUpdate()
        {

        }



        [ServerEvent(Event.ChatMessage)] // Handling server chat.
        public void OnChatMessage(Player player, string message)
        {
            if (message.Contains("Foo"))
            {
                NAPI.Chat.SendChatMessageToPlayer(player, "Prohibited word!");
                return;
            }
        }



        [ServerEvent(Event.PlayerConnected)] //This event is invoked once the player has finished loading all the required resources.
        public void OnPlayerConnected(Player player)
        {
            player.SendChatMessage($"Welcome to our server {player.Name}");
        }



        [ServerEvent(Event.PlayerDisconnected)] //This type of event is used for handling code when the player disconnects.
        public void OnPlayerDisconnected(Player player, DisconnectionType type, string reason)
        {
            switch (type)
            {
                case DisconnectionType.Left:
                    NAPI.Chat.SendChatMessageToAll("~b~" + player.Name + "~w~ has quit the server.");
                    break;

                case DisconnectionType.Timeout:
                    NAPI.Chat.SendChatMessageToAll("~b~" + player.Name + "~w~ has timed out.");
                    break;

                case DisconnectionType.Kicked:
                    NAPI.Chat.SendChatMessageToAll("~b~" + player.Name + "~w~ has been kicked for " + reason);
                    break;
            }
        }



        [ServerEvent(Event.PlayerDeath)] //This type of event is used for handling code when someone dies.
        public void OnPlayerDeath(Player player, Player killer, uint reason)
        {
            if (!killer.IsNull)
            {
                NAPI.Notification.SendNotificationToAll($"{killer.Name} killed {player.Name}");
            }
            else
            {
                NAPI.Notification.SendNotificationToAll($"{player.Name} died");
            }
        }



        [ServerEvent(Event.PlayerSpawn)] //This type of event is used for handling your code when you spawn.
        public void OnPlayerSpawn(Player player)
        {

        }



        [ServerEvent(Event.PlayerPickup)] //This type of event is used for handling code when the character picks up a pickup entity.
        public void OnPlayerPickup(Player player, Pickup pickup)
        {

        }



        [ServerEvent(Event.PlayerDamage)] //This event is triggered when a player's health or armor changes.
        public void OnPlayerDamage(Player player, float healthLoss, float armorLoss)
        {

        }



        [ServerEvent(Event.PlayerEnterVehicle)] // This type of event is used for handling code when the player enters any type of vehicle.
        public void OnPlayerEnterVehicle(Player player, Vehicle vehicle, sbyte seatID)
        {
            NAPI.Chat.SendChatMessageToPlayer(player, "You've entered the vehicle");
        }



        [ServerEvent(Event.PlayerExitVehicle)] //This type of event is used for handling code when the player exits any type of vehicle.
        public void OnPlayerExitVehicle(Player player, Vehicle vehicle)
        {
            NAPI.Chat.SendChatMessageToPlayer(player, "You've left the vehicle");
        }



        [ServerEvent(Event.PlayerWeaponSwitch)] //This event is triggered when a player changes weapon.
        public void OnPlayerWeaponSwitch(Player player, WeaponHash oldWeapon, WeaponHash newWeapon)
        {

        }



        [ServerEvent(Event.PlayerDetonateStickies)] //This event is triggered when a player detonate stickies.
        public void OnPlayerDetonateStickies(Player player)
        {

        }



        [ServerEvent(Event.PlayerEnterColshape)] //This type of event is used for handling code when the player enters a ColShape.
        public void OnPlayerEnterColshape(ColShape shape, Player player)
        {

        }



        [ServerEvent(Event.PlayerExitColshape)] //This event is triggered when a player exits a colshape.
        public void OnPlayerExitColShape(ColShape shape, Player player)
        {

        }



        [ServerEvent(Event.PlayerEnterCheckpoint)] //Event when player enters checkpoint.
        public void OnPlayerEnterCheckpoint(Checkpoint checkpoint, Player player)
        {

        }



        [ServerEvent(Event.PlayerExitCheckpoint)] //Event when player exits checkpoint.
        public void OnPlayerExitCheckpoint(Checkpoint checkpoint, Player player)
        {

        }



        [ServerEvent(Event.VehicleDamage)] //This event is triggered when a vehicle's health changes.
        public void OnVehicleDamageHandler(Vehicle vehicle, float bodyHealthLoss, float engineHealthLoss)
        {

        }



        [ServerEvent(Event.VehicleSirenToggle)] // This event is triggered when siren toggle.
        public void OnVehicleSirenToggle(Vehicle vehicle, bool oldValue)
        {

        }



        [ServerEvent(Event.VehicleDoorBreak)] //This event is triggered when a vehicle door break.
        public void OnVehicleDoorBreak(Vehicle vehicle, int doorIndex)
        {

        }



        [ServerEvent(Event.VehicleWindowSmash)] //This event is triggered when a vehicle window get smashed.
        public void OnVehicleWindowSmash(Vehicle vehicle, int windowIndex)
        {

        }



        [ServerEvent(Event.VehicleTyreBurst)] //This event is triggered when a vehicle tyre burst.
        public void OnVehicleTyreBurst(Vehicle vehicle, int tyreIndex)
        {

        }



        [ServerEvent(Event.VehicleDeath)] //This type of event is used for handling code when a vehicle gets destroyed.
        public void OnVehicleDeath(Vehicle veh)
        {

        }



        [ServerEvent(Event.VehicleTrailerChange)] //This event is triggered when a vehicle trailer change.
        public void OnVehicleTrailerChange(Vehicle vehicle, Vehicle trailer)
        {

        }
    }
}