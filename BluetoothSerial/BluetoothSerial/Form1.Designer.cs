
namespace BluetoothSerial
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.設定連線埠ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.埠號設定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.儲檔類型ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cSV檔ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tXT檔ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.設定連線埠ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(466, 24);
            this.menuStrip1.TabIndex = 52;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 設定連線埠ToolStripMenuItem
            // 
            this.設定連線埠ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.埠號設定ToolStripMenuItem,
            this.儲檔類型ToolStripMenuItem});
            this.設定連線埠ToolStripMenuItem.Name = "設定連線埠ToolStripMenuItem";
            this.設定連線埠ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.設定連線埠ToolStripMenuItem.Text = "設定";
            // 
            // 埠號設定ToolStripMenuItem
            // 
            this.埠號設定ToolStripMenuItem.Name = "埠號設定ToolStripMenuItem";
            this.埠號設定ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.埠號設定ToolStripMenuItem.Text = "埠號設定";
            this.埠號設定ToolStripMenuItem.Click += new System.EventHandler(this.埠號設定ToolStripMenuItem_Click);
            // 
            // 儲檔類型ToolStripMenuItem
            // 
            this.儲檔類型ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cSV檔ToolStripMenuItem,
            this.tXT檔ToolStripMenuItem});
            this.儲檔類型ToolStripMenuItem.Name = "儲檔類型ToolStripMenuItem";
            this.儲檔類型ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.儲檔類型ToolStripMenuItem.Text = "儲檔類型";
            // 
            // cSV檔ToolStripMenuItem
            // 
            this.cSV檔ToolStripMenuItem.CheckOnClick = true;
            this.cSV檔ToolStripMenuItem.Name = "cSV檔ToolStripMenuItem";
            this.cSV檔ToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.cSV檔ToolStripMenuItem.Text = "CSV檔";
            this.cSV檔ToolStripMenuItem.Click += new System.EventHandler(this.cSV檔ToolStripMenuItem_Click);
            // 
            // tXT檔ToolStripMenuItem
            // 
            this.tXT檔ToolStripMenuItem.CheckOnClick = true;
            this.tXT檔ToolStripMenuItem.Name = "tXT檔ToolStripMenuItem";
            this.tXT檔ToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.tXT檔ToolStripMenuItem.Text = "TXT檔";
            this.tXT檔ToolStripMenuItem.Click += new System.EventHandler(this.tXT檔ToolStripMenuItem_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label15.Location = new System.Drawing.Point(107, 112);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(54, 21);
            this.label15.TabIndex = 55;
            this.label15.Text = "連線";
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.Silver;
            this.textBox3.Location = new System.Drawing.Point(178, 61);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 3);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(105, 43);
            this.textBox3.TabIndex = 57;
            this.textBox3.TabStop = false;
            this.textBox3.Text = "狀態";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox3.Enter += new System.EventHandler(this.textBox3_Enter);
            this.textBox3.Leave += new System.EventHandler(this.textBox3_Leave);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(178, 229);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 73);
            this.button2.TabIndex = 58;
            this.button2.Text = "點我";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.MouseLeave += new System.EventHandler(this.button2_MouseLeave);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("新細明體", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Image = global::BluetoothSerial.Properties.Resources._2;
            this.label1.Location = new System.Drawing.Point(191, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 70);
            this.label1.TabIndex = 60;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImage = global::BluetoothSerial.Properties.Resources.label16_Image;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(109, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 56;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 380);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "ESP32藍芽控制LED";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 設定連線埠ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 埠號設定ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 儲檔類型ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cSV檔ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tXT檔ToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox3;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
    }
}

