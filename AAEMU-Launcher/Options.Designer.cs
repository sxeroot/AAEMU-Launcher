namespace AAEMU_Launcher
{
    partial class Options
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Options));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.splash_CHK = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.hostname = new System.Windows.Forms.TextBox();
            this.port = new System.Windows.Forms.TextBox();
            this.gamepath = new System.Windows.Forms.TextBox();
            this.save_BTN = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.get_BTN = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 135);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // splash_CHK
            // 
            this.splash_CHK.AutoSize = true;
            this.splash_CHK.Location = new System.Drawing.Point(537, 138);
            this.splash_CHK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splash_CHK.Name = "splash_CHK";
            this.splash_CHK.Size = new System.Drawing.Size(96, 22);
            this.splash_CHK.TabIndex = 1;
            this.splash_CHK.Text = "No Splash";
            this.splash_CHK.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hostname / IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(506, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(137, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Game Path / Location";
            // 
            // hostname
            // 
            this.hostname.Location = new System.Drawing.Point(250, 6);
            this.hostname.Name = "hostname";
            this.hostname.Size = new System.Drawing.Size(250, 23);
            this.hostname.TabIndex = 5;
            // 
            // port
            // 
            this.port.Location = new System.Drawing.Point(551, 6);
            this.port.Name = "port";
            this.port.Size = new System.Drawing.Size(82, 23);
            this.port.TabIndex = 6;
            // 
            // gamepath
            // 
            this.gamepath.Location = new System.Drawing.Point(140, 81);
            this.gamepath.Name = "gamepath";
            this.gamepath.Size = new System.Drawing.Size(458, 23);
            this.gamepath.TabIndex = 7;
            // 
            // save_BTN
            // 
            this.save_BTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(177)))), ((int)(((byte)(171)))));
            this.save_BTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.save_BTN.FlatAppearance.BorderSize = 0;
            this.save_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_BTN.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_BTN.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.save_BTN.Location = new System.Drawing.Point(0, 133);
            this.save_BTN.Name = "save_BTN";
            this.save_BTN.Size = new System.Drawing.Size(130, 40);
            this.save_BTN.TabIndex = 8;
            this.save_BTN.Text = "Save";
            this.save_BTN.UseVisualStyleBackColor = false;
            this.save_BTN.Click += new System.EventHandler(this.save_BTN_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(177)))), ((int)(((byte)(171)))));
            this.panel1.Location = new System.Drawing.Point(130, -23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(4, 461);
            this.panel1.TabIndex = 9;
            // 
            // get_BTN
            // 
            this.get_BTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(177)))), ((int)(((byte)(171)))));
            this.get_BTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.get_BTN.FlatAppearance.BorderSize = 0;
            this.get_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.get_BTN.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.get_BTN.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.get_BTN.Location = new System.Drawing.Point(597, 81);
            this.get_BTN.Name = "get_BTN";
            this.get_BTN.Size = new System.Drawing.Size(36, 23);
            this.get_BTN.TabIndex = 10;
            this.get_BTN.Text = "...";
            this.get_BTN.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.get_BTN.UseVisualStyleBackColor = false;
            this.get_BTN.Click += new System.EventHandler(this.get_BTN_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(404, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(229, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "( Select the BIN32 folder in archeage )";
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 173);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.get_BTN);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.save_BTN);
            this.Controls.Add(this.gamepath);
            this.Controls.Add(this.port);
            this.Controls.Add(this.hostname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.splash_CHK);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Montserrat Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Options";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Options";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Options_FormClosing);
            this.Load += new System.EventHandler(this.Options_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox splash_CHK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox hostname;
        private System.Windows.Forms.TextBox port;
        private System.Windows.Forms.TextBox gamepath;
        private System.Windows.Forms.Button save_BTN;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button get_BTN;
        private System.Windows.Forms.Label label4;
    }
}