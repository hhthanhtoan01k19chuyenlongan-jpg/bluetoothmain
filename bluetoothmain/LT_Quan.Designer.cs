
namespace bluetoothmain
{
    partial class LT
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.lythuyet = new System.Windows.Forms.TabPage();
            this.sensor = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.lythuyet);
            this.tabControl1.Controls.Add(this.sensor);
            this.tabControl1.Location = new System.Drawing.Point(3, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(536, 28);
            this.tabControl1.TabIndex = 1;
            // 
            // lythuyet
            // 
            this.lythuyet.Location = new System.Drawing.Point(4, 25);
            this.lythuyet.Name = "lythuyet";
            this.lythuyet.Padding = new System.Windows.Forms.Padding(3);
            this.lythuyet.Size = new System.Drawing.Size(528, 0);
            this.lythuyet.TabIndex = 0;
            this.lythuyet.Text = "Lythuyet";
            this.lythuyet.UseVisualStyleBackColor = true;
            // 
            // sensor
            // 
            this.sensor.Location = new System.Drawing.Point(4, 25);
            this.sensor.Name = "sensor";
            this.sensor.Padding = new System.Windows.Forms.Padding(3);
            this.sensor.Size = new System.Drawing.Size(528, 0);
            this.sensor.TabIndex = 1;
            this.sensor.Text = "sensor";
            this.sensor.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 98);
            this.button1.TabIndex = 0;
            this.button1.Text = "HỖ TRỢ CHUẨN ĐOÁN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(424, 96);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(223, 82);
            this.button2.TabIndex = 2;
            this.button2.Text = "CẢM BIẾN NHIỆT ĐỘ";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(424, 203);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(223, 82);
            this.button3.TabIndex = 3;
            this.button3.Text = "CẢM BIẾN VỊ TRÍ";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(424, 320);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(223, 82);
            this.button4.TabIndex = 4;
            this.button4.Text = "CẢM BIẾN TỐC ĐỘ";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(718, 96);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(223, 82);
            this.button5.TabIndex = 5;
            this.button5.Text = "CẢM BIẾN ÁP SUẤT";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(718, 203);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(223, 82);
            this.button6.TabIndex = 6;
            this.button6.Text = "CẢM BIẾN NỒNG ĐỘ";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(728, 320);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(223, 82);
            this.button7.TabIndex = 7;
            this.button7.Text = "CẢM BIẾN LƯU LƯỢNG";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // LT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LT";
            this.Size = new System.Drawing.Size(1696, 854);
            this.Load += new System.EventHandler(this.LT_Load);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage lythuyet;
        private System.Windows.Forms.TabPage sensor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}
