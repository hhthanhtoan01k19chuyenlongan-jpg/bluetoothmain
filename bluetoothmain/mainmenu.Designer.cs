
namespace bluetoothmain
{
    partial class mainmenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.settings_panel = new System.Windows.Forms.Panel();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.btmode = new System.Windows.Forms.TabPage();
            this.buttona = new System.Windows.Forms.Button();
            this.COMcbo = new System.Windows.Forms.ComboBox();
            this.refresh = new System.Windows.Forms.Button();
            this.wfmode = new System.Windows.Forms.TabPage();
            this.connectwifi = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.usbmode = new System.Windows.Forms.TabPage();
            this.comusb = new System.Windows.Forms.Label();
            this.close_settings = new System.Windows.Forms.Button();
            this.wifi = new System.Windows.Forms.Button();
            this.usb = new System.Windows.Forms.Button();
            this.bluetooth = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.settings = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.kt = new System.Windows.Forms.Button();
            this.hs = new System.Windows.Forms.Button();
            this.gv = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.log = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mk = new System.Windows.Forms.TextBox();
            this.tk = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.statelbl = new System.Windows.Forms.Label();
            this.disconnect = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.Button();
            this.backpg4 = new System.Windows.Forms.Button();
            this.pan16cb = new System.Windows.Forms.CheckBox();
            this.pan15cb = new System.Windows.Forms.CheckBox();
            this.pan14cb = new System.Windows.Forms.CheckBox();
            this.pan13cb = new System.Windows.Forms.CheckBox();
            this.pan12cb = new System.Windows.Forms.CheckBox();
            this.pan11cb = new System.Windows.Forms.CheckBox();
            this.pan10cb = new System.Windows.Forms.CheckBox();
            this.pan9cb = new System.Windows.Forms.CheckBox();
            this.pan8cb = new System.Windows.Forms.CheckBox();
            this.pan7cb = new System.Windows.Forms.CheckBox();
            this.pan6cb = new System.Windows.Forms.CheckBox();
            this.pan5cb = new System.Windows.Forms.CheckBox();
            this.pan4cb = new System.Windows.Forms.CheckBox();
            this.pan3cb = new System.Windows.Forms.CheckBox();
            this.pan2cb = new System.Windows.Forms.CheckBox();
            this.pan1cb = new System.Windows.Forms.CheckBox();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.backpg7 = new System.Windows.Forms.Button();
            this.disconnectWF = new System.Windows.Forms.Button();
            this.wfpan16cb = new System.Windows.Forms.CheckBox();
            this.wfpan15cb = new System.Windows.Forms.CheckBox();
            this.wfpan14cb = new System.Windows.Forms.CheckBox();
            this.wfpan13cb = new System.Windows.Forms.CheckBox();
            this.wfpan12cb = new System.Windows.Forms.CheckBox();
            this.wfpan11cb = new System.Windows.Forms.CheckBox();
            this.wfpan10cb = new System.Windows.Forms.CheckBox();
            this.wfpan9cb = new System.Windows.Forms.CheckBox();
            this.wfpan8cb = new System.Windows.Forms.CheckBox();
            this.wfpan7cb = new System.Windows.Forms.CheckBox();
            this.wfpan6cb = new System.Windows.Forms.CheckBox();
            this.wfpan5cb = new System.Windows.Forms.CheckBox();
            this.wfpan4cb = new System.Windows.Forms.CheckBox();
            this.wfpan3cb = new System.Windows.Forms.CheckBox();
            this.wfpan2cb = new System.Windows.Forms.CheckBox();
            this.wfpan1cb = new System.Windows.Forms.CheckBox();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.svLT = new System.Windows.Forms.Button();
            this.svTH = new System.Windows.Forms.Button();
            this.serCOM = new System.IO.Ports.SerialPort(this.components);
            this.ping_timer = new System.Windows.Forms.Timer(this.components);
            this.wifi_ping_timer = new System.Windows.Forms.Timer(this.components);
            this.usb_ping_timer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.settings_panel.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.btmode.SuspendLayout();
            this.wfmode.SuspendLayout();
            this.usbmode.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.tabPage8.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.settings_panel);
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Location = new System.Drawing.Point(0, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1600, 900);
            this.panel1.TabIndex = 20;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // settings_panel
            // 
            this.settings_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.settings_panel.Controls.Add(this.tabControl2);
            this.settings_panel.Controls.Add(this.close_settings);
            this.settings_panel.Controls.Add(this.wifi);
            this.settings_panel.Controls.Add(this.usb);
            this.settings_panel.Controls.Add(this.bluetooth);
            this.settings_panel.Location = new System.Drawing.Point(76, 67);
            this.settings_panel.Margin = new System.Windows.Forms.Padding(2);
            this.settings_panel.Name = "settings_panel";
            this.settings_panel.Size = new System.Drawing.Size(1057, 553);
            this.settings_panel.TabIndex = 3;
            this.settings_panel.Visible = false;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.btmode);
            this.tabControl2.Controls.Add(this.wfmode);
            this.tabControl2.Controls.Add(this.usbmode);
            this.tabControl2.Location = new System.Drawing.Point(190, 23);
            this.tabControl2.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(830, 500);
            this.tabControl2.TabIndex = 1;
            // 
            // btmode
            // 
            this.btmode.Controls.Add(this.buttona);
            this.btmode.Controls.Add(this.COMcbo);
            this.btmode.Controls.Add(this.refresh);
            this.btmode.Location = new System.Drawing.Point(4, 22);
            this.btmode.Name = "btmode";
            this.btmode.Padding = new System.Windows.Forms.Padding(3);
            this.btmode.Size = new System.Drawing.Size(822, 474);
            this.btmode.TabIndex = 2;
            this.btmode.Text = "btmode";
            this.btmode.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // buttona
            // 
            this.buttona.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttona.Location = new System.Drawing.Point(509, 200);
            this.buttona.Name = "buttona";
            this.buttona.Size = new System.Drawing.Size(157, 53);
            this.buttona.TabIndex = 10;
            this.buttona.Text = "CONNECT";
            this.buttona.UseVisualStyleBackColor = true;
            this.buttona.Click += new System.EventHandler(this.buttona_Click);
            // 
            // COMcbo
            // 
            this.COMcbo.FormattingEnabled = true;
            this.COMcbo.Location = new System.Drawing.Point(149, 218);
            this.COMcbo.Name = "COMcbo";
            this.COMcbo.Size = new System.Drawing.Size(148, 21);
            this.COMcbo.TabIndex = 9;
            this.COMcbo.SelectedIndexChanged += new System.EventHandler(this.COMcbo_SelectedIndexChanged);
            this.COMcbo.Click += new System.EventHandler(this.COMcbo_Click_1);
            // 
            // refresh
            // 
            this.refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh.Location = new System.Drawing.Point(322, 200);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(157, 53);
            this.refresh.TabIndex = 17;
            this.refresh.Text = "REFRESH COMs";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click_1);
            // 
            // wfmode
            // 
            this.wfmode.Controls.Add(this.connectwifi);
            this.wfmode.Controls.Add(this.label3);
            this.wfmode.Location = new System.Drawing.Point(4, 22);
            this.wfmode.Name = "wfmode";
            this.wfmode.Padding = new System.Windows.Forms.Padding(3);
            this.wfmode.Size = new System.Drawing.Size(822, 474);
            this.wfmode.TabIndex = 5;
            this.wfmode.Text = "wfmode";
            this.wfmode.UseVisualStyleBackColor = true;
            this.wfmode.Click += new System.EventHandler(this.tabPage6_Click);
            // 
            // connectwifi
            // 
            this.connectwifi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectwifi.Location = new System.Drawing.Point(74, 135);
            this.connectwifi.Name = "connectwifi";
            this.connectwifi.Size = new System.Drawing.Size(178, 76);
            this.connectwifi.TabIndex = 1;
            this.connectwifi.Text = "CONNECT";
            this.connectwifi.UseVisualStyleBackColor = true;
            this.connectwifi.Click += new System.EventHandler(this.connectwifi_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(87, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(588, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Đảm bảo Laptop đang sử dụng cùng Wifi với thiết bị đánh Pan";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // usbmode
            // 
            this.usbmode.Controls.Add(this.comusb);
            this.usbmode.Location = new System.Drawing.Point(4, 22);
            this.usbmode.Name = "usbmode";
            this.usbmode.Padding = new System.Windows.Forms.Padding(3);
            this.usbmode.Size = new System.Drawing.Size(822, 474);
            this.usbmode.TabIndex = 8;
            this.usbmode.Text = "usbmode";
            this.usbmode.UseVisualStyleBackColor = true;
            // 
            // comusb
            // 
            this.comusb.AutoSize = true;
            this.comusb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comusb.Location = new System.Drawing.Point(294, 147);
            this.comusb.Name = "comusb";
            this.comusb.Size = new System.Drawing.Size(0, 24);
            this.comusb.TabIndex = 6;
            // 
            // close_settings
            // 
            this.close_settings.Location = new System.Drawing.Point(431, 2);
            this.close_settings.Margin = new System.Windows.Forms.Padding(2);
            this.close_settings.Name = "close_settings";
            this.close_settings.Size = new System.Drawing.Size(24, 27);
            this.close_settings.TabIndex = 3;
            this.close_settings.Text = "X";
            this.close_settings.UseVisualStyleBackColor = true;
            this.close_settings.Click += new System.EventHandler(this.close_settings_Click);
            // 
            // wifi
            // 
            this.wifi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wifi.Location = new System.Drawing.Point(2, 23);
            this.wifi.Margin = new System.Windows.Forms.Padding(2);
            this.wifi.Name = "wifi";
            this.wifi.Size = new System.Drawing.Size(181, 67);
            this.wifi.TabIndex = 0;
            this.wifi.Text = "Wifi";
            this.wifi.UseVisualStyleBackColor = true;
            this.wifi.Click += new System.EventHandler(this.wifi_Click);
            // 
            // usb
            // 
            this.usb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usb.Location = new System.Drawing.Point(2, 163);
            this.usb.Margin = new System.Windows.Forms.Padding(2);
            this.usb.Name = "usb";
            this.usb.Size = new System.Drawing.Size(181, 67);
            this.usb.TabIndex = 2;
            this.usb.Text = "USB";
            this.usb.UseVisualStyleBackColor = true;
            this.usb.Click += new System.EventHandler(this.usb_Click);
            // 
            // bluetooth
            // 
            this.bluetooth.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bluetooth.Location = new System.Drawing.Point(2, 92);
            this.bluetooth.Margin = new System.Windows.Forms.Padding(2);
            this.bluetooth.Name = "bluetooth";
            this.bluetooth.Size = new System.Drawing.Size(181, 67);
            this.bluetooth.TabIndex = 1;
            this.bluetooth.Text = "Bluetooth";
            this.bluetooth.UseVisualStyleBackColor = true;
            this.bluetooth.Click += new System.EventHandler(this.bluetooth_usb_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Controls.Add(this.tabPage8);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.MaximumSize = new System.Drawing.Size(1280, 720);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1280, 720);
            this.tabControl1.TabIndex = 20;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.button1);
            this.tabPage5.Controls.Add(this.settings);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1272, 694);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "tabPage5";
            this.tabPage5.Click += new System.EventHandler(this.tabPage5_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(148, 619);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 31);
            this.button1.TabIndex = 1;
            this.button1.Text = "debug lt";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // settings
            // 
            this.settings.Location = new System.Drawing.Point(2, 630);
            this.settings.Margin = new System.Windows.Forms.Padding(2);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(113, 31);
            this.settings.TabIndex = 0;
            this.settings.Text = "settings";
            this.settings.UseVisualStyleBackColor = true;
            this.settings.Click += new System.EventHandler(this.settings_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1272, 694);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.kt);
            this.panel2.Controls.Add(this.hs);
            this.panel2.Controls.Add(this.gv);
            this.panel2.Location = new System.Drawing.Point(-4, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1280, 720);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // kt
            // 
            this.kt.AutoSize = true;
            this.kt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kt.Location = new System.Drawing.Point(532, 386);
            this.kt.Name = "kt";
            this.kt.Size = new System.Drawing.Size(217, 93);
            this.kt.TabIndex = 5;
            this.kt.Text = "Kiểm tra";
            this.kt.UseVisualStyleBackColor = true;
            // 
            // hs
            // 
            this.hs.AutoSize = true;
            this.hs.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hs.Location = new System.Drawing.Point(532, 275);
            this.hs.Name = "hs";
            this.hs.Size = new System.Drawing.Size(217, 93);
            this.hs.TabIndex = 4;
            this.hs.Text = "Sinh Viên";
            this.hs.UseVisualStyleBackColor = true;
            this.hs.Click += new System.EventHandler(this.hs_Click_1);
            // 
            // gv
            // 
            this.gv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gv.AutoSize = true;
            this.gv.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gv.Location = new System.Drawing.Point(532, 163);
            this.gv.Name = "gv";
            this.gv.Size = new System.Drawing.Size(217, 93);
            this.gv.TabIndex = 3;
            this.gv.Text = "Giáo Viên";
            this.gv.UseVisualStyleBackColor = true;
            this.gv.Click += new System.EventHandler(this.gv_Click_1);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.log);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.mk);
            this.tabPage2.Controls.Add(this.tk);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1272, 694);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // log
            // 
            this.log.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log.Location = new System.Drawing.Point(553, 361);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(189, 94);
            this.log.TabIndex = 9;
            this.log.Text = "Đăng Nhập";
            this.log.UseVisualStyleBackColor = true;
            this.log.Click += new System.EventHandler(this.log_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(411, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Mật Khẩu:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(411, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tài Khoản GV:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // mk
            // 
            this.mk.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mk.Location = new System.Drawing.Point(563, 296);
            this.mk.Name = "mk";
            this.mk.PasswordChar = '*';
            this.mk.Size = new System.Drawing.Size(299, 29);
            this.mk.TabIndex = 6;
            this.mk.TextChanged += new System.EventHandler(this.mk_TextChanged);
            // 
            // tk
            // 
            this.tk.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tk.Location = new System.Drawing.Point(563, 239);
            this.tk.Name = "tk";
            this.tk.Size = new System.Drawing.Size(299, 29);
            this.tk.TabIndex = 5;
            this.tk.TextChanged += new System.EventHandler(this.tk_TextChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.statelbl);
            this.tabPage4.Controls.Add(this.disconnect);
            this.tabPage4.Controls.Add(this.menu);
            this.tabPage4.Controls.Add(this.backpg4);
            this.tabPage4.Controls.Add(this.pan16cb);
            this.tabPage4.Controls.Add(this.pan15cb);
            this.tabPage4.Controls.Add(this.pan14cb);
            this.tabPage4.Controls.Add(this.pan13cb);
            this.tabPage4.Controls.Add(this.pan12cb);
            this.tabPage4.Controls.Add(this.pan11cb);
            this.tabPage4.Controls.Add(this.pan10cb);
            this.tabPage4.Controls.Add(this.pan9cb);
            this.tabPage4.Controls.Add(this.pan8cb);
            this.tabPage4.Controls.Add(this.pan7cb);
            this.tabPage4.Controls.Add(this.pan6cb);
            this.tabPage4.Controls.Add(this.pan5cb);
            this.tabPage4.Controls.Add(this.pan4cb);
            this.tabPage4.Controls.Add(this.pan3cb);
            this.tabPage4.Controls.Add(this.pan2cb);
            this.tabPage4.Controls.Add(this.pan1cb);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1272, 694);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.Click += new System.EventHandler(this.tabPage4_Click);
            // 
            // statelbl
            // 
            this.statelbl.AutoSize = true;
            this.statelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statelbl.Location = new System.Drawing.Point(1060, 626);
            this.statelbl.Name = "statelbl";
            this.statelbl.Size = new System.Drawing.Size(72, 24);
            this.statelbl.TabIndex = 11;
            this.statelbl.Text = "STATE";
            this.statelbl.TextChanged += new System.EventHandler(this.DISCONNECTED);
            this.statelbl.Click += new System.EventHandler(this.statelbl_Click_1);
            // 
            // disconnect
            // 
            this.disconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disconnect.Location = new System.Drawing.Point(-1, 600);
            this.disconnect.Name = "disconnect";
            this.disconnect.Size = new System.Drawing.Size(150, 50);
            this.disconnect.TabIndex = 2;
            this.disconnect.Text = "Ngắt kết nối";
            this.disconnect.UseVisualStyleBackColor = true;
            this.disconnect.Click += new System.EventHandler(this.disconnect_Click);
            // 
            // menu
            // 
            this.menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu.Location = new System.Drawing.Point(8, 768);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(150, 50);
            this.menu.TabIndex = 39;
            this.menu.Text = "Main Menu";
            this.menu.UseVisualStyleBackColor = true;
            this.menu.Click += new System.EventHandler(this.menu_Click_1);
            // 
            // backpg4
            // 
            this.backpg4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backpg4.Location = new System.Drawing.Point(177, 768);
            this.backpg4.Name = "backpg4";
            this.backpg4.Size = new System.Drawing.Size(100, 50);
            this.backpg4.TabIndex = 37;
            this.backpg4.Text = "Back";
            this.backpg4.UseVisualStyleBackColor = true;
            this.backpg4.Click += new System.EventHandler(this.back_Click_1);
            // 
            // pan16cb
            // 
            this.pan16cb.AutoSize = true;
            this.pan16cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pan16cb.Location = new System.Drawing.Point(645, 452);
            this.pan16cb.Name = "pan16cb";
            this.pan16cb.Size = new System.Drawing.Size(132, 35);
            this.pan16cb.TabIndex = 35;
            this.pan16cb.Text = "PAN 16";
            this.pan16cb.UseVisualStyleBackColor = true;
            this.pan16cb.CheckedChanged += new System.EventHandler(this.bt_CheckedChanged);
            // 
            // pan15cb
            // 
            this.pan15cb.AutoSize = true;
            this.pan15cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pan15cb.Location = new System.Drawing.Point(645, 417);
            this.pan15cb.Name = "pan15cb";
            this.pan15cb.Size = new System.Drawing.Size(132, 35);
            this.pan15cb.TabIndex = 34;
            this.pan15cb.Text = "PAN 15";
            this.pan15cb.UseVisualStyleBackColor = true;
            this.pan15cb.CheckedChanged += new System.EventHandler(this.bt_CheckedChanged);
            // 
            // pan14cb
            // 
            this.pan14cb.AutoSize = true;
            this.pan14cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pan14cb.Location = new System.Drawing.Point(645, 382);
            this.pan14cb.Name = "pan14cb";
            this.pan14cb.Size = new System.Drawing.Size(132, 35);
            this.pan14cb.TabIndex = 33;
            this.pan14cb.Text = "PAN 14";
            this.pan14cb.UseVisualStyleBackColor = true;
            this.pan14cb.CheckedChanged += new System.EventHandler(this.bt_CheckedChanged);
            // 
            // pan13cb
            // 
            this.pan13cb.AutoSize = true;
            this.pan13cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pan13cb.Location = new System.Drawing.Point(645, 347);
            this.pan13cb.Name = "pan13cb";
            this.pan13cb.Size = new System.Drawing.Size(132, 35);
            this.pan13cb.TabIndex = 32;
            this.pan13cb.Text = "PAN 13";
            this.pan13cb.UseVisualStyleBackColor = true;
            this.pan13cb.CheckedChanged += new System.EventHandler(this.bt_CheckedChanged);
            // 
            // pan12cb
            // 
            this.pan12cb.AutoSize = true;
            this.pan12cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pan12cb.Location = new System.Drawing.Point(645, 312);
            this.pan12cb.Name = "pan12cb";
            this.pan12cb.Size = new System.Drawing.Size(132, 35);
            this.pan12cb.TabIndex = 31;
            this.pan12cb.Text = "PAN 12";
            this.pan12cb.UseVisualStyleBackColor = true;
            this.pan12cb.CheckedChanged += new System.EventHandler(this.bt_CheckedChanged);
            // 
            // pan11cb
            // 
            this.pan11cb.AutoSize = true;
            this.pan11cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pan11cb.Location = new System.Drawing.Point(645, 277);
            this.pan11cb.Name = "pan11cb";
            this.pan11cb.Size = new System.Drawing.Size(132, 35);
            this.pan11cb.TabIndex = 30;
            this.pan11cb.Text = "PAN 11";
            this.pan11cb.UseVisualStyleBackColor = true;
            this.pan11cb.CheckedChanged += new System.EventHandler(this.bt_CheckedChanged);
            // 
            // pan10cb
            // 
            this.pan10cb.AutoSize = true;
            this.pan10cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pan10cb.Location = new System.Drawing.Point(645, 242);
            this.pan10cb.Name = "pan10cb";
            this.pan10cb.Size = new System.Drawing.Size(132, 35);
            this.pan10cb.TabIndex = 29;
            this.pan10cb.Text = "PAN 10";
            this.pan10cb.UseVisualStyleBackColor = true;
            this.pan10cb.CheckedChanged += new System.EventHandler(this.bt_CheckedChanged);
            // 
            // pan9cb
            // 
            this.pan9cb.AutoSize = true;
            this.pan9cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pan9cb.Location = new System.Drawing.Point(645, 207);
            this.pan9cb.Name = "pan9cb";
            this.pan9cb.Size = new System.Drawing.Size(116, 35);
            this.pan9cb.TabIndex = 28;
            this.pan9cb.Text = "PAN 9";
            this.pan9cb.UseVisualStyleBackColor = true;
            this.pan9cb.CheckedChanged += new System.EventHandler(this.bt_CheckedChanged);
            // 
            // pan8cb
            // 
            this.pan8cb.AutoSize = true;
            this.pan8cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pan8cb.Location = new System.Drawing.Point(496, 452);
            this.pan8cb.Name = "pan8cb";
            this.pan8cb.Size = new System.Drawing.Size(116, 35);
            this.pan8cb.TabIndex = 27;
            this.pan8cb.Text = "PAN 8";
            this.pan8cb.UseVisualStyleBackColor = true;
            this.pan8cb.CheckedChanged += new System.EventHandler(this.bt_CheckedChanged);
            // 
            // pan7cb
            // 
            this.pan7cb.AutoSize = true;
            this.pan7cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pan7cb.Location = new System.Drawing.Point(496, 417);
            this.pan7cb.Name = "pan7cb";
            this.pan7cb.Size = new System.Drawing.Size(116, 35);
            this.pan7cb.TabIndex = 26;
            this.pan7cb.Text = "PAN 7";
            this.pan7cb.UseVisualStyleBackColor = true;
            this.pan7cb.CheckedChanged += new System.EventHandler(this.bt_CheckedChanged);
            // 
            // pan6cb
            // 
            this.pan6cb.AutoSize = true;
            this.pan6cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pan6cb.Location = new System.Drawing.Point(496, 382);
            this.pan6cb.Name = "pan6cb";
            this.pan6cb.Size = new System.Drawing.Size(116, 35);
            this.pan6cb.TabIndex = 25;
            this.pan6cb.Text = "PAN 6";
            this.pan6cb.UseVisualStyleBackColor = true;
            this.pan6cb.CheckedChanged += new System.EventHandler(this.bt_CheckedChanged);
            // 
            // pan5cb
            // 
            this.pan5cb.AutoSize = true;
            this.pan5cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pan5cb.Location = new System.Drawing.Point(496, 347);
            this.pan5cb.Name = "pan5cb";
            this.pan5cb.Size = new System.Drawing.Size(116, 35);
            this.pan5cb.TabIndex = 24;
            this.pan5cb.Text = "PAN 5";
            this.pan5cb.UseVisualStyleBackColor = true;
            this.pan5cb.CheckedChanged += new System.EventHandler(this.bt_CheckedChanged);
            // 
            // pan4cb
            // 
            this.pan4cb.AutoSize = true;
            this.pan4cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pan4cb.Location = new System.Drawing.Point(496, 312);
            this.pan4cb.Name = "pan4cb";
            this.pan4cb.Size = new System.Drawing.Size(116, 35);
            this.pan4cb.TabIndex = 23;
            this.pan4cb.Text = "PAN 4";
            this.pan4cb.UseVisualStyleBackColor = true;
            this.pan4cb.CheckedChanged += new System.EventHandler(this.bt_CheckedChanged);
            // 
            // pan3cb
            // 
            this.pan3cb.AutoSize = true;
            this.pan3cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pan3cb.Location = new System.Drawing.Point(496, 277);
            this.pan3cb.Name = "pan3cb";
            this.pan3cb.Size = new System.Drawing.Size(116, 35);
            this.pan3cb.TabIndex = 22;
            this.pan3cb.Text = "PAN 3";
            this.pan3cb.UseVisualStyleBackColor = true;
            this.pan3cb.CheckedChanged += new System.EventHandler(this.bt_CheckedChanged);
            // 
            // pan2cb
            // 
            this.pan2cb.AutoSize = true;
            this.pan2cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pan2cb.Location = new System.Drawing.Point(496, 242);
            this.pan2cb.Name = "pan2cb";
            this.pan2cb.Size = new System.Drawing.Size(116, 35);
            this.pan2cb.TabIndex = 21;
            this.pan2cb.Text = "PAN 2";
            this.pan2cb.UseVisualStyleBackColor = true;
            this.pan2cb.CheckedChanged += new System.EventHandler(this.bt_CheckedChanged);
            // 
            // pan1cb
            // 
            this.pan1cb.AutoSize = true;
            this.pan1cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pan1cb.Location = new System.Drawing.Point(496, 207);
            this.pan1cb.Name = "pan1cb";
            this.pan1cb.Size = new System.Drawing.Size(116, 35);
            this.pan1cb.TabIndex = 20;
            this.pan1cb.Text = "PAN 1";
            this.pan1cb.UseVisualStyleBackColor = true;
            this.pan1cb.CheckedChanged += new System.EventHandler(this.bt_CheckedChanged);
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.backpg7);
            this.tabPage7.Controls.Add(this.disconnectWF);
            this.tabPage7.Controls.Add(this.wfpan16cb);
            this.tabPage7.Controls.Add(this.wfpan15cb);
            this.tabPage7.Controls.Add(this.wfpan14cb);
            this.tabPage7.Controls.Add(this.wfpan13cb);
            this.tabPage7.Controls.Add(this.wfpan12cb);
            this.tabPage7.Controls.Add(this.wfpan11cb);
            this.tabPage7.Controls.Add(this.wfpan10cb);
            this.tabPage7.Controls.Add(this.wfpan9cb);
            this.tabPage7.Controls.Add(this.wfpan8cb);
            this.tabPage7.Controls.Add(this.wfpan7cb);
            this.tabPage7.Controls.Add(this.wfpan6cb);
            this.tabPage7.Controls.Add(this.wfpan5cb);
            this.tabPage7.Controls.Add(this.wfpan4cb);
            this.tabPage7.Controls.Add(this.wfpan3cb);
            this.tabPage7.Controls.Add(this.wfpan2cb);
            this.tabPage7.Controls.Add(this.wfpan1cb);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(1272, 694);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "tabPage7";
            this.tabPage7.UseVisualStyleBackColor = true;
            this.tabPage7.Click += new System.EventHandler(this.tabPage7_Click);
            // 
            // backpg7
            // 
            this.backpg7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backpg7.Location = new System.Drawing.Point(21, 780);
            this.backpg7.Name = "backpg7";
            this.backpg7.Size = new System.Drawing.Size(100, 50);
            this.backpg7.TabIndex = 69;
            this.backpg7.Text = "Back";
            this.backpg7.UseVisualStyleBackColor = true;
            this.backpg7.Click += new System.EventHandler(this.backpg7_Click);
            // 
            // disconnectWF
            // 
            this.disconnectWF.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disconnectWF.Location = new System.Drawing.Point(6, 609);
            this.disconnectWF.Name = "disconnectWF";
            this.disconnectWF.Size = new System.Drawing.Size(150, 50);
            this.disconnectWF.TabIndex = 68;
            this.disconnectWF.Text = "Ngắt kết nối";
            this.disconnectWF.UseVisualStyleBackColor = true;
            this.disconnectWF.Click += new System.EventHandler(this.disconnectWF_Click);
            // 
            // wfpan16cb
            // 
            this.wfpan16cb.AutoSize = true;
            this.wfpan16cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wfpan16cb.Location = new System.Drawing.Point(645, 452);
            this.wfpan16cb.Name = "wfpan16cb";
            this.wfpan16cb.Size = new System.Drawing.Size(132, 35);
            this.wfpan16cb.TabIndex = 67;
            this.wfpan16cb.Text = "PAN 16";
            this.wfpan16cb.UseVisualStyleBackColor = true;
            this.wfpan16cb.CheckedChanged += new System.EventHandler(this.wf_CheckedChanged);
            // 
            // wfpan15cb
            // 
            this.wfpan15cb.AutoSize = true;
            this.wfpan15cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wfpan15cb.Location = new System.Drawing.Point(645, 417);
            this.wfpan15cb.Name = "wfpan15cb";
            this.wfpan15cb.Size = new System.Drawing.Size(132, 35);
            this.wfpan15cb.TabIndex = 66;
            this.wfpan15cb.Text = "PAN 15";
            this.wfpan15cb.UseVisualStyleBackColor = true;
            this.wfpan15cb.CheckedChanged += new System.EventHandler(this.wf_CheckedChanged);
            // 
            // wfpan14cb
            // 
            this.wfpan14cb.AutoSize = true;
            this.wfpan14cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wfpan14cb.Location = new System.Drawing.Point(645, 382);
            this.wfpan14cb.Name = "wfpan14cb";
            this.wfpan14cb.Size = new System.Drawing.Size(132, 35);
            this.wfpan14cb.TabIndex = 65;
            this.wfpan14cb.Text = "PAN 14";
            this.wfpan14cb.UseVisualStyleBackColor = true;
            this.wfpan14cb.CheckedChanged += new System.EventHandler(this.wf_CheckedChanged);
            // 
            // wfpan13cb
            // 
            this.wfpan13cb.AutoSize = true;
            this.wfpan13cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wfpan13cb.Location = new System.Drawing.Point(645, 347);
            this.wfpan13cb.Name = "wfpan13cb";
            this.wfpan13cb.Size = new System.Drawing.Size(132, 35);
            this.wfpan13cb.TabIndex = 64;
            this.wfpan13cb.Text = "PAN 13";
            this.wfpan13cb.UseVisualStyleBackColor = true;
            this.wfpan13cb.CheckedChanged += new System.EventHandler(this.wf_CheckedChanged);
            // 
            // wfpan12cb
            // 
            this.wfpan12cb.AutoSize = true;
            this.wfpan12cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wfpan12cb.Location = new System.Drawing.Point(645, 312);
            this.wfpan12cb.Name = "wfpan12cb";
            this.wfpan12cb.Size = new System.Drawing.Size(132, 35);
            this.wfpan12cb.TabIndex = 63;
            this.wfpan12cb.Text = "PAN 12";
            this.wfpan12cb.UseVisualStyleBackColor = true;
            this.wfpan12cb.CheckedChanged += new System.EventHandler(this.wf_CheckedChanged);
            // 
            // wfpan11cb
            // 
            this.wfpan11cb.AutoSize = true;
            this.wfpan11cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wfpan11cb.Location = new System.Drawing.Point(645, 277);
            this.wfpan11cb.Name = "wfpan11cb";
            this.wfpan11cb.Size = new System.Drawing.Size(132, 35);
            this.wfpan11cb.TabIndex = 62;
            this.wfpan11cb.Text = "PAN 11";
            this.wfpan11cb.UseVisualStyleBackColor = true;
            this.wfpan11cb.CheckedChanged += new System.EventHandler(this.wf_CheckedChanged);
            // 
            // wfpan10cb
            // 
            this.wfpan10cb.AutoSize = true;
            this.wfpan10cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wfpan10cb.Location = new System.Drawing.Point(645, 242);
            this.wfpan10cb.Name = "wfpan10cb";
            this.wfpan10cb.Size = new System.Drawing.Size(132, 35);
            this.wfpan10cb.TabIndex = 61;
            this.wfpan10cb.Text = "PAN 10";
            this.wfpan10cb.UseVisualStyleBackColor = true;
            this.wfpan10cb.CheckedChanged += new System.EventHandler(this.wf_CheckedChanged);
            // 
            // wfpan9cb
            // 
            this.wfpan9cb.AutoSize = true;
            this.wfpan9cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wfpan9cb.Location = new System.Drawing.Point(645, 207);
            this.wfpan9cb.Name = "wfpan9cb";
            this.wfpan9cb.Size = new System.Drawing.Size(116, 35);
            this.wfpan9cb.TabIndex = 60;
            this.wfpan9cb.Text = "PAN 9";
            this.wfpan9cb.UseVisualStyleBackColor = true;
            this.wfpan9cb.CheckedChanged += new System.EventHandler(this.wf_CheckedChanged);
            // 
            // wfpan8cb
            // 
            this.wfpan8cb.AutoSize = true;
            this.wfpan8cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wfpan8cb.Location = new System.Drawing.Point(496, 452);
            this.wfpan8cb.Name = "wfpan8cb";
            this.wfpan8cb.Size = new System.Drawing.Size(116, 35);
            this.wfpan8cb.TabIndex = 59;
            this.wfpan8cb.Text = "PAN 8";
            this.wfpan8cb.UseVisualStyleBackColor = true;
            this.wfpan8cb.CheckedChanged += new System.EventHandler(this.wf_CheckedChanged);
            // 
            // wfpan7cb
            // 
            this.wfpan7cb.AutoSize = true;
            this.wfpan7cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wfpan7cb.Location = new System.Drawing.Point(496, 417);
            this.wfpan7cb.Name = "wfpan7cb";
            this.wfpan7cb.Size = new System.Drawing.Size(116, 35);
            this.wfpan7cb.TabIndex = 58;
            this.wfpan7cb.Text = "PAN 7";
            this.wfpan7cb.UseVisualStyleBackColor = true;
            this.wfpan7cb.CheckedChanged += new System.EventHandler(this.wf_CheckedChanged);
            // 
            // wfpan6cb
            // 
            this.wfpan6cb.AutoSize = true;
            this.wfpan6cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wfpan6cb.Location = new System.Drawing.Point(496, 382);
            this.wfpan6cb.Name = "wfpan6cb";
            this.wfpan6cb.Size = new System.Drawing.Size(116, 35);
            this.wfpan6cb.TabIndex = 57;
            this.wfpan6cb.Text = "PAN 6";
            this.wfpan6cb.UseVisualStyleBackColor = true;
            this.wfpan6cb.CheckedChanged += new System.EventHandler(this.wf_CheckedChanged);
            // 
            // wfpan5cb
            // 
            this.wfpan5cb.AutoSize = true;
            this.wfpan5cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wfpan5cb.Location = new System.Drawing.Point(496, 347);
            this.wfpan5cb.Name = "wfpan5cb";
            this.wfpan5cb.Size = new System.Drawing.Size(116, 35);
            this.wfpan5cb.TabIndex = 56;
            this.wfpan5cb.Text = "PAN 5";
            this.wfpan5cb.UseVisualStyleBackColor = true;
            this.wfpan5cb.CheckedChanged += new System.EventHandler(this.wf_CheckedChanged);
            // 
            // wfpan4cb
            // 
            this.wfpan4cb.AutoSize = true;
            this.wfpan4cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wfpan4cb.Location = new System.Drawing.Point(496, 312);
            this.wfpan4cb.Name = "wfpan4cb";
            this.wfpan4cb.Size = new System.Drawing.Size(116, 35);
            this.wfpan4cb.TabIndex = 55;
            this.wfpan4cb.Text = "PAN 4";
            this.wfpan4cb.UseVisualStyleBackColor = true;
            this.wfpan4cb.CheckedChanged += new System.EventHandler(this.wf_CheckedChanged);
            // 
            // wfpan3cb
            // 
            this.wfpan3cb.AutoSize = true;
            this.wfpan3cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wfpan3cb.Location = new System.Drawing.Point(496, 277);
            this.wfpan3cb.Name = "wfpan3cb";
            this.wfpan3cb.Size = new System.Drawing.Size(116, 35);
            this.wfpan3cb.TabIndex = 54;
            this.wfpan3cb.Text = "PAN 3";
            this.wfpan3cb.UseVisualStyleBackColor = true;
            this.wfpan3cb.CheckedChanged += new System.EventHandler(this.wf_CheckedChanged);
            // 
            // wfpan2cb
            // 
            this.wfpan2cb.AutoSize = true;
            this.wfpan2cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wfpan2cb.Location = new System.Drawing.Point(496, 242);
            this.wfpan2cb.Name = "wfpan2cb";
            this.wfpan2cb.Size = new System.Drawing.Size(116, 35);
            this.wfpan2cb.TabIndex = 53;
            this.wfpan2cb.Text = "PAN 2";
            this.wfpan2cb.UseVisualStyleBackColor = true;
            this.wfpan2cb.CheckedChanged += new System.EventHandler(this.wf_CheckedChanged);
            // 
            // wfpan1cb
            // 
            this.wfpan1cb.AutoSize = true;
            this.wfpan1cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wfpan1cb.Location = new System.Drawing.Point(496, 207);
            this.wfpan1cb.Name = "wfpan1cb";
            this.wfpan1cb.Size = new System.Drawing.Size(116, 35);
            this.wfpan1cb.TabIndex = 52;
            this.wfpan1cb.Text = "PAN 1";
            this.wfpan1cb.UseVisualStyleBackColor = true;
            this.wfpan1cb.CheckedChanged += new System.EventHandler(this.wf_CheckedChanged);
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.svLT);
            this.tabPage8.Controls.Add(this.svTH);
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(1272, 694);
            this.tabPage8.TabIndex = 7;
            this.tabPage8.Text = "tabPage8";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // svLT
            // 
            this.svLT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.svLT.Location = new System.Drawing.Point(618, 228);
            this.svLT.Name = "svLT";
            this.svLT.Size = new System.Drawing.Size(197, 71);
            this.svLT.TabIndex = 1;
            this.svLT.Text = "Lý Thuyết";
            this.svLT.UseVisualStyleBackColor = true;
            // 
            // svTH
            // 
            this.svTH.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.svTH.Location = new System.Drawing.Point(357, 228);
            this.svTH.Name = "svTH";
            this.svTH.Size = new System.Drawing.Size(197, 71);
            this.svTH.TabIndex = 0;
            this.svTH.Text = "Thực Hành";
            this.svTH.UseVisualStyleBackColor = true;
            // 
            // ping_timer
            // 
            this.ping_timer.Interval = 1000;
            this.ping_timer.Tick += new System.EventHandler(this.ping_timer_Tick);
            // 
            // wifi_ping_timer
            // 
            this.wifi_ping_timer.Interval = 1000;
            this.wifi_ping_timer.Tick += new System.EventHandler(this.wifi_ping_timer_Tick);
            // 
            // usb_ping_timer
            // 
            this.usb_ping_timer.Interval = 1000;
            this.usb_ping_timer.Tick += new System.EventHandler(this.usb_ping_timer_Tick);
            // 
            // mainmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(1203, 681);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "mainmenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mainmenu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainmenu_FormClosing);
            this.Load += new System.EventHandler(this.mainmenu_Load);
            this.panel1.ResumeLayout(false);
            this.settings_panel.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.btmode.ResumeLayout(false);
            this.wfmode.ResumeLayout(false);
            this.wfmode.PerformLayout();
            this.usbmode.ResumeLayout(false);
            this.usbmode.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            this.tabPage8.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage btmode;
        private System.Windows.Forms.Button log;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox mk;
        private System.Windows.Forms.TextBox tk;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        public System.Windows.Forms.Label statelbl;
        private System.Windows.Forms.Button buttona;
        private System.Windows.Forms.ComboBox COMcbo;
        private System.Windows.Forms.Button refresh;
        public System.IO.Ports.SerialPort serCOM;
        private System.Windows.Forms.Timer ping_timer;
        private System.Windows.Forms.Button menu;
        private System.Windows.Forms.Button backpg4;
        private System.Windows.Forms.CheckBox pan16cb;
        private System.Windows.Forms.CheckBox pan15cb;
        private System.Windows.Forms.CheckBox pan14cb;
        private System.Windows.Forms.CheckBox pan13cb;
        private System.Windows.Forms.CheckBox pan12cb;
        private System.Windows.Forms.CheckBox pan11cb;
        private System.Windows.Forms.CheckBox pan10cb;
        private System.Windows.Forms.CheckBox pan9cb;
        private System.Windows.Forms.CheckBox pan8cb;
        private System.Windows.Forms.CheckBox pan7cb;
        private System.Windows.Forms.CheckBox pan6cb;
        private System.Windows.Forms.CheckBox pan5cb;
        private System.Windows.Forms.CheckBox pan4cb;
        private System.Windows.Forms.CheckBox pan3cb;
        private System.Windows.Forms.CheckBox pan2cb;
        private System.Windows.Forms.CheckBox pan1cb;
        private System.Windows.Forms.Button bluetooth;
        private System.Windows.Forms.Button wifi;
        private System.Windows.Forms.TabPage wfmode;
        private System.Windows.Forms.Button connectwifi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.CheckBox wfpan16cb;
        private System.Windows.Forms.CheckBox wfpan15cb;
        private System.Windows.Forms.CheckBox wfpan14cb;
        private System.Windows.Forms.CheckBox wfpan13cb;
        private System.Windows.Forms.CheckBox wfpan12cb;
        private System.Windows.Forms.CheckBox wfpan11cb;
        private System.Windows.Forms.CheckBox wfpan10cb;
        private System.Windows.Forms.CheckBox wfpan9cb;
        private System.Windows.Forms.CheckBox wfpan8cb;
        private System.Windows.Forms.CheckBox wfpan7cb;
        private System.Windows.Forms.CheckBox wfpan6cb;
        private System.Windows.Forms.CheckBox wfpan5cb;
        private System.Windows.Forms.CheckBox wfpan4cb;
        private System.Windows.Forms.CheckBox wfpan3cb;
        private System.Windows.Forms.CheckBox wfpan2cb;
        private System.Windows.Forms.CheckBox wfpan1cb;
        private System.Windows.Forms.Timer wifi_ping_timer;
        private System.Windows.Forms.Button disconnect;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button hs;
        private System.Windows.Forms.Button gv;
        private System.Windows.Forms.Button disconnectWF;
        private System.Windows.Forms.Button backpg7;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.Button svLT;
        private System.Windows.Forms.Button svTH;
        private System.Windows.Forms.Button usb;
        private System.Windows.Forms.TabPage usbmode;
        private System.Windows.Forms.Label comusb;
        public System.Windows.Forms.Timer usb_ping_timer;
        private System.Windows.Forms.Button kt;
        private System.Windows.Forms.Panel settings_panel;
        private System.Windows.Forms.Button settings;
        private System.Windows.Forms.Button close_settings;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.Button button1;
    }
}