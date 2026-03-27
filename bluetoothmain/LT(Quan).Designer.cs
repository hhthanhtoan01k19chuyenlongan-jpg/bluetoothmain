
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
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.lythuyet = new System.Windows.Forms.TabPage();
            this.sensor = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(88, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 98);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // LT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LT";
            this.Size = new System.Drawing.Size(1696, 854);
            this.Load += new System.EventHandler(this.LT_Load);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage lythuyet;
        private System.Windows.Forms.TabPage sensor;
    }
}
