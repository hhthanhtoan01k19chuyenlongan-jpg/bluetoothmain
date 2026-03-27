using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace bluetoothmain
{
    public partial class bluetooth1 : Form
    {
        public bluetooth1()
        {
            InitializeComponent();

            
        }
        public event Action LostConnection;
        private void FormMain_Load(object sender, EventArgs e)
        {
            COMcbo.Items.Clear();
            COMcbo.Items.AddRange(SerialPort.GetPortNames());

            if (COMcbo.Items.Count > 1)
                COMcbo.SelectedIndex = 1;

            statelblbt1.Text = "DISCONNECTED";
            statelblbt1.ForeColor = Color.Red;
            
        }
        int selected;
        bool gotOk = false;
        private void SetConnected()
        {
            if (!serCOM.IsOpen)
                serCOM.Open();

            statelblbt1.Text = "CONNECTED";
            statelblbt1.ForeColor = Color.Green;
        }
        private void SetDisconnected()
        {
            if (serCOM.IsOpen)
                serCOM.Close();

            statelblbt1.Text = "DISCONNECTED";
            statelblbt1.ForeColor = Color.Red;
        }
        private void ping()
        {
            try
            {
                serCOM.WriteLine("ping");
                label2.Text = "ping";
            }
            catch (Exception) { SetDisconnected();
                
                ping_timer.Stop();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                if (!serCOM.IsOpen)
                {

                    serCOM.PortName = COMcbo.Text;
                    selected = COMcbo.SelectedIndex;
                    serCOM.BaudRate = 9600;
                    serCOM.Open();

                    serCOM.WriteTimeout = 200;
                    serCOM.ReadTimeout = 200;
                    statelblbt1.Text = "CONNECTING";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Không kết nối được COM\n" + ex.Message);
                SetDisconnected();
            }


                if (serCOM.IsOpen)
                {
                    ping_timer.Start();
                
                    SetConnected();
                bluetooth2 f2 = new bluetooth2(this);
                this.Hide();
                f2.Show();
            }

            }
        

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (serCOM.IsOpen)

                try { serCOM.WriteLine("1"); }
                catch (TimeoutException) { MessageBox.Show("Chua gui duoc"); }


            else
                MessageBox.Show("Chưa kết nối Bluetooth");
                }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (serCOM.IsOpen)
                try { serCOM.WriteLine("0"); }
                catch (TimeoutException) { MessageBox.Show("Chua gui duoc"); }


            else
                MessageBox.Show("Chưa kết nối Bluetooth");
        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {
            ping();
            try
            {
                string data = serCOM.ReadLine().Trim();
                if (data == "ok") { gotOk = true;
                    label1.Text = data;
                    
                }
            }
            catch(Exception)
            {
                gotOk = false;
                if (!gotOk) { SetDisconnected();
                    LostConnection?.Invoke();
                    ping_timer.Stop();
                 }
            }
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (serCOM.IsOpen)
                serCOM.Close();
        }

        private void COMcbo_Click(object sender, EventArgs e)
        {
            COMcbo.Items.Clear();
            COMcbo.Items.AddRange(SerialPort.GetPortNames());

            if (COMcbo.Items.Count > 1)
                COMcbo.SelectedIndex = 1;
        }
       
        public void button3_Click(object sender, EventArgs e)
        {
            bluetooth2 f3 = new bluetooth2(this);
            this.Hide();
            f3.Show();

        }

        private void refresh_Click(object sender, EventArgs e)
        {
            COMcbo.Items.Clear();
            COMcbo.Items.AddRange(SerialPort.GetPortNames());

            if (COMcbo.Items.Count > selected)
                COMcbo.SelectedIndex = selected;
        }
    }
        
}
   
