using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bluetoothmain
{
    public partial class LT : UserControl
    {
        public LT()
        {
            InitializeComponent();
        }

        private void LT_Load(object sender, EventArgs e)
        {
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;

            tabControl2.Appearance = TabAppearance.FlatButtons;
            tabControl2.ItemSize = new Size(0, 1);
            tabControl2.SizeMode = TabSizeMode.Fixed;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lythuyet.Hide();
            sensor.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            lythuyet.Hide();
            sensor.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sensor.Hide();
            tabControl1.SelectedTab = nhietdo;

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            sensor.Hide();
            loi.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            loi.Hide();
            open.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            loi.Hide();
            chmass.Show();
        }

        private void label36_Click(object sender, EventArgs e)
        {

        }

        private void label35_Click(object sender, EventArgs e)
        {

        }

        private void chmass_Click(object sender, EventArgs e)
        {

        }

        private void label42_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            loi.Hide();
            sensor.Show();
        }

        private void rcao_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            open.Hide();
            loi.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            chmass.Hide();
            loi.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            rcao.Hide();
            loi.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            loi.Hide();
            rcao.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            loi.Hide();
            chduong.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            chduong.Hide();
            loi.Show();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            open.Hide();
            chmass.Show();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            chmass.Hide();
            rcao.Show();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            rcao.Hide();
            chduong.Show();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            ltnd.Hide();
            thda.Show();
        }

        private void button22_Click(object sender, EventArgs e)
        {

            tabControl1.SelectedTab =sensor;
        }

        private void cdnd1_Click(object sender, EventArgs e)
        {

        }

        private void button23_Click(object sender, EventArgs e)
        {
            thda.Hide();
            vsub.Show();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            thda.Hide();
            ltnd.Show();
        }

        private void button34_Click(object sender, EventArgs e)
        {
            vsub.Hide();
            thda.Show();
        }

        private void button33_Click(object sender, EventArgs e)
        {
            vsub.Hide();
            cdnd.Show();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            cdnd.Hide();
            cdnd1.Show();
        }

        private void button26_Click(object sender, EventArgs e)
        {
           cdnd.Hide();
            vsub.Show();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            cdnd1.Hide();
            cdnd2.Show();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            cdnd1.Hide();
            cdnd.Show();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            cdnd2.Hide();
            cdnd3.Show();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            cdnd2.Hide();
            cdnd1.Show();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = sensor;
        }

        private void label68_Click(object sender, EventArgs e)
        {

        }

        private void button35_Click(object sender, EventArgs e)
        {
            ltll.Hide();
            cdll.Show();
        }

        private void button36_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = sensor;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            sensor.Hide();
            luuluong.Show();
        }

        private void button37_Click(object sender, EventArgs e)
        {
            cdll.Hide();
            cdll1.Show();
        }

        private void button38_Click(object sender, EventArgs e)
        {
            cdll1.Hide();
            cdll.Show();
        }

        private void button42_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = sensor;
        }

        private void label89_Click(object sender, EventArgs e)
        {

        }

        private void tabPage7_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            sensor.Hide();
            luuluong.Show();
        }

        private void button43_Click(object sender, EventArgs e)
        {
            td.Hide();
            td1.Show();
        }

        private void button45_Click(object sender, EventArgs e)
        {
            td1.Hide();
            td2.Show();
        }

        private void button44_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = sensor;
        }

        private void button48_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = sensor; 
        }

        private void button46_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            sensor.Hide();
            tocdo.Show();
        }

        private void button5_Click(object sender, EventArgs e) 
        {

            sensor.Hide();
            tabControl7.Visible = true;
            tabControl7.BringToFront();
            tabControl7.SelectedIndex = 0;
        }

        private void button51_Click(object sender, EventArgs e)
        {
            ap.Hide();
            ap1.Show();
        }

        private void button53_Click(object sender, EventArgs e)
        {
            ap1.Hide();
            ap2.Show();
        }

        private void button56_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = sensor;
        }

        private void button54_Click(object sender, EventArgs e)
        {
            ap1.Hide();
            ap.Show();
        }

        private void button52_Click(object sender, EventArgs e)
        {
        
            tabControl1.SelectedTab = sensor;
        }
    }
}
