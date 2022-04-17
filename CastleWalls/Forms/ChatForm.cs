
using DNA.CastleMinerZ.Net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CastleMod.Forms
{
    public partial class ChatForm : Form
    {
        public ChatForm()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (GameWorld.instance.CurrentNetworkSession != null)
            {
                #region Local

                if (Server.GetPlayers().Count < comboBox1.Items.Count || Server.GetPlayers().Count > comboBox1.Items.Count)
                {
                    comboBox1.Items.Clear();
                    Server.GetPlayers().ForEach(x =>
                    {
                        comboBox1.Items.Add(x.Gamertag);
                    });
                }

                #endregion Local
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BroadcastTextMessage.Send(GameWorld.instance.MyNetworkGamer, Server.GetPlayers().Where(x => x.Gamertag == comboBox1.Text).FirstOrDefault().Gamertag + " " + "Has Respawned");
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ChatForm_Load(object sender, EventArgs e)
        {

        }

        private void button52_Click(object sender, EventArgs e)
        {
            BroadcastTextMessage.Send(GameWorld.instance.MyNetworkGamer, Server.GetPlayers().Where(x => x.Gamertag == comboBox1.Text).FirstOrDefault().Gamertag + " " + "Has Opened 1,000,000 Lucky Loot Blocks.");
        }

        private void button44_Click(object sender, EventArgs e)
        {
            BroadcastTextMessage.Send(GameWorld.instance.MyNetworkGamer, Server.GetPlayers().Where(x => x.Gamertag == comboBox1.Text).FirstOrDefault().Gamertag + " " + "Has Opened 1,000,000 Loot Blocks.");
        }

        private void button51_Click(object sender, EventArgs e)
        {
            BroadcastTextMessage.Send(GameWorld.instance.MyNetworkGamer, Server.GetPlayers().Where(x => x.Gamertag == comboBox1.Text).FirstOrDefault().Gamertag + " " + "Has Defeated 1,000,000 Zombies.");
        }

        private void button50_Click(object sender, EventArgs e)
        {
            BroadcastTextMessage.Send(GameWorld.instance.MyNetworkGamer, Server.GetPlayers().Where(x => x.Gamertag == comboBox1.Text).FirstOrDefault().Gamertag + " " + "Has Defeated 1,000,000 Aliens.");

        }

        private void button43_Click(object sender, EventArgs e)
        {
            BroadcastTextMessage.Send(GameWorld.instance.MyNetworkGamer, Server.GetPlayers().Where(x => x.Gamertag == comboBox1.Text).FirstOrDefault().Gamertag + " " + "Has Defeated 1,000,000 Dragons.");

        }

        private void button42_Click(object sender, EventArgs e)
        {
            BroadcastTextMessage.Send(GameWorld.instance.MyNetworkGamer, Server.GetPlayers().Where(x => x.Gamertag == comboBox1.Text).FirstOrDefault().Gamertag + " " + "Has Defeated 1,000,000 Players.");

        }

        private void button41_Click(object sender, EventArgs e)
        {
            BroadcastTextMessage.Send(GameWorld.instance.MyNetworkGamer, Server.GetPlayers().Where(x => x.Gamertag == comboBox1.Text).FirstOrDefault().Gamertag + " " + "Has Defeated 1,000,000 HellMinions.");

        }

        private void button46_Click(object sender, EventArgs e)
        {
            BroadcastTextMessage.Send(GameWorld.instance.MyNetworkGamer, Server.GetPlayers().Where(x => x.Gamertag == comboBox1.Text).FirstOrDefault().Gamertag + " " + "Has Defeated 1,000,000 Skeletons.");

        }

        private void button45_Click(object sender, EventArgs e)
        {
            BroadcastTextMessage.Send(GameWorld.instance.MyNetworkGamer, Server.GetPlayers().Where(x => x.Gamertag == comboBox1.Text).FirstOrDefault().Gamertag + " " + "Has Defeated 1,000,000 Underlords.");

        }

        private void button53_Click(object sender, EventArgs e)
        {
            BroadcastTextMessage.Send(GameWorld.instance.MyNetworkGamer, Server.GetPlayers().Where(x => x.Gamertag == comboBox1.Text).FirstOrDefault().Gamertag + " " + "Has Defeated The Super Secret Dragon.");

        }

        private void button54_Click(object sender, EventArgs e)
        {
            BroadcastTextMessage.Send(GameWorld.instance.MyNetworkGamer, Server.GetPlayers().Where(x => x.Gamertag == comboBox1.Text).FirstOrDefault().Gamertag + " " + "Killed The DNA_Developers");

        }

        private void button13_Click(object sender, EventArgs e)
        {
            BroadcastTextMessage.Send(GameWorld.instance.MyNetworkGamer, Server.GetPlayers().Where(x => x.Gamertag == comboBox1.Text).FirstOrDefault().Gamertag + " " + "Is Gay");

        }

        private void button16_Click(object sender, EventArgs e)
        {
            BroadcastTextMessage.Send(GameWorld.instance.MyNetworkGamer, "Changed Host From" + " " + Server.GetPlayers().Where(x => x.Gamertag == comboBox1.Text).FirstOrDefault().Gamertag + ".");

        }

        private void button62_Click(object sender, EventArgs e)
        {
            BroadcastTextMessage.Send(GameWorld.instance.MyNetworkGamer, Server.GetPlayers().Where(x => x.Gamertag == comboBox1.Text).FirstOrDefault().Gamertag + " " + "Has Killed The Fire Dragon.");

        }

        private void button58_Click(object sender, EventArgs e)
        {
            BroadcastTextMessage.Send(GameWorld.instance.MyNetworkGamer, Server.GetPlayers().Where(x => x.Gamertag == comboBox1.Text).FirstOrDefault().Gamertag + " " + "Has Killed The Forest Dragon.");

        }

        private void button57_Click(object sender, EventArgs e)
        {
            BroadcastTextMessage.Send(GameWorld.instance.MyNetworkGamer, Server.GetPlayers().Where(x => x.Gamertag == comboBox1.Text).FirstOrDefault().Gamertag + " " + "Has Killed The Sand Dragon.");

        }

        private void button56_Click(object sender, EventArgs e)
        {
            BroadcastTextMessage.Send(GameWorld.instance.MyNetworkGamer, Server.GetPlayers().Where(x => x.Gamertag == comboBox1.Text).FirstOrDefault().Gamertag + " " + "Has Killed The Ice Dragon.");

        }

        private void button55_Click(object sender, EventArgs e)
        {
            BroadcastTextMessage.Send(GameWorld.instance.MyNetworkGamer, Server.GetPlayers().Where(x => x.Gamertag == comboBox1.Text).FirstOrDefault().Gamertag + " " + "Has Killed The Undead Dragon.");

        }

        private void button12_Click(object sender, EventArgs e)
        {
            BroadcastTextMessage.Send(GameWorld.instance.MyNetworkGamer, Server.GetPlayers().Where(x => x.Gamertag == comboBox1.Text).FirstOrDefault().Gamertag + " " + "Has Earned Veteren Miner Z .");

        }

        private void button11_Click(object sender, EventArgs e)
        {
            BroadcastTextMessage.Send(GameWorld.instance.MyNetworkGamer, Server.GetPlayers().Where(x => x.Gamertag == comboBox1.Text).FirstOrDefault().Gamertag + " " + "Has Earned MinerZ Potato.");

        }

        private void button10_Click(object sender, EventArgs e)
        {
            BroadcastTextMessage.Send(GameWorld.instance.MyNetworkGamer, Server.GetPlayers().Where(x => x.Gamertag == comboBox1.Text).FirstOrDefault().Gamertag + " " + "Has Earned Short Timer.");

        }

        private void button9_Click(object sender, EventArgs e)
        {
            BroadcastTextMessage.Send(GameWorld.instance.MyNetworkGamer, Server.GetPlayers().Where(x => x.Gamertag == comboBox1.Text).FirstOrDefault().Gamertag + " " + "Has Earned First Contact.");

        }

        private void button8_Click(object sender, EventArgs e)
        {
            BroadcastTextMessage.Send(GameWorld.instance.MyNetworkGamer, Server.GetPlayers().Where(x => x.Gamertag == comboBox1.Text).FirstOrDefault().Gamertag + " " + "Has Earned Leaving Home.");

        }

        private void button19_Click(object sender, EventArgs e)
        {
            BroadcastTextMessage.Send(GameWorld.instance.MyNetworkGamer, Server.GetPlayers().Where(x => x.Gamertag == comboBox1.Text).FirstOrDefault().Gamertag + " " + "Has Earned Desert Crawler.");

        }

        private void button18_Click(object sender, EventArgs e)
        {
            BroadcastTextMessage.Send(GameWorld.instance.MyNetworkGamer, Server.GetPlayers().Where(x => x.Gamertag == comboBox1.Text).FirstOrDefault().Gamertag + " " + "Has Earned Mountain Man.");

        }

        private void button17_Click(object sender, EventArgs e)
        {
            BroadcastTextMessage.Send(GameWorld.instance.MyNetworkGamer, Server.GetPlayers().Where(x => x.Gamertag == comboBox1.Text).FirstOrDefault().Gamertag + " " + "Has Earned Deep Freeze.");

        }

        private void button37_Click(object sender, EventArgs e)
        {
            BroadcastTextMessage.Send(GameWorld.instance.MyNetworkGamer, Server.GetPlayers().Where(x => x.Gamertag == comboBox1.Text).FirstOrDefault().Gamertag + " " + "Has Earned Hell On Earth.");

        }

        private void button36_Click(object sender, EventArgs e)
        {
            BroadcastTextMessage.Send(GameWorld.instance.MyNetworkGamer, Server.GetPlayers().Where(x => x.Gamertag == comboBox1.Text).FirstOrDefault().Gamertag + " " + "Has Earned Around The World.");

        }

        private void button35_Click(object sender, EventArgs e)
        {
            BroadcastTextMessage.Send(GameWorld.instance.MyNetworkGamer, Server.GetPlayers().Where(x => x.Gamertag == comboBox1.Text).FirstOrDefault().Gamertag + " " + "Has Earned Deep Digger.");

        }

        private void button34_Click(object sender, EventArgs e)
        {
            BroadcastTextMessage.Send(GameWorld.instance.MyNetworkGamer, Server.GetPlayers().Where(x => x.Gamertag == comboBox1.Text).FirstOrDefault().Gamertag + " " + "Has Earned Welcome To Hell.");

        }

        private void button33_Click(object sender, EventArgs e)
        {
            BroadcastTextMessage.Send(GameWorld.instance.MyNetworkGamer, Server.GetPlayers().Where(x => x.Gamertag == comboBox1.Text).FirstOrDefault().Gamertag + " " + "Has Earned Survived The Night.");

        }

        private void button32_Click(object sender, EventArgs e)
        {
            BroadcastTextMessage.Send(GameWorld.instance.MyNetworkGamer, Server.GetPlayers().Where(x => x.Gamertag == comboBox1.Text).FirstOrDefault().Gamertag + " " + "Has Earned A Week Later.");

        }

        private void button25_Click(object sender, EventArgs e)
        {
            BroadcastTextMessage.Send(GameWorld.instance.MyNetworkGamer, Server.GetPlayers().Where(x => x.Gamertag == comboBox1.Text).FirstOrDefault().Gamertag + " " + "Has Earned Survivor.");

        }

        private void button24_Click(object sender, EventArgs e)
        {
            BroadcastTextMessage.Send(GameWorld.instance.MyNetworkGamer, Server.GetPlayers().Where(x => x.Gamertag == comboBox1.Text).FirstOrDefault().Gamertag + " " + "Has Earned 28 Days Later.");

        }

        private void button23_Click(object sender, EventArgs e)
        {
            BroadcastTextMessage.Send(GameWorld.instance.MyNetworkGamer, Server.GetPlayers().Where(x => x.Gamertag == comboBox1.Text).FirstOrDefault().Gamertag + " " + "Has Earned 28 Weeks Later.");

        }

        private void button28_Click(object sender, EventArgs e)
        {
            BroadcastTextMessage.Send(GameWorld.instance.MyNetworkGamer, Server.GetPlayers().Where(x => x.Gamertag == comboBox1.Text).FirstOrDefault().Gamertag + " " + "Has Earned Aniversary.");

        }

        private void button27_Click(object sender, EventArgs e)
        {
            BroadcastTextMessage.Send(GameWorld.instance.MyNetworkGamer, Server.GetPlayers().Where(x => x.Gamertag == comboBox1.Text).FirstOrDefault().Gamertag + " " + "Has Earned Tinkerer.");

        }

        private void button26_Click(object sender, EventArgs e)
        {
            BroadcastTextMessage.Send(GameWorld.instance.MyNetworkGamer, Server.GetPlayers().Where(x => x.Gamertag == comboBox1.Text).FirstOrDefault().Gamertag + " " + "Has Earned Crafter.");

        }

        private void button31_Click(object sender, EventArgs e)
        {
            BroadcastTextMessage.Send(GameWorld.instance.MyNetworkGamer, Server.GetPlayers().Where(x => x.Gamertag == comboBox1.Text).FirstOrDefault().Gamertag + " " + "Has Earned Master Craftsman.");

        }

        private void button30_Click(object sender, EventArgs e)
        {
            BroadcastTextMessage.Send(GameWorld.instance.MyNetworkGamer, Server.GetPlayers().Where(x => x.Gamertag == comboBox1.Text).FirstOrDefault().Gamertag + " " + "Has Earned Self Defense.");

        }

        private void button29_Click(object sender, EventArgs e)
        {
            BroadcastTextMessage.Send(GameWorld.instance.MyNetworkGamer, Server.GetPlayers().Where(x => x.Gamertag == comboBox1.Text).FirstOrDefault().Gamertag + " " + "Has Earned No Fear.");

        }

        private void button21_Click(object sender, EventArgs e)
        {
            BroadcastTextMessage.Send(GameWorld.instance.MyNetworkGamer, Server.GetPlayers().Where(x => x.Gamertag == comboBox1.Text).FirstOrDefault().Gamertag + " " + "Has Earned Zombies Slayer.");

        }

        private void button22_Click(object sender, EventArgs e)
        {
            BroadcastTextMessage.Send(GameWorld.instance.MyNetworkGamer, Server.GetPlayers().Where(x => x.Gamertag == comboBox1.Text).FirstOrDefault().Gamertag + " " + "Has Earned Dragon Slayer.");

        }

        private void button20_Click(object sender, EventArgs e)
        {
            BroadcastTextMessage.Send(GameWorld.instance.MyNetworkGamer, Server.GetPlayers().Where(x => x.Gamertag == comboBox1.Text).FirstOrDefault().Gamertag + " " + "Has Earned Alien Encounter.");

        }

        private void button61_Click(object sender, EventArgs e)
        {
            BroadcastTextMessage.Send(GameWorld.instance.MyNetworkGamer, Server.GetPlayers().Where(x => x.Gamertag == comboBox1.Text).FirstOrDefault().Gamertag + " " + "Has Earned Alien Technology.");

        }

        private void button60_Click(object sender, EventArgs e)
        {
            BroadcastTextMessage.Send(GameWorld.instance.MyNetworkGamer, Server.GetPlayers().Where(x => x.Gamertag == comboBox1.Text).FirstOrDefault().Gamertag + " " + "Has Earned Demolitioner.");

        }

        private void button59_Click(object sender, EventArgs e)
        {
            BroadcastTextMessage.Send(GameWorld.instance.MyNetworkGamer, Server.GetPlayers().Where(x => x.Gamertag == comboBox1.Text).FirstOrDefault().Gamertag + " " + "Has Earned Air Defense.");

        }

        private void button64_Click(object sender, EventArgs e)
        {
            BroadcastTextMessage.Send(GameWorld.instance.MyNetworkGamer, Server.GetPlayers().Where(x => x.Gamertag == comboBox1.Text).FirstOrDefault().Gamertag + " " + "Has Earned Fire in The Hole.");

        }

        private void button63_Click(object sender, EventArgs e)
        {
            BroadcastTextMessage.Send(GameWorld.instance.MyNetworkGamer, Server.GetPlayers().Where(x => x.Gamertag == comboBox1.Text).FirstOrDefault().Gamertag + " " + "Has Earned Boom.");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            BroadcastTextMessage.Send(GameWorld.instance.MyNetworkGamer, Server.GetPlayers().Where(x => x.Gamertag == comboBox1.Text).FirstOrDefault().Gamertag + " " + "Has Fallen.");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            BroadcastTextMessage.Send(GameWorld.instance.MyNetworkGamer, Server.GetPlayers().Where(x => x.Gamertag == comboBox1.Text).FirstOrDefault().Gamertag + " " + "Has Been Banned by The Host.");

        }

        private void button7_Click(object sender, EventArgs e)
        {
            BroadcastTextMessage.Send(GameWorld.instance.MyNetworkGamer, Server.GetPlayers().Where(x => x.Gamertag == comboBox1.Text).FirstOrDefault().Gamertag + " " + "Has Been Kicked by The Host.");

        }

        private void button6_Click(object sender, EventArgs e)
        {
            BroadcastTextMessage.Send(GameWorld.instance.MyNetworkGamer, Server.GetPlayers().Where(x => x.Gamertag == comboBox1.Text).FirstOrDefault().Gamertag + " " + "Has Restarted The Game.");

        }

        private void button5_Click(object sender, EventArgs e)
        {
            BroadcastTextMessage.Send(GameWorld.instance.MyNetworkGamer, Server.GetPlayers().Where(x => x.Gamertag == comboBox1.Text).FirstOrDefault().Gamertag + " " + "Has Triggered a Monster Spawner.");

        }

        private void button15_Click(object sender, EventArgs e)
        {
            BroadcastTextMessage.Send(GameWorld.instance.MyNetworkGamer, Server.GetPlayers().Where(x => x.Gamertag == comboBox1.Text).FirstOrDefault().Gamertag + " " + "Has Extinguished a Spawn Block.");

        }

        private void button14_Click(object sender, EventArgs e)
        {
            BroadcastTextMessage.Send(GameWorld.instance.MyNetworkGamer, Server.GetPlayers().Where(x => x.Gamertag == comboBox1.Text).FirstOrDefault().Gamertag + " " + "Is Cheater!");

        }

        private void button65_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }
    }
}
