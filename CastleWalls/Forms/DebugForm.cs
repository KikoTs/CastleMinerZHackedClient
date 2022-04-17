using DNA.CastleMinerZ;
using DNA.CastleMinerZ.Inventory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using DNA.CastleMinerZ.Achievements;
using DNA.CastleMinerZ.Net;
using DNA.Net.GamerServices;
using DNA.CastleMinerZ.Net.Steam;

namespace CastleMod.Forms
{
    public partial class DebugForm : Form
    {
        bool PlayerSelected = false;
        public DebugForm()
        {
            InitializeComponent();
            timer1.Start();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void DebugForm_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)

        {
            if (GameWorld.instance.CurrentNetworkSession != null)
            {
                var pvp = (CastleMinerZGame.PVPEnum)GameWorld.instance.CurrentNetworkSession.SessionProperties[5];
                var gamemode = (CastleMinerZGame.PVPEnum)GameWorld.instance.CurrentNetworkSession.SessionProperties[2];
                var diff = (CastleMinerZGame.PVPEnum)GameWorld.instance.CurrentNetworkSession.SessionProperties[3];
                string spvp = pvp.ToString();
                string sgamemode = gamemode.ToString();
                string sdiff = diff.ToString();
                label20.Text = "//"; //server name
                label17.Text = "// Gamemode: " + sgamemode; //server gamemode
                label24.Text = "// PvP: " + spvp; //pvp
                label21.Text = "// Difficulty: " + sdiff; //difficulty

                if (Server.GetPlayers().Count < PlayerSelect.Items.Count || Server.GetPlayers().Count > PlayerSelect.Items.Count)
                {
                    PlayerSelect.Items.Clear();
                    Server.GetPlayers().ForEach(x =>
                    {
                        PlayerSelect.Items.Add(x.Gamertag);
                    });

                }

                if (PlayerSelected == true)
                {
                    var p = (Player)Server.GetPlayers().Where(x => x.Gamertag == PlayerSelect.Text).FirstOrDefault().Tag;
                    label12.Text = Convert.ToString(p.LocalPosition);


                }
                var ishost = Server.GetPlayers().Where(x => x.Gamertag == PlayerSelect.Text).FirstOrDefault().IsHost;
                var tag = Server.GetPlayers().Where(x => x.Gamertag == PlayerSelect.Text).FirstOrDefault().Gamertag;
                label13.Text = tag.ToString();
                label16.Text = ishost.ToString();




            }
            else
            {
                PlayerSelected = false;
                this.Close();
                MessageBox.Show("Not in a session!");

            }    

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {

        }

        private void button22_Click(object sender, EventArgs e)
        {


        }

        private void button24_Click(object sender, EventArgs e)
        {

        }

        private void button25_Click(object sender, EventArgs e)
        {

        }

        private void button26_Click(object sender, EventArgs e)
        {

        }

        private void button27_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure, this will delete all ur data!", "Are you sure?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                GameWorld.instance.CheaterFound();
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private void button28_Click(object sender, EventArgs e)
        {

        }

        private void button29_Click(object sender, EventArgs e)
        {

        }

        private void button30_Click(object sender, EventArgs e)
        {

        }

        private void button23_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {
            //ServerInfo server = new ServerInfo();
            //AvailableNetworkSession session = new AvailableNetworkSession(GameWorld.instance.GetNetworkSessions);
            // Assembly.GetAssembly(typeof(DNA.Net.GamerServices.NetworkGamer)).GetType("DNA.Net.GamerServices.NetworkGamer").GetField("_alternateAddress", BindingFlags.NonPublic | BindingFlags.Instance).SetValue(GameWorld.instance.MyNetworkGamer, Convert.ToUInt64((Globalization.rand.Next(1, int.MaxValue))));
            Clipboard.SetText(label20.Text);
        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            //  Assembly.GetAssembly(typeof(DNA.Net.GamerServices.AvailableNetworkSession)).GetType("DNA.Net.GamerServices.AvailableNetworkSession").GetField("_endPoint", BindingFlags.NonPublic | BindingFlags.Instance).GetValue();
            //NetworkSessionProvider nsp = new NetworkSessionProvider();
            // requestConnectToHostMessage.SessionID = this._sessionID;
            //requestConnectToHostMessage.SessionProperties = this._properties;
            //requestConnectToHostMessage.Password = nsp._password;

        }

        private void label17_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(label17.Text);
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(label24.Text);
        }

        private void label21_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(label21.Text);
        }

        private void PlayerSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            PlayerSelected = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(label16.Text);
        }

        private void label13_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(label13.Text);
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(label9.Text);
        }

        private void label12_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(label12.Text);
        }

        private void label28_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(label28.Text);
        }

        private void label25_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(label25.Text);
        }

        private void label32_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(label32.Text);
        }

        private void label29_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(label29.Text);
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
    }
}
