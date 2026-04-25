
namespace bluetoothmain
{
    partial class ECT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ECT));
            this.giatridmm = new System.Windows.Forms.Label();
            this.kimdo = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.timerdo = new System.Windows.Forms.Timer(this.components);
            this.dmm = new System.Windows.Forms.PictureBox();
            this.kimden = new System.Windows.Forms.PictureBox();
            this.timerden = new System.Windows.Forms.Timer(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.signal_conn = new System.Windows.Forms.PictureBox();
            this.return_conn = new System.Windows.Forms.PictureBox();
            this.mass_conn = new System.Windows.Forms.PictureBox();
            this.batt_conn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.kimdo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kimden)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.signal_conn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.return_conn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mass_conn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.batt_conn)).BeginInit();
            this.SuspendLayout();
            // 
            // giatridmm
            // 
            this.giatridmm.AutoSize = true;
            this.giatridmm.BackColor = System.Drawing.Color.DarkGray;
            this.giatridmm.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.giatridmm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.giatridmm.Location = new System.Drawing.Point(1389, 326);
            this.giatridmm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.giatridmm.Name = "giatridmm";
            this.giatridmm.Size = new System.Drawing.Size(0, 25);
            this.giatridmm.TabIndex = 3;
            this.giatridmm.Click += new System.EventHandler(this.label1_Click);
            // 
            // kimdo
            // 
            this.kimdo.BackColor = System.Drawing.Color.Transparent;
            this.kimdo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("kimdo.BackgroundImage")));
            this.kimdo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.kimdo.ErrorImage = null;
            this.kimdo.Location = new System.Drawing.Point(224, 593);
            this.kimdo.Margin = new System.Windows.Forms.Padding(4);
            this.kimdo.Name = "kimdo";
            this.kimdo.Size = new System.Drawing.Size(22, 133);
            this.kimdo.TabIndex = 5;
            this.kimdo.TabStop = false;
            this.kimdo.Click += new System.EventHandler(this.pictureBox1_Click);
            this.kimdo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.kimdo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // timerdo
            // 
            this.timerdo.Interval = 20;
            this.timerdo.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dmm
            // 
            this.dmm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dmm.BackgroundImage")));
            this.dmm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dmm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dmm.Location = new System.Drawing.Point(1349, 265);
            this.dmm.Margin = new System.Windows.Forms.Padding(4);
            this.dmm.Name = "dmm";
            this.dmm.Size = new System.Drawing.Size(181, 252);
            this.dmm.TabIndex = 7;
            this.dmm.TabStop = false;
            this.dmm.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // kimden
            // 
            this.kimden.BackColor = System.Drawing.Color.Transparent;
            this.kimden.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("kimden.BackgroundImage")));
            this.kimden.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.kimden.ErrorImage = null;
            this.kimden.Location = new System.Drawing.Point(272, 593);
            this.kimden.Margin = new System.Windows.Forms.Padding(4);
            this.kimden.Name = "kimden";
            this.kimden.Size = new System.Drawing.Size(22, 133);
            this.kimden.TabIndex = 15;
            this.kimden.TabStop = false;
            this.kimden.MouseDown += new System.Windows.Forms.MouseEventHandler(this.kimden_MouseDown);
            this.kimden.MouseUp += new System.Windows.Forms.MouseEventHandler(this.kimden_MouseUp);
            // 
            // timerden
            // 
            this.timerden.Interval = 20;
            this.timerden.Tick += new System.EventHandler(this.timerden_Tick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 1);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(168, 858);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(160, 832);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(313, 370);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(252, 90);
            this.button2.TabIndex = 3;
            this.button2.Text = "Test";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(63, 198);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(252, 90);
            this.button1.TabIndex = 2;
            this.button1.Text = "Practice";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button6);
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(160, 832);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(289, 480);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(252, 90);
            this.button6.TabIndex = 6;
            this.button6.Text = "Practice";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(271, 383);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(252, 90);
            this.button5.TabIndex = 5;
            this.button5.Text = "Practice";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(271, 250);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(252, 90);
            this.button4.TabIndex = 4;
            this.button4.Text = "Practice";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(47, 100);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(252, 90);
            this.button3.TabIndex = 3;
            this.button3.Tag = "";
            this.button3.Text = "IAT";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage3.Size = new System.Drawing.Size(160, 832);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 436);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 1);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "label3";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(1288, 113);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(101, 71);
            this.button7.TabIndex = 22;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // signal_conn
            // 
            this.signal_conn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("signal_conn.BackgroundImage")));
            this.signal_conn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.signal_conn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signal_conn.ErrorImage = null;
            this.signal_conn.Location = new System.Drawing.Point(891, 355);
            this.signal_conn.Margin = new System.Windows.Forms.Padding(4);
            this.signal_conn.Name = "signal_conn";
            this.signal_conn.Size = new System.Drawing.Size(62, 231);
            this.signal_conn.TabIndex = 23;
            this.signal_conn.TabStop = false;
            this.signal_conn.Click += new System.EventHandler(this.signal_conn_Click);
            // 
            // return_conn
            // 
            this.return_conn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("return_conn.BackgroundImage")));
            this.return_conn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.return_conn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.return_conn.ErrorImage = null;
            this.return_conn.Location = new System.Drawing.Point(541, 355);
            this.return_conn.Margin = new System.Windows.Forms.Padding(4);
            this.return_conn.Name = "return_conn";
            this.return_conn.Size = new System.Drawing.Size(37, 114);
            this.return_conn.TabIndex = 24;
            this.return_conn.TabStop = false;
            this.return_conn.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // mass_conn
            // 
            this.mass_conn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mass_conn.BackgroundImage")));
            this.mass_conn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mass_conn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mass_conn.ErrorImage = null;
            this.mass_conn.Location = new System.Drawing.Point(847, 630);
            this.mass_conn.Margin = new System.Windows.Forms.Padding(4);
            this.mass_conn.Name = "mass_conn";
            this.mass_conn.Size = new System.Drawing.Size(23, 32);
            this.mass_conn.TabIndex = 25;
            this.mass_conn.TabStop = false;
            this.mass_conn.Click += new System.EventHandler(this.mass_conn_Click);
            // 
            // batt_conn
            // 
            this.batt_conn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("batt_conn.BackgroundImage")));
            this.batt_conn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.batt_conn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.batt_conn.ErrorImage = null;
            this.batt_conn.Location = new System.Drawing.Point(347, 593);
            this.batt_conn.Margin = new System.Windows.Forms.Padding(4);
            this.batt_conn.Name = "batt_conn";
            this.batt_conn.Size = new System.Drawing.Size(320, 212);
            this.batt_conn.TabIndex = 26;
            this.batt_conn.TabStop = false;
            this.batt_conn.Click += new System.EventHandler(this.batt_conn_Click);
            // 
            // PMHT
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.batt_conn);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.giatridmm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dmm);
            this.Controls.Add(this.kimdo);
            this.Controls.Add(this.kimden);
            this.Controls.Add(this.signal_conn);
            this.Controls.Add(this.return_conn);
            this.Controls.Add(this.mass_conn);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1600, 900);
            this.Name = "PMHT";
            this.Padding = new System.Windows.Forms.Padding(1, 1, 0, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PMHT";
            this.Load += new System.EventHandler(this.PMHT_Load);
            this.Enter += new System.EventHandler(this.PMHT_Enter);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.PMHT_MouseDoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.kimdo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kimden)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.signal_conn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.return_conn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mass_conn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.batt_conn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label giatridmm;
        private System.Windows.Forms.PictureBox kimdo;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Timer timerdo;
        private System.Windows.Forms.PictureBox dmm;
        private System.Windows.Forms.PictureBox kimden;
        private System.Windows.Forms.Timer timerden;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.PictureBox signal_conn;
        private System.Windows.Forms.PictureBox return_conn;
        private System.Windows.Forms.PictureBox mass_conn;
        private System.Windows.Forms.PictureBox batt_conn;
    }
}