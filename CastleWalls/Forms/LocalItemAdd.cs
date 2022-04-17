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
    public partial class LocalItemAdd : Form
    {

        public LocalItemAdd()
        {
            InitializeComponent();
        }

        private void LocalItemAdd_Load(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {


        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(numericUpDown1.Value);
            LocalPlayer.ItemAdd(count, InventoryItemIDs.BloodStoneBlock);
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
            int count = Convert.ToInt32(numericUpDown1.Value);
            LocalPlayer.ItemAdd(count, InventoryItemIDs.Pistol);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(numericUpDown1.Value);
            LocalPlayer.ItemAdd(count, InventoryItemIDs.BloodStoneAssultRifle);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(numericUpDown1.Value);
            LocalPlayer.ItemAdd(count, InventoryItemIDs.BloodStoneBoltActionRifle);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(numericUpDown1.Value);
            LocalPlayer.ItemAdd(count, InventoryItemIDs.Knife);

        }

        private void button16_Click(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(numericUpDown1.Value);
            LocalPlayer.ItemAdd(count, InventoryItemIDs.BloodstonePickAxe);

        }

        private void button15_Click(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(numericUpDown1.Value);
            LocalPlayer.ItemAdd(count, InventoryItemIDs.BloodstoneContainer);

        }

        private void button14_Click(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(numericUpDown1.Value);
            LocalPlayer.ItemAdd(count, InventoryItemIDs.BloodStoneSMGGun);

        }

        private void button13_Click(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(numericUpDown1.Value);
            LocalPlayer.ItemAdd(count, InventoryItemIDs.BloodStoneLMGGun);

        }

        private void button12_Click(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(numericUpDown1.Value);
            LocalPlayer.ItemAdd(count, InventoryItemIDs.BloodStonePumpShotgun);

        }

        private void button11_Click(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(numericUpDown1.Value);
            LocalPlayer.ItemAdd(count, InventoryItemIDs.BloodStoneLaserSword);

        }

        private void button10_Click(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(numericUpDown1.Value);
            LocalPlayer.ItemAdd(count, InventoryItemIDs.LaserDrill);

        }

        private void button9_Click(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(numericUpDown1.Value);
            LocalPlayer.ItemAdd(count, InventoryItemIDs.DiamondAxe);

        }

        private void button23_Click(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(numericUpDown1.Value);
            LocalPlayer.ItemAdd(count, InventoryItemIDs.LaserBullets);

        }

        private void button24_Click(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(numericUpDown1.Value);
            LocalPlayer.ItemAdd(count, InventoryItemIDs.DiamondBullets);

        }

        private void button25_Click(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(numericUpDown1.Value);
            LocalPlayer.ItemAdd(count, InventoryItemIDs.GoldBullets);
        }

        private void button32_Click(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(numericUpDown1.Value);
            LocalPlayer.ItemAdd(count, InventoryItemIDs.IronBullets);

        }

        private void button33_Click(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(numericUpDown1.Value);
            LocalPlayer.ItemAdd(count, InventoryItemIDs.Bullets);

        }

        private void button8_Click(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(numericUpDown1.Value);
            LocalPlayer.ItemAdd(count, InventoryItemIDs.DiamondSpade);

        }

        private void button19_Click(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(numericUpDown1.Value);
            LocalPlayer.ItemAdd(count, InventoryItemIDs.RocketLauncher);

        }

        private void button18_Click(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(numericUpDown1.Value);
            LocalPlayer.ItemAdd(count, InventoryItemIDs.RocketLauncherGuided);

        }

        private void button17_Click(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(numericUpDown1.Value);
            LocalPlayer.ItemAdd(count, InventoryItemIDs.TNT);

        }

        private void button37_Click(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(numericUpDown1.Value);
            LocalPlayer.ItemAdd(count, InventoryItemIDs.C4);

        }

        private void button36_Click(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(numericUpDown1.Value);
            LocalPlayer.ItemAdd(count, InventoryItemIDs.Grenade);

        }

        private void button35_Click(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(numericUpDown1.Value);
            LocalPlayer.ItemAdd(count, InventoryItemIDs.StickyGrenade);

        }

        private void button34_Click(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(numericUpDown1.Value);
            LocalPlayer.ItemAdd(count, InventoryItemIDs.DiamondSpaceAssultRifle);

        }

        private void button61_Click(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(numericUpDown1.Value);
            LocalPlayer.ItemAdd(count, InventoryItemIDs.Chainsaw1);

        }

        private void button60_Click(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(numericUpDown1.Value);
            LocalPlayer.ItemAdd(count, InventoryItemIDs.Chainsaw2);
        }

        private void button59_Click(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(numericUpDown1.Value);
            LocalPlayer.ItemAdd(count, InventoryItemIDs.Chainsaw3);

        }

        private void button64_Click(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(numericUpDown1.Value);
            LocalPlayer.ItemAdd(count, InventoryItemIDs.AdvancedGrenadeLauncher);

        }

        private void button63_Click(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(numericUpDown1.Value);
            LocalPlayer.ItemAdd(count, InventoryItemIDs.BasicGrenadeLauncher);

        }

        private void button62_Click(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(numericUpDown1.Value);
            LocalPlayer.ItemAdd(count, InventoryItemIDs.MegaPickAxe);

        }

        private void button58_Click(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(numericUpDown1.Value);
            LocalPlayer.ItemAdd(count, InventoryItemIDs.MultiLaser);

        }

        private void button57_Click(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(numericUpDown1.Value);
            LocalPlayer.ItemAdd(count, InventoryItemIDs.MonsterBlock);

        }

        private void button56_Click(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(numericUpDown1.Value);
            LocalPlayer.ItemAdd(count, InventoryItemIDs.LanternFancyBlock);

        }

        private void button55_Click(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(numericUpDown1.Value);
            LocalPlayer.ItemAdd(count, InventoryItemIDs.SpawnCombat);

        }

        private void button54_Click(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(numericUpDown1.Value);
            LocalPlayer.ItemAdd(count, InventoryItemIDs.SpawnBuilder);

        }

        private void button53_Click(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(numericUpDown1.Value);
            LocalPlayer.ItemAdd(count, InventoryItemIDs.SpawnExplorer);

        }

        private void button52_Click(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(numericUpDown1.Value);
            LocalPlayer.ItemAdd(count, InventoryItemIDs.SpawnBasic);

        }

        private void button51_Click(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(numericUpDown1.Value);
            LocalPlayer.ItemAdd(count, InventoryItemIDs.Snowball);

        }

        private void button50_Click(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(numericUpDown1.Value);
            LocalPlayer.ItemAdd(count, InventoryItemIDs.Slime);

        }

        private void button43_Click(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(numericUpDown1.Value);
            LocalPlayer.ItemAdd(count, InventoryItemIDs.PrecisionLaser);

        }

        private void button42_Click(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(numericUpDown1.Value);
            LocalPlayer.ItemAdd(count, InventoryItemIDs.Iceball);

        }

        private void button41_Click(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(numericUpDown1.Value);
            LocalPlayer.ItemAdd(count, InventoryItemIDs.BareHands);

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
        private void button39_Click(object sender, EventArgs e)
        {

        }
        private void button40_Click(object sender, EventArgs e)
        {

        }
        private void button44_Click(object sender, EventArgs e)
        {

        }
        private void button45_Click(object sender, EventArgs e)
        {

        }
        private void button46_Click(object sender, EventArgs e)
        {

        }
        private void button47_Click(object sender, EventArgs e)
        {

        }
        private void button48_Click(object sender, EventArgs e)
        {

        }
        private void button49_Click(object sender, EventArgs e)
        {

        }



    }
}


