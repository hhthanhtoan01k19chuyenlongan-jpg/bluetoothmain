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
            nhietdo.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }
    }
}
