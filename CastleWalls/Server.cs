using DNA;
using DNA.CastleMinerZ;
using DNA.CastleMinerZ.AI;
using DNA.CastleMinerZ.Inventory;
using DNA.CastleMinerZ.Net;
using DNA.Net.GamerServices;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CastleMod
{
    internal class Server
    {
        public static void SendFakeConnect()
        {
            string username = Globalization.Chars.ToList().OrderBy(x => Globalization.rand.Next(0, Globalization.Chars.Length)).Select(x => x.ToString()).Aggregate((a, b) => { return a + b; });
            GameWorld.instance.CurrentNetworkSession.ReportClientJoined(username);
        }

        public static void KillAllPlayers()
        {
            Console.WriteLine("BOOM");
            foreach (NetworkGamer networkGamer in GameWorld.instance.CurrentNetworkSession.AllGamers)
            {
                if (networkGamer.Gamertag != GameWorld.instance.MyNetworkGamer.Gamertag)
                {
                    Player player = (Player)networkGamer.Tag;
                    DetonateExplosiveMessage.Send(GameWorld.instance.MyNetworkGamer, new IntVector3((int)player.LocalPosition.X, (int)player.LocalPosition.Y, (int)player.LocalPosition.Z), true, ExplosiveTypes.Rocket);
                }
            }
        }

        public static void KillPlayer(string name)
        {
            Console.WriteLine("BOOM");
            var player = (Player)GetPlayers().Where(x => x.Gamertag == name).FirstOrDefault().Tag;
            DetonateExplosiveMessage.Send(GameWorld.instance.MyNetworkGamer, new IntVector3((int)player.LocalPosition.X, (int)player.LocalPosition.Y, (int)player.LocalPosition.Z), true, ExplosiveTypes.Rocket);
        }


        public static void SetPVP()
        {
            //var pvp = (CastleMinerZGame.PVPEnum)GameWorld.instance.CurrentNetworkSession.SessionProperties[5].Value;
            GameWorld.instance.CurrentNetworkSession.SessionProperties[5] = Convert.ToInt32(CastleMinerZGame.PVPEnum.Everyone);
            GameWorld.instance.PVPState = CastleMinerZGame.PVPEnum.Everyone;

           // GameWorld.instance.CurrentNetworkSession.UpdateHostSession("Bruh GIt Gud", false, true, GameWorld.instance.CurrentNetworkSession.SessionProperties);
        }
        public static void ServerSetGamemode()
        {
            GameWorld.instance.CurrentNetworkSession.SessionProperties[2] = Convert.ToInt32(DNA.CastleMinerZ.UI.GameModeTypes.Endurance);
            GameWorld.instance.CurrentNetworkSession.SessionProperties[4] = 1;

        }
        public static void SpawnItem(string pname, InventoryItemIDs ids, Int32 num)
        {
            Console.WriteLine("Spawned?");
            var player = (Player)GetPlayers().Where(x => x.Gamertag == pname).FirstOrDefault().Tag;
            PickupManager pickup = new PickupManager();
            InventoryItemIDs id = (InventoryItemIDs)ids;
            InventoryItem inventoryItem = InventoryItem.CreateItem(id, num);
            pickup.CreatePickup(inventoryItem, new IntVector3((int)player.LocalPosition.X, (int)player.LocalPosition.Y, (int)player.LocalPosition.Z), true);
        }
        public static List<NetworkGamer> GetPlayers()
        {
            return GameWorld.instance.CurrentNetworkSession.AllGamers.Cast<NetworkGamer>().ToList();
        }

        public static void ForceDragon()
        {
            EnemyManager.Instance.ForceDragonSpawn(DragonTypeEnum.SKELETON);
        }

        public static void KillAllMonsters()
        {
            EnemyManager.Instance._enemies.ForEach(z =>
            {
                DetonateExplosiveMessage.Send(GameWorld.instance.MyNetworkGamer, new IntVector3((int)z.LocalPosition.X, (int)z.LocalPosition.Y, (int)z.LocalPosition.Z), true, ExplosiveTypes.Rocket);
            });
        }

        public static void SpawnHell()
        {
            GetPlayers().ForEach(x =>
            {
                Player p = (Player)x.Tag;
                for (int i = 0; i < 20; i++)
                {
                    EnemyManager.Instance.SpawnEnemy(p.LocalPosition, EnemyTypeEnum.ALIEN, p.LocalPosition, 10, p.Name);
                }
                EnemyManager.Instance._enemies.ForEach(z => { z.Target = p; });
            });
        }

        public static void SpawnHell(string name)
        {
            var p = (Player)GetPlayers().Where(x => x.Gamertag == name).FirstOrDefault().Tag;
            EnemyManager.Instance.SpawnEnemy(p.LocalPosition, EnemyTypeEnum.ALIEN, p.LocalPosition, 10, p.Name);
        }

        public static void TpToPlayer(string name)
        {
            var p = (Player)GetPlayers().Where(x => x.Gamertag == name).FirstOrDefault().Tag;
            //var localp = (Player)GameWorld.instance.MyNetworkGamer.Tag;
            //    p.LocalPosition = localp.LocalPosition;
            GameWorld.instance.LocalPlayer.LocalPosition =  p.LocalPosition;



        }
    }
}