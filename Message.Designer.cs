namespace Blazing_Tweet
{
    partial class Message
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Message));
            this.message_box = new System.Windows.Forms.TextBox();
            this.count_label = new System.Windows.Forms.Label();
            this.send_button = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hide_checkbox = new System.Windows.Forms.CheckBox();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // message_box
            // 
            this.message_box.Location = new System.Drawing.Point(13, 13);
            this.message_box.Multiline = true;
            this.message_box.Name = "message_box";
            this.message_box.Size = new System.Drawing.Size(360, 68);
            this.message_box.TabIndex = 0;
            this.message_box.TextChanged += new System.EventHandler(this.updateCount);
            // 
            // count_label
            // 
            this.count_label.AutoSize = true;
            this.count_label.ForeColor = System.Drawing.Color.Black;
            this.count_label.Location = new System.Drawing.Point(345, 84);
            this.count_label.Name = "count_label";
            this.count_label.Size = new System.Drawing.Size(13, 13);
            this.count_label.TabIndex = 1;
            this.count_label.Text = " -";
            // 
            // send_button
            // 
            this.send_button.Location = new System.Drawing.Point(164, 92);
            this.send_button.Name = "send_button";
            this.send_button.Size = new System.Drawing.Size(75, 23);
            this.send_button.TabIndex = 3;
            this.send_button.Text = "Send";
            this.send_button.UseVisualStyleBackColor = true;
            this.send_button.Click += new System.EventHandler(this.onSend);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "App is running in tybar";
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Blazing Tweet";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.onNotifyDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOutToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(118, 48);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.onLogOut);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.onQuit);
            // 
            // hide_checkbox
            // 
            this.hide_checkbox.AutoSize = true;
            this.hide_checkbox.Checked = true;
            this.hide_checkbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.hide_checkbox.Location = new System.Drawing.Point(13, 97);
            this.hide_checkbox.Name = "hide_checkbox";
            this.hide_checkbox.Size = new System.Drawing.Size(71, 17);
            this.hide_checkbox.TabIndex = 4;
            this.hide_checkbox.Text = "Auto hide";
            this.hide_checkbox.UseVisualStyleBackColor = true;
            this.hide_checkbox.CheckedChanged += new System.EventHandler(this.onCheckChange);
            // 
            // Message
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 127);
            this.Controls.Add(this.hide_checkbox);
            this.Controls.Add(this.send_button);
            this.Controls.Add(this.count_label);
            this.Controls.Add(this.message_box);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Message";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Blazing Tweet";
            this.Resize += new System.EventHandler(this.onResize);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox message_box;
        private System.Windows.Forms.Label count_label;
        private System.Windows.Forms.Button send_button;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.CheckBox hide_checkbox;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
    }
}

