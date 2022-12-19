namespace TelemetryJsonService
{
    partial class TelemetryJsonService
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelemetryJsonService));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbStatus = new System.Windows.Forms.TextBox();
            this.lbGame = new System.Windows.Forms.Label();
            this.lbGameVersion = new System.Windows.Forms.Label();
            this.lbTelemetryVersion = new System.Windows.Forms.Label();
            this.lbUpdateInterval = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Open Telemetry Json Service";
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.SystemColors.Window;
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.ShowImageMargin = false;
            this.contextMenuStrip1.Size = new System.Drawing.Size(156, 48);
            this.contextMenuStrip1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(155, 22);
            this.toolStripMenuItem1.Text = "Exit";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Location = new System.Drawing.Point(13, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Service URL:";
            // 
            // tbUrl
            // 
            this.tbUrl.Location = new System.Drawing.Point(110, 101);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.ReadOnly = true;
            this.tbUrl.Size = new System.Drawing.Size(212, 20);
            this.tbUrl.TabIndex = 1;
            this.tbUrl.WordWrap = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Location = new System.Drawing.Point(13, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Game:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label3.Location = new System.Drawing.Point(13, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Game version:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label4.Location = new System.Drawing.Point(13, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Telemetry version:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label5.Location = new System.Drawing.Point(13, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Update interval:";
            // 
            // tbStatus
            // 
            this.tbStatus.Location = new System.Drawing.Point(0, 141);
            this.tbStatus.Name = "tbStatus";
            this.tbStatus.ReadOnly = true;
            this.tbStatus.Size = new System.Drawing.Size(334, 20);
            this.tbStatus.TabIndex = 6;
            this.tbStatus.WordWrap = false;
            // 
            // lbGame
            // 
            this.lbGame.AutoSize = true;
            this.lbGame.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbGame.Location = new System.Drawing.Point(107, 9);
            this.lbGame.Name = "lbGame";
            this.lbGame.Size = new System.Drawing.Size(16, 13);
            this.lbGame.TabIndex = 7;
            this.lbGame.Text = "---";
            // 
            // lbGameVersion
            // 
            this.lbGameVersion.AutoSize = true;
            this.lbGameVersion.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbGameVersion.Location = new System.Drawing.Point(107, 32);
            this.lbGameVersion.Name = "lbGameVersion";
            this.lbGameVersion.Size = new System.Drawing.Size(16, 13);
            this.lbGameVersion.TabIndex = 8;
            this.lbGameVersion.Text = "---";
            // 
            // lbTelemetryVersion
            // 
            this.lbTelemetryVersion.AutoSize = true;
            this.lbTelemetryVersion.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbTelemetryVersion.Location = new System.Drawing.Point(107, 55);
            this.lbTelemetryVersion.Name = "lbTelemetryVersion";
            this.lbTelemetryVersion.Size = new System.Drawing.Size(16, 13);
            this.lbTelemetryVersion.TabIndex = 9;
            this.lbTelemetryVersion.Text = "---";
            // 
            // lbUpdateInterval
            // 
            this.lbUpdateInterval.AutoSize = true;
            this.lbUpdateInterval.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbUpdateInterval.Location = new System.Drawing.Point(107, 80);
            this.lbUpdateInterval.Name = "lbUpdateInterval";
            this.lbUpdateInterval.Size = new System.Drawing.Size(16, 13);
            this.lbUpdateInterval.TabIndex = 10;
            this.lbUpdateInterval.Text = "---";
            // 
            // TelemetryJsonService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(334, 161);
            this.Controls.Add(this.lbUpdateInterval);
            this.Controls.Add(this.lbTelemetryVersion);
            this.Controls.Add(this.lbGameVersion);
            this.Controls.Add(this.lbGame);
            this.Controls.Add(this.tbStatus);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbUrl);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TelemetryJsonService";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Telemetry Json Service for ETS2/ATS";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Closing);
            this.Resize += new System.EventHandler(this.Form_Resize);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbUrl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbStatus;
        private System.Windows.Forms.Label lbGame;
        private System.Windows.Forms.Label lbGameVersion;
        private System.Windows.Forms.Label lbTelemetryVersion;
        private System.Windows.Forms.Label lbUpdateInterval;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}