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
    
    public partial class bluetooth2 : Form
    {
        private bluetooth1 main;
        

        public bluetooth2(bluetooth1 fm )
        {
            InitializeComponent();
            main = fm;
            main.LostConnection += LostConnection2;
        }
       
        public int connectstate = 1;

        public void LostConnection2()
        {
           
            if (InvokeRequired)
            {
                Invoke(new Action(LostConnection2));
                return;
            }
            connectstate--;
            this.Hide();
            main.Show();
            if (connectstate==0)
            { MessageBox.Show("Mất kết nối "); }

        } 
        string pan1, pan2, pan3, pan4, pan5, pan6, pan7, pan8, pan9, pan10, pan11, pan12, pan13, pan14, pan15, pan16;

        private void menu_Click(object sender, EventArgs e)
        {
            
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            main.Show();
            main.serCOM.WriteLine("CB0000000000000000");
            MessageBox.Show("Đã vô hiệu hóa các pan");
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();

            main.Show();
            main.serCOM.WriteLine("CB0000000000000000");
            MessageBox.Show("Đã vô hiệu hóa các pan");
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
            statelblbt2.Text = main.statelblbt1.Text;
            statelblbt2.ForeColor = main.statelblbt1.ForeColor;

        }
       
        private void Checked_Changed(object sender, EventArgs e)
        {
            pan1= pan1cb.Checked ? "1" : "0";
            pan2 = pan2cb.Checked ? "1" : "0";
            pan3 = pan3cb.Checked ? "1" : "0";
            pan4 = pan4cb.Checked ? "1" : "0";
            pan5 = pan5cb.Checked ? "1" : "0";
            pan6 = pan6cb.Checked ? "1" : "0";
            pan7 = pan7cb.Checked ? "1" : "0";
            pan8= pan8cb.Checked ? "1" : "0";
            pan9 = pan9cb.Checked ? "1" : "0";
            pan10 = pan10cb.Checked ? "1" : "0";
            pan11 = pan11cb.Checked ? "1" : "0";
            pan12 = pan12cb.Checked ? "1" : "0";
            pan13 = pan13cb.Checked ? "1" : "0";
            pan14= pan14cb.Checked ? "1" : "0";
            pan15 = pan15cb.Checked ? "1" : "0";
            pan16 = pan16cb.Checked ? "1" : "0";
            label1.Text = "CB" + pan1 + pan2 + pan3 + pan4 + pan5 + pan6 + pan7 + pan8 + pan9 + pan10 + pan11 + pan12 + pan13 + pan14 + pan15 + pan16;
            main.serCOM.WriteLine(label1.Text);
        }
    }
}
