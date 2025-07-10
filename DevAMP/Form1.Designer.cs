namespace DevAMP
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.start_stop_apache = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.start_stop_mysql = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.filezilla_start_stop_btn = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.apache_pid_label = new System.Windows.Forms.Label();
            this.apache_port_label = new System.Windows.Forms.Label();
            this.mysql_pid_label = new System.Windows.Forms.Label();
            this.mysql_port_label = new System.Windows.Forms.Label();
            this.filezilla_pid_label = new System.Windows.Forms.Label();
            this.filezilla_port_label = new System.Windows.Forms.Label();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(539, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(515, 52);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "DevAMP Control Panel";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DevAMP.Properties.Resources.favicon;
            this.pictureBox1.Location = new System.Drawing.Point(11, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Modules";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(122, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "PID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(213, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Port";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(310, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Actions";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "Apache";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "MySQL";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 275);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 15);
            this.label8.TabIndex = 2;
            this.label8.Text = "Filezilla";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.CausesValidation = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 307);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(518, 127);
            this.textBox1.TabIndex = 3;
            // 
            // start_stop_apache
            // 
            this.start_stop_apache.Location = new System.Drawing.Point(313, 190);
            this.start_stop_apache.Name = "start_stop_apache";
            this.start_stop_apache.Size = new System.Drawing.Size(66, 23);
            this.start_stop_apache.TabIndex = 4;
            this.start_stop_apache.Text = "Start";
            this.start_stop_apache.UseVisualStyleBackColor = true;
            this.start_stop_apache.Click += new System.EventHandler(this.start_stop_apache_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(385, 190);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(66, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Config";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // start_stop_mysql
            // 
            this.start_stop_mysql.Location = new System.Drawing.Point(313, 228);
            this.start_stop_mysql.Name = "start_stop_mysql";
            this.start_stop_mysql.Size = new System.Drawing.Size(66, 23);
            this.start_stop_mysql.TabIndex = 4;
            this.start_stop_mysql.Text = "Start";
            this.start_stop_mysql.UseVisualStyleBackColor = true;
            this.start_stop_mysql.Click += new System.EventHandler(this.start_stop_mysql_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(385, 228);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(66, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "Config";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // filezilla_start_stop_btn
            // 
            this.filezilla_start_stop_btn.Location = new System.Drawing.Point(313, 267);
            this.filezilla_start_stop_btn.Name = "filezilla_start_stop_btn";
            this.filezilla_start_stop_btn.Size = new System.Drawing.Size(66, 23);
            this.filezilla_start_stop_btn.TabIndex = 4;
            this.filezilla_start_stop_btn.Text = "Start";
            this.filezilla_start_stop_btn.UseVisualStyleBackColor = true;
            this.filezilla_start_stop_btn.Click += new System.EventHandler(this.filezilla_start_stop_btn_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(385, 267);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(66, 23);
            this.button8.TabIndex = 4;
            this.button8.Text = "Config";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // apache_pid_label
            // 
            this.apache_pid_label.AutoSize = true;
            this.apache_pid_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apache_pid_label.Location = new System.Drawing.Point(124, 198);
            this.apache_pid_label.Name = "apache_pid_label";
            this.apache_pid_label.Size = new System.Drawing.Size(26, 15);
            this.apache_pid_label.TabIndex = 2;
            this.apache_pid_label.Text = "N/A";
            // 
            // apache_port_label
            // 
            this.apache_port_label.AutoSize = true;
            this.apache_port_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apache_port_label.Location = new System.Drawing.Point(217, 198);
            this.apache_port_label.Name = "apache_port_label";
            this.apache_port_label.Size = new System.Drawing.Size(26, 15);
            this.apache_port_label.TabIndex = 2;
            this.apache_port_label.Text = "N/A";
            // 
            // mysql_pid_label
            // 
            this.mysql_pid_label.AutoSize = true;
            this.mysql_pid_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mysql_pid_label.Location = new System.Drawing.Point(124, 236);
            this.mysql_pid_label.Name = "mysql_pid_label";
            this.mysql_pid_label.Size = new System.Drawing.Size(26, 15);
            this.mysql_pid_label.TabIndex = 2;
            this.mysql_pid_label.Text = "N/A";
            // 
            // mysql_port_label
            // 
            this.mysql_port_label.AutoSize = true;
            this.mysql_port_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mysql_port_label.Location = new System.Drawing.Point(217, 236);
            this.mysql_port_label.Name = "mysql_port_label";
            this.mysql_port_label.Size = new System.Drawing.Size(26, 15);
            this.mysql_port_label.TabIndex = 2;
            this.mysql_port_label.Text = "N/A";
            // 
            // filezilla_pid_label
            // 
            this.filezilla_pid_label.AutoSize = true;
            this.filezilla_pid_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filezilla_pid_label.Location = new System.Drawing.Point(124, 275);
            this.filezilla_pid_label.Name = "filezilla_pid_label";
            this.filezilla_pid_label.Size = new System.Drawing.Size(26, 15);
            this.filezilla_pid_label.TabIndex = 2;
            this.filezilla_pid_label.Text = "N/A";
            // 
            // filezilla_port_label
            // 
            this.filezilla_port_label.AutoSize = true;
            this.filezilla_port_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filezilla_port_label.Location = new System.Drawing.Point(217, 275);
            this.filezilla_port_label.Name = "filezilla_port_label";
            this.filezilla_port_label.Size = new System.Drawing.Size(26, 15);
            this.filezilla_port_label.TabIndex = 2;
            this.filezilla_port_label.Text = "N/A";
            // 
            // button13
            // 
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.Image = global::DevAMP.Properties.Resources.customer_service;
            this.button13.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button13.Location = new System.Drawing.Point(297, 104);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(88, 28);
            this.button13.TabIndex = 4;
            this.button13.Text = "Help";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.Image = global::DevAMP.Properties.Resources.cogwheel;
            this.button12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button12.Location = new System.Drawing.Point(203, 104);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(88, 28);
            this.button12.TabIndex = 4;
            this.button12.Text = "  Services";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Image = global::DevAMP.Properties.Resources.folder;
            this.button11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button11.Location = new System.Drawing.Point(109, 104);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(88, 28);
            this.button11.TabIndex = 4;
            this.button11.Text = "  Explorer";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Image = global::DevAMP.Properties.Resources.earth;
            this.button10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button10.Location = new System.Drawing.Point(15, 104);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(88, 28);
            this.button10.TabIndex = 4;
            this.button10.Text = " Netstats";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(539, 446);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.filezilla_start_stop_btn);
            this.Controls.Add(this.start_stop_mysql);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.start_stop_apache);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.filezilla_port_label);
            this.Controls.Add(this.filezilla_pid_label);
            this.Controls.Add(this.mysql_port_label);
            this.Controls.Add(this.mysql_pid_label);
            this.Controls.Add(this.apache_port_label);
            this.Controls.Add(this.apache_pid_label);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "DevAMP";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button start_stop_apache;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button start_stop_mysql;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button filezilla_start_stop_btn;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Label apache_pid_label;
        private System.Windows.Forms.Label apache_port_label;
        private System.Windows.Forms.Label mysql_pid_label;
        private System.Windows.Forms.Label mysql_port_label;
        private System.Windows.Forms.Label filezilla_pid_label;
        private System.Windows.Forms.Label filezilla_port_label;
    }
}

