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
    public partial class GamemodeForm : Form
    {
        public GamemodeForm()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            GameWorld.instance.GameMode = DNA.CastleMinerZ.UI.GameModeTypes.Creative;
            if (checkBox1.Checked)
            {
                BroadcastTextMessage.Send(GameWorld.instance.MyNetworkGamer, GameWorld.instance.MyNetworkGamer.Gamertag + " Set His Gamemode on " + DNA.CastleMinerZ.UI.GameModeTypes.Creative.ToString());
            }

        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GameWorld.instance.GameMode = DNA.CastleMinerZ.UI.GameModeTypes.Endurance;
            if (checkBox1.Checked)
            {
                BroadcastTextMessage.Send(GameWorld.instance.MyNetworkGamer, GameWorld.instance.MyNetworkGamer.Gamertag + " Set His Gamemode on " + DNA.CastleMinerZ.UI.GameModeTypes.Endurance.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GameWorld.instance.GameMode = DNA.CastleMinerZ.UI.GameModeTypes.Survival;
            if (checkBox1.Checked)
            {
                BroadcastTextMessage.Send(GameWorld.instance.MyNetworkGamer, GameWorld.instance.MyNetworkGamer.Gamertag + " Set His Gamemode on " + DNA.CastleMinerZ.UI.GameModeTypes.Survival.ToString());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GameWorld.instance.GameMode = DNA.CastleMinerZ.UI.GameModeTypes.DragonEndurance;
            if (checkBox1.Checked)
            {
                BroadcastTextMessage.Send(GameWorld.instance.MyNetworkGamer, GameWorld.instance.MyNetworkGamer.Gamertag + " Set His Gamemode on " + DNA.CastleMinerZ.UI.GameModeTypes.DragonEndurance.ToString());
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            GameWorld.instance.GameMode = DNA.CastleMinerZ.UI.GameModeTypes.Exploration;
            if (checkBox1.Checked)
            {
                BroadcastTextMessage.Send(GameWorld.instance.MyNetworkGamer, GameWorld.instance.MyNetworkGamer.Gamertag + " Set His Gamemode on " + DNA.CastleMinerZ.UI.GameModeTypes.Exploration.ToString());
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            GameWorld.instance.GameMode = DNA.CastleMinerZ.UI.GameModeTypes.Scavenger;
            if (checkBox1.Checked)
            {
                BroadcastTextMessage.Send(GameWorld.instance.MyNetworkGamer, GameWorld.instance.MyNetworkGamer.Gamertag + " Set His Gamemode on " + DNA.CastleMinerZ.UI.GameModeTypes.Scavenger.ToString());
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            GameWorld.instance.Difficulty = DNA.CastleMinerZ.UI.GameDifficultyTypes.EASY;
            if (checkBox1.Checked)
            {
                BroadcastTextMessage.Send(GameWorld.instance.MyNetworkGamer, GameWorld.instance.MyNetworkGamer.Gamertag + " Set Difficulty on " + DNA.CastleMinerZ.UI.GameDifficultyTypes.EASY.ToString());
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            GameWorld.instance.Difficulty = DNA.CastleMinerZ.UI.GameDifficultyTypes.HARD;
            if (checkBox1.Checked)
            {
                BroadcastTextMessage.Send(GameWorld.instance.MyNetworkGamer, GameWorld.instance.MyNetworkGamer.Gamertag + " Set Difficulty on " + DNA.CastleMinerZ.UI.GameDifficultyTypes.HARD.ToString());
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            GameWorld.instance.Difficulty = DNA.CastleMinerZ.UI.GameDifficultyTypes.NOENEMIES;
            if (checkBox1.Checked)
            {
                BroadcastTextMessage.Send(GameWorld.instance.MyNetworkGamer, GameWorld.instance.MyNetworkGamer.Gamertag + " Set Difficulty on " + DNA.CastleMinerZ.UI.GameDifficultyTypes.NOENEMIES.ToString());
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            GameWorld.instance.Difficulty = DNA.CastleMinerZ.UI.GameDifficultyTypes.HARDCORE;
            if (checkBox1.Checked)
            {
                BroadcastTextMessage.Send(GameWorld.instance.MyNetworkGamer, GameWorld.instance.MyNetworkGamer.Gamertag + " Set Dificulty on " + DNA.CastleMinerZ.UI.GameDifficultyTypes.HARDCORE.ToString());
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = GameWorld.instance.GameMode.ToString();
            label4.Text = GameWorld.instance.Difficulty.ToString();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

    }
}


