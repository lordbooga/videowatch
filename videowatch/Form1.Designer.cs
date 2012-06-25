using Twitterizer;

namespace videowatch
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.watchFolderText = new System.Windows.Forms.TextBox();
            this.locateDir = new System.Windows.Forms.FolderBrowserDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.videoList = new System.Windows.Forms.TextBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.tweetOrNot = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 26);
            this.button1.TabIndex = 0;
            this.button1.Text = "Browse For Folder";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // watchFolderText
            // 
            this.watchFolderText.Location = new System.Drawing.Point(12, 24);
            this.watchFolderText.Name = "watchFolderText";
            this.watchFolderText.Size = new System.Drawing.Size(242, 20);
            this.watchFolderText.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(271, 17);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 27);
            this.button2.TabIndex = 2;
            this.button2.Text = "Start Monitoring";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // videoList
            // 
            this.videoList.Location = new System.Drawing.Point(-1, 105);
            this.videoList.Multiline = true;
            this.videoList.Name = "videoList";
            this.videoList.ReadOnly = true;
            this.videoList.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.videoList.Size = new System.Drawing.Size(424, 286);
            this.videoList.TabIndex = 3;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            this.fileSystemWatcher1.Created += new System.IO.FileSystemEventHandler(this.fileSystemWatcher1_Created);
            this.fileSystemWatcher1.Deleted += new System.IO.FileSystemEventHandler(this.fileSystemWatcher1_Deleted);
            this.fileSystemWatcher1.Renamed += new System.IO.RenamedEventHandler(this.fileSystemWatcher1_Renamed);
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon.BalloonTipTitle = "New Video";
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "New Episode Notfier";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // tweetOrNot
            // 
            this.tweetOrNot.AutoSize = true;
            this.tweetOrNot.Location = new System.Drawing.Point(298, 62);
            this.tweetOrNot.Name = "tweetOrNot";
            this.tweetOrNot.Size = new System.Drawing.Size(62, 17);
            this.tweetOrNot.TabIndex = 4;
            this.tweetOrNot.Text = "Tweet?";
            this.tweetOrNot.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(169, 59);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 28);
            this.button3.TabIndex = 5;
            this.button3.Text = "Config";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 393);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.tweetOrNot);
            this.Controls.Add(this.videoList);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.watchFolderText);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "New Episode Monitor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private bool isMonitoring;
        private bool isMin;
        private OAuthTokens tokens = new OAuthTokens();
        private System.Collections.Generic.List<string> fileList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox watchFolderText;
        private System.Windows.Forms.FolderBrowserDialog locateDir;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox videoList;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.CheckBox tweetOrNot;
        private System.Windows.Forms.Button button3;
        private configForm cf;
        public string accessToken { get; set; }
        public string accessSecret { get; set; }
        public string consumerKey { get; set; }
        public string consumerSecret { get; set; }
        public bool shouldTweet { get; set; }
    }
}

