namespace videowatch
{
    partial class configForm
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
            this.tweetNewFiles = new System.Windows.Forms.CheckBox();
            this.accessTokenBox = new System.Windows.Forms.TextBox();
            this.accessTokenSecret = new System.Windows.Forms.TextBox();
            this.consumerKeyBox = new System.Windows.Forms.TextBox();
            this.consumerSecretBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.debugMe = new System.Windows.Forms.TextBox();
            this.monitorDir = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tweetNewFiles
            // 
            this.tweetNewFiles.AutoSize = true;
            this.tweetNewFiles.Checked = true;
            this.tweetNewFiles.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tweetNewFiles.Location = new System.Drawing.Point(23, 16);
            this.tweetNewFiles.Name = "tweetNewFiles";
            this.tweetNewFiles.Size = new System.Drawing.Size(106, 17);
            this.tweetNewFiles.TabIndex = 0;
            this.tweetNewFiles.Text = "Tweet new files?";
            this.tweetNewFiles.UseVisualStyleBackColor = true;
            this.tweetNewFiles.CheckedChanged += new System.EventHandler(this.tweetNewFiles_CheckedChanged);
            // 
            // accessTokenBox
            // 
            this.accessTokenBox.Location = new System.Drawing.Point(157, 39);
            this.accessTokenBox.Name = "accessTokenBox";
            this.accessTokenBox.Size = new System.Drawing.Size(376, 20);
            this.accessTokenBox.TabIndex = 1;
            // 
            // accessTokenSecret
            // 
            this.accessTokenSecret.Location = new System.Drawing.Point(157, 65);
            this.accessTokenSecret.Name = "accessTokenSecret";
            this.accessTokenSecret.Size = new System.Drawing.Size(376, 20);
            this.accessTokenSecret.TabIndex = 2;
            // 
            // consumerKeyBox
            // 
            this.consumerKeyBox.Location = new System.Drawing.Point(157, 91);
            this.consumerKeyBox.Name = "consumerKeyBox";
            this.consumerKeyBox.Size = new System.Drawing.Size(376, 20);
            this.consumerKeyBox.TabIndex = 3;
            // 
            // consumerSecretBox
            // 
            this.consumerSecretBox.Location = new System.Drawing.Point(157, 117);
            this.consumerSecretBox.Name = "consumerSecretBox";
            this.consumerSecretBox.Size = new System.Drawing.Size(376, 20);
            this.consumerSecretBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Access Token";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Access Token Secret";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Consumer Key";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Consumer Secret";
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(446, 280);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(86, 27);
            this.okButton.TabIndex = 9;
            this.okButton.Text = "Ok";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(538, 281);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 26);
            this.button2.TabIndex = 10;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // debugMe
            // 
            this.debugMe.Location = new System.Drawing.Point(138, 239);
            this.debugMe.Name = "debugMe";
            this.debugMe.Size = new System.Drawing.Size(394, 20);
            this.debugMe.TabIndex = 11;
            // 
            // monitorDir
            // 
            this.monitorDir.Location = new System.Drawing.Point(159, 168);
            this.monitorDir.Name = "monitorDir";
            this.monitorDir.Size = new System.Drawing.Size(373, 20);
            this.monitorDir.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Directory to Monitor";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(273, 194);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(115, 26);
            this.button3.TabIndex = 14;
            this.button3.Text = "Browse For Folder";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // configForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 312);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.monitorDir);
            this.Controls.Add(this.debugMe);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.consumerSecretBox);
            this.Controls.Add(this.consumerKeyBox);
            this.Controls.Add(this.accessTokenSecret);
            this.Controls.Add(this.accessTokenBox);
            this.Controls.Add(this.tweetNewFiles);
            this.Name = "configForm";
            this.Text = "Configuration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox tweetNewFiles;
        private System.Windows.Forms.TextBox accessTokenBox;
        private System.Windows.Forms.TextBox accessTokenSecret;
        private System.Windows.Forms.TextBox consumerKeyBox;
        private System.Windows.Forms.TextBox consumerSecretBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox debugMe;
        private Form1 mainForm;
        public Configuration xmlConfig;
        private System.Windows.Forms.TextBox monitorDir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
    }
}