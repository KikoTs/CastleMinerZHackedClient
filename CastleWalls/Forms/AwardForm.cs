using DNA.CastleMinerZ;
using DNA.CastleMinerZ.Inventory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CastleMod.Forms
{
    public partial class AwardForm : Form
    {
        public AwardForm()
        {
            InitializeComponent();
            timer1.Start();
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


        private void button2_Click(object sender, EventArgs e)
        {
            //var i = (Server.GetPlayers().Where(x => x.Gamertag == comboBox1.Text).FirstOrDefault().Tag as Player).PlayerInventory;
            //InventoryItemIDs id = InventoryItemIDs.Diamond;
            //InventoryItem inventoryItem = InventoryItem.CreateItem(id, 10);
            //i.AddInventoryItem(inventoryItem, true);
            Server.SpawnItem(comboBox1.Text, InventoryItemIDs.Diamond, 64);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Server.SpawnItem(comboBox1.Text, InventoryItemIDs.BloodStoneBlock, 64);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button65_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Server.SpawnItem(comboBox1.Text, InventoryItemIDs.Pistol, 1);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Server.SpawnItem(comboBox1.Text, InventoryItemIDs.BloodStoneAssultRifle, 1);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Server.SpawnItem(comboBox1.Text, InventoryItemIDs.BloodStoneBoltActionRifle, 1);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Server.SpawnItem(comboBox1.Text, InventoryItemIDs.Knife, 1);

        }

        private void button16_Click(object sender, EventArgs e)
        {
            Server.SpawnItem(comboBox1.Text, InventoryItemIDs.BloodstonePickAxe, 1);

        }

        private void button15_Click(object sender, EventArgs e)
        {
            Server.SpawnItem(comboBox1.Text, InventoryItemIDs.BloodstoneContainer, 1);

        }

        private void button14_Click(object sender, EventArgs e)
        {
            Server.SpawnItem(comboBox1.Text, InventoryItemIDs.BloodStoneSMGGun, 1);

        }

        private void button13_Click(object sender, EventArgs e)
        {
            Server.SpawnItem(comboBox1.Text, InventoryItemIDs.BloodStoneLMGGun, 1);

        }

        private void button12_Click(object sender, EventArgs e)
        {
            Server.SpawnItem(comboBox1.Text, InventoryItemIDs.BloodStonePumpShotgun, 1);

        }

        private void button11_Click(object sender, EventArgs e)
        {
            Server.SpawnItem(comboBox1.Text, InventoryItemIDs.BloodStoneLaserSword, 1);

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Server.SpawnItem(comboBox1.Text, InventoryItemIDs.LaserDrill, 1);

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Server.SpawnItem(comboBox1.Text, InventoryItemIDs.DiamondAxe, 1);

        }

        private void button23_Click(object sender, EventArgs e)
        {
            Server.SpawnItem(comboBox1.Text, InventoryItemIDs.LaserBullets, 1000);

        }

        private void button24_Click(object sender, EventArgs e)
        {
            Server.SpawnItem(comboBox1.Text, InventoryItemIDs.DiamondBullets, 1000);

        }

        private void button25_Click(object sender, EventArgs e)
        {
            Server.SpawnItem(comboBox1.Text, InventoryItemIDs.GoldBullets, 1000);
        }

        private void button32_Click(object sender, EventArgs e)
        {
            Server.SpawnItem(comboBox1.Text, InventoryItemIDs.IronBullets, 1000);

        }

        private void button33_Click(object sender, EventArgs e)
        {
            Server.SpawnItem(comboBox1.Text, InventoryItemIDs.Bullets, 1000);

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Server.SpawnItem(comboBox1.Text, InventoryItemIDs.DiamondSpade, 1);

        }

        private void button19_Click(object sender, EventArgs e)
        {
            Server.SpawnItem(comboBox1.Text, InventoryItemIDs.RocketLauncher, 1);

        }

        private void button18_Click(object sender, EventArgs e)
        {
            Server.SpawnItem(comboBox1.Text, InventoryItemIDs.RocketLauncherGuided, 1);

        }

        private void button17_Click(object sender, EventArgs e)
        {
            Server.SpawnItem(comboBox1.Text, InventoryItemIDs.TNT, 10);

        }

        private void button37_Click(object sender, EventArgs e)
        {
            Server.SpawnItem(comboBox1.Text, InventoryItemIDs.C4, 1);

        }

        private void button36_Click(object sender, EventArgs e)
        {
            Server.SpawnItem(comboBox1.Text, InventoryItemIDs.Grenade, 1);

        }

        private void button35_Click(object sender, EventArgs e)
        {
            Server.SpawnItem(comboBox1.Text, InventoryItemIDs.StickyGrenade, 1);

        }

        private void button34_Click(object sender, EventArgs e)
        {
            Server.SpawnItem(comboBox1.Text, InventoryItemIDs.DiamondSpaceAssultRifle, 1);

        }

        private void button61_Click(object sender, EventArgs e)
        {
            Server.SpawnItem(comboBox1.Text, InventoryItemIDs.Chainsaw1, 1);

        }

        private void button60_Click(object sender, EventArgs e)
        {
            Server.SpawnItem(comboBox1.Text, InventoryItemIDs.Chainsaw2, 1);
        }

        private void button59_Click(object sender, EventArgs e)
        {
            Server.SpawnItem(comboBox1.Text, InventoryItemIDs.Chainsaw3, 1);

        }

        private void button64_Click(object sender, EventArgs e)
        {
            Server.SpawnItem(comboBox1.Text, InventoryItemIDs.AdvancedGrenadeLauncher, 1);

        }

        private void button63_Click(object sender, EventArgs e)
        {
            Server.SpawnItem(comboBox1.Text, InventoryItemIDs.BasicGrenadeLauncher, 1);

        }

        private void button62_Click(object sender, EventArgs e)
        {
            Server.SpawnItem(comboBox1.Text, InventoryItemIDs.MegaPickAxe, 1);

        }

        private void button58_Click(object sender, EventArgs e)
        {
            Server.SpawnItem(comboBox1.Text, InventoryItemIDs.MultiLaser, 1);

        }

        private void button57_Click(object sender, EventArgs e)
        {
            Server.SpawnItem(comboBox1.Text, InventoryItemIDs.MonsterBlock, 1);

        }

        private void button56_Click(object sender, EventArgs e)
        {
            Server.SpawnItem(comboBox1.Text, InventoryItemIDs.LanternFancyBlock, 1);

        }

        private void button55_Click(object sender, EventArgs e)
        {
            Server.SpawnItem(comboBox1.Text, InventoryItemIDs.SpawnCombat, 1);

        }

        private void button54_Click(object sender, EventArgs e)
        {
            Server.SpawnItem(comboBox1.Text, InventoryItemIDs.SpawnBuilder, 1);

        }

        private void button53_Click(object sender, EventArgs e)
        {
            Server.SpawnItem(comboBox1.Text, InventoryItemIDs.SpawnExplorer, 1);

        }

        private void button52_Click(object sender, EventArgs e)
        {
            Server.SpawnItem(comboBox1.Text, InventoryItemIDs.SpawnBasic, 1);

        }

        private void button51_Click(object sender, EventArgs e)
        {
            Server.SpawnItem(comboBox1.Text, InventoryItemIDs.Snowball, 1);

        }

        private void button50_Click(object sender, EventArgs e)
        {
            Server.SpawnItem(comboBox1.Text, InventoryItemIDs.Slime, 1);

        }

        private void button43_Click(object sender, EventArgs e)
        {
            Server.SpawnItem(comboBox1.Text, InventoryItemIDs.PrecisionLaser, 1);

        }

        private void button42_Click(object sender, EventArgs e)
        {
            Server.SpawnItem(comboBox1.Text, InventoryItemIDs.Iceball, 1);

        }

        private void button41_Click(object sender, EventArgs e)
        {
            Server.SpawnItem(comboBox1.Text, InventoryItemIDs.BareHands, 1);

        }

        private void AwardForm_Load(object sender, EventArgs e)
        {

        }
    }
}
