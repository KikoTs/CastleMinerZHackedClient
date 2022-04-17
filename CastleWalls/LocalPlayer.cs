using DNA.CastleMinerZ;
using DNA.CastleMinerZ.Inventory;
using DNA.CastleMinerZ.Net;
using DNA.CastleMinerZ.UI;
using DNA.Drawing;
using DNA.Net;
using DNA.Net.GamerServices;
using DNA.Timers;
using System;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace CastleMod
{
    public class LocalPlayer : IGameMessageHandler
    {
        public static Player LPlayer { get { return GameWorld.instance.LocalPlayer; } }
        public static GameModeTypes SetGameMode { set { GameWorld.instance.GameMode = value; } }

        public static GameDifficultyTypes gameDifficulty { set { GameWorld.instance.Difficulty = value; } }

        public static int JmpCount { set { LPlayer.JumpCountLimit = value; } }
        public static void SetDiff(GameDifficultyTypes DiffType)
        {
            GameWorld.instance.Difficulty = DiffType;
            Console.WriteLine("Debug:Set Difficulty: " + DiffType);
        }
        public static void DisableJumpLimit()
        {
            GameWorld.instance.LocalPlayer.JumpCountLimit = 1000000;
        }
        public static void EnableJumpLimit()
        {
            GameWorld.instance.LocalPlayer.JumpCountLimit = 2;
        }
        public static void SetFly(bool State)
        {
            GameWorld.instance.LocalPlayer.FlyMode = State;
            Console.WriteLine("Debug:FlyMode: " + State.ToString());
        }
        public static void FinishReloading()
        {
            try
            {
                GameWorld.instance.LocalPlayer.ReadyToThrowGrenade = true;
                if (GameWorld.instance.LocalPlayer.Reloading)
                {
                    GameWorld.instance.LocalPlayer.FinishReload();
                }
            }
            catch
            {
            }
        }
        public static void RefillHPSP()
        {
            try
            {
                GameWorld.instance.GameScreen.HUD.PlayerHealth = 1f;
                GameWorld.instance.GameScreen.HUD.PlayerStamina = 1f;
            }
            catch
            {
            }
        }
        public static void SetHost()
        {
            try
            {
                if (GameWorld.instance.CurrentNetworkSession != null && !GameWorld.instance.MyNetworkGamer.IsHost)
                {
                    GameWorld.instance.CurrentNetworkSession.AllowHostMigration = true;
                    AppointServerMessage.Send(GameWorld.instance.MyNetworkGamer, GameWorld.instance.MyNetworkGamer.Id);
                    bool isGameHost = GameWorld.instance.IsGameHost;
                }
            }
            catch
            {
            }
        }
        public static void SetDurability()
        {
            var item = (LPlayer.PlayerInventory.ActiveInventoryItem);
            item.ItemHealthLevel = 1f; 
        }
        public static void ForceHostMigration()
        {
            if (!GameWorld.instance.IsGameHost)
            {
                GameWorld.instance.CurrentNetworkSession.AllowHostMigration = true;
                AppointServerMessage.Send(GameWorld.instance.MyNetworkGamer, GameWorld.instance.MyNetworkGamer.Id);
            }
        }
        public static void SetNamePlayer(string name, string pname)
        {
            Server.GetPlayers().Where(x => x.Gamertag == pname).FirstOrDefault().Gamertag = name;
        }
        public static void SetName(string name)
        {
            GameWorld.instance.MyNetworkGamer.Gamertag = name;
        }

        public static void SetSpeed(float amt)
        {
            Assembly.GetEntryAssembly().GetType("DNA.CastleMinerZ.Player").GetField("_sprintMultiplier", BindingFlags.NonPublic | BindingFlags.Instance).SetValue(LPlayer, amt);
        }

        public static void SetGravity(float amt)
        {
            BasicPhysics.Gravity = new Microsoft.Xna.Framework.Vector3(0f, amt, 0f);
        }

        public static void InfiniteAmmo(bool state)
        {
            if (state)
            {
                GameMessageManager.Instance.Subscribe(Init.MSGHANDLER, GameMessageType.LocalPlayerFiredGun);
                GameWorld.instance.InfiniteResourceMode = true;
            }
            else
            {
                GameMessageManager.Instance.UnSubscribe(GameMessageType.LocalPlayerFiredGun, Init.MSGHANDLER);
                GameWorld.instance.InfiniteResourceMode = false;
            }
        }

        public static void UnlockDragonMode()
        {
            GameWorld.instance.PlayerStats.UndeadDragonKills = 1;
        }

        public static void MaxItems()
        {
            var item = (LPlayer.PlayerInventory.ActiveInventoryItem);
            if (item.MaxStackCount > 1)
            {
            item.StackCount = item.MaxStackCount;
            }
        }

        public static void SuperPix(bool state)
        {

            if (state)
            {
                GameMessageManager.Instance.Subscribe(Init.MSGHANDLER, GameMessageType.LocalPlayerPickedAtBlock);
            }
            else
            {
                GameMessageManager.Instance.UnSubscribe(GameMessageType.LocalPlayerPickedAtBlock, Init.MSGHANDLER);
            }
        }
        public static void InfoGatherOnSelectedPlayer(string pname)
        {
          //  var splayer = Server.GetPlayers().Where(x => x.Gamertag == pname).FirstOrDefault().Tag;
            var ad = Server.GetPlayers().Where(x => x.Gamertag == pname).FirstOrDefault().AlternateAddress;
            var id = Server.GetPlayers().Where(x => x.Gamertag == pname).FirstOrDefault().Id;
            var host = Server.GetPlayers().Where(x => x.Gamertag == pname).FirstOrDefault().IsHost;
            var local = Server.GetPlayers().Where(x => x.Gamertag == pname).FirstOrDefault().IsLocal;
            var left = Server.GetPlayers().Where(x => x.Gamertag == pname).FirstOrDefault().HasLeftSession;
            var ip = Server.GetPlayers().Where(x => x.Gamertag == pname).FirstOrDefault().PublicAddress;
            var csgo = Server.GetPlayers().Where(x => x.Gamertag == pname).FirstOrDefault().Session;

            Console.WriteLine("Selected Player: " + pname);
            Console.WriteLine("Alternate Address on Selected Player: " + ad.ToString());
            Console.WriteLine("Global Id on Selected Player: " + id.ToString());
            Console.WriteLine("Selected Player is Host: " + host.ToString());
            Console.WriteLine("Selected Player is Local: " + local.ToString());
            Console.WriteLine("Selected Player is Left: " + left.ToString());
           // Console.WriteLine("Ip Address Selected Player: " + ip);
        }
        public static void InfoGatherOnSelectedPlayerPublic(string pname)
        {

            //  var splayer = Server.GetPlayers().Where(x => x.Gamertag == pname).FirstOrDefault().Tag;
            var ad = Server.GetPlayers().Where(x => x.Gamertag == pname).FirstOrDefault().AlternateAddress;
            var id = Server.GetPlayers().Where(x => x.Gamertag == pname).FirstOrDefault().Id;
            var host = Server.GetPlayers().Where(x => x.Gamertag == pname).FirstOrDefault().IsHost;
            var local = Server.GetPlayers().Where(x => x.Gamertag == pname).FirstOrDefault().IsLocal;
            var left = Server.GetPlayers().Where(x => x.Gamertag == pname).FirstOrDefault().HasLeftSession;
            //var ip = Server.GetPlayers().Where(x => x.Gamertag == pname).FirstOrDefault().PublicAddress;
            //var csgo = Server.GetPlayers().Where(x => x.Gamertag == pname).FirstOrDefault().Session;

            BroadcastTextMessage.Send(GameWorld.instance.MyNetworkGamer, "Selected Player: " + pname);
            BroadcastTextMessage.Send(GameWorld.instance.MyNetworkGamer, "Alternate Address on Selected Player: " + ad.ToString());
            BroadcastTextMessage.Send(GameWorld.instance.MyNetworkGamer, "Global Id on Selected Player: " + id.ToString());
            BroadcastTextMessage.Send(GameWorld.instance.MyNetworkGamer, "Selected Player is Host: " + host.ToString());
            BroadcastTextMessage.Send(GameWorld.instance.MyNetworkGamer, "Selected Player is Local: " + local.ToString());
            BroadcastTextMessage.Send(GameWorld.instance.MyNetworkGamer, "Selected Player is Left: " + left.ToString());
            // BroadcastTextMessage.Send(GameWorld.instance.MyNetworkGamer,"Ip Address Selected Player: " + ip);
        }
        public static void SendMessage(string chatmessage)

        {
            // var sender = Server.GetPlayers().Where(x => x.Gamertag == pname);
            // ChatMessage sendInstance = (ChatMessage)Assembly.GetAssembly(typeof(DNA.Net.Message)).GetType("DNA.Net.Message").GetField("GetSendInstance", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(GameWorld.instance.MyNetworkGamer));
            // ChatMessage sendInstance = Message.GetSendInstance<ChatMessage>();
            //ChatMessage.Send(GameWorld.instance.MyNetworkGamer, chatmessage);
            BroadcastTextMessage.Send(GameWorld.instance.MyNetworkGamer, chatmessage);
            // sendInstance.DoSend(from);
        }
        public static void LocalMessage(string lmessage)
        {
            Console.WriteLine(lmessage);
        }

        public static void InfoGather()
        {

            Console.WriteLine("Selected Player: " + GameWorld.instance.MyNetworkGamer.Gamertag);
            Console.WriteLine("Alternate Address: " + Assembly.GetAssembly(typeof(DNA.Net.GamerServices.NetworkGamer)).GetType("DNA.Net.GamerServices.NetworkGamer").GetField("_alternateAddress", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(GameWorld.instance.MyNetworkGamer));
            Console.WriteLine("Global ID: " + Assembly.GetAssembly(typeof(DNA.Net.GamerServices.NetworkGamer)).GetType("DNA.Net.GamerServices.NetworkGamer").GetField("_globalId", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(GameWorld.instance.MyNetworkGamer));
            Console.WriteLine("Is Host: " + Assembly.GetAssembly(typeof(DNA.Net.GamerServices.NetworkGamer)).GetType("DNA.Net.GamerServices.NetworkGamer").GetField("_isHost", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(GameWorld.instance.MyNetworkGamer));
            Console.WriteLine("Is Local: " + Assembly.GetAssembly(typeof(DNA.Net.GamerServices.NetworkGamer)).GetType("DNA.Net.GamerServices.NetworkGamer").GetField("_isLocal", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(GameWorld.instance.MyNetworkGamer));
            Console.WriteLine("Public Address: " + Assembly.GetAssembly(typeof(DNA.Net.GamerServices.NetworkGamer)).GetType("DNA.Net.GamerServices.NetworkGamer").GetField("_publicAddress", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(GameWorld.instance.MyNetworkGamer));
            Console.WriteLine("Has Left The Session: " + Assembly.GetAssembly(typeof(DNA.Net.GamerServices.NetworkGamer)).GetType("DNA.Net.GamerServices.NetworkGamer").GetField("_hasLeftSession", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(GameWorld.instance.MyNetworkGamer));



            // Console.WriteLine("Public Address on Selected Player: " + Assembly.GetAssembly(typeof(DNA.Net.GamerServices.NetworkGamer)).GetType("DNA.Net.GamerServices.NetworkGamer").GetField("_publicAddress", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(ip.ToString()));
            //Console.WriteLine("Alternate Address on Selected Player: " + Assembly.GetAssembly(typeof(DNA.Net.GamerServices.NetworkGamer)).GetType("DNA.Net.GamerServices.NetworkGamer").GetField("_alternateAddress", BindingFlags.NonPublic | BindingFlags.Instance).GetValue());
            // Console.WriteLine("Global ID on Selected Player: " + Assembly.GetAssembly(typeof(DNA.Net.GamerServices.NetworkGamer)).GetType("DNA.Net.GamerServices.NetworkGamer").GetField("_globalId", BindingFlags.Instance | BindingFlags.NonPublic).GetValue((byte)id));
            //Console.WriteLine("Is Host Selected Player: " + Assembly.GetAssembly(typeof(DNA.Net.GamerServices.NetworkGamer)).GetType("DNA.Net.GamerServices.NetworkGamer").GetField("_isHost", BindingFlags.NonPublic | BindingFlags.Instance).GetValue((bool)host));
            //Console.WriteLine("Is Local Selected Player: " + Assembly.GetAssembly(typeof(DNA.Net.GamerServices.NetworkGamer)).GetType("DNA.Net.GamerServices.NetworkGamer").GetField("_isLocal", BindingFlags.Instance | BindingFlags.NonPublic).GetValue((bool)local));
            //Console.WriteLine("Has Left The Session Selected Player: " + Assembly.GetAssembly(typeof(DNA.Net.GamerServices.NetworkGamer)).GetType("DNA.Net.GamerServices.NetworkGamer").GetField("_hasLeftSession", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(left));

        }
        public static void RandomizeID(byte? id = null)
        {
            Assembly.GetAssembly(typeof(DNA.Net.GamerServices.NetworkGamer)).GetType("DNA.Net.GamerServices.NetworkGamer").GetField("_alternateAddress", BindingFlags.NonPublic | BindingFlags.Instance).SetValue(GameWorld.instance.MyNetworkGamer, Convert.ToUInt64((Globalization.rand.Next(1, int.MaxValue))));
            Assembly.GetAssembly(typeof(DNA.Net.GamerServices.NetworkGamer)).GetType("DNA.Net.GamerServices.NetworkGamer").GetField("_globalId", BindingFlags.Instance | BindingFlags.NonPublic).SetValue(GameWorld.instance.MyNetworkGamer, id != null ? id : (byte)Globalization.rand.Next(0, byte.MaxValue));
        }

        public static void DaytimeGetsAawayFromMe(float amt = 0.41f)
        {
            //GameWorld.instance.GameScreen._sky.Day = amt;
            GameWorld.instance.GameScreen._sky.drawLightning = true;
        }

        public static void setDamage(float dmg = float.MaxValue, bool rapid = false)
        {
            if ((LPlayer.PlayerInventory.ActiveInventoryItem is DNA.CastleMinerZ.Inventory.GunInventoryItem))
            {
                var gun = (LPlayer.PlayerInventory.ActiveInventoryItem as DNA.CastleMinerZ.Inventory.GunInventoryItem).GunClass;

                if (gun.EnemyDamage != float.MaxValue || gun.Name.ToLower().Contains("rocket") || rapid)
                {
                    gun.EnemyDamage = dmg;
                    gun.Velocity = 100000f;
                    gun.FlightTime = 100000f;
                    gun.Recoil = new DNA.Angle();
                    gun.MinInnaccuracy = new DNA.Angle();
                    gun.MaxInnaccuracy = new DNA.Angle();
                    gun.ShoulderedMaxAccuracy = new DNA.Angle();
                    gun.ShoulderedMinAccuracy = new DNA.Angle();
                    gun.ClipCapacity = int.MaxValue;
                    gun.ItemSelfDamagePerUse = 0f;
                }

                if (rapid)
                {
                    gun.Automatic = rapid;
                 //   LPlayer.PlayerInventory.ActiveInventoryItem._coolDownTimer = new OneShotTimer(new TimeSpan(0));
                }
            }
        }

        public static void CpyPInven(string pname)
        {
            // ACTUALLY FUCKING WORKING!!!!
            var i = LPlayer.PlayerInventory;
            //var item = i.TrayManager.GetItemFromCurrentTray(1);
            for (int k = 0; k < i.Inventory.Length; k++)
            {
                if (i.TrayManager.GetItemFromCurrentTray(k) != null)
                {
                    LPlayer.PlayerInventory.AddInventoryItem(i.TrayManager.GetItemFromCurrentTray(k), true);
                    MessageBox.Show(i.TrayManager.GetItemFromCurrentTray(k).Name);
                }
            }
        }
        public static void ItemAdd(Int32 num, InventoryItemIDs ids)
        {
            var i = (Server.GetPlayers().Where(x => x.Gamertag == GameWorld.instance.MyNetworkGamer.Gamertag).FirstOrDefault().Tag as Player).PlayerInventory;
            InventoryItemIDs id = (InventoryItemIDs)ids;
            InventoryItem inventoryItem = InventoryItem.CreateItem(id, num);
            i.AddInventoryItem(inventoryItem, true);
        }


        public void HandleMessage(GameMessageType type, object data, object sender)
        {
            switch (type)
            {
                case GameMessageType.LocalPlayerMinedBlock:
                    break;

                case GameMessageType.LocalPlayerPickedAtBlock:
                    GameWorld.instance.GameScreen.HUD.Dig(LPlayer.PlayerInventory.ActiveInventoryItem, true);
                    break;

                case GameMessageType.LocalPlayerFiredGun:
                    (LPlayer.PlayerInventory.ActiveInventoryItem as DNA.CastleMinerZ.Inventory.GunInventoryItem).RoundsInClip++;
                    break;

                case GameMessageType.Count:
                    break;

                default:
                    break;
            }
        }
    }
}