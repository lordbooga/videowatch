using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Xml.Serialization;


namespace videowatch
{
    public partial class configForm : Form
    {
        public configForm(Form1 mainform)
        {
            InitializeComponent();
            mainForm = mainform;
            ConfigFormToSettings();
            accessTokenBox.Enabled = tweetNewFiles.Checked;
            accessTokenSecret.Enabled = tweetNewFiles.Checked;
            consumerSecretBox.Enabled = tweetNewFiles.Checked;
            consumerKeyBox.Enabled = tweetNewFiles.Checked;
        }

        private void tweetNewFiles_CheckedChanged(object sender, EventArgs e)
        {
                accessTokenBox.Enabled = tweetNewFiles.Checked;
                accessTokenSecret.Enabled = tweetNewFiles.Checked;
                consumerSecretBox.Enabled = tweetNewFiles.Checked;
                consumerKeyBox.Enabled = tweetNewFiles.Checked;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ConfigFormToSettings();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SettingsToConfigForm();
            Hide();
        }
        public void SettingsToConfigForm()
        {

            videowatch.Properties.Settings.Default.AccessTokenSecret = accessTokenSecret.Text;
            videowatch.Properties.Settings.Default.AccessToken = accessTokenBox.Text;
            videowatch.Properties.Settings.Default.ConsumerKey = consumerKeyBox.Text;
            videowatch.Properties.Settings.Default.ConsumerKeySecret = consumerSecretBox.Text;
            videowatch.Properties.Settings.Default.TweetNewFiles = tweetNewFiles.Checked;
            videowatch.Properties.Settings.Default.MonitorDirectory = monitorDir.Text;
            videowatch.Properties.Settings.Default.Save();

        }
        public void ConfigFormToSettings()
        {
            accessTokenBox.Text = videowatch.Properties.Settings.Default.AccessToken;
            accessTokenSecret.Text = videowatch.Properties.Settings.Default.AccessTokenSecret;
            consumerSecretBox.Text = videowatch.Properties.Settings.Default.ConsumerKeySecret;
            consumerKeyBox.Text = videowatch.Properties.Settings.Default.ConsumerKey;
            tweetNewFiles.Checked = videowatch.Properties.Settings.Default.TweetNewFiles;
            monitorDir.Text = videowatch.Properties.Settings.Default.MonitorDirectory;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog locateDir = new FolderBrowserDialog();
            locateDir.ShowNewFolderButton = true;
            DialogResult res = locateDir.ShowDialog();
            if(res == DialogResult.OK)
                monitorDir.Text = locateDir.SelectedPath;
        }


    }
}
