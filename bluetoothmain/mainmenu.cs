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
using OfficeOpenXml;


namespace bluetoothmain
{
    public partial class mainmenu : Form
    {

        ComboBox[] da;
        ComboBox[] loi;
        CheckBox[] bt_usb_cb;
        CheckBox[] wf_cb;
        Button[] baihoccambien;
        Button[] baihocthuchanh;
        List<Button> cauhoithuchanh= new List<Button>();

        string svkiemtra;
        string[] poolda = {
"ECT - Cảm biến nhiệt độ nước làm mát",
"IAT - Cảm biến nhiệt độ khí nạp",
"MAF - Cảm biến lưu lượng khí nạp",
"CKP - Cảm biến tốc độ động cơ",
"IGT1 - Bộ đánh lửa máy số 1",
"IGT2 - Bộ đánh lửa máy số 2",
"IGT3 - Bộ đánh lửa máy số 3",
"IGT4 - Bộ đánh lửa máy số 4",
"CMPA - Cảm biến vị trí CAM Nạp",
"CMPB - Cảm biến vị trí CAM Xả",
"APP1 - Cảm biến vị trí bàn đạp ga 1",
"APP2 - Cảm biến vị trí bàn đạp ga 2",
"FRPS - Cảm biến áp suất nhiên liệu ống phân phối",
"AFS - Cảm biến A/F",
"TPS1 - Cảm biến vị trí bướm ga 1",
"TPS2 - Cảm biến vị trí bướm ga 2" };

        DataTable dt = new DataTable();
        private void LoadExcel(string path)
        {
            dataGridView1.AllowUserToAddRows = true;
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

            FileInfo file = new FileInfo(path);


            using (ExcelPackage package = new ExcelPackage(file))

            {
                var ws = package.Workbook.Worksheets[0];

                try
                {
                    dt.Columns.Add("STT");
                    dt.Columns.Add("MSSV");
                    dt.Columns.Add("HỌ VÀ TÊN");
                }
                catch (Exception) { }

dt.Clear();


                for (int col = 1; col <= ws.Dimension.End.Column; col++)
                {
                    for (int row = 1; row <= ws.Dimension.End.Row; row++)
                    {
                        if (ws.Cells[row, col].Text.Trim().ToUpper().Contains("MSSV") || ws.Cells[row, col].Text.Trim().ToUpper().Contains("SV") || ws.Cells[row, col].Text.Trim().ToUpper().Contains("MÃ SỐ") || ws.Cells[row, col].Text.Trim().ToUpper().Contains("SINH VIÊN"))
                        {
                            for (int i = 0; i <= ws.Dimension.End.Row; i++)
                            {
                                dataGridView1.RowsAdded -= dataGridView1_RowsAdded;
                                dataGridView1.AllowUserToAddRows = true;
                                dt.Rows.Add();
                                
                                dt.Rows[i][1] = ws.Cells[row + 1, col].Text;
                                
                                row++;
                                dataGridView1.RowsAdded += dataGridView1_RowsAdded;
                              
                            }

                        }

                    }
                }

                for (int col = 1; col <= ws.Dimension.End.Column; col++)
                {
                    for (int row = 1; row <= ws.Dimension.End.Row; row++)
                    {
                        if (ws.Cells[row, col].Text.Trim().ToUpper().Contains("TÊN"))
                        {
                            for (int i = 0; i <= ws.Dimension.End.Row; i++)
                            {


                                dt.Rows[i][2] = ws.Cells[row + 1, col].Text;
                                row++;

                            }

                        }

                    }
                }
                
                for (int i = dt.Rows.Count - 1; i > 0; i--)
                {
                    if (string.IsNullOrWhiteSpace(dt.Rows[i][1].ToString()))
                    {
                        dt.Rows[i].Delete();

                    }
                    else { break; }
                }





                dataGridView1.DataSource = dt;

                luuexcel(filemoi);
                cotdiem = 1;
                
            }
            dataGridView1.AllowUserToAddRows = false;
        }

        string currentfile;
        string filemoi;
        string thumucluu = "";
        int cotdiem;
        string debugpath = Application.StartupPath;
        string fullpath;
        public mainmenu()
        {
            InitializeComponent(); ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            da = new ComboBox[] { da1, da2, da3, da4, da5, da6, da7, da8, da9, da10, da11, da12, da13, da14, da15, da16 };
            loi = new ComboBox[] { loi1, loi2, loi3, loi4, loi5, loi6, loi7, loi8, loi9, loi10, loi11, loi12, loi13, loi14, loi15, loi16 };
            bt_usb_cb = new CheckBox[] { pan1cb, pan2cb, pan3cb, pan4cb, pan5cb, pan6cb, pan7cb, pan8cb, pan9cb, pan10cb, pan11cb, pan12cb, pan13cb, pan14cb, pan15cb, pan16cb };
            wf_cb = new CheckBox[] { wfpan1cb, wfpan2cb, wfpan3cb, wfpan4cb, wfpan5cb, wfpan6cb, wfpan7cb, wfpan8cb, wfpan9cb, wfpan10cb, wfpan11cb, wfpan12cb, wfpan13cb, wfpan14cb, wfpan15cb, wfpan16cb };
            baihoccambien = new Button[] { bai1cambien, bai2cambien, bai3cambien, bai4cambien, bai5cambien, bai6cambien, bai7cambien, bai8cambien, bai9cambien, bai10cambien, bai11cambien, bai12cambien };
            baihocthuchanh = new Button[] { th1, th2, th3, th4, th5, th6, th7, th8, th9, th10, th11, th12 };
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

            tabControl2.Appearance = TabAppearance.FlatButtons;
            tabControl2.ItemSize = new Size(0, 1);
            tabControl2.SizeMode = TabSizeMode.Fixed;
            statelbl.Hide();
            disconnect.Enabled = false;
            disconnect.Hide();
            tabControl1.Focus();


        }

        string comdung;
        string cmd;
        string dapan;
        double socauhoi = 0;
        double diem;
        string[] pool = { "ECT Hở mạch", "IAT Điện trở cao", "MAF Hở mạch", "CKP Hở mạch", "IGT1 Hở mạch", "IGT2 Chạm mass", "IGT3 Chạm mass", "IGT4 Chạm mass", "CMPA Hở mạch", "CMPB Hở mạch", "APP1 Hở mạch", "APP2 Chạm mass", "FRPS Hở mạch", "AFS Chạm mass", "TPS1 Hở mạch", "TPS2 Chạm mass" };
        char[] traloi = "0000000000000000".ToCharArray();
        private void login_Load(object sender, EventArgs e)
        {

        }

        private void log_Click(object sender, EventArgs e)
        {


            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            if (tk.Text.StartsWith("g"))
            { fullpath = debugpath + @"\giangvien.xlsx";

                FileInfo file = new FileInfo(fullpath);
                using (ExcelPackage package = new ExcelPackage(file))
                {

                    int sotk = package.Workbook.Worksheets["taikhoangv"].Dimension.End.Row;
                    for (int i = 2; i <= sotk; i++)
                    {
                        if (tk.Text == package.Workbook.Worksheets["taikhoangv"].Cells["A" + i].Text)
                        {
                            if (mk.Text == package.Workbook.Worksheets["taikhoangv"].Cells["B" + i].Text)
                            {
                                tabControl1.SelectedTab = gv1;
                                return;
                            }
                        }



                        if (i == sotk) { MessageBox.Show("Sai tài khoản hoặc mật khẩu"); }

                    }
                }

            }
            else
            {
                if (cb_chonlop.SelectedItem != "")
                {
                    fullpath = thumucluu + cb_chonlop.SelectedItem + ".xlsx";

                    FileInfo file = new FileInfo(fullpath);
                    using (ExcelPackage package = new ExcelPackage(file))
                    {

                        int sotk = package.Workbook.Worksheets[1].Dimension.End.Row;
                        for (int i = 2; i <= sotk; i++)
                        {
                            if (tk.Text == package.Workbook.Worksheets[1].Cells["A" + i].Text)
                            {
                                if (mk.Text == package.Workbook.Worksheets[1].Cells["B" + i].Text)
                                {
                                    tabControl1.SelectedTab = gv1;
                                    return;
                                }
                            }



                            if (i == sotk) { MessageBox.Show("Sai tài khoản hoặc mật khẩu"); }

                        }
                    }




                }
                else { MessageBox.Show("Bạn chưa chọn lớp"); }
            }

            
          
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

            if (gd.Enabled == false) { tipgd.Text = "Yêu cầu kết nối với thiết bị để sử dụng chức năng này"; }
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
            gd.Enabled = true;


        }
        private void SetDisconnectedBT()
        {
            if (tabControl1.SelectedTab == danhpanbtusb && donebt.Visible == true)
            {
                tabControl1.SelectedTab = kiemtraqlsv;
                settings_panel.Show();
                tabControl2.SelectedTab = btmode;


            }
            if (tabControl1.SelectedTab == danhpanbtusb && donebt.Visible == false)
            {
                tabControl1.SelectedTab = gv1;
                settings_panel.Show();
                tabControl2.SelectedTab = btmode;


            }

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
            statelbl.Text = "DISCONNECTED";
            statelbl.ForeColor = Color.Red;
            danhpanbtusb.Hide();
            btmode.Show();
            gd.Enabled = false;
            kt.Enabled = false;




        }
        private void ping()
        {
            try
            {
                serCOM.WriteLine("ping");
                serCOM.WriteTimeout = 1000;

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
                tabControl2.SelectedTab = btctd;
            }
        }



        public void ping_timer_Tick(object sender, EventArgs e)
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

            if (statelbl.Text != "BLUETOOTH CONNECTED")
            { tabControl2.SelectedTab = btmode;

            }
            else if (statelbl.Text == "BLUETOOTH CONNECTED")
            { tabControl2.SelectedTab = btctd;
                label4.Text = "Đã kết nối Bluetooth";
            }
            else if (statelbl.Text == "USB CONNECTED")
            { tabControl2.SelectedTab = btctd;
                label4.Text = "Đã kết nối USB " + comdung;
            }



        }

        private void wifi_Click(object sender, EventArgs e)
        {

            tabControl2.SelectedTab = wfmode;
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
            try
            {
                serCOM.WriteLine(cmd);
            }
            catch (Exception) { MessageBox.Show("Mất kết nối Bluetooth"); }


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
                MessageBox.Show("Mất kết nối.");
            }
            catch (WebException) { }
        }



        private void connectwifi_Click(object sender, EventArgs e)
        {
            wifi_ping_timer.Start();


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
            btmode.Hide();
        }

        private void backpg6_Click(object sender, EventArgs e)
        {
            wfmode.Hide();

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

            tabControl1.SelectedTab = dangnhap;
        }

        private void hs_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = sinhvien;
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
            danhpanwf.Hide();
            wfmode.Show();
        }





        private void backpg9_Click(object sender, EventArgs e)
        {
            usbmode.Hide();

        }

        private void usb_Click(object sender, EventArgs e)
        {
            tabControl2.SelectedTab = usbmode;


            usb_ping_timer.Start();

        }
        bool IsAlive(string port)
        {
            try
            {
                using (SerialPort sp = new SerialPort(port))
                {
                    sp.Open();
                    sp.Close();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        public void usb_ping_timer_Tick(object sender, EventArgs e)
        {
            bool found = false;

            foreach (var device in new ManagementObjectSearcher(
                "SELECT * FROM Win32_PnPEntity WHERE Name LIKE '%(COM%'").Get())
            {
                string name = device["Name"]?.ToString();

                if (name != null && name.Contains("CP21"))
                {
                    found = true;

                    var match = System.Text.RegularExpressions.Regex.Match(name, @"\(COM\d+\)");
                    string com = match.Value.Replace("(", "").Replace(")", "");

                    comusb.Text = "Đã kết nối USB cổng " + com;
                    comdung = com;

                    if (!serCOM.IsOpen || com != comdung)
                    {
                        comdung = com;
                        SetConnectedUSB();
                    }

                    break;
                }
            }

            if (!found)
            {
                comusb.Text = "Không tìm thấy USB";

                if (statelbl.Text == "USB CONNECTED")
                {
                    SetDisconnectedUSB();
                }
            }
        }



        void SetConnectedUSB()
        {

            if (comdung != "" && !serCOM.IsOpen)
            { try
                {
                    serCOM.PortName = comdung;

                    serCOM.BaudRate = 9600;
                    serCOM.Open();
                    statelbl.Show();
                    statelbl.Text = "USB CONNECTED";
                    statelbl.ForeColor = Color.Green;

                    disconnect.Enabled = true;
                    disconnect.Show();
                    gd.Enabled = true;
                    serCOM.WriteLine("USBconnected");




                }
                catch (Exception) { MessageBox.Show("Không thể kết nối USB"); }
            }
        }
        private void SetDisconnectedUSB()
        {
            if (tabControl1.SelectedTab == danhpanbtusb && donebt.Visible == true)
            {
                tabControl1.SelectedTab = kiemtraqlsv;
                settings_panel.Show();
                tabControl2.SelectedTab = usbmode;

            }
            if (tabControl1.SelectedTab == danhpanbtusb && donebt.Visible == false)
            {
                tabControl1.SelectedTab = gv1;
                settings_panel.Show();
                tabControl2.SelectedTab = usbmode;

            }

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
            statelbl.Text = "DISCONNECTED";
            statelbl.ForeColor = Color.Red;
            gd.Enabled = false;
            kt.Enabled = false;





        }

        private void button1_Click(object sender, EventArgs e)
        {
            statelbl.Text = "USB CONNECTED";
        }

        private void settings_Click(object sender, EventArgs e)
        {
            
        }

        private void close_settings_Click(object sender, EventArgs e)
        {
            settings_panel.Visible = false;
        }

        private void debug_Click(object sender, EventArgs e)
        {

            LT uc = new LT();
            uc.Dock = DockStyle.Fill;

        
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
         

            LT uc = new LT();
            uc.Dock = DockStyle.Fill;

           
        }

        private void cbpan_CheckedChanged(object sender, EventArgs e)
        {
            pan1 = cbpan1.Checked ? "1" : "0";
            pan2 = cbpan2.Checked ? "1" : "0";
            pan3 = cbpan3.Checked ? "1" : "0";
            pan4 = cbpan4.Checked ? "1" : "0";
            pan5 = cbpan5.Checked ? "1" : "0";
            pan6 = cbpan6.Checked ? "1" : "0";
            pan7 = cbpan7.Checked ? "1" : "0";
            pan8 = cbpan8.Checked ? "1" : "0";
            pan9 = cbpan9.Checked ? "1" : "0";
            pan10 = cbpan10.Checked ? "1" : "0";
            pan11 = cbpan11.Checked ? "1" : "0";
            pan12 = cbpan12.Checked ? "1" : "0";
            pan13 = cbpan13.Checked ? "1" : "0";
            pan14 = cbpan14.Checked ? "1" : "0";
            pan15 = cbpan15.Checked ? "1" : "0";
            pan16 = cbpan16.Checked ? "1" : "0";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = gvsv;
        }

        private void gd_Click(object sender, EventArgs e)
        {
            if (statelbl.Text == "BLUETOOTH CONNECTED" || statelbl.Text == "USB CONNECTED")
            {
                tabControl1.SelectedTab = danhpanbtusb;
                gvcchonpanbt.Visible = false;
                donebt.Visible = false;
            }
            if (statelbl.Text == "WIFI CONNECTED")
            {
                tabControl1.SelectedTab = danhpanwf;
                gvchonpanwf.Visible = false;
                donewf.Visible = false;

            }

        }

        private void gv1_Click(object sender, EventArgs e)
        {

        }

        private void gd_MouseEnter(object sender, EventArgs e)
        {

        }

        private void tip_gd_Popup(object sender, PopupEventArgs e)
        {

        }

        private void kiemtraqlsv_Click(object sender, EventArgs e)
        {

        }

        private void kt_Click(object sender, EventArgs e)
        {
            if (statelbl.Text == "BLUETOOTH CONNECTED" || statelbl.Text == "USB CONNECTED")
            { tabControl1.SelectedTab = danhpanbtusb;
                gvcchonpanbt.Visible = true;
                donebt.Visible = true;
            }
            if (statelbl.Text == "WIFI CONNECTED")
            { tabControl1.SelectedTab = danhpanwf;
                gvchonpanwf.Visible = true;
                donewf.Visible = true;

            }
            traloi = "0000000000000000".ToCharArray();
        }

        private void qlsv_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = kiemtraqlsv;
        }

        private void donewf_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = kiemtra1;
            dapan = cmd.Substring(2);
            socauhoi = 0;
            for (int i = 0; i < 16; i++) { if (dapan[i] == '1') { socauhoi++; } }

            for (int r = 0; r < tableLayoutPanel1.RowCount; r++)
            {
                foreach (Control c in tableLayoutPanel1.Controls)
                {
                    if (tableLayoutPanel1.GetRow(c) == r)
                    {
                        c.Visible = (r < socauhoi);
                    }
                }
            }

        }

        private void donebt_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = kiemtra1;
            dapan = cmd.Substring(2);
            socauhoi = 0;
            for (int i = 0; i < 16; i++) { if (dapan[i] == '1') { socauhoi++; } }

            for (int r = 0; r < tableLayoutPanel1.RowCount; r++)
            {
                foreach (Control c in tableLayoutPanel1.Controls)
                {
                    if (tableLayoutPanel1.GetRow(c) == r)
                    {
                        c.Visible = (r < socauhoi);
                    }
                }
            }

        }

        private void submit_Click(object sender, EventArgs e)
        {


            for (int i = 0; i < socauhoi; i++)
            {


                int vitri = 0;
                int index;
                string sensor = "";
                if (da[i].Text != "")
                {
                    vitri = da[i].Text.IndexOf('-');


                    sensor = da[i].SelectedItem?.ToString().Substring(0, vitri);

                    if (loi[i].Text == "") { MessageBox.Show("Điền đủ"); return; }
                    else
                    { index = Array.IndexOf(pool, sensor + loi[i].Text); }
                    if (index != -1) { traloi[index] = '1'; }
                }
                else { MessageBox.Show("Điền đủ"); return; }

            }





            string final = new string(traloi);

            double caudung = 0;

            for (int i = 0; i < 16; i++)
            {

                if (final[i] == dapan[i] && final[i] == '1')
                { caudung++; }
            }


            lbdapan.Text = caudung.ToString() + "/" + socauhoi.ToString();
            diem = caudung * 10 / socauhoi;
            diem = Math.Round(diem, 1);
            if (MessageBox.Show("SỐ CÂU ĐÚNG: " + caudung.ToString() + "/" + socauhoi.ToString() + "\nĐIỂM: " + diem + "\n ẤN OK ĐỂ TRỞ VỀ TRANG QLSV") == DialogResult.OK) { tabControl1.SelectedTab = kiemtraqlsv; luudiem(diem);

                for (int i = 0; i < 16; i++)
                {
                    bt_usb_cb[i].Checked = false;
                    wf_cb[i].Checked = false;
                }

            }
        }

        void luudiem(double diem)
        { int i;
            for (i = 2; i < dataGridView1.Columns.Count; i++)
            {

                if (string.IsNullOrWhiteSpace(dataGridView1.SelectedRows[0].Cells[i].Value?.ToString()))
                {

                    dataGridView1.SelectedRows[0].Cells[i].Value = diem;
                    dataGridView1.Refresh();
                    return;
                }

            }
        }
        private void lbdapan_Click(object sender, EventArgs e)
        {
            traloi = "0000000000000000".ToCharArray();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void browse_Click(object sender, EventArgs e)
        {

        }
        private void luuexcel(string path)
        {
            try
            {
                ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
                FileInfo file = new FileInfo(path);

                using (ExcelPackage package = new ExcelPackage(file))
                {
                    var ws = package.Workbook.Worksheets[0];
                    int rowCount = dataGridView1.Rows.Count;
                    int colCount = dataGridView1.Columns.Count;
                    ws.Cells[1, 1].Value = "MSSV";
                    ws.Cells[1, 2].Value = "Họ và tên";

                    for (int i = 0; i < rowCount; i++)
                    {

                        if (dataGridView1.Rows[i].IsNewRow) continue;

                        for (int j = 0; j < colCount; j++)
                        {
                            ws.Cells[i + 2, j + 1].Value =
                                dataGridView1.Rows[i].Cells[j].Value?.ToString();
                            if (colCount >= 3 && j >= 2) { ws.Cells[1, j + 1].Value = "Cột điểm " + (j - 1).ToString(); ; }
                        }
                    }

                    package.Save();
                }

                MessageBox.Show("Lưu thành công");
            }
            catch (Exception) { MessageBox.Show("Lưu không thành công, hãy đảm bảo file không đang được mở"); }

        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (statelbl.Text.Contains("CONNECTED"))
            {
                kt.Enabled = true;
                svkiemtra = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();

            }
            else { kt.Enabled = false; }
        }

        private void kiemtra1_Enter(object sender, EventArgs e)
        {
            tensvkiemtra.Text = "Tên sinh viên: " + svkiemtra;
            for (int i = 0; i < 16; i++)
            {
                da[i].SelectedIndex = -1;
                loi[i].SelectedIndex = -1;
            }
        }

        private void da_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void kiemtra1_Click(object sender, EventArgs e)
        {

            List<string> pooldatemp = poolda.ToList();
            for (int i = 0; i < 16; i++)
            {
                if (da[i].Text != "")
                {
                    pooldatemp.Remove(da[i].Text);

                }
            }
            for (int i = 0; i < 16; i++)
            {
                if (da[i].Text == "")
                {
                    da[i].Items.Clear();
                    da[i].Items.AddRange(pooldatemp.ToArray());

                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void save_Click(object sender, EventArgs e)
        {

            luuexcel(Path.Combine(thumucluu, dgvLop.SelectedCells[0].Value + ".xlsx"));
        }

        private void themcotdiem_Click(object sender, EventArgs e)
        {
            for (cotdiem = 1; cotdiem > 0; cotdiem++)
            { if (dt.Columns.Contains("Cột điểm " + cotdiem))
                { }
                else
                {
                    dt.Columns.Add("Cột điểm " + cotdiem);
                    dataGridView1.Columns[1 + cotdiem].ReadOnly = true;
                    break;
                }
            }

        }

        private void themsv_Click(object sender, EventArgs e)
        {
            dataGridView1.AllowUserToAddRows = true;
            dt.Rows.Add();
            
            
            dataGridView1.AllowUserToAddRows = false;


        }

        private void themlop_Click(object sender, EventArgs e)
        {


            foreach (DataGridViewRow row in dgvLop.Rows)
            {
                foreach (DataGridViewCell item in row.Cells)
                {
                    if (string.IsNullOrWhiteSpace(item.Value.ToString())) { return; }

                    if (tenlopmoi.Text.ToUpper() == item.Value.ToString())
                    {
                        MessageBox.Show("Tên lớp mới không được trùng với lớp cũ");
                        return;
                    }
                }
            }
                if (string.IsNullOrWhiteSpace(tenlopmoi.Text) || tenlopmoi.Text.Length < 8) { MessageBox.Show("Tên lớp mới gồm ít nhất 8 ký tự"); return; }
                
            
            dgvLop.Rows.Add(tenlopmoi.Text.ToUpper());
            DialogResult result = MessageBox.Show(
    "Bạn có muốn dùng danh sách sinh viên có sẵn để tạo lớp mới không? \n Nếu chọn No, bạn sẽ tạo được một lớp trống và có thể thêm SV thủ công!",
    "Thông báo",
    MessageBoxButtons.YesNo
);
            if (result == DialogResult.Yes)
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Title = "Chọn danh sách sinh viên cần tạo lớp";
                ofd.Filter = "Excel Files (*.xlsx)|*.xlsx";

                if (ofd.ShowDialog() == DialogResult.OK)
                {


                    thumucluu = Properties.Settings.Default.luufile;

                    if (string.IsNullOrEmpty(thumucluu))
                    {

                        FolderBrowserDialog sfd = new FolderBrowserDialog();
                        sfd.Description = "Chọn thư mục lưu trữ các lớp mới";


                        if (sfd.ShowDialog() == DialogResult.OK)
                        {

                            thumucluu = sfd.SelectedPath.ToString();
                            Properties.Settings.Default.luufile = thumucluu;
                            Properties.Settings.Default.Save();


                        }
                    }
                    using (ExcelPackage package = new ExcelPackage())
                    {

                        package.Workbook.Worksheets.Add("Sheet1");
                        package.Workbook.Worksheets.Add("Tài khoản SV");
                        var wstaikhoan = package.Workbook.Worksheets[1];



                        string path = Path.Combine(thumucluu, tenlopmoi.Text.ToUpper() + ".xlsx");
                                package.SaveAs(new FileInfo(path));
                                filemoi = path;
                              
                                dt.Clear();


                                
                            
                        
                    }
                    LoadExcel(ofd.FileName);


                }


                currentfile = ofd.FileName;

                dataGridView1.ClearSelection();
               
            }



            else
            {
                using (ExcelPackage package = new ExcelPackage())
                {
                    package.Workbook.Worksheets.Add("Sheet1");
                   
                   
                    package.Workbook.Worksheets.Add("Tài khoản SV");
                    var wstaikhoan = package.Workbook.Worksheets[1];
                    wstaikhoan.Cells[1, 1].Value = "Tài khoản SV";
                    wstaikhoan.Cells[1, 2].Value = "Mật khẩu";

                    try
                    {
                        dt.Columns.Add("STT");
                        dt.Columns.Add("MSSV");
                        dt.Columns.Add("HỌ VÀ TÊN");
                    }
                    catch (Exception) { }

                    string path = Path.Combine(thumucluu, tenlopmoi.Text.ToUpper() + ".xlsx");
                   
                        
                    
                    package.SaveAs(new FileInfo(path));
                    filemoi = path;

                    dt.Clear();

                    luuexcel(filemoi);



                }
                

            }
            dgvLop.Rows[find_row_index(dgvLop, tenlopmoi.Text.ToUpper())].Selected = true;
            tenlopmoi.Clear();
            tenlopmoi.Text = "";
            
           


        }
        private int find_row_index(DataGridView dataGridView, string searchValue)
        {
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && cell.Value.ToString() == searchValue)
                    {
                        return row.Index;
                    }
                }
            }
            return -1;
        }

        private void listbox_recentfiles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void danhpan_Enter(object sender, EventArgs e)
        {


        }

        private void danhpanbtusb_Enter(object sender, EventArgs e)
        {
            for (int i = 0; i < 16; i++)
            {
                bt_usb_cb[i].Checked = false;
            }
        }

        private void danhpanwf_Enter(object sender, EventArgs e)
        {
            for (int i = 0; i < 16; i++)
            {
                wf_cb[i].Checked = false;
            }
        }

        private void kiemtra1_Leave(object sender, EventArgs e)
        {
            if (statelbl.Text.Contains("USB") || statelbl.Text.Contains("BLUETOOTH"))
            {
                for (int i = 0; i < 16; i++)
                {
                    bt_usb_cb[i].Checked = false;
                }
            }
            if (statelbl.Text.Contains("WIFI"))
            {
                for (int i = 0; i < 16; i++)
                {
                    wf_cb[i].Checked = false;
                }
            }
        }

        private void recentfiles_AfterLabelEdit(object sender, LabelEditEventArgs e)
        {

            if (string.IsNullOrWhiteSpace(e.Label))
            {
                if (e.Label == null) return;
                e.CancelEdit = true;
                MessageBox.Show("Tên lớp không được là khoảng trắng hoặc trùng với các lớp khác");

            }
            else if (e.Label != oldname) {
                File.Move(Path.Combine(thumucluu, oldname), Path.Combine(thumucluu, e.Label + ".xlsx"));
                MessageBox.Show("Lưu thành công");
            }
        }
        string oldname;
        private void recentfiles_BeforeLabelEdit(object sender, LabelEditEventArgs e)
        {


        }

        private void recentfiles_CursorChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0) return;
            filemoi = Path.Combine(thumucluu, dgvLop.CurrentCell.Value + ".xlsx");
           
            luuexcel(filemoi);
        }

        private void kiemtraqlsv_Enter(object sender, EventArgs e)
        {
            try
            {
                thumucluu = Properties.Settings.Default.luufile;
                dgvLop.Rows.Clear();
                foreach (string file in Directory.GetFiles(thumucluu, "*.xlsx"))
                {
                    
                    
                        if (!Path.GetFileNameWithoutExtension(file).Contains("~$"))
                            dgvLop.Rows.Add(Path.GetFileNameWithoutExtension(file));
                    

                }
                

            }
            catch (Exception) { }
            
               
        }
        int lastActivatedIndex = -1;
        private void recentfiles_ItemActivate(object sender, EventArgs e)
        {


        }

        private void recentfiles_ItemCheck(object sender, ItemCheckEventArgs e)
        {
        }

        private void recentfiles_ItemChecked(object sender, ItemCheckedEventArgs e)
        {


        }
        int lastIndex = 0;

      
        int currentIndex;
        

       

        private void xoacotdiem_Click(object sender, EventArgs e)
        {
            if (dt.Columns[dt.Columns.Count - 1].ColumnName.Contains("Cột điểm"))
            {
                dt.Columns.RemoveAt(dt.Columns.Count - 1);

            }


        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            dataGridView1.AllowUserToAddRows = true;
            try
            {
                for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                    dt.Rows.RemoveAt(dataGridView1.SelectedRows[i].Index );
            }
            catch (Exception) { MessageBox.Show("Bạn chưa chọn sinh viên để xóa"); }
            dataGridView1.AllowUserToAddRows = false;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            { xoasv.Enabled = true; }
        }

        private void backlogin_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = gvsv;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = gv1;
        }

        private void button3_Click_3(object sender, EventArgs e)
        {

        }

        private void svLT_Click(object sender, EventArgs e)
        {
            //sinhvien.Controls.Clear();

            //LT uc = new LT();
            //uc.Dock = DockStyle.Fill;

            // sinhvien.Controls.Add(uc);
            tabControl1.SelectedTab = chonchuonglt;

        }

        private void backltsv_Click(object sender, EventArgs e)
        {
            sinhvien.Hide();

        }
        string tenbaihoc = "";


        private void btn_chuongcambien_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = chonbailt;

          
        }
        

        private int Slides, CurrentSlide = 0, PreviousSlide = 1, DoneSlide = 1;

        TabPage prevtab;
        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            prevtab = tabControl1.SelectedTab;
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
        string tenchuong;
        private void chonchuong_Click(object sender, EventArgs e)
        {
           tenchuong  = (string)((Button)sender).Tag;
            tabControl1.SelectedTab = chonbailt;

        }

        private void pn_baihoccambien_Enter(object sender, EventArgs e)
        {

        }

        private void chonbai_Enter(object sender, EventArgs e)
        {
        }

        private void tabControl1_Enter(object sender, EventArgs e)
        {

        }

        private void chonbai_Enter_1(object sender, EventArgs e)
        {

            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            fullpath = debugpath + @"/Mazda 3 L4-2.0L/" + tenchuong;
            FileInfo file = new FileInfo(fullpath);
            using (ExcelPackage package = new ExcelPackage(file))
            {
                for (int i = 0; i < package.Workbook.Worksheets.Count&&i<=12; i++)
                {
                    if (package.Workbook.Worksheets[i].Name.Contains("bai"))
                    {
                        tenbaihoc = "";
                        baihoccambien[i].Visible = true;

                        tenbaihoc = package.Workbook.Worksheets[i].Cells["B1"].Text.Split('\n')[0];

                        baihoccambien[i].Text = tenbaihoc;
                        baihoccambien[i].Tag = package.Workbook.Worksheets[i].Name;



                    }


                }
            }
        }

        private void nextslide_Click(object sender, EventArgs e)
        {

            using (var package = new ExcelPackage(new FileInfo(fullpath)))
            {
                if (CurrentSlide < Slides)
                {
                   
                        CurrentSlide++;
                        ExcelWorksheet worksheet = package.Workbook.Worksheets[tensheet];

                        noidungslide.Text = (string)worksheet.Cells["B" + (CurrentSlide).ToString()].Value;



                        pictureBox1.BackgroundImage = Image.FromFile(debugpath + @"\Mazda 3 L4-2.0L\anh\" + (string)worksheet.Cells["A" + (CurrentSlide).ToString()].Value);
                    
                }
            }
            

            
        }

        private void prevslide_Click(object sender, EventArgs e)
        {
            using (var package = new ExcelPackage(new FileInfo(fullpath)))
            {
                if (CurrentSlide <= Slides&& CurrentSlide>=2)
                {

                    CurrentSlide--;
                    ExcelWorksheet worksheet = package.Workbook.Worksheets[tensheet];

                    noidungslide.Text = (string)worksheet.Cells["B" + (CurrentSlide).ToString()].Value;



                    pictureBox1.BackgroundImage = Image.FromFile(debugpath + @"\Mazda 3 L4-2.0L\anh\" + (string)worksheet.Cells["A" + (CurrentSlide).ToString()].Value);

                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            settings_panel.Visible = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = sinhvien;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = chonchuonglt;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = chonbailt;
        }

        private void slidesbaihoc_Enter(object sender, EventArgs e)
        {
            CurrentSlide = 0;
            PreviousSlide = 1;
             DoneSlide = 1;
            pn_slides.Controls.Clear();
            noidungslide.Text = "";
            pictureBox1.BackgroundImage = null;
        }

        private int[] DoneSlides;
        string tensheet;

        private void svTH_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = chonchuongth;
        }
        string tenchuongth;
        private void button10_Click(object sender, EventArgs e)
        {
            tenchuongth = button10.Tag.ToString();
            tabControl1.SelectedTab = chonbaith;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            tenchuongth = button9.Tag.ToString();
            tabControl1.SelectedTab = chonbaith;
        }
       
        private void chonbaith_Enter(object sender, EventArgs e)
        {
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            fullpath = debugpath + @"/Mazda 3 L4-2.0L/" + tenchuongth;
            FileInfo file = new FileInfo(fullpath);
            using (ExcelPackage package = new ExcelPackage(file))
            {
                for (int i = 0; i < package.Workbook.Worksheets.Count&&i<=12; i++)
                {
                    if (package.Workbook.Worksheets[i].Name.Contains("bai"))
                    {
                        tenbaihoc = "";
                        baihocthuchanh[i].Visible = true;

                        tenbaihoc = package.Workbook.Worksheets[i].Cells["E1"].Text;

                        baihocthuchanh[i].Text = tenbaihoc;
                        baihocthuchanh[i].Tag = package.Workbook.Worksheets[i].Name;



                    }


                }
            }
        }
        int questscount = 0;

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        int Slides_th;
        string tensheet_th;
        private void th_click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = slidethuchanh;
            tensheet_th = (string)((Button)sender).Tag;
            label10.Text = tenbaihoc;
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            fullpath = debugpath + @"/Mazda 3 L4-2.0L/" + tenchuongth;
            FileInfo file = new FileInfo(fullpath);
            using (ExcelPackage package = new ExcelPackage(file))
            {
                pn_slideth.Controls.Clear();
                var ws = package.Workbook.Worksheets[tensheet_th];
                Slides_th = ws.Dimension.End.Row;
                questscount = Slides_th;
                
              

                cauhoithuchanh.Clear();
                for (int i = 1; i <= Slides_th; i++)
                {
                    Button buttonth = new Button();
                    buttonth.Text = i.ToString();
                    buttonth.Name = "buttonth" + i.ToString();
                    buttonth.BackColor = Color.FromArgb(212, 232, 248);

                    buttonth.Location = new Point(  -20+i * 65, 6);
                    buttonth.Size = new Size(55, 45);
                    buttonth.Font = new Font("Arial", 18, FontStyle.Bold);

                    buttonth.Click += Button_th_Click;
                    buttonth.BackColorChanged += Button_th_backcolorchanged;

                    pn_slideth.Controls.Add(buttonth);
                    cauhoithuchanh.Add(buttonth);
                    
                }
            }
        }
        string rightchoice;
        string choice;
        Button currentquest;
        private void Button_th_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            clickedButton.Focus();
            currentquest = clickedButton;

            if (clickedButton.BackColor == Color.Red || clickedButton.BackColor == Color.Green)
            {
                pn_choices.Controls.Clear();
                using (var package = new ExcelPackage(new FileInfo(fullpath)))
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets[tensheet_th];

                    noidungth.Text = (string)worksheet.Cells["B" + clickedButton.Text].Value;



                    ptb_slideth.BackgroundImage = Image.FromFile(debugpath + @"\Mazda 3 L4-2.0L\anh\" + (string)worksheet.Cells["A" + clickedButton.Text].Value);

                    string[] DapAn = ((string)worksheet.Cells["C" + clickedButton.Text].Value).Split('%');
                    for (int i = 0; i < DapAn.Length; i++)
                    {
                        if (DapAn[i][0] == ((Button)sender).Tag.ToString()[0]&& ((Button)sender).Tag.ToString()[0]== ((Button)sender).Tag.ToString()[1])
                        {
                            System.Windows.Forms.RadioButton radioButton = new System.Windows.Forms.RadioButton
                            {

                                AutoSize = true,
                                Text = DapAn[i],
                                Font = new Font("Arial", 14, FontStyle.Regular),
                                ForeColor = Color.Green,
                                Location = new Point(10, 5 + i * 25),
                            };
                            radioButton.AutoCheck = false;
                            radioButton.Checked = true;
                            pn_choices.Controls.Add(radioButton);
                           

                        }
                       else if (DapAn[i][0] == ((Button)sender).Tag.ToString()[0] && ((Button)sender).Tag.ToString()[0] != ((Button)sender).Tag.ToString()[1])
                        {
                            System.Windows.Forms.RadioButton radioButton = new System.Windows.Forms.RadioButton
                            {

                                AutoSize = true,
                                Text = DapAn[i],
                                Font = new Font("Arial", 14, FontStyle.Regular),
                                ForeColor = Color.Green,
                                Location = new Point(10, 5 + i * 25),
                            };
                            radioButton.AutoCheck = false;
                            
                            pn_choices.Controls.Add(radioButton);


                        }
                        else if(DapAn[i][0] == ((Button)sender).Tag.ToString()[1]&& ((Button)sender).Tag.ToString()[0]!= ((Button)sender).Tag.ToString()[1])
                        {
                            System.Windows.Forms.RadioButton radioButton = new System.Windows.Forms.RadioButton
                            {

                                AutoSize = true,
                                Text = DapAn[i],
                                Font = new Font("Arial", 14, FontStyle.Regular),
                                ForeColor = Color.Red,

                                Location = new Point(10, 5 + i * 25),
                            };
                            radioButton.Checked = true;
                            radioButton.AutoCheck = false;

                            pn_choices.Controls.Add(radioButton);
                           
                        }
                        else 
                        {
                            System.Windows.Forms.RadioButton radioButton = new System.Windows.Forms.RadioButton
                            {

                                AutoSize = true,
                                Text = DapAn[i],
                                Font = new Font("Arial", 14, FontStyle.Regular),
                                Location = new Point(10, 5 + i * 25),
                            };
                            
                            radioButton.AutoCheck = false;

                            pn_choices.Controls.Add(radioButton);

                        }






                    }
                }
            }
            else
            {
                pn_choices.Controls.Clear();



                using (var package = new ExcelPackage(new FileInfo(fullpath)))
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets[tensheet_th];

                    noidungth.Text = (string)worksheet.Cells["B" + clickedButton.Text].Value;



                    ptb_slideth.BackgroundImage = Image.FromFile(debugpath + @"\Mazda 3 L4-2.0L\anh\" + (string)worksheet.Cells["A" + clickedButton.Text].Value);

                    string[] DapAn = ((string)worksheet.Cells["C" + clickedButton.Text].Value).Split('%');
                    for (int i = 0; i < DapAn.Length; i++)
                    {
                        System.Windows.Forms.RadioButton radioButton = new System.Windows.Forms.RadioButton
                        {
                            AutoSize = true,
                            Text = DapAn[i],
                            Font = new Font("Arial", 14, FontStyle.Regular),
                            Location = new Point(10, 5 + i * 25),
                        };

                        pn_choices.Controls.Add(radioButton);
                        radioButton.CheckedChanged += RadioButton_CheckedChanged;

                    }

                    rightchoice = (string)worksheet.Cells["D" + clickedButton.Text].Value;
                    choice = "";
                }
            }

        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.RadioButton radioButton = (System.Windows.Forms.RadioButton)sender;
            if (radioButton.Checked)
            {
                choice = radioButton.Text.Substring(0, 1);
                
            }
        }

        private void Button_th_backcolorchanged(object sender, EventArgs e)
        {
            ((Button)sender).Tag = rightchoice+choice;
            label11.Text= rightchoice + choice;
            currentquest.PerformClick();
            
        }

        private void but_xong_Click(object sender, EventArgs e)
        {
           int socauthdung = 0;
            int caudatraloi = 0;
           
            foreach (Button button in cauhoithuchanh )
            {
                if (button.BackColor == Color.Green) { socauthdung++;caudatraloi++; }
                else if(button.BackColor == Color.Red) { caudatraloi++; }
            }
            if (caudatraloi != questscount) { MessageBox.Show("Bạn chưa trả lời hết câu hỏi"); }
            label11.Text = socauthdung.ToString() + "/" + caudatraloi++;
        }




        private void xemdapan_Click(object sender, EventArgs e)
        {
            if (choice == rightchoice)
            {
                MessageBox.Show("Bạn đã trả lời đúng!");
                currentquest.BackColor = Color.Green;
            }
            else if (choice != rightchoice && choice != "")
            {
                MessageBox.Show("Bạn đã trả lời sai, đáp án đúng là:\n" + rightchoice);
                currentquest.BackColor = Color.Red;
            }
            else if (choice == "") { MessageBox.Show("Bạn chưa chọn đáp án"); }
            
            
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void cb_chonlop_Click(object sender, EventArgs e)
        {
           
        }

        private void dangnhap_Enter(object sender, EventArgs e)
        {
            try
            {
                thumucluu = Properties.Settings.Default.luufile;
                foreach (string file in Directory.GetFiles(thumucluu, "*.xlsx"))
                {
                    
                    
                        if (!Path.GetFileNameWithoutExtension(file).Contains("~$"))
                            cb_chonlop.Items.Add(Path.GetFileNameWithoutExtension(file));
                    

                }


            }
            catch (Exception) { }
        }

        private void taolop_Click(object sender, EventArgs e)
        {

          

           


        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = kiemtraqlsv;
        }

        private void dgvLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void dgvLop_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.AllowUserToAddRows = true;

                oldname = dgvLop.SelectedCells[0].Value + ".xlsx";
                string path = Path.Combine(thumucluu, dgvLop.SelectedCells[0].Value + ".xlsx");

                themcotdiem.Enabled = true;
                themsv.Enabled = true;
                xoacotdiem.Enabled = true;
                xoasv.Enabled = true;
                save.Enabled = true;

                dt.Clear();
                using (var package = new ExcelPackage(new FileInfo(path)))
                {
                    var ws = package.Workbook.Worksheets[0];

                    try {
                        dt.Columns.Add("STT");dt.Columns["STT"].ReadOnly = true;
                        dt.Columns.Add("MSSV");
                        dt.Columns.Add("HỌ VÀ TÊN");
                    }
                    catch (Exception) { }

                 



                    for (int row = 2; row <= ws.Dimension.End.Row; row++)
                    {
                        DataRow dr = dt.NewRow();
                        for (int col = ws.Dimension.Start.Column; col <= ws.Dimension.End.Column; col++)
                        {
                            dr[col - 1] = ws.Cells[row, col].Text;
                        }
                        dt.Rows.Add(dr);
                    }

                    dataGridView1.DataSource = dt;
                    for (int i = 0; i < dataGridView1.Columns.Count; i++)
                    {
                        if (dataGridView1.Columns[i].HeaderText.Contains("Cột điểm"))
                        {
                            dataGridView1.Columns[i].ReadOnly = true;

                        }
                    }
                }
                dataGridView1.AllowUserToAddRows = false;

            }
            catch (Exception) { }
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            
   

        }

        private void baihoc_Click(object sender, EventArgs e)
        {
            CurrentSlide = 0;
            PreviousSlide = 1;
            DoneSlide = 1;
            tabControl1.SelectedTab = slidesbaihoc;
            tensheet = (string)((Button)sender).Tag;
            label9.Text = ((Button)sender).Text;
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            fullpath = debugpath + @"/Mazda 3 L4-2.0L/"+tenchuong;
            FileInfo file = new FileInfo(fullpath);
            using (ExcelPackage package = new ExcelPackage(file))
            {
                pn_slides.Controls.Clear();
                var ws = package.Workbook.Worksheets[tensheet];
                Slides = ws.Dimension.End.Row;

                DoneSlides = new int[Slides];
                DoneSlides[0] = 1;

                for (int i = 1; i <= Slides; i++)
                {
                    Button button = new Button();
                    button.Text = i.ToString();
                    button.Name = "button" + i.ToString();
                    button.BackColor = Color.FromArgb(212, 232, 248);

                    button.Location = new Point(50 + i * 65, 6);
                    button.Size = new Size(55, 45);
                    button.Font = new Font("Arial", 18, FontStyle.Bold);

                    button.Click += Button_Click;

                    pn_slides.Controls.Add(button);
                }
            }
        }

        
       
        private void Button_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            CurrentSlide = int.Parse(clickedButton.Text);

            
            PreviousSlide = int.Parse(clickedButton.Text);

            using (var package = new ExcelPackage(new FileInfo(fullpath)))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[tensheet];

                noidungslide.Text = (string)worksheet.Cells["B" + clickedButton.Text].Value;



                pictureBox1.BackgroundImage = Image.FromFile(debugpath + @"\Mazda 3 L4-2.0L\anh\" + (string)worksheet.Cells["A" + clickedButton.Text].Value);
            }

            

            if (CurrentSlide - DoneSlide == 1)
            {
                DoneSlides[CurrentSlide - 1] = 1;
                DoneSlide = CurrentSlide;
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void tk_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void mk_TextChanged(object sender, EventArgs e)
        {
            if (tk.Text.StartsWith("g")) { cb_chonlop.Visible = false;  lb_chonlop.Visible = false; }
            else { cb_chonlop.Visible = true; lb_chonlop.Visible = true; }
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
            danhpanbtusb.Hide();
            gvsv.Show();
        }

       

        private void back_Click_1(object sender, EventArgs e)
        {
            danhpanbtusb.Hide();
            btmode.Show();
        }





        //Wifi tab 7
        string url = "http://esp32.local/send?data=";

        private void setDisconnectedWF()
        {
            if (tabControl1.SelectedTab == danhpanwf && donewf.Visible == true)
            {
                tabControl1.SelectedTab = kiemtraqlsv;
                settings_panel.Show();
                tabControl2.SelectedTab = wfmode;

            }
            if (tabControl1.SelectedTab == danhpanwf && donewf.Visible == false)
            {
                tabControl1.SelectedTab = gv1;
                settings_panel.Show();
                tabControl2.SelectedTab = wfmode;

            }

            statelbl.Show();
            statelbl.Text = "DISCONNECTED";
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
                    MessageBox.Show("Mất kết nối Wifi");
                }
                catch (WebException) { }
            
        }
            wifi_ping_timer.Stop();
            
            tabControl2.SelectedTab = wfmode;
            disconnect.Hide();
            kt.Enabled = false;
            gd.Enabled = false;



        }
        private void setConnectedWF()
        {
            statelbl.Show();
            statelbl.Text = "WIFI CONNECTED";
            statelbl.ForeColor = Color.Green;
            
            
            disconnect.Enabled = true;
            disconnect.Show();
            gd.Enabled=true;
            

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



