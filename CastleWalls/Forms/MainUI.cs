using DNA.CastleMinerZ;
using DNA.CastleMinerZ.Achievements;
using DNA.CastleMinerZ.Net;
using DNA.CastleMinerZ.UI;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CastleMod.Forms
{
    public partial class MainUI : Form
    {
        bool LockedPlayerSet = true;
        public MainUI()
        {
            InitializeComponent();
            Timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (GameWorld.instance.CurrentNetworkSession != null)
            {
                #region Local
                if (MaxItemsCheckBox.Checked)
                {
                    LocalPlayer.MaxItems();
                }
                if (DurabilityCheckBox.Checked)
                {
                    LocalPlayer.SetDurability();
                }
                if (HostCB.Checked)
                {
                    LocalPlayer.ForceHostMigration();
                }

                if (GodCB.Checked)
                {
                    LocalPlayer.RefillHPSP();
                }
                if (checkBox4.Checked)
                {
                    LocalPlayer.FinishReloading();
                }

                if (rPidCB.Checked && GameWorld.instance.MyNetworkGamer != null)
                {
                    LocalPlayer.RandomizeID();
                }

                if (KillCB.Checked)
                {
                    LocalPlayer.setDamage(float.MaxValue, RapidCB.Checked);
                }

                PIDlbl.Text = GameWorld.instance.MyNetworkGamer.Id.ToString();
                hNameLbl.Text = GameWorld.instance.CurrentNetworkSession.Host.Gamertag;

                if (Server.GetPlayers().Count < PlayerSelect.Items.Count || Server.GetPlayers().Count > PlayerSelect.Items.Count)
                {
                    PlayerSelect.Items.Clear();
                    Server.GetPlayers().ForEach(x =>
                    {
                        PlayerSelect.Items.Add(x.Gamertag);
                    });
                    
                }
                if(LockedPlayerSet == false)
                {
                    var ad = Server.GetPlayers().Where(x => x.Gamertag == PlayerSelect.Text).FirstOrDefault().AlternateAddress;
                    var id = Server.GetPlayers().Where(x => x.Gamertag == PlayerSelect.Text).FirstOrDefault().Id;
                    var host = Server.GetPlayers().Where(x => x.Gamertag == PlayerSelect.Text).FirstOrDefault().IsHost;
                    label18.Text = id.ToString(); //pid
                    label16.Text = host.ToString(); //host
                    label14.Text = ad.ToString();//steamid
                    label12.Text = PlayerSelect.Text; //nick
                }





                #endregion Local
            }
            else
            {
                label18.Text = ""; //pid
                label16.Text = ""; //host
                label14.Text = "";//steamid
                label12.Text = ""; //nick
                PIDlbl.Text = "";
                hNameLbl.Text = "";
            }

            /* #region BlasterShot_Bug_Fix

             BlasterShot._garbage.ForEach(x =>
             {
                 if (x.CollisionsRemaining == 0)
                 {
                     x.DrawPriority = 0;
                     x.RemoveFromParent();
                 }
             });

             #endregion BlasterShot_Bug_Fix
         */
        }

        private void ammoCB_CheckedChanged(object sender, EventArgs e)
        {
            LocalPlayer.InfiniteAmmo(ammoCB.Checked);
        }

        private void MineCB_CheckedChanged(object sender, EventArgs e)
        {
            LocalPlayer.SuperPix(MineCB.Checked);
        }

        private void SetGmBtn_Click(object sender, EventArgs e)
        {
            Form gamemodeForm = new GamemodeForm();
            gamemodeForm.Show();
        }

        private void KillAllBtn_Click(object sender, EventArgs e)
        {
            Server.KillAllPlayers();
        }

        private void KillAllMonstersBtn_Click(object sender, EventArgs e)
        {
            Server.KillAllMonsters();
        }

        private void pJoinCB_CheckedChanged(object sender, EventArgs e)
        {
            Hooks.PreventPlayerJoin(pJoinCB.Checked);
        }

        private void CpyItemsBtn_Click(object sender, EventArgs e)
        {
            LocalPlayer.CpyPInven(PlayerSelect.Text);
        }

        private void KillrpBtn_Click(object sender, EventArgs e)
        {
            Server.KillPlayer(PlayerSelect.Text);
        }

        private void SpawnDragoonBtn_Click(object sender, EventArgs e)
        {
            Server.ForceDragon();
        }

        private void SwnHellBtn_Click(object sender, EventArgs e)
        {
            Server.SpawnHell(PlayerSelect.Text);
        }

        private void HostCB_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void pSpeedTB_Scroll(object sender, EventArgs e)
        {
            LocalPlayer.SetSpeed(pSpeedTB.Value);
        }

        private void IdStealBtn_Click(object sender, EventArgs e)
        {
            byte id = Server.GetPlayers().Where(x => x.Gamertag == PlayerSelect.Text).FirstOrDefault().Id;
            LocalPlayer.RandomizeID(id);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void MainUI_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LocalPlayer.InfoGather();
        }

        private void PlayerSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            LockedPlayerSet = false;
        }

        private void GodCB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            LocalPlayer.SetHost();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LocalPlayer.InfoGatherOnSelectedPlayer(PlayerSelect.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
           LocalPlayer.SendMessage(textBox1.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form chatform = new ChatForm();
            chatform.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LocalPlayer.LocalMessage(textBox2.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LocalPlayer.InfoGatherOnSelectedPlayerPublic(PlayerSelect.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            LocalPlayer.SetNamePlayer(textBox3.Text, PlayerSelect.Text);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            LocalPlayer.SetName(textBox4.Text);
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox5.Checked)
            {
                LocalPlayer.SetDiff(GameDifficultyTypes.NOENEMIES);
                return;
            }
            LocalPlayer.SetDiff(GameDifficultyTypes.EASY);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox3.Checked)
            {
                LocalPlayer.DisableJumpLimit();
                return;
            }
            LocalPlayer.EnableJumpLimit();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            LocalPlayer.SetFly(checkBox2.Checked);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //Server.NameChange(textBox5.Text, PlayerSelect.Text);
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            Form AwardForm = new AwardForm();
            AwardForm.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form awardFromLocal = new LocalItemAdd();
            awardFromLocal.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Server.SetPVP();
            MessageBox.Show("This only works for the other/host. Doesnt work local.");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Server.ServerSetGamemode();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Server.TpToPlayer(PlayerSelect.Text);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (GameWorld.instance.CurrentNetworkSession != null)
            {
                Form debugform = new DebugForm();
                debugform.Show();
            }
            else
            {
                MessageBox.Show("You must be in a game in order to use this feature!");
            }


        }
        private async void FlexWithAchievements()
        {
            BroadcastTextMessage.Send(GameWorld.instance.MyNetworkGamer, Server.GetPlayers().Where(x => x.Gamertag == GameWorld.instance.MyNetworkGamer.Gamertag).FirstOrDefault().Gamertag + " " + "Has Earned Veteren Miner Z .");
            await TaskEx.Delay(500);
            BroadcastTextMessage.Send(GameWorld.instance.MyNetworkGamer, Server.GetPlayers().Where(x => x.Gamertag == GameWorld.instance.MyNetworkGamer.Gamertag).FirstOrDefault().Gamertag + " " + "Has Earned MinerZ Potato.");
            await TaskEx.Delay(500);
            BroadcastTextMessage.Send(GameWorld.instance.MyNetworkGamer, Server.GetPlayers().Where(x => x.Gamertag == GameWorld.instance.MyNetworkGamer.Gamertag).FirstOrDefault().Gamertag + " " + "Has Earned Short Timer.");
            await TaskEx.Delay(500);
            BroadcastTextMessage.Send(GameWorld.instance.MyNetworkGamer, Server.GetPlayers().Where(x => x.Gamertag == GameWorld.instance.MyNetworkGamer.Gamertag).FirstOrDefault().Gamertag + " " + "Has Earned First Contact.");
            await TaskEx.Delay(500);
            BroadcastTextMessage.Send(GameWorld.instance.MyNetworkGamer, Server.GetPlayers().Where(x => x.Gamertag == GameWorld.instance.MyNetworkGamer.Gamertag).FirstOrDefault().Gamertag + " " + "Has Earned Leaving Home.");
            await TaskEx.Delay(500);
            BroadcastTextMessage.Send(GameWorld.instance.MyNetworkGamer, Server.GetPlayers().Where(x => x.Gamertag == GameWorld.instance.MyNetworkGamer.Gamertag).FirstOrDefault().Gamertag + " " + "Has Earned Desert Crawler.");
            await TaskEx.Delay(500);
            BroadcastTextMessage.Send(GameWorld.instance.MyNetworkGamer, Server.GetPlayers().Where(x => x.Gamertag == GameWorld.instance.MyNetworkGamer.Gamertag).FirstOrDefault().Gamertag + " " + "Has Earned Mountain Man.");
            await TaskEx.Delay(500);
            BroadcastTextMessage.Send(GameWorld.instance.MyNetworkGamer, Server.GetPlayers().Where(x => x.Gamertag == GameWorld.instance.MyNetworkGamer.Gamertag).FirstOrDefault().Gamertag + " " + "Has Earned Deep Freeze.");
            await TaskEx.Delay(500);
            BroadcastTextMessage.Send(GameWorld.instance.MyNetworkGamer, Server.GetPlayers().Where(x => x.Gamertag == GameWorld.instance.MyNetworkGamer.Gamertag).FirstOrDefault().Gamertag + " " + "Has Earned Hell On Earth.");
            await TaskEx.Delay(500);
            BroadcastTextMessage.Send(GameWorld.instance.MyNetworkGamer, Server.GetPlayers().Where(x => x.Gamertag == GameWorld.instance.MyNetworkGamer.Gamertag).FirstOrDefault().Gamertag + " " + "Has Earned Around The World.");
            await TaskEx.Delay(500);
            BroadcastTextMessage.Send(GameWorld.instance.MyNetworkGamer, Server.GetPlayers().Where(x => x.Gamertag == GameWorld.instance.MyNetworkGamer.Gamertag).FirstOrDefault().Gamertag + " " + "Has Earned Deep Digger.");
            await TaskEx.Delay(500);
            BroadcastTextMessage.Send(GameWorld.instance.MyNetworkGamer, Server.GetPlayers().Where(x => x.Gamertag == GameWorld.instance.MyNetworkGamer.Gamertag).FirstOrDefault().Gamertag + " " + "Has Earned Welcome To Hell.");
            await TaskEx.Delay(500);
            BroadcastTextMessage.Send(GameWorld.instance.MyNetworkGamer, Server.GetPlayers().Where(x => x.Gamertag == GameWorld.instance.MyNetworkGamer.Gamertag).FirstOrDefault().Gamertag + " " + "Has Earned Survived The Night.");
            await TaskEx.Delay(500);
            BroadcastTextMessage.Send(GameWorld.instance.MyNetworkGamer, Server.GetPlayers().Where(x => x.Gamertag == GameWorld.instance.MyNetworkGamer.Gamertag).FirstOrDefault().Gamertag + " " + "Has Earned A Week Later.");
            await TaskEx.Delay(500);
            BroadcastTextMessage.Send(GameWorld.instance.MyNetworkGamer, Server.GetPlayers().Where(x => x.Gamertag == GameWorld.instance.MyNetworkGamer.Gamertag).FirstOrDefault().Gamertag + " " + "Has Earned Survivor.");
            await TaskEx.Delay(500);
            BroadcastTextMessage.Send(GameWorld.instance.MyNetworkGamer, Server.GetPlayers().Where(x => x.Gamertag == GameWorld.instance.MyNetworkGamer.Gamertag).FirstOrDefault().Gamertag + " " + "Has Earned 28 Days Later.");
            await TaskEx.Delay(500);
            BroadcastTextMessage.Send(GameWorld.instance.MyNetworkGamer, Server.GetPlayers().Where(x => x.Gamertag == GameWorld.instance.MyNetworkGamer.Gamertag).FirstOrDefault().Gamertag + " " + "Has Earned 28 Weeks Later.");
            await TaskEx.Delay(500);
            BroadcastTextMessage.Send(GameWorld.instance.MyNetworkGamer, Server.GetPlayers().Where(x => x.Gamertag == GameWorld.instance.MyNetworkGamer.Gamertag).FirstOrDefault().Gamertag + " " + "Has Earned Aniversary.");
            await TaskEx.Delay(500);
            BroadcastTextMessage.Send(GameWorld.instance.MyNetworkGamer, Server.GetPlayers().Where(x => x.Gamertag == GameWorld.instance.MyNetworkGamer.Gamertag).FirstOrDefault().Gamertag + " " + "Has Earned Tinkerer.");
            await TaskEx.Delay(500);
            BroadcastTextMessage.Send(GameWorld.instance.MyNetworkGamer, Server.GetPlayers().Where(x => x.Gamertag == GameWorld.instance.MyNetworkGamer.Gamertag).FirstOrDefault().Gamertag + " " + "Has Earned Crafter.");
            await TaskEx.Delay(500);
            BroadcastTextMessage.Send(GameWorld.instance.MyNetworkGamer, Server.GetPlayers().Where(x => x.Gamertag == GameWorld.instance.MyNetworkGamer.Gamertag).FirstOrDefault().Gamertag + " " + "Has Earned Master Craftsman.");
            await TaskEx.Delay(500);
            BroadcastTextMessage.Send(GameWorld.instance.MyNetworkGamer, Server.GetPlayers().Where(x => x.Gamertag == GameWorld.instance.MyNetworkGamer.Gamertag).FirstOrDefault().Gamertag + " " + "Has Earned Self Defense.");
            await TaskEx.Delay(500);
            BroadcastTextMessage.Send(GameWorld.instance.MyNetworkGamer, Server.GetPlayers().Where(x => x.Gamertag == GameWorld.instance.MyNetworkGamer.Gamertag).FirstOrDefault().Gamertag + " " + "Has Earned No Fear.");
            await TaskEx.Delay(500);
            BroadcastTextMessage.Send(GameWorld.instance.MyNetworkGamer, Server.GetPlayers().Where(x => x.Gamertag == GameWorld.instance.MyNetworkGamer.Gamertag).FirstOrDefault().Gamertag + " " + "Has Earned Zombies Slayer.");
            await TaskEx.Delay(500);
            BroadcastTextMessage.Send(GameWorld.instance.MyNetworkGamer, Server.GetPlayers().Where(x => x.Gamertag == GameWorld.instance.MyNetworkGamer.Gamertag).FirstOrDefault().Gamertag + " " + "Has Earned Dragon Slayer.");
            await TaskEx.Delay(500);
            BroadcastTextMessage.Send(GameWorld.instance.MyNetworkGamer, Server.GetPlayers().Where(x => x.Gamertag == GameWorld.instance.MyNetworkGamer.Gamertag).FirstOrDefault().Gamertag + " " + "Has Earned Alien Encounter.");
            await TaskEx.Delay(500);
            BroadcastTextMessage.Send(GameWorld.instance.MyNetworkGamer, Server.GetPlayers().Where(x => x.Gamertag == GameWorld.instance.MyNetworkGamer.Gamertag).FirstOrDefault().Gamertag + " " + "Has Earned Alien Technology.");
            await TaskEx.Delay(500);
            BroadcastTextMessage.Send(GameWorld.instance.MyNetworkGamer, Server.GetPlayers().Where(x => x.Gamertag == GameWorld.instance.MyNetworkGamer.Gamertag).FirstOrDefault().Gamertag + " " + "Has Earned Demolitioner.");
            await TaskEx.Delay(500);
            BroadcastTextMessage.Send(GameWorld.instance.MyNetworkGamer, Server.GetPlayers().Where(x => x.Gamertag == GameWorld.instance.MyNetworkGamer.Gamertag).FirstOrDefault().Gamertag + " " + "Has Earned Air Defense.");
            await TaskEx.Delay(500);
            BroadcastTextMessage.Send(GameWorld.instance.MyNetworkGamer, Server.GetPlayers().Where(x => x.Gamertag == GameWorld.instance.MyNetworkGamer.Gamertag).FirstOrDefault().Gamertag + " " + "Has Earned Fire in The Hole.");
            await TaskEx.Delay(500);
            BroadcastTextMessage.Send(GameWorld.instance.MyNetworkGamer, Server.GetPlayers().Where(x => x.Gamertag == GameWorld.instance.MyNetworkGamer.Gamertag).FirstOrDefault().Gamertag + " " + "Has Earned Boom.");

        }
        private void button16_Click(object sender, EventArgs e)
        {
            CastleMinerZAchievementManager achieve = new CastleMinerZAchievementManager(GameWorld.instance);
            DialogResult dialogResult = MessageBox.Show("Wanna Announce it?", "Nearly there!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                achieve.OnAchieved(achieve.Achievements[1]);
                achieve.OnAchieved(achieve.Achievements[2]);
                achieve.OnAchieved(achieve.Achievements[3]);
                achieve.OnAchieved(achieve.Achievements[4]);
                achieve.OnAchieved(achieve.Achievements[5]);
                achieve.OnAchieved(achieve.Achievements[6]);
                achieve.OnAchieved(achieve.Achievements[7]);
                achieve.OnAchieved(achieve.Achievements[8]);
                achieve.OnAchieved(achieve.Achievements[9]);
                achieve.OnAchieved(achieve.Achievements[10]);
                achieve.OnAchieved(achieve.Achievements[11]);
                achieve.OnAchieved(achieve.Achievements[12]);
                achieve.OnAchieved(achieve.Achievements[13]);
                FlexWithAchievements();
                achieve.OnAchieved(achieve.Achievements[14]);
                achieve.OnAchieved(achieve.Achievements[15]);
                achieve.OnAchieved(achieve.Achievements[16]);
                achieve.OnAchieved(achieve.Achievements[17]);
                achieve.OnAchieved(achieve.Achievements[18]);
                achieve.OnAchieved(achieve.Achievements[19]);
                achieve.OnAchieved(achieve.Achievements[20]);
                achieve.OnAchieved(achieve.Achievements[21]);
                achieve.OnAchieved(achieve.Achievements[22]);
                achieve.OnAchieved(achieve.Achievements[23]);
                achieve.OnAchieved(achieve.Achievements[24]);
                achieve.OnAchieved(achieve.Achievements[25]);
                achieve.OnAchieved(achieve.Achievements[26]);
                achieve.OnAchieved(achieve.Achievements[27]);
                achieve.OnAchieved(achieve.Achievements[28]);
                achieve.OnAchieved(achieve.Achievements[29]);
                achieve.OnAchieved(achieve.Achievements[30]);
              //  achieve.OnAchieved(achieve.Achievements[31]);
            }
            else if (dialogResult == DialogResult.No)
            {
                achieve.OnAchieved(achieve.Achievements[1]);
                achieve.OnAchieved(achieve.Achievements[2]);
                achieve.OnAchieved(achieve.Achievements[3]);
                achieve.OnAchieved(achieve.Achievements[4]);
                achieve.OnAchieved(achieve.Achievements[5]);
                achieve.OnAchieved(achieve.Achievements[6]);
                achieve.OnAchieved(achieve.Achievements[7]);
                achieve.OnAchieved(achieve.Achievements[8]);
                achieve.OnAchieved(achieve.Achievements[9]);
                achieve.OnAchieved(achieve.Achievements[10]);
                achieve.OnAchieved(achieve.Achievements[11]);
                achieve.OnAchieved(achieve.Achievements[12]);
                achieve.OnAchieved(achieve.Achievements[13]);
                achieve.OnAchieved(achieve.Achievements[14]);
                achieve.OnAchieved(achieve.Achievements[15]);
                achieve.OnAchieved(achieve.Achievements[16]);
                achieve.OnAchieved(achieve.Achievements[17]);
                achieve.OnAchieved(achieve.Achievements[18]);
                achieve.OnAchieved(achieve.Achievements[19]);
                achieve.OnAchieved(achieve.Achievements[20]);
                achieve.OnAchieved(achieve.Achievements[21]);
                achieve.OnAchieved(achieve.Achievements[22]);
                achieve.OnAchieved(achieve.Achievements[23]);
                achieve.OnAchieved(achieve.Achievements[24]);
                achieve.OnAchieved(achieve.Achievements[25]);
                achieve.OnAchieved(achieve.Achievements[26]);
                achieve.OnAchieved(achieve.Achievements[27]);
                achieve.OnAchieved(achieve.Achievements[28]);
                achieve.OnAchieved(achieve.Achievements[29]);
                achieve.OnAchieved(achieve.Achievements[30]);
                //achieve.OnAchieved(achieve.Achievements[31]);
            }










        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(label18.Text);
        }

        private void label16_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(label16.Text);
        }

        private void label14_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(label14.Text);
        }

        private void label12_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(label12.Text);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if(GameWorld.instance.MyNetworkGamer.IsHost == true)
            {
                Form hostonly = new HostOnlyForm();
               
                hostonly.Show();
            }
            else if(GameWorld.instance.MyNetworkGamer == null)
            {
                MessageBox.Show("Must be in game!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("You must be host in order to use this menu!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void DurabilityCheckBox_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void MaxItemsCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}