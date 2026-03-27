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
using System.Net;
using System.IO;
using System.Management;
using System.Text.RegularExpressions;
//okee

namespace bluetoothmain
{
    public partial class mainmenu : Form
    {
        
        
        public mainmenu()
        {
            InitializeComponent();
           
        }
        private void mainmenu_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (serCOM.IsOpen)
                serCOM.Close();
        }

        private void mainmenu_Load(object sender, EventArgs e)
        {
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            statelbl.Hide();
            disconnect.Enabled = false;
            disconnect.Hide();
            
        }
        
      
     
        string tkdung = "123";
        string mkdung = "1234";
        string comdung;
        string cmd;
        private void login_Load(object sender, EventArgs e)
        {

        }

        private void log_Click(object sender, EventArgs e)
        {
            if (tk.Text == tkdung)
            {
                if (mk.Text == mkdung)
                {
                    tabPage2.Hide();
                    tabPage5.Show();
                    

                }
                else { MessageBox.Show("Sai tài khoản hoặc mật khẩu"); }


            }
            else { MessageBox.Show("Sai tài khoản hoặc mật khẩu"); }
        }

        

        


        //FORM BLUETOOTH1 tab 3


        private void FormMain_Load(object sender, EventArgs e)
        {
            COMcbo.Items.Clear();
            COMcbo.Items.AddRange(SerialPort.GetPortNames());

            if (COMcbo.Items.Count > 1)
                COMcbo.SelectedIndex = 1;

            statelbl.Text = "DISCONNECTED";
            statelbl.ForeColor = Color.Red;

        }
        int selected;
        bool gotOk = false;
        private void SetConnectedBT()
        {
            if (!serCOM.IsOpen)
                serCOM.Open();
            statelbl.Show();
            statelbl.Text = "BLUETOOTH CONNECTED";
            statelbl.ForeColor = Color.Green;
            disconnect.Enabled = true;
            disconnect.Show();
        }
        private void SetDisconnectedBT()
        {
            

            pan1cb.Checked = false;
            pan2cb.Checked = false;
            pan3cb.Checked = false;
            pan4cb.Checked = false;
            pan5cb.Checked = false;
            pan6cb.Checked = false;
            pan7cb.Checked = false;
            pan8cb.Checked = false;
            pan9cb.Checked = false;
            pan10cb.Checked = false;
            pan11cb.Checked = false;
            pan12cb.Checked = false;
            pan13cb.Checked = false;
            pan14cb.Checked = false;
            pan15cb.Checked = false;
            pan16cb.Checked = false;

            if (serCOM.IsOpen)
            { serCOM.Close(); }
            statelbl.Show();
            statelbl.Text = "BLUETOOTH DISCONNECTED";
            statelbl.ForeColor = Color.Red;
            tabPage4.Hide();
            tabPage3.Show();


        }
        private void ping()
        {
            try
            {
                serCOM.WriteLine("ping");
                serCOM.WriteTimeout=1000;
               
            }
            catch (Exception)
            {
                SetDisconnectedBT();

                ping_timer.Stop();
            }
        }



        private void buttona_Click(object sender, EventArgs e)
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

                    pan1cb.Enabled = false;
                    pan2cb.Enabled = false;
                    pan3cb.Enabled = false;
                    pan4cb.Enabled = false;
                    pan5cb.Enabled = false;
                    pan6cb.Enabled = false;
                    pan7cb.Enabled = false;
                    pan8cb.Enabled = false;
                    pan9cb.Enabled = false;
                    pan10cb.Enabled = false;
                    pan11cb.Enabled = false;
                    pan12cb.Enabled = false;
                    pan13cb.Enabled = false;
                    pan14cb.Enabled = false;
                    pan15cb.Enabled = false;
                    pan16cb.Enabled = false;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Không kết nối được COM\n" + ex.Message);
                SetDisconnectedBT();
            }


            if (serCOM.IsOpen)
            {
                ping_timer.Start();

                SetConnectedBT();
                tabPage3.Hide();
                tabPage4.Show();
            }
        }

      

        private void ping_timer_Tick(object sender, EventArgs e)
        {
            ping();
            try
            {
                string data = serCOM.ReadLine().Trim();
                if (data == "ok")
                {
                    gotOk = true;
                    if (pan1cb.Enabled == false)
                    {
                        pan1cb.Enabled = true;
                        pan2cb.Enabled = true;
                        pan3cb.Enabled = true;
                        pan4cb.Enabled = true;
                        pan5cb.Enabled = true;
                        pan6cb.Enabled = true;
                        pan7cb.Enabled = true;
                        pan8cb.Enabled = true;
                        pan9cb.Enabled = true;
                        pan10cb.Enabled = true;
                        pan11cb.Enabled = true;
                        pan12cb.Enabled = true;
                        pan13cb.Enabled = true;
                        pan14cb.Enabled = true;
                        pan15cb.Enabled = true;
                        pan16cb.Enabled = true;
                    }

                }
            }
            catch (Exception)
            {
                gotOk = false;
                if (!gotOk)
                {
                    SetDisconnectedBT();
                   
                    ping_timer.Stop();
                }
            }
        }

        private void COMcbo_Click_1(object sender, EventArgs e)
        {
            COMcbo.Items.Clear();
            COMcbo.Items.AddRange(SerialPort.GetPortNames());

            if (COMcbo.Items.Count > 1)
                COMcbo.SelectedIndex = 1;
        }

        private void refresh_Click_1(object sender, EventArgs e)
        {
            COMcbo.Items.Clear();
            COMcbo.Items.AddRange(SerialPort.GetPortNames());

            if (COMcbo.Items.Count > selected)
                COMcbo.SelectedIndex = selected;
        }

        private void back_Click(object sender, EventArgs e)
        {

        }

        private void Checked_Changed(object sender, EventArgs e)
        {

        }


        //FORM BLUETOOTH2 tab 4


       
        string pan1, pan2, pan3, pan4, pan5, pan6, pan7, pan8, pan9, pan10, pan11, pan12, pan13, pan14, pan15, pan16;

        private void COMcbo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void bluetooth_usb_Click(object sender, EventArgs e)
        {
            tabPage3.Show();
            tabPage5.Hide();
        }

        private void wifi_Click(object sender, EventArgs e)
        {
            tabPage5.Hide();
            tabPage6.Show();
        }

        private void bt_CheckedChanged(object sender, EventArgs e)
        {
            pan1 = pan1cb.Checked ? "1" : "0";
            pan2 = pan2cb.Checked ? "1" : "0";
            pan3 = pan3cb.Checked ? "1" : "0";
            pan4 = pan4cb.Checked ? "1" : "0";
            pan5 = pan5cb.Checked ? "1" : "0";
            pan6 = pan6cb.Checked ? "1" : "0";
            pan7 = pan7cb.Checked ? "1" : "0";
            pan8 = pan8cb.Checked ? "1" : "0";
            pan9 = pan9cb.Checked ? "1" : "0";
            pan10 = pan10cb.Checked ? "1" : "0";
            pan11 = pan11cb.Checked ? "1" : "0";
            pan12 = pan12cb.Checked ? "1" : "0";
            pan13 = pan13cb.Checked ? "1" : "0";
            pan14 = pan14cb.Checked ? "1" : "0";
            pan15 = pan15cb.Checked ? "1" : "0";
            pan16 = pan16cb.Checked ? "1" : "0";
             cmd = "CB" + pan1 + pan2 + pan3 + pan4 + pan5 + pan6 + pan7 + pan8 + pan9 + pan10 + pan11 + pan12 + pan13 + pan14 + pan15 + pan16;
            
            serCOM.WriteLine(cmd);

            

        }

        private void statelbl_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void wf_CheckedChanged(object sender, EventArgs e)
        {
            pan1 = wfpan1cb.Checked ? "1" : "0";
            pan2 = wfpan2cb.Checked ? "1" : "0";
            pan3 = wfpan3cb.Checked ? "1" : "0";
            pan4 = wfpan4cb.Checked ? "1" : "0";
            pan5 = wfpan5cb.Checked ? "1" : "0";
            pan6 = wfpan6cb.Checked ? "1" : "0";
            pan7 = wfpan7cb.Checked ? "1" : "0";
            pan8 = wfpan8cb.Checked ? "1" : "0";
            pan9 = wfpan9cb.Checked ? "1" : "0";
            pan10 = wfpan10cb.Checked ? "1" : "0";
            pan11 = wfpan11cb.Checked ? "1" : "0";
            pan12 = wfpan12cb.Checked ? "1" : "0";
            pan13 = wfpan13cb.Checked ? "1" : "0";
            pan14 = wfpan14cb.Checked ? "1" : "0";
            pan15 = wfpan15cb.Checked ? "1" : "0";
            pan16 = wfpan16cb.Checked ? "1" : "0";
             cmd = "CB" + pan1 + pan2 + pan3 + pan4 + pan5 + pan6 + pan7 + pan8 + pan9 + pan10 + pan11 + pan12 + pan13 + pan14 + pan15 + pan16;

            try
            {
                HttpWebRequest request =
                    (HttpWebRequest)WebRequest.Create(url + cmd);

                request.Method = "GET";
                request.Timeout = 1000;
                request.ReadWriteTimeout = 1000;
                HttpWebResponse response =
     (HttpWebResponse)request.GetResponse();

                response.Close();

            }
            catch (TimeoutException)
            {
                MessageBox.Show("Mất kết nối." );
            }
            catch (WebException) { }
        }

       

        private void connectwifi_Click(object sender, EventArgs e)
        {
            wifi_ping_timer.Start();
            tabPage6.Hide();
            tabPage7.Show();
            if (statelbl.Text != "WIFI CONNECTED")
            {
                wfpan1cb.Enabled = false;
                wfpan2cb.Enabled = false;
                wfpan3cb.Enabled = false;
                wfpan4cb.Enabled = false;
                wfpan5cb.Enabled = false;
                wfpan6cb.Enabled = false;
                wfpan7cb.Enabled = false;
                wfpan8cb.Enabled = false;
                wfpan9cb.Enabled = false;
                wfpan10cb.Enabled = false;
                wfpan11cb.Enabled = false;
                wfpan12cb.Enabled = false;
                wfpan13cb.Enabled = false;
                wfpan14cb.Enabled = false;
                wfpan15cb.Enabled = false;
                wfpan16cb.Enabled = false;
            }

        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void backpg3_Click(object sender, EventArgs e)
        {
            tabPage3.Hide();
            tabPage5.Show();
        }

        private void backpg6_Click(object sender, EventArgs e)
        {
            tabPage6.Hide();
            tabPage5.Show();

        }

        private void disconnect_Click(object sender, EventArgs e)
        {
                if (statelbl.Text == "BLUETOOTH CONNECTED")
                {
                    
                    SetDisconnectedBT();
                }
            if (statelbl.Text == "USB CONNECTED")
            {

                SetDisconnectedUSB();
            }


        }

        private void gv_Click_1(object sender, EventArgs e)
        {

            tabPage1.Hide();
            tabPage2.Show();
        }

        private void hs_Click_1(object sender, EventArgs e)
        {
            tabPage1.Hide();
            tabPage8.Show();
        }

        private void statelbl_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void tabPage7_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void disconnectWF_Click(object sender, EventArgs e)
        {
            setDisconnectedWF();
        }

        private void backpg7_Click(object sender, EventArgs e)
        {
            tabPage7.Hide();
            tabPage6.Show();
        }

        

       

        private void backpg9_Click(object sender, EventArgs e)
        {
            tabPage9.Hide();
            tabPage5.Show();
           
        }

        private void usb_Click(object sender, EventArgs e)
        {
            tabPage9.Show();
            tabPage5.Hide();
            usb_ping_timer.Start();
            
        }

        private void usb_ping_timer_Tick(object sender, EventArgs e)
        {
            
        foreach (var device in new ManagementObjectSearcher(
    "SELECT * FROM Win32_PnPEntity WHERE Name LIKE '%(COM%'").Get())
                {
                    string id = device["PNPDeviceID"].ToString();
                string name = device["Name"].ToString();
                string com="";
                if (id.Contains("VID_10C4"))
                    {
                    var match = System.Text.RegularExpressions.Regex.Match(name, @"\(COM\d+\)");
                     com = match.Value.Replace("(", "").Replace(")", "");
                    comusb.Text = "Đã kết nối USB cổng " + com;
                    if (com != comdung)
                    {
                        comdung = com;
                        SetConnectedUSB();
                    }
                    break;
                    
                    }

                else{ 
                    comusb.Text = "Không tìm thấy kết nối USB";
                    comdung = "";
                    SetDisconnectedUSB();

                    }
                }
        }
        void SetConnectedUSB()
        {

            if (comdung != "" && !serCOM.IsOpen)
            {try
                {
                    serCOM.PortName = comdung;
                    
                    serCOM.BaudRate = 9600;
                    serCOM.Open();
                    statelbl.Show();
                    statelbl.Text = "USB CONNECTED";
                    tabPage9.Hide();
                    tabPage4.Show();
                    disconnect.Enabled = true;
                    disconnect.Show();
                    serCOM.WriteLine("USBconnected");
                }
                catch (Exception) { MessageBox.Show("Không thể kết nối USB"); }
            }
        }
        private void SetDisconnectedUSB()
        {


            pan1cb.Checked = false;
            pan2cb.Checked = false;
            pan3cb.Checked = false;
            pan4cb.Checked = false;
            pan5cb.Checked = false;
            pan6cb.Checked = false;
            pan7cb.Checked = false;
            pan8cb.Checked = false;
            pan9cb.Checked = false;
            pan10cb.Checked = false;
            pan11cb.Checked = false;
            pan12cb.Checked = false;
            pan13cb.Checked = false;
            pan14cb.Checked = false;
            pan15cb.Checked = false;
            pan16cb.Checked = false;

            if (serCOM.IsOpen)
            {
                serCOM.WriteLine("dis");
                serCOM.Close(); }
            statelbl.Show();
            statelbl.Text = "USB DISCONNECTED";
            statelbl.ForeColor = Color.Red;
            tabPage4.Hide();
            tabPage5.Show();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            statelbl.Text = "USB CONNECTED";
        }

        private void settings_Click(object sender, EventArgs e)
        {
            settings_panel.Visible = true;
        }

        private void close_settings_Click(object sender, EventArgs e)
        {
            settings_panel.Visible = false;
        }

        private void tk_TextChanged(object sender, EventArgs e)
        {

        }

        private void mk_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

       

        private void DISCONNECTED(object sender, EventArgs e)
        {
            
            cmd = "CB0000000000000000";
        }

      

       

        private void menu_Click_1(object sender, EventArgs e)
        {
            tabPage4.Hide();
            tabPage1.Show();
        }

       

        private void back_Click_1(object sender, EventArgs e)
        {
            tabPage4.Hide();
            tabPage3.Show();
        }





        //Wifi tab 7
        string url = "http://esp32.local/send?data=";

        private void setDisconnectedWF()
        {
            
            statelbl.Show();
            statelbl.Text = "WIFI DISCONNECTED";
            statelbl.ForeColor = Color.Red;
            if (statelbl.Text!= "WIFI CONNECTED")
            {
                wfpan1cb.Enabled = false;
                wfpan2cb.Enabled = false;
                wfpan3cb.Enabled = false;
                wfpan4cb.Enabled = false;
                wfpan5cb.Enabled = false;
                wfpan6cb.Enabled = false;
                wfpan7cb.Enabled = false;
                wfpan8cb.Enabled = false;
                wfpan9cb.Enabled = false;
                wfpan10cb.Enabled = false;
                wfpan11cb.Enabled = false;
                wfpan12cb.Enabled = false;
                wfpan13cb.Enabled = false;
                wfpan14cb.Enabled = false;
                wfpan15cb.Enabled = false;
                wfpan16cb.Enabled = false;

                wfpan1cb.Checked = false;
                wfpan2cb.Checked = false;
                wfpan3cb.Checked = false;
                wfpan4cb.Checked = false;
                wfpan5cb.Checked = false;
                wfpan6cb.Checked = false;
                wfpan7cb.Checked = false;
                wfpan8cb.Checked = false;
                wfpan9cb.Checked = false;
                wfpan10cb.Checked = false;
                wfpan11cb.Checked = false;
                wfpan12cb.Checked = false;
                wfpan13cb.Checked = false;
                wfpan14cb.Checked = false;
                wfpan15cb.Checked = false;
                wfpan16cb.Checked = false;
                try
                {
                    HttpWebRequest request =
                        (HttpWebRequest)WebRequest.Create(url + "dis");

                    request.Method = "GET";
                    request.Timeout = 3000;
                    request.ReadWriteTimeout = 1000;
                    HttpWebResponse response =
         (HttpWebResponse)request.GetResponse();

                    response.Close();

                }
                catch (TimeoutException)
                {
                    MessageBox.Show("Mất kết nối.");
                }
                catch (WebException) { }
            
        }
            wifi_ping_timer.Stop();
            tabPage7.Hide();
            tabPage6.Show();
            disconnect.Hide();
            
        }
        private void setConnectedWF()
        {
            statelbl.Show();
            statelbl.Text = "WIFI CONNECTED";
            statelbl.ForeColor = Color.Green;
            tabPage7.Show();
            tabPage6.Hide();
            disconnect.Enabled = true;
            disconnect.Show();

            if (statelbl.Text == "WIFI CONNECTED")
            {
                wfpan1cb.Enabled = true;
                wfpan2cb.Enabled = true;
                wfpan3cb.Enabled = true;
                wfpan4cb.Enabled = true;
                wfpan5cb.Enabled = true;
                wfpan6cb.Enabled = true;
                wfpan7cb.Enabled = true;
                wfpan8cb.Enabled = true;
                wfpan9cb.Enabled = true;
                wfpan10cb.Enabled = true;
                wfpan11cb.Enabled = true;
                wfpan12cb.Enabled = true;
                wfpan13cb.Enabled = true;
                wfpan14cb.Enabled = true;
                wfpan15cb.Enabled = true;
                wfpan16cb.Enabled = true;
            }
            try
            {
                HttpWebRequest request =
                    (HttpWebRequest)WebRequest.Create(url + "WFconnected");

                request.Method = "GET";
                request.Timeout = 1000;
                request.ReadWriteTimeout = 1000;
                HttpWebResponse response =
     (HttpWebResponse)request.GetResponse();

                response.Close();

            }
            catch (TimeoutException)
            {
                MessageBox.Show("Mất kết nối.");
            }
            catch (WebException) { }

        }
        private void wifi_ping_timer_Tick(object sender, EventArgs e)
        {
            try
            {
                HttpWebRequest request =
                    (HttpWebRequest)WebRequest.Create("http://esp32.local/ping");
                

                request.Method = "GET";
                request.Timeout = 3500; 

                HttpWebResponse response =
                    (HttpWebResponse)request.GetResponse();

                
                setConnectedWF();

                response.Close();
            }
            catch
            {
               
                setDisconnectedWF();
            }
        }



    }


//USB MODE












}



