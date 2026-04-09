using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO.Ports;
using System.IO;


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
            sdmd.Show();
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
            cdnd.Show();
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
            chot.Show();
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

        private void button57_Click(object sender, EventArgs e)
        {
            Process.Start("https://drive.google.com/drive/folders/1sAb5N4NN3jlh4bc9efZMn5rdEdbsDqlg?usp=sharing");
        }

        private void button58_Click(object sender, EventArgs e)
        {
            Process.Start("https://drive.google.com/drive/folders/1sAb5N4NN3jlh4bc9efZMn5rdEdbsDqlg?usp=sharing");
        }

        private void tabPage7_Click_1(object sender, EventArgs e)
        {

        }

        private void button59_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "5")
            {
                textBox1.BackColor = Color.LightGreen;
            }
            else
            {
                textBox1.BackColor = Color.Red;
            }

            if (textBox2.Text == "2")
            {
                textBox2.BackColor = Color.LightGreen;
            }
            else
            {
                textBox2.BackColor = Color.Red;
            }
            if (textBox3.Text == "xanh lam")
            {
                textBox3.BackColor = Color.LightGreen;
            }
            else
            {
                textBox3.BackColor = Color.Red;
            }
            if (textBox4.Text == "xanh da trời")
            {
                textBox4.BackColor = Color.LightGreen;
            }
            else
            {
                textBox4.BackColor = Color.Red;
            }
            if (textBox5.Text == "3,57")
            {
                textBox5.BackColor = Color.LightGreen;
            }
            else
            {
                textBox5.BackColor = Color.Red;
            }
            if (textBox6.Text == "0.316")
            {
                textBox6.BackColor = Color.LightGreen;
            }
            else
            {
                textBox6.BackColor = Color.Red;
            }
            if (textBox7.Text == "1CE")
            {
                textBox7.BackColor = Color.LightGreen;
            }
            else
            {
                textBox7.BackColor = Color.Red;
            }
            if (comboBox2.Text == "Hở mạch")
            {
                comboBox2.BackColor = Color.LightGreen;
            }
            else
            {
                comboBox2.BackColor = Color.Red;
            }
            if (comboBox1.Text == "2.49-2.79")
            {
                comboBox1.BackColor = Color.LightGreen;
            }
            else
            {
                comboBox1.BackColor = Color.Red;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button31_Click(object sender, EventArgs e)
        {
            cdnd3.Hide();
            vsub.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button61_Click(object sender, EventArgs e)
        {
            sdmd.Hide();
            thda.Show();
        }

        private void button62_Click(object sender, EventArgs e)
        {
            sdmd.Hide();
            ltnd.Show();
        }

        string cmd;
        string url = "http://esp32.local/send?data=";
        private void button60_Click(object sender, EventArgs e)
        {
            SerialPort serCOM = new SerialPort();
            cmd = "CB1100000000000000";
            if (serCOM.IsOpen)
            {
                serCOM.WriteLine(cmd);
            }
            
        }
    }
}
