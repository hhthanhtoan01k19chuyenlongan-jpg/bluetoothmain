
namespace bluetoothmain
{
    partial class bluetooth1
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
            this.serCOM = new System.IO.Ports.SerialPort(this.components);
            this.COMcbo = new System.Windows.Forms.ComboBox();
            this.buttona = new System.Windows.Forms.Button();
            this.statelblbt1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ping_timer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.refresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // COMcbo
            // 
            this.COMcbo.FormattingEnabled = true;
            this.COMcbo.Location = new System.Drawing.Point(155, 109);
            this.COMcbo.Name = "COMcbo";
            this.COMcbo.Size = new System.Drawing.Size(148, 21);
            this.COMcbo.TabIndex = 0;
            this.COMcbo.Click += new System.EventHandler(this.COMcbo_Click);
            // 
            // buttona
            // 
            this.buttona.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttona.Location = new System.Drawing.Point(551, 91);
            this.buttona.Name = "buttona";
            this.buttona.Size = new System.Drawing.Size(157, 53);
            this.buttona.TabIndex = 1;
            this.buttona.Text = "CONNECT";
            this.buttona.UseVisualStyleBackColor = true;
            this.buttona.Click += new System.EventHandler(this.button1_Click);
            // 
            // statelblbt1
            // 
            this.statelblbt1.AutoSize = true;
            this.statelblbt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statelblbt1.Location = new System.Drawing.Point(168, 242);
            this.statelblbt1.Name = "statelblbt1";
            this.statelblbt1.Size = new System.Drawing.Size(72, 24);
            this.statelblbt1.TabIndex = 2;
            this.statelblbt1.Text = "STATE";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(328, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 53);
            this.button1.TabIndex = 3;
            this.button1.Text = "on";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(551, 213);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(157, 53);
            this.button2.TabIndex = 4;
            this.button2.Text = "off";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // ping_timer
            // 
            this.ping_timer.Interval = 1000;
            this.ping_timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "label2";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(212, 321);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "sang form2";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // refresh
            // 
            this.refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh.Location = new System.Drawing.Point(328, 91);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(157, 53);
            this.refresh.TabIndex = 8;
            this.refresh.Text = "REFRESH COMs";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // bluetooth1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.statelblbt1);
            this.Controls.Add(this.buttona);
            this.Controls.Add(this.COMcbo);
            this.MinimizeBox = false;
            this.Name = "bluetooth1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMain";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox COMcbo;
        private System.Windows.Forms.Button buttona;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer ping_timer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        public System.IO.Ports.SerialPort serCOM;
        private System.Windows.Forms.Button refresh;
        public System.Windows.Forms.Label statelblbt1;
    }
}

