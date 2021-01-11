namespace vPad
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutVPadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.discordIntegrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textbox = new System.Windows.Forms.RichTextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.font_down_button = new System.Windows.Forms.PictureBox();
            this.font_up_button = new System.Windows.Forms.PictureBox();
            this.time_label = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.CharCounter = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.font_down_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.font_up_button)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.NewToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutVPadToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.aboutToolStripMenuItem.Text = "Help";
            // 
            // aboutVPadToolStripMenuItem
            // 
            this.aboutVPadToolStripMenuItem.Name = "aboutVPadToolStripMenuItem";
            this.aboutVPadToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.aboutVPadToolStripMenuItem.Text = "About vPad";
            this.aboutVPadToolStripMenuItem.Click += new System.EventHandler(this.AboutVPadToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.discordIntegrationToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // discordIntegrationToolStripMenuItem
            // 
            this.discordIntegrationToolStripMenuItem.Name = "discordIntegrationToolStripMenuItem";
            this.discordIntegrationToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.discordIntegrationToolStripMenuItem.Text = "Discord Integration";
            this.discordIntegrationToolStripMenuItem.Click += new System.EventHandler(this.DiscordIntegrationToolStripMenuItem_Click);
            // 
            // textbox
            // 
            this.textbox.AcceptsTab = true;
            this.textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.textbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textbox.Font = new System.Drawing.Font("Lucida Console", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox.ForeColor = System.Drawing.Color.White;
            this.textbox.Location = new System.Drawing.Point(0, 28);
            this.textbox.Margin = new System.Windows.Forms.Padding(0);
            this.textbox.Name = "textbox";
            this.textbox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.textbox.Size = new System.Drawing.Size(800, 422);
            this.textbox.TabIndex = 1;
            this.textbox.Text = "";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.SaveFileDialog1_FileOk);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.panel1.Controls.Add(this.font_down_button);
            this.panel1.Controls.Add(this.font_up_button);
            this.panel1.Controls.Add(this.time_label);
            this.panel1.Controls.Add(this.TimeLabel);
            this.panel1.Controls.Add(this.CharCounter);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 415);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(800, 35);
            this.panel1.TabIndex = 2;
            // 
            // font_down_button
            // 
            this.font_down_button.BackgroundImage = global::vPad.Properties.Resources.baseline_remove_white_18dp;
            this.font_down_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.font_down_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.font_down_button.Location = new System.Drawing.Point(38, 8);
            this.font_down_button.Name = "font_down_button";
            this.font_down_button.Size = new System.Drawing.Size(20, 20);
            this.font_down_button.TabIndex = 6;
            this.font_down_button.TabStop = false;
            this.font_down_button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Font_down_button_MouseDown);
            // 
            // font_up_button
            // 
            this.font_up_button.BackgroundImage = global::vPad.Properties.Resources.baseline_add_white_18dp;
            this.font_up_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.font_up_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.font_up_button.Location = new System.Drawing.Point(12, 8);
            this.font_up_button.Name = "font_up_button";
            this.font_up_button.Size = new System.Drawing.Size(20, 20);
            this.font_up_button.TabIndex = 5;
            this.font_up_button.TabStop = false;
            this.font_up_button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Font_up_button_MouseDown);
            // 
            // time_label
            // 
            this.time_label.AutoSize = true;
            this.time_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.time_label.Dock = System.Windows.Forms.DockStyle.Right;
            this.time_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time_label.Location = new System.Drawing.Point(646, 5);
            this.time_label.Name = "time_label";
            this.time_label.Padding = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.time_label.Size = new System.Drawing.Size(59, 24);
            this.time_label.TabIndex = 4;
            this.time_label.Text = "00:00";
            this.time_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.time_label.Click += new System.EventHandler(this.Time_label_Click);
            this.time_label.DoubleClick += new System.EventHandler(this.Time_label_DoubleClick);
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TimeLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.TimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLabel.Location = new System.Drawing.Point(705, 5);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(0, 24);
            this.TimeLabel.TabIndex = 3;
            // 
            // CharCounter
            // 
            this.CharCounter.AutoSize = true;
            this.CharCounter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CharCounter.Dock = System.Windows.Forms.DockStyle.Right;
            this.CharCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CharCounter.Location = new System.Drawing.Point(705, 5);
            this.CharCounter.Name = "CharCounter";
            this.CharCounter.Padding = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CharCounter.Size = new System.Drawing.Size(90, 24);
            this.CharCounter.TabIndex = 0;
            this.CharCounter.Text = "0 Char(s)";
            this.CharCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CharCounter.Click += new System.EventHandler(this.CharCounter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textbox);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.Text = "vPad";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.font_down_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.font_up_button)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.RichTextBox textbox;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutVPadToolStripMenuItem;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label CharCounter;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label time_label;
        private System.Windows.Forms.PictureBox font_up_button;
        private System.Windows.Forms.PictureBox font_down_button;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem discordIntegrationToolStripMenuItem;
    }
}