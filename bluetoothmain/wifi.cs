using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
namespace bluetoothmain
{
    public partial class wifi : Form
    {
        public wifi()
        {
            InitializeComponent();
        }
        string url = "http://esp32.local/send?data=";

        private void  setDisconnectedWF()
        { }
        private void setConnectedWF()
        { }

        private void wifi_Load(object sender, EventArgs e)
        {
            
        }
        string pan1, pan2, pan3, pan4, pan5, pan6, pan7, pan8, pan9, pan10, pan11, pan12, pan13, pan14, pan15, pan16;

        private void wifi_ping_Tick(object sender, EventArgs e)
        {
            try
            {
              HttpWebRequest request =
                    (HttpWebRequest)WebRequest.Create(url+"ping");

                request.Method = "GET";

                HttpWebResponse response =
                    (HttpWebResponse)request.GetResponse();

                StreamReader reader =
                    new StreamReader(response.GetResponseStream());

                string result = reader.ReadToEnd();

                response.Close();

                if (result != "ok") { setDisconnectedWF(); }
                else { setConnectedWF(); }
            }
            catch (TimeoutException)
            {
                MessageBox.Show("Mất kết nối Wifi");
                setDisconnectedWF();
            }
        }

        private void wf_CheckedChanged(object sender, EventArgs e)
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
            string cmd = "CB" + pan1 + pan2 + pan3 + pan4 + pan5 + pan6 + pan7 + pan8 + pan9 + pan10 + pan11 + pan12 + pan13 + pan14 + pan15 + pan16;



            try
            {
                HttpWebRequest request =
                    (HttpWebRequest)WebRequest.Create(url+cmd);

                request.Method = "GET";
                request.Timeout = 1000;
                request.ReadWriteTimeout = 1000;

                HttpWebResponse response =
                    (HttpWebResponse)request.GetResponse();

                StreamReader reader =
                    new StreamReader(response.GetResponseStream());

                string result = reader.ReadToEnd();

                response.Close();

                MessageBox.Show("ESP32 trả về: " + result);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
